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
    /// <summary>
    ///     The NetDaemonApp implements async model API
    ///     currently the default one
    /// </summary>
    public class Wifi2IrApp : NetDaemonRxApp
    {
        public IEnumerable<ItachDevice>? ItachDevices {get;set;}

        private ConcurrentDictionary<string, Socket> _wf2IrConnections = new ConcurrentDictionary<string, Socket>();

        private Dictionary<string, CommandDispatchDetails> Commands = new Dictionary<string, CommandDispatchDetails>();

        public override void Initialize()
        {
            Log("initializing commands");
            try
            {
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
            catch(Exception ex)
            {
                Log(ex, "Commands initialization error");
            }
        }

        [HomeAssistantServiceCall]
        public async void SendIr(dynamic data)
        {
            try
            {
                Log("Sending IR Command: {data}", data);
                if (Commands.TryGetValue(data.command, out CommandDispatchDetails? dispatchDetails))
                {
                    if (!string.IsNullOrEmpty(dispatchDetails?.Endpoint?.Address) && !string.IsNullOrEmpty(dispatchDetails?.IrCode))
                    {
                        Socket socket = await GetSocket(dispatchDetails.Endpoint.Address, dispatchDetails.Endpoint.Port);
                        if (socket != null)
                        {
                            try
                            {
                                SendCommand(socket, dispatchDetails.IrCode);
                            }
                            catch
                            {
                                socket.Disconnect(true);
                                _wf2IrConnections.TryRemove(BuildEndpointKey(dispatchDetails.Endpoint.Address, dispatchDetails.Endpoint.Port), out Socket? removedSocket);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex, "IR command send error");
            }
        }
        async Task<Socket> GetSocket(string address, int port)
        {
            Socket? connectionSocket = null;
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

        private bool SendCommand(Socket socket, string command)
        {
            bool success = false;
            SocketAsyncEventArgs x = new SocketAsyncEventArgs();
            x.SetBuffer(Encoding.UTF8.GetBytes(command + "\r"));
            success = socket.SendAsync(x);
            return success;
        }

        private string BuildEndpointKey(string address, int port) 
        {
            return $"{address}:{port}";
        }
    }

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


