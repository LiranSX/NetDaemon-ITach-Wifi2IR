using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Reactive.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using NetDaemon.Common.Reactive;
using NetDaemon.Common;


// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace Wifi2Ir
{
    public class ItachEndpoint
    {
        public string? Address {get;set;}
        public int Port {get;set;}
    }

    public class CommandDispatchDetails
    {
        public string? IrCode {get;set;}
        public ItachEndpoint? Endpoint {get;set;}
    }
    /// <summary>
    ///     The NetDaemonApp implements async model API
    ///     currently the default one
    /// </summary>
    public class Wifi2IrApp : NetDaemonRxApp
    {
        public IEnumerable<ItachDevice>? ItachDevices {get;set;}

        private ConcurrentDictionary<string, Socket>? _wf2IrConnections = new ConcurrentDictionary<string, Socket>();

        private Dictionary<string, CommandDispatchDetails> Commands = new Dictionary<string, CommandDispatchDetails>();
        public override void Initialize()
        {
            Log("initialize called");
            if (ItachDevices != null)
            {
                foreach(ItachDevice itachDevice in ItachDevices)
                {
                    if (itachDevice.Devices != null && itachDevice.Address != null && itachDevice.Port != null)
                    {
                        ItachEndpoint endpoint = new ItachEndpoint {Address = itachDevice.Address, Port = int.Parse(itachDevice.Port)};

                        foreach(Device device in itachDevice.Devices)
                        {
                            if (device.Commands != null)
                            {
                                foreach(Command command in device.Commands)
                                {
                                    if (!string.IsNullOrEmpty(command.Data))
                                    {
                                        Log($"adding {device.Name}.{command.Name}");
                                        Commands.Add($"{device.Name}.{command.Name}", new CommandDispatchDetails {IrCode = command.Data, Endpoint = endpoint} );
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        [HomeAssistantServiceCall]
        public async void SendIr(dynamic data)
        {
            Log("A call from hass! {data}", data);
            CommandDispatchDetails dispatchDetails;

            try
            {
                if (Commands.TryGetValue(data.command, out dispatchDetails))
                {
                    Socket socket;
                    socket = await GetSocket(dispatchDetails.Endpoint.Address, dispatchDetails.Endpoint.Port);
                    if (socket != null)
                    {
                        try
                        {
                            await SendCommand(socket, dispatchDetails.IrCode);
                        }
                        catch
                        {
                            Socket removedSocket;
                            socket.Disconnect(true);
                            _wf2IrConnections.TryRemove(BuildEndpointKey(dispatchDetails.Endpoint.Address, dispatchDetails.Endpoint.Port), out removedSocket);
                        }
                    }
                }
            }
            catch{}
        }
        private string BuildEndpointKey(string address, int port) 
        {
            return $"{address}:{port}";
        }
        async Task<Socket> GetSocket(string address, int port)
        {
            Socket connectionSocket = null;
            string endpointKey = BuildEndpointKey(address, port);
            if (_wf2IrConnections.TryGetValue(endpointKey, out connectionSocket))
            {
                if (!connectionSocket.Connected)
                {
                    connectionSocket.Dispose();
                    _wf2IrConnections.TryRemove(endpointKey, out connectionSocket);
                    connectionSocket = null;
                }
            }

            if (connectionSocket == null)
            {
                connectionSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                await connectionSocket.ConnectAsync(address, port);
                _wf2IrConnections[endpointKey] = connectionSocket;
            }

            return connectionSocket;
        }

        async Task<bool> SendCommand(Socket socket, string command)
        {
            bool success = false;
            try
            {
                SocketAsyncEventArgs x = new SocketAsyncEventArgs();
                x.SetBuffer(Encoding.UTF8.GetBytes(command + "\r"));
                success = socket.SendAsync(x);
            }
            catch (SocketException se)
            {
                Log(se, "error");
            }
            catch (Exception ex)
            {
                Log(ex, "error");
            }
            return success;
        }
    }

    public class ItachDevice{
        public string? Address { get; set; }

        public string? Port { get; set; }

        public IEnumerable<Device>? Devices {get;set;}
    }

    public class Device {
        public string? Name { get; set; } 
        public IEnumerable<Command>? Commands { get; set; }
    }
    public class Command    {
        public string? Name { get; set; } 
        public string? Data { get; set; } 
    }
}


