using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using NetDaemon.Common;
using NetDaemon.Common.Reactive;
using NetDaemon.Common.Fluent;

namespace Netdaemon.Generated.Reactive
{
    public class GeneratedAppBase : NetDaemonRxApp
    {
        public PersonEntities Person => new PersonEntities(this);
        public AutomationEntities Automation => new AutomationEntities(this);
        public InputNumberEntities InputNumber => new InputNumberEntities(this);
        public ScriptEntity Script => new ScriptEntity(this, new string[]{""});
        public SwitchEntities Switch => new SwitchEntities(this);
        public InputBooleanEntities InputBoolean => new InputBooleanEntities(this);
        public SensorEntities Sensor => new SensorEntities(this);
        public InputSelectEntities InputSelect => new InputSelectEntities(this);
        public VarEntities Var => new VarEntities(this);
        public MediaPlayerEntities MediaPlayer => new MediaPlayerEntities(this);
        public BinarySensorEntities BinarySensor => new BinarySensorEntities(this);
        public CameraEntities Camera => new CameraEntities(this);
        public NetdaemonEntities Netdaemon => new NetdaemonEntities(this);
        public LightEntities Light => new LightEntities(this);
        public WeatherEntities Weather => new WeatherEntities(this);
        public ZoneEntities Zone => new ZoneEntities(this);
        public InputTextEntities InputText => new InputTextEntities(this);
        public SunEntities Sun => new SunEntities(this);
    }

    public partial class PersonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public PersonEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("person", "reload", serviceData);
        }
    }

    public partial class AutomationEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public AutomationEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Trigger(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("automation", "trigger", serviceData);
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("automation", "reload", serviceData);
        }
    }

    public partial class InputNumberEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public InputNumberEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_number", "reload", serviceData);
        }

        public void SetValue(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "set_value", serviceData);
        }

        public void Increment(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "increment", serviceData);
        }

        public void Decrement(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "decrement", serviceData);
        }
    }

    public partial class ScriptEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public ScriptEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void ArcadecabinetLoadpoint1(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "arcadecabinet_loadpoint1", serviceData);
        }

        public void ArcadecabinetLoadpoint2(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "arcadecabinet_loadpoint2", serviceData);
        }

        public void ArcadecabinetSavepoint1(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "arcadecabinet_savepoint1", serviceData);
        }

        public void ArcadecabinetSavepoint2(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "arcadecabinet_savepoint2", serviceData);
        }

        public void ArcadecabinetKill(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "arcadecabinet_kill", serviceData);
        }

        public void ArcadecabinetRestart(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "arcadecabinet_restart", serviceData);
        }

        public void ArcadecabinetMute(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "arcadecabinet_mute", serviceData);
        }

        public void ActivateProfileFromTarget(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "activate_profile_from_target", serviceData);
        }

        public void AssistantDoactivityPlayconsole(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "assistant_doactivity_playconsole", serviceData);
        }

        public void AssistantDoactivityUseCinema(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "assistant_doactivity_use_cinema", serviceData);
        }

        public void AssistantDoactivityUseCinemaInBackground(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "assistant_doactivity_use_cinema_in_background", serviceData);
        }

        public void AssistantDoactivityPctv(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "assistant_doactivity_pctv", serviceData);
        }

        public void AssistantDoactivityWatchtelevision(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "assistant_doactivity_watchtelevision", serviceData);
        }

        public void AssistantDoactivitySleep(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "assistant_doactivity_sleep", serviceData);
        }

        public void AssistantDoactivityLeavehouse(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "assistant_doactivity_leavehouse", serviceData);
        }

        public void AssistantDoactivityWarehouse(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "assistant_doactivity_warehouse", serviceData);
        }

        public void RhasspyDoneactivitySleep(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rhasspy_doneactivity_sleep", serviceData);
        }

        public void RhasspyRestart(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rhasspy_restart", serviceData);
        }

        public void RhasspyAssistantMuteMedias(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rhasspy_assistant_mute_medias", serviceData);
        }

        public void RhasspyAssistantUnmuteMedias(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rhasspy_assistant_unmute_medias", serviceData);
        }

        public void RhasspyAssistantWakeup(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rhasspy_assistant_wakeup", serviceData);
        }

        public void ClearPendingRequest(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "clear_pending_request", serviceData);
        }

        public void ActiveMusicVoldown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "active_music_voldown", serviceData);
        }

        public void ActiveMusicVolup(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "active_music_volup", serviceData);
        }

        public void ActiveKodiMusicReplay(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "active_kodi_music_replay", serviceData);
        }

        public void KodiPlaySelectionClear(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_play_selection_clear", serviceData);
        }

        public void KodiSetRecieverMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_set_reciever_mode", serviceData);
        }

        public void KodiSetTvMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_set_tv_mode", serviceData);
        }

        public void BedheadbackLoadpoint1(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bedheadback_loadpoint1", serviceData);
        }

        public void BedheadbackLoadpoint2(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bedheadback_loadpoint2", serviceData);
        }

        public void BedheadbackSavepoint1(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bedheadback_savepoint1", serviceData);
        }

        public void BedheadbackSavepoint2(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bedheadback_savepoint2", serviceData);
        }

        public void HeadbackSunrise(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "headback_sunrise", serviceData);
        }

        public void Ac1ToggleByMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac1_toggle_by_mode", serviceData);
        }

        public void Ac2ToggleByMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_toggle_by_mode", serviceData);
        }

        public void Ac1FanSetup(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac1_fan_setup", serviceData);
        }

        public void Ac2FanSetup(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_fan_setup", serviceData);
        }

        public void Ac1Off(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac1_off", serviceData);
        }

        public void Ac1Warm(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac1_warm", serviceData);
        }

        public void Ac1Hot(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac1_hot", serviceData);
        }

        public void Ac1Fan(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac1_fan", serviceData);
        }

        public void Ac1Cool(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac1_cool", serviceData);
        }

        public void Ac1Cold(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac1_cold", serviceData);
        }

        public void Ac2Off(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_off", serviceData);
        }

        public void Ac2Warm(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_warm", serviceData);
        }

        public void Ac2Hot(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_hot", serviceData);
        }

        public void Ac2Fan(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_fan", serviceData);
        }

        public void Ac2Cool(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_cool", serviceData);
        }

        public void Ac2Cold(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_cold", serviceData);
        }

        public void Ac2OffIr(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_off_ir", serviceData);
        }

        public void Ac2NormalIr(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_normal_ir", serviceData);
        }

        public void BulkLaunch(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch", serviceData);
        }

        public void BulkLaunchSmartlamp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_smartlamp", serviceData);
        }

        public void BulkLaunchFrontLight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_front_light", serviceData);
        }

        public void BulkLaunchBackLight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_back_light", serviceData);
        }

        public void BulkLaunchAc(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_ac", serviceData);
        }

        public void BulkLaunchInfinityCube(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_infinity_cube", serviceData);
        }

        public void BulkLaunchLightString(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_light_string", serviceData);
        }

        public void BulkLaunchLightStringColor(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_light_string_color", serviceData);
        }

        public void BedHeadbackColors(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bed_headback_colors", serviceData);
        }

        public void BulkLaunchBedHeadback(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_bed_headback", serviceData);
        }

        public void BulkLaunchCandles(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_candles", serviceData);
        }

        public void BulkLaunchArcadeCabinet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_arcade_cabinet", serviceData);
        }

        public void BulkLaunchArcadeCabinetRgb(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_arcade_cabinet_rgb", serviceData);
        }

        public void BulkLaunchArcadeCabinetMarquee(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_arcade_cabinet_marquee", serviceData);
        }

        public void BulkLaunchNeonSign(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_neon_sign", serviceData);
        }

        public void BulkLaunchWarehouseLight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_warehouse_light", serviceData);
        }

        public void BulkLaunchMusic(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_music", serviceData);
        }

        public void BulkLaunchTvNews(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bulk_launch_tv_news", serviceData);
        }

        public void HouseTurnOff(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "house_turn_off", serviceData);
        }

        public void GoingToSleepForce(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "going_to_sleep_force", serviceData);
        }

        public void SleepKeepMediaPcOn(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sleep_keep_media_pc_on", serviceData);
        }

        public void GoingToSleep(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "going_to_sleep", serviceData);
        }

        public void HeadbackSleep(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "headback_sleep", serviceData);
        }

        public void InfinitycubeSleep(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "infinitycube_sleep", serviceData);
        }

        public void WakingUpBoilerProcess(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "waking_up_boiler_process", serviceData);
        }

        public void WakingUpAcProcess(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "waking_up_ac_process", serviceData);
        }

        public void WakingUpForce(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "waking_up_force", serviceData);
        }

        public void WakingUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "waking_up", serviceData);
        }

        public void HassRestart(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "hass_restart", serviceData);
        }

        public void InfinitycubeLoadpoint1(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "infinitycube_loadpoint1", serviceData);
        }

        public void InfinitycubeLoadpoint2(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "infinitycube_loadpoint2", serviceData);
        }

        public void InfinitycubeSavepoint1(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "infinitycube_savepoint1", serviceData);
        }

        public void InfinitycubeSavepoint2(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "infinitycube_savepoint2", serviceData);
        }

        public void Rl4mpPresetMiddle(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rl4mp_preset_middle", serviceData);
        }

        public void Rl4mpPresetLowerleft(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rl4mp_preset_lowerleft", serviceData);
        }

        public void Rl4mpPresetHigherright(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rl4mp_preset_higherright", serviceData);
        }

        public void Rl4mpUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rl4mp_up", serviceData);
        }

        public void Rl4mpDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rl4mp_down", serviceData);
        }

        public void Rl4mpLeft(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rl4mp_left", serviceData);
        }

        public void Rl4mpRight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rl4mp_right", serviceData);
        }

        public void Rl4mpHide(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "rl4mp_hide", serviceData);
        }

        public void KodiPriSaveMovieState(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_pri_save_movie_state", serviceData);
        }

        public void KodiPriLoadMovieState(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_pri_load_movie_state", serviceData);
        }

        public void KodiPriPauseOrStop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_pri_pause_or_stop", serviceData);
        }

        public void KodiPriPrevious(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_pri_previous", serviceData);
        }

        public void KodiPriNext(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_pri_next", serviceData);
        }

        public void KodiPlaypause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_playpause", serviceData);
        }

        public void KodiStop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_stop", serviceData);
        }

        public void KodiUpdateLibrary(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "kodi_update_library", serviceData);
        }

        public void LcdToggle(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "lcd_toggle", serviceData);
        }

        public void HouseLightThemeNight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "house_light_theme_night", serviceData);
        }

        public void HouseLightThemeEvening(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "house_light_theme_evening", serviceData);
        }

        public void HouseLightThemeReading(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "house_light_theme_reading", serviceData);
        }

        public void HouseLightThemeRomantic(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "house_light_theme_romantic", serviceData);
        }

        public void MediaPcConditionalOff(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "media_pc_conditional_off", serviceData);
        }

        public void SystemShutdown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "system_shutdown", serviceData);
        }

        public void SystemReboot(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "system_reboot", serviceData);
        }

        public void NetdaemonRestart(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "netdaemon_restart", serviceData);
        }

        public void MediaPcSleep(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "media_pc_sleep", serviceData);
        }

        public void MediaPcScreenTv(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "media_pc_screen_tv", serviceData);
        }

        public void MediaPcScreenDesk(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "media_pc_screen_desk", serviceData);
        }

        public void MediaPcScreenProjector(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "media_pc_screen_projector", serviceData);
        }

        public void MediaPcMuteToggle(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "media_pc_mute_toggle", serviceData);
        }

        public void MediaPcCloseActiveWindow(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "media_pc_close_active_window", serviceData);
        }

        public void MediaPcClearMouse(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "media_pc_clear_mouse", serviceData);
        }

        public void MediaPcKillGames(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "media_pc_kill_games", serviceData);
        }

        public void MopidyShuffle(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_shuffle", serviceData);
        }

        public void MopidyShufflePlay(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_shuffle_play", serviceData);
        }

        public void MopidyStop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_stop", serviceData);
        }

        public void MopidyNext(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_next", serviceData);
        }

        public void MopidyPrevious(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_previous", serviceData);
        }

        public void MopidyVolumeUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_volume_up", serviceData);
        }

        public void MopidyVolumeDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_volume_down", serviceData);
        }

        public void MopidyVolumeUpSinglestep(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_volume_up_singlestep", serviceData);
        }

        public void MopidyVolumeDownSinglestep(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_volume_down_singlestep", serviceData);
        }

        public void MopidyMarkFavored(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_mark_favored", serviceData);
        }

        public void MopidyMarkUnfavored(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_mark_unfavored", serviceData);
        }

        public void MopidyRemoveUnfavored(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_remove_unfavored", serviceData);
        }

        public void MopidyPlaylistConditionalShuffle(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_playlist_conditional_shuffle", serviceData);
        }

        public void MopidyRestart(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_restart", serviceData);
        }

        public void MopidyConditionalUnmute(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "mopidy_conditional_unmute", serviceData);
        }

        public void NeonsignLoadpoint1(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "neonsign_loadpoint1", serviceData);
        }

        public void NeonsignLoadpoint2(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "neonsign_loadpoint2", serviceData);
        }

        public void NeonsignSavepoint1(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "neonsign_savepoint1", serviceData);
        }

        public void NeonsignSavepoint2(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "neonsign_savepoint2", serviceData);
        }

        public void NeonsignSunrise(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "neonsign_sunrise", serviceData);
        }

        public void BedroomPowerSaveOn(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bedroom_power_save_on", serviceData);
        }

        public void BedroomPowerSaveOff(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "bedroom_power_save_off", serviceData);
        }

        public void ProfileEnable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "profile_enable", serviceData);
        }

        public void ProfileDisable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "profile_disable", serviceData);
        }

        public void TogglePlaybackByProfile(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "toggle_playback_by_profile", serviceData);
        }

        public void PauseByActiveProfile(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "pause_by_active_profile", serviceData);
        }

        public void UnpauseByActiveProfile(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "unpause_by_active_profile", serviceData);
        }

        public void ProfileDisabledPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "profile_disabled_pause", serviceData);
        }

        public void ProfileDisabledUnpause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "profile_disabled_unpause", serviceData);
        }

        public void ReceiverCheckPrepare(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "receiver_check_prepare", serviceData);
        }

        public void ProjectorPrepareLighting(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "projector_prepare_lighting", serviceData);
        }

        public void ProjectorRestoreLightsStates(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "projector_restore_lights_states", serviceData);
        }

        public void ClearActiveProfile(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "clear_active_profile", serviceData);
        }

        public void TvGamingConsoleEnable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_gaming_console_enable", serviceData);
        }

        public void TvGamingConsoleDisable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_gaming_console_disable", serviceData);
        }

        public void TvGamingConsoleDisableRecieverProcess(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_gaming_console_disable_reciever_process", serviceData);
        }

        public void TvGamingConsoleDisableTvProcess(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_gaming_console_disable_tv_process", serviceData);
        }

        public void ProjectorEnable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "projector_enable", serviceData);
        }

        public void ProjectorDisable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "projector_disable", serviceData);
        }

        public void DesktopGamingPcEnable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "desktop_gaming_pc_enable", serviceData);
        }

        public void DesktopGamingPcDisable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "desktop_gaming_pc_disable", serviceData);
        }

        public void ActiveProfileVolumeUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "active_profile_volume_up", serviceData);
        }

        public void ActiveProfileVolumeDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "active_profile_volume_down", serviceData);
        }

        public void ProfileCabletvPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "profile_cabletv_pause", serviceData);
        }

        public void ProfileCabletvUnpause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "profile_cabletv_unpause", serviceData);
        }

        public void TvCableProviderEnable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_cable_provider_enable", serviceData);
        }

        public void TvCableProviderDisable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_cable_provider_disable", serviceData);
        }

        public void AutoLaunchTvCableProvider(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "auto_launch_tv_cable_provider", serviceData);
        }

        public void TvPcEnable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_pc_enable", serviceData);
        }

        public void LoadLastMovieState(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "load_last_movie_state", serviceData);
        }

        public void TvPcDisable(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_pc_disable", serviceData);
        }

        public void SaveLastMovieState(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "save_last_movie_state", serviceData);
        }

        public void TvPcEnableRecieverProcess(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_pc_enable_reciever_process", serviceData);
        }

        public void TvPcEnableTvProcess(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_pc_enable_tv_process", serviceData);
        }

        public void TvEnableLightingProcess(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_enable_lighting_process", serviceData);
        }

        public void TvDisableLightingProcess(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_disable_lighting_process", serviceData);
        }

        public void ProfileTvpcPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "profile_tvpc_pause", serviceData);
        }

        public void ProfileTvpcUnpause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "profile_tvpc_unpause", serviceData);
        }

        public void SonyProjectorPower(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sony_projector_power", serviceData);
        }

        public void SonyProjectorLeft(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sony_projector_left", serviceData);
        }

        public void SonyProjectorRight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sony_projector_right", serviceData);
        }

        public void SonyProjectorEnter(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sony_projector_enter", serviceData);
        }

        public void ReceiverEntertainmentMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "receiver_entertainment_mode", serviceData);
        }

        public void SmartlampLoadpoint1(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "smartlamp_loadpoint1", serviceData);
        }

        public void SmartlampLoadpoint2(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "smartlamp_loadpoint2", serviceData);
        }

        public void SmartlampSavepoint1(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "smartlamp_savepoint1", serviceData);
        }

        public void SmartlampSavepoint2(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "smartlamp_savepoint2", serviceData);
        }

        public void LgtvVolumeUpSinglestep(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "lgtv_volume_up_singlestep", serviceData);
        }

        public void LgtvVolumeDownSinglestep(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "lgtv_volume_down_singlestep", serviceData);
        }

        public void TurnOffPhilipsTvOnLaptopOff(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "turn_off_philips_tv_on_laptop_off", serviceData);
        }

        public void Ac1ToggleByModeTablet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac1_toggle_by_mode_tablet", serviceData);
        }

        public void Ac1ToggleAutoModeTablet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac1_toggle_auto_mode_tablet", serviceData);
        }

        public void Ac2ToggleByModeTablet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_toggle_by_mode_tablet", serviceData);
        }

        public void Ac2ToggleAutoModeTablet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "ac2_toggle_auto_mode_tablet", serviceData);
        }

        public void Speak(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "speak", serviceData);
        }

        public void Testing(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "testing", serviceData);
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "reload", serviceData);
        }
    }

    public partial class SwitchEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public SwitchEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class InputBooleanEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public InputBooleanEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_boolean", "reload", serviceData);
        }
    }

    public partial class SensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public SensorEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class InputSelectEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public InputSelectEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_select", "reload", serviceData);
        }

        public void SelectOption(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_option", serviceData);
        }

        public void SelectNext(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_next", serviceData);
        }

        public void SelectPrevious(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_previous", serviceData);
        }

        public void SetOptions(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "set_options", serviceData);
        }
    }

    public partial class VarEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public VarEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Set(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("var", "set", serviceData);
        }

        public void Update(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("var", "update", serviceData);
        }
    }

    public partial class MediaPlayerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public MediaPlayerEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void VolumeUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_up", serviceData);
        }

        public void VolumeDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_down", serviceData);
        }

        public void MediaPlayPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play_pause", serviceData);
        }

        public void MediaPlay(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play", serviceData);
        }

        public void MediaPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_pause", serviceData);
        }

        public void MediaStop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_stop", serviceData);
        }

        public void MediaNextTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_next_track", serviceData);
        }

        public void MediaPreviousTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_previous_track", serviceData);
        }

        public void ClearPlaylist(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "clear_playlist", serviceData);
        }

        public void VolumeSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_set", serviceData);
        }

        public void VolumeMute(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_mute", serviceData);
        }

        public void MediaSeek(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_seek", serviceData);
        }

        public void SelectSource(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_source", serviceData);
        }

        public void SelectSoundMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_sound_mode", serviceData);
        }

        public void PlayMedia(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "play_media", serviceData);
        }

        public void ShuffleSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "shuffle_set", serviceData);
        }
    }

    public partial class BinarySensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public BinarySensorEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class CameraEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public CameraEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void EnableMotionDetection(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "enable_motion_detection", serviceData);
        }

        public void DisableMotionDetection(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "disable_motion_detection", serviceData);
        }

        public void Snapshot(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "snapshot", serviceData);
        }

        public void PlayStream(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "play_stream", serviceData);
        }

        public void Record(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "record", serviceData);
        }
    }

    public partial class NetdaemonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public NetdaemonEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void RegisterService(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "register_service", serviceData);
        }

        public void ReloadApps(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "reload_apps", serviceData);
        }

        public void Wifi2irappSendir(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "wifi2irapp_sendir", serviceData);
        }
    }

    public partial class LightEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public LightEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class WeatherEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public WeatherEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class ZoneEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public ZoneEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zone", "reload", serviceData);
        }
    }

    public partial class InputTextEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public InputTextEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_text", "reload", serviceData);
        }

        public void SetValue(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_text", "set_value", serviceData);
        }
    }

    public partial class SunEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public SunEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class PersonEntities
    {
        private readonly NetDaemonRxApp _app;
        public PersonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public PersonEntity Impeham => new PersonEntity(_app, new string[]{"person.impeham"});
    }

    public partial class AutomationEntities
    {
        private readonly NetDaemonRxApp _app;
        public AutomationEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public AutomationEntity Automation145 => new AutomationEntity(_app, new string[]{"automation.automation_145"});
        public AutomationEntity WarehousePowerDown => new AutomationEntity(_app, new string[]{"automation.warehouse_power_down"});
        public AutomationEntity SmartLampBlueChanged => new AutomationEntity(_app, new string[]{"automation.smart_lamp_blue_changed"});
        public AutomationEntity Automation99 => new AutomationEntity(_app, new string[]{"automation.automation_99"});
        public AutomationEntity LightStringStartPointChange2 => new AutomationEntity(_app, new string[]{"automation.light_string_start_point_change_2"});
        public AutomationEntity LightStringScenarioSet => new AutomationEntity(_app, new string[]{"automation.light_string_scenario_set"});
        public AutomationEntity LightStringScenarioSet2 => new AutomationEntity(_app, new string[]{"automation.light_string_scenario_set_2"});
        public AutomationEntity SetSmartLampScenarioSelector => new AutomationEntity(_app, new string[]{"automation.set_smart_lamp_scenario_selector"});
        public AutomationEntity Automation107 => new AutomationEntity(_app, new string[]{"automation.automation_107"});
        public AutomationEntity AssistantWakeupMessageHandler => new AutomationEntity(_app, new string[]{"automation.assistant_wakeup_message_handler"});
        public AutomationEntity LightStringEndPointChanged2 => new AutomationEntity(_app, new string[]{"automation.light_string_end_point_changed_2"});
        public AutomationEntity LightStringScenarioDelayChanged2 => new AutomationEntity(_app, new string[]{"automation.light_string_scenario_delay_changed_2"});
        public AutomationEntity Ac2AutoModeProcessor => new AutomationEntity(_app, new string[]{"automation.ac2_auto_mode_processor"});
        public AutomationEntity ReceiverInputSoundChange => new AutomationEntity(_app, new string[]{"automation.receiver_input_sound_change"});
        public AutomationEntity ArcadeCabinetScenarioDelayChange => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_scenario_delay_change"});
        public AutomationEntity InfinityCubeNightMovement => new AutomationEntity(_app, new string[]{"automation.infinity_cube_night_movement"});
        public AutomationEntity BedroomPowerSaveArcadergbOn => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_arcadergb_on"});
        public AutomationEntity ActivityGoingToWarehouse => new AutomationEntity(_app, new string[]{"automation.activity_going_to_warehouse"});
        public AutomationEntity PhilipsLaptopPowerSensedOff => new AutomationEntity(_app, new string[]{"automation.philips_laptop_power_sensed_off"});
        public AutomationEntity MediaCommandRequest => new AutomationEntity(_app, new string[]{"automation.media_command_request"});
        public AutomationEntity Automation134 => new AutomationEntity(_app, new string[]{"automation.automation_134"});
        public AutomationEntity PhilipsPowerSwitchedOn => new AutomationEntity(_app, new string[]{"automation.philips_power_switched_on"});
        public AutomationEntity MopidyPlayPlaylistSet => new AutomationEntity(_app, new string[]{"automation.mopidy_play_playlist_set"});
        public AutomationEntity Automation140 => new AutomationEntity(_app, new string[]{"automation.automation_140"});
        public AutomationEntity WakeupWordDetectedMuteMedias => new AutomationEntity(_app, new string[]{"automation.wakeup_word_detected_mute_medias"});
        public AutomationEntity BedroomPowerSaveDisabled => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_disabled"});
        public AutomationEntity LgtvVolumeChanged => new AutomationEntity(_app, new string[]{"automation.lgtv_volume_changed"});
        public AutomationEntity TriplePanelLeftMiddle => new AutomationEntity(_app, new string[]{"automation.triple_panel_left_middle"});
        public AutomationEntity NeonSignScenarioDelayChanged => new AutomationEntity(_app, new string[]{"automation.neon_sign_scenario_delay_changed"});
        public AutomationEntity DoneActivityUsingWarehouse => new AutomationEntity(_app, new string[]{"automation.done_activity_using_warehouse"});
        public AutomationEntity MediaPcVolumeTracker => new AutomationEntity(_app, new string[]{"automation.media_pc_volume_tracker"});
        public AutomationEntity BoilerTimerVoiceUpdate => new AutomationEntity(_app, new string[]{"automation.boiler_timer_voice_update"});
        public AutomationEntity Automation97 => new AutomationEntity(_app, new string[]{"automation.automation_97"});
        public AutomationEntity Automation74 => new AutomationEntity(_app, new string[]{"automation.automation_74"});
        public AutomationEntity Automation101 => new AutomationEntity(_app, new string[]{"automation.automation_101"});
        public AutomationEntity SmartLampScenarioDelayChange => new AutomationEntity(_app, new string[]{"automation.smart_lamp_scenario_delay_change"});
        public AutomationEntity KodisPlayModeSetSurround => new AutomationEntity(_app, new string[]{"automation.kodis_play_mode_set_surround"});
        public AutomationEntity Automation3 => new AutomationEntity(_app, new string[]{"automation.automation_3"});
        public AutomationEntity InfinityCubeRedChanged => new AutomationEntity(_app, new string[]{"automation.infinity_cube_red_changed"});
        public AutomationEntity ProjectorBackgroundOn => new AutomationEntity(_app, new string[]{"automation.projector_background_on"});
        public AutomationEntity Automation156 => new AutomationEntity(_app, new string[]{"automation.automation_156"});
        public AutomationEntity KodisPlayModeSetSingle => new AutomationEntity(_app, new string[]{"automation.kodis_play_mode_set_single"});
        public AutomationEntity SpeakMopidyMarkUnfavored => new AutomationEntity(_app, new string[]{"automation.speak_mopidy_mark_unfavored"});
        public AutomationEntity Automation104 => new AutomationEntity(_app, new string[]{"automation.automation_104"});
        public AutomationEntity Automation72 => new AutomationEntity(_app, new string[]{"automation.automation_72"});
        public AutomationEntity ProjectorPowerSwitchedOn => new AutomationEntity(_app, new string[]{"automation.projector_power_switched_on"});
        public AutomationEntity KodiLibraryRefresh => new AutomationEntity(_app, new string[]{"automation.kodi_library_refresh"});
        public AutomationEntity AssistantVolumeChanged => new AutomationEntity(_app, new string[]{"automation.assistant_volume_changed"});
        public AutomationEntity NeonSignScenarioDelayChange => new AutomationEntity(_app, new string[]{"automation.neon_sign_scenario_delay_change"});
        public AutomationEntity WakingUp => new AutomationEntity(_app, new string[]{"automation.waking_up"});
        public AutomationEntity Automation105 => new AutomationEntity(_app, new string[]{"automation.automation_105"});
        public AutomationEntity AssistantOff => new AutomationEntity(_app, new string[]{"automation.assistant_off"});
        public AutomationEntity KodisPlayFileSet => new AutomationEntity(_app, new string[]{"automation.kodis_play_file_set"});
        public AutomationEntity SpeakWeather => new AutomationEntity(_app, new string[]{"automation.speak_weather"});
        public AutomationEntity Automation137 => new AutomationEntity(_app, new string[]{"automation.automation_137"});
        public AutomationEntity TriplePanelLeft => new AutomationEntity(_app, new string[]{"automation.triple_panel_left"});
        public AutomationEntity Automation71 => new AutomationEntity(_app, new string[]{"automation.automation_71"});
        public AutomationEntity LightStringEndPointChanged => new AutomationEntity(_app, new string[]{"automation.light_string_end_point_changed"});
        public AutomationEntity KeepExtensionCableOn => new AutomationEntity(_app, new string[]{"automation.keep_extension_cable_on"});
        public AutomationEntity InfinityCubeScenarioDelayChange => new AutomationEntity(_app, new string[]{"automation.infinity_cube_scenario_delay_change"});
        public AutomationEntity BoilerTimerSet => new AutomationEntity(_app, new string[]{"automation.boiler_timer_set"});
        public AutomationEntity TriplePanelRightMiddle => new AutomationEntity(_app, new string[]{"automation.triple_panel_right_middle"});
        public AutomationEntity Ac1AutoModeProcessor => new AutomationEntity(_app, new string[]{"automation.ac1_auto_mode_processor"});
        public AutomationEntity SmartlampPowerstate => new AutomationEntity(_app, new string[]{"automation.smartlamp_powerstate"});
        public AutomationEntity ActivitySleep => new AutomationEntity(_app, new string[]{"automation.activity_sleep"});
        public AutomationEntity ArcadeCabinetAmbientSoundSet => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_ambient_sound_set"});
        public AutomationEntity ArcadeCabinetBlueChanged => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_blue_changed"});
        public AutomationEntity Automation76 => new AutomationEntity(_app, new string[]{"automation.automation_76"});
        public AutomationEntity Automation135 => new AutomationEntity(_app, new string[]{"automation.automation_135"});
        public AutomationEntity LightStringBrightnessChange => new AutomationEntity(_app, new string[]{"automation.light_string_brightness_change"});
        public AutomationEntity ActivityWatchAMovie => new AutomationEntity(_app, new string[]{"automation.activity_watch_a_movie"});
        public AutomationEntity LgtvVolumeTracker => new AutomationEntity(_app, new string[]{"automation.lgtv_volume_tracker"});
        public AutomationEntity Automation2 => new AutomationEntity(_app, new string[]{"automation.automation_2"});
        public AutomationEntity Wirelessmotionsesnsor9b76ToShowerMotionAdapter => new AutomationEntity(_app, new string[]{"automation.wirelessmotionsesnsor_9b76_to_shower_motion_adapter"});
        public AutomationEntity MediaPcTvVideoProfileSetter => new AutomationEntity(_app, new string[]{"automation.media_pc_tv_video_profile_setter"});
        public AutomationEntity InfinityCubeNightModeOff => new AutomationEntity(_app, new string[]{"automation.infinity_cube_night_mode_off"});
        public AutomationEntity DualPanelRightRight => new AutomationEntity(_app, new string[]{"automation.dual_panel_right_right"});
        public AutomationEntity SayTime => new AutomationEntity(_app, new string[]{"automation.say_time"});
        public AutomationEntity LgtvPowerSensedOff => new AutomationEntity(_app, new string[]{"automation.lgtv_power_sensed_off"});
        public AutomationEntity BedroomPowerSaveMovement => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_movement"});
        public AutomationEntity PhilipsAmbilightSwitchedOnInvalid => new AutomationEntity(_app, new string[]{"automation.philips_ambilight_switched_on_invalid"});
        public AutomationEntity CandleLightingToday => new AutomationEntity(_app, new string[]{"automation.candle_lighting_today"});
        public AutomationEntity LightStringEndPointChange2 => new AutomationEntity(_app, new string[]{"automation.light_string_end_point_change_2"});
        public AutomationEntity TurnOnAutoClimateInHouse => new AutomationEntity(_app, new string[]{"automation.turn_on_auto_climate_in_house"});
        public AutomationEntity SetNeonSignScenarioSelector => new AutomationEntity(_app, new string[]{"automation.set_neon_sign_scenario_selector"});
        public AutomationEntity ArcadeCabinetVolumeChanged => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_volume_changed"});
        public AutomationEntity LightStringScenarioDelayChanged => new AutomationEntity(_app, new string[]{"automation.light_string_scenario_delay_changed"});
        public AutomationEntity Automation132 => new AutomationEntity(_app, new string[]{"automation.automation_132"});
        public AutomationEntity GamesCornerNeonModeSet => new AutomationEntity(_app, new string[]{"automation.games_corner_neon_mode_set"});
        public AutomationEntity KodisPlayModeSetReciever => new AutomationEntity(_app, new string[]{"automation.kodis_play_mode_set_reciever"});
        public AutomationEntity PhilipsLaptopPowerSensedOn => new AutomationEntity(_app, new string[]{"automation.philips_laptop_power_sensed_on"});
        public AutomationEntity ActivityPlayPcOnTv => new AutomationEntity(_app, new string[]{"automation.activity_play_pc_on_tv"});
        public AutomationEntity SmartLampScenarioSet => new AutomationEntity(_app, new string[]{"automation.smart_lamp_scenario_set"});
        public AutomationEntity GlobalMediaPlaypause => new AutomationEntity(_app, new string[]{"automation.global_media_playpause"});
        public AutomationEntity LikeDislikeTrack => new AutomationEntity(_app, new string[]{"automation.like_dislike_track"});
        public AutomationEntity LightStringStartPointChanged => new AutomationEntity(_app, new string[]{"automation.light_string_start_point_changed"});
        public AutomationEntity Automation136 => new AutomationEntity(_app, new string[]{"automation.automation_136"});
        public AutomationEntity HassTheme => new AutomationEntity(_app, new string[]{"automation.hass_theme"});
        public AutomationEntity InfluxFolderSizeRecieve => new AutomationEntity(_app, new string[]{"automation.influx_folder_size_recieve"});
        public AutomationEntity ArcadeCabinetVolumeChange => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_volume_change"});
        public AutomationEntity AutoEveningLights => new AutomationEntity(_app, new string[]{"automation.auto_evening_lights"});
        public AutomationEntity SetArcadeCabinetAmbientSoundSelector => new AutomationEntity(_app, new string[]{"automation.set_arcade_cabinet_ambient_sound_selector"});
        public AutomationEntity TriplePanelMiddleLeft => new AutomationEntity(_app, new string[]{"automation.triple_panel_middle_left"});
        public AutomationEntity NeonSignBlueChanged => new AutomationEntity(_app, new string[]{"automation.neon_sign_blue_changed"});
        public AutomationEntity ReceiverVolumeLevelChange => new AutomationEntity(_app, new string[]{"automation.receiver_volume_level_change"});
        public AutomationEntity LgTvOffActions => new AutomationEntity(_app, new string[]{"automation.lg_tv_off_actions"});
        public AutomationEntity AssistantOn => new AutomationEntity(_app, new string[]{"automation.assistant_on"});
        public AutomationEntity GoingToSleep => new AutomationEntity(_app, new string[]{"automation.going_to_sleep"});
        public AutomationEntity InfinityCubeScenarioSet => new AutomationEntity(_app, new string[]{"automation.infinity_cube_scenario_set"});
        public AutomationEntity SetLightThemeRequest => new AutomationEntity(_app, new string[]{"automation.set_light_theme_request"});
        public AutomationEntity Automation61 => new AutomationEntity(_app, new string[]{"automation.automation_61"});
        public AutomationEntity PhilipsAmbilightSwitchedOn => new AutomationEntity(_app, new string[]{"automation.philips_ambilight_switched_on"});
        public AutomationEntity ActivityPlayArcadeMachine => new AutomationEntity(_app, new string[]{"automation.activity_play_arcade_machine"});
        public AutomationEntity DoneActivitySleep => new AutomationEntity(_app, new string[]{"automation.done_activity_sleep"});
        public AutomationEntity NeonSignLampRedChanged => new AutomationEntity(_app, new string[]{"automation.neon_sign_lamp_red_changed"});
        public AutomationEntity Automation96 => new AutomationEntity(_app, new string[]{"automation.automation_96"});
        public AutomationEntity Automation73 => new AutomationEntity(_app, new string[]{"automation.automation_73"});
        public AutomationEntity VoiceCommandAbort => new AutomationEntity(_app, new string[]{"automation.voice_command_abort"});
        public AutomationEntity SetArcadeCabinetScenarioSelector => new AutomationEntity(_app, new string[]{"automation.set_arcade_cabinet_scenario_selector"});
        public AutomationEntity ProjectorPowerSwitchedOff => new AutomationEntity(_app, new string[]{"automation.projector_power_switched_off"});
        public AutomationEntity InfinityCubeBlueChanged => new AutomationEntity(_app, new string[]{"automation.infinity_cube_blue_changed"});
        public AutomationEntity AssistantPowerOff => new AutomationEntity(_app, new string[]{"automation.assistant_power_off"});
        public AutomationEntity SmartlampToBedroomMotionAdapter => new AutomationEntity(_app, new string[]{"automation.smartlamp_to_bedroom_motion_adapter"});
        public AutomationEntity ArcadeCabinetGreenChanged => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_green_changed"});
        public AutomationEntity SetLightStringScenarioSelector => new AutomationEntity(_app, new string[]{"automation.set_light_string_scenario_selector"});
        public AutomationEntity MopidyShuffleOn => new AutomationEntity(_app, new string[]{"automation.mopidy_shuffle_on"});
        public AutomationEntity GlobalVolumeUp => new AutomationEntity(_app, new string[]{"automation.global_volume_up"});
        public AutomationEntity InfinityCubeBlendingSet => new AutomationEntity(_app, new string[]{"automation.infinity_cube_blending_set"});
        public AutomationEntity KodiPlaying => new AutomationEntity(_app, new string[]{"automation.kodi_playing"});
        public AutomationEntity SetLightStringScenarioSelector2 => new AutomationEntity(_app, new string[]{"automation.set_light_string_scenario_selector_2"});
        public AutomationEntity LikeDislikeTrackRequest => new AutomationEntity(_app, new string[]{"automation.like_dislike_track_request"});
        public AutomationEntity SetArcadeCabinetAttractModeSelector => new AutomationEntity(_app, new string[]{"automation.set_arcade_cabinet_attract_mode_selector"});
        public AutomationEntity DualPanelLeft => new AutomationEntity(_app, new string[]{"automation.dual_panel_left"});
        public AutomationEntity TriplePanelLeftLeft => new AutomationEntity(_app, new string[]{"automation.triple_panel_left_left"});
        public AutomationEntity DualPanelRight => new AutomationEntity(_app, new string[]{"automation.dual_panel_right"});
        public AutomationEntity AssistantVoiceOn => new AutomationEntity(_app, new string[]{"automation.assistant_voice_on"});
        public AutomationEntity LightStringEndPointChange => new AutomationEntity(_app, new string[]{"automation.light_string_end_point_change"});
        public AutomationEntity BoilerTimerStatusSetter => new AutomationEntity(_app, new string[]{"automation.boiler_timer_status_setter"});
        public AutomationEntity BedroomPowerSaveArcademarqueeOn => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_arcademarquee_on"});
        public AutomationEntity DoneActivityRequest => new AutomationEntity(_app, new string[]{"automation.done_activity_request"});
        public AutomationEntity LgtvVolumeSetter => new AutomationEntity(_app, new string[]{"automation.lgtv_volume_setter"});
        public AutomationEntity ProfileDisabled => new AutomationEntity(_app, new string[]{"automation.profile_disabled"});
        public AutomationEntity KodisPlayModeSetTv => new AutomationEntity(_app, new string[]{"automation.kodis_play_mode_set_tv"});
        public AutomationEntity TriplePanelLeftRight => new AutomationEntity(_app, new string[]{"automation.triple_panel_left_right"});
        public AutomationEntity LcdSetOutsideTemp => new AutomationEntity(_app, new string[]{"automation.lcd_set_outside_temp"});
        public AutomationEntity DualPanelRightLeft => new AutomationEntity(_app, new string[]{"automation.dual_panel_right_left"});
        public AutomationEntity PhilipsAmbilightSwitchedOffInvalid => new AutomationEntity(_app, new string[]{"automation.philips_ambilight_switched_off_invalid"});
        public AutomationEntity ArcadeCabinetPowerChange => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_power_change"});
        public AutomationEntity ForceScriptWakingUp => new AutomationEntity(_app, new string[]{"automation.force_script_waking_up"});
        public AutomationEntity Automation64 => new AutomationEntity(_app, new string[]{"automation.automation_64"});
        public AutomationEntity Automation143 => new AutomationEntity(_app, new string[]{"automation.automation_143"});
        public AutomationEntity SetBedHeadbackScenarioSelector => new AutomationEntity(_app, new string[]{"automation.set_bed_headback_scenario_selector"});
        public AutomationEntity BedHeadbackScenarioDelayChanged => new AutomationEntity(_app, new string[]{"automation.bed_headback_scenario_delay_changed"});
        public AutomationEntity Automation141 => new AutomationEntity(_app, new string[]{"automation.automation_141"});
        public AutomationEntity ResetWakeupFlag => new AutomationEntity(_app, new string[]{"automation.reset_wakeup_flag"});
        public AutomationEntity MediaPcVolumeSetter => new AutomationEntity(_app, new string[]{"automation.media_pc_volume_setter"});
        public AutomationEntity BedroomPowerSaveHeadbackOn => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_headback_on"});
        public AutomationEntity ArcadeCabinetAttractModeSet => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_attract_mode_set"});
        public AutomationEntity PlayMusicRequest => new AutomationEntity(_app, new string[]{"automation.play_music_request"});
        public AutomationEntity NeonSignGreenChanged => new AutomationEntity(_app, new string[]{"automation.neon_sign_green_changed"});
        public AutomationEntity PhilipsAmbilightSwitchedOff => new AutomationEntity(_app, new string[]{"automation.philips_ambilight_switched_off"});
        public AutomationEntity ActivityPlayThePlaystation => new AutomationEntity(_app, new string[]{"automation.activity_play_the_playstation"});
        public AutomationEntity TriplePanelMiddleMiddle => new AutomationEntity(_app, new string[]{"automation.triple_panel_middle_middle"});
        public AutomationEntity BulkControlMusicSwitchedOn => new AutomationEntity(_app, new string[]{"automation.bulk_control_music_switched_on"});
        public AutomationEntity Automation69 => new AutomationEntity(_app, new string[]{"automation.automation_69"});
        public AutomationEntity SmartphonePowerLow => new AutomationEntity(_app, new string[]{"automation.smartphone_power_low"});
        public AutomationEntity BedHeadbackLampRedChanged => new AutomationEntity(_app, new string[]{"automation.bed_headback_lamp_red_changed"});
        public AutomationEntity LightStringColorBrightnessChange => new AutomationEntity(_app, new string[]{"automation.light_string_color_brightness_change"});
        public AutomationEntity ActivityLeaveTheHouse => new AutomationEntity(_app, new string[]{"automation.activity_leave_the_house"});
        public AutomationEntity LightStringStartPointChange => new AutomationEntity(_app, new string[]{"automation.light_string_start_point_change"});
        public AutomationEntity MediaPcTvVideoProfileTracker => new AutomationEntity(_app, new string[]{"automation.media_pc_tv_video_profile_tracker"});
        public AutomationEntity BedroomPowerSaveCandlesOn => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_candles_on"});
        public AutomationEntity LgtvPowerSensedOn => new AutomationEntity(_app, new string[]{"automation.lgtv_power_sensed_on"});
        public AutomationEntity TriplePanelMiddleRight => new AutomationEntity(_app, new string[]{"automation.triple_panel_middle_right"});
        public AutomationEntity Automation62 => new AutomationEntity(_app, new string[]{"automation.automation_62"});
        public AutomationEntity MopidyVolume => new AutomationEntity(_app, new string[]{"automation.mopidy_volume"});
        public AutomationEntity LgtvPowerSwitchedOn => new AutomationEntity(_app, new string[]{"automation.lgtv_power_switched_on"});
        public AutomationEntity SetHouseLightThemeSelector => new AutomationEntity(_app, new string[]{"automation.set_house_light_theme_selector"});
        public AutomationEntity MopidyPowerOff => new AutomationEntity(_app, new string[]{"automation.mopidy_power_off"});
        public AutomationEntity Automation5 => new AutomationEntity(_app, new string[]{"automation.automation_5"});
        public AutomationEntity WarehouseDoorSensorArmed => new AutomationEntity(_app, new string[]{"automation.warehouse_door_sensor_armed"});
        public AutomationEntity ReceiverPowerSwitchChange => new AutomationEntity(_app, new string[]{"automation.receiver_power_switch_change"});
        public AutomationEntity BedHeadbackBlueChanged => new AutomationEntity(_app, new string[]{"automation.bed_headback_blue_changed"});
        public AutomationEntity SetGamesCornerNeonModeSelector => new AutomationEntity(_app, new string[]{"automation.set_games_corner_neon_mode_selector"});
        public AutomationEntity MediaProfileInvalidChange => new AutomationEntity(_app, new string[]{"automation.media_profile_invalid_change"});
        public AutomationEntity KodisPlayModeSetTv2 => new AutomationEntity(_app, new string[]{"automation.kodis_play_mode_set_tv_2"});
        public AutomationEntity LightStringScenarioDelayChange => new AutomationEntity(_app, new string[]{"automation.light_string_scenario_delay_change"});
        public AutomationEntity Automation67 => new AutomationEntity(_app, new string[]{"automation.automation_67"});
        public AutomationEntity BedHeadbackScenarioDelayChange => new AutomationEntity(_app, new string[]{"automation.bed_headback_scenario_delay_change"});
        public AutomationEntity InfinityCubeScenarioDelayChanged => new AutomationEntity(_app, new string[]{"automation.infinity_cube_scenario_delay_changed"});
        public AutomationEntity BedHeadbackGreenChanged => new AutomationEntity(_app, new string[]{"automation.bed_headback_green_changed"});
        public AutomationEntity BedroomPowerSaveLightstringOn => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_lightstring_on"});
        public AutomationEntity DoneActivityUsingTheProfile => new AutomationEntity(_app, new string[]{"automation.done_activity_using_the_profile"});
        public AutomationEntity MediaCommand => new AutomationEntity(_app, new string[]{"automation.media_command"});
        public AutomationEntity SetInfinityCubeBlendingSelector => new AutomationEntity(_app, new string[]{"automation.set_infinity_cube_blending_selector"});
        public AutomationEntity ArcadeCabinetScenarioSet => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_scenario_set"});
        public AutomationEntity TurnOnAutoClimateInLivingRoom => new AutomationEntity(_app, new string[]{"automation.turn_on_auto_climate_in_living_room"});
        public AutomationEntity LightStringBrightnessChanged => new AutomationEntity(_app, new string[]{"automation.light_string_brightness_changed"});
        public AutomationEntity ArcadeCabinetScenarioDelayChanged => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_scenario_delay_changed"});
        public AutomationEntity TurnOnAutoClimateInBedRoom => new AutomationEntity(_app, new string[]{"automation.turn_on_auto_climate_in_bed_room"});
        public AutomationEntity Automation70 => new AutomationEntity(_app, new string[]{"automation.automation_70"});
        public AutomationEntity LightStringColorBrightnessChanged => new AutomationEntity(_app, new string[]{"automation.light_string_color_brightness_changed"});
        public AutomationEntity TriplePanelRightRight => new AutomationEntity(_app, new string[]{"automation.triple_panel_right_right"});
        public AutomationEntity Automation65 => new AutomationEntity(_app, new string[]{"automation.automation_65"});
        public AutomationEntity SetLightTheme => new AutomationEntity(_app, new string[]{"automation.set_light_theme"});
        public AutomationEntity UnhandledNonRecognizedIntentUnmuteMedias => new AutomationEntity(_app, new string[]{"automation.unhandled_non_recognized_intent_unmute_medias"});
        public AutomationEntity BedHeadbackNightModeOff => new AutomationEntity(_app, new string[]{"automation.bed_headback_night_mode_off"});
        public AutomationEntity MediaPcAudioOutputSet => new AutomationEntity(_app, new string[]{"automation.media_pc_audio_output_set"});
        public AutomationEntity ActivityWatchCableTv => new AutomationEntity(_app, new string[]{"automation.activity_watch_cable_tv"});
        public AutomationEntity LightStringStartPointChanged2 => new AutomationEntity(_app, new string[]{"automation.light_string_start_point_changed_2"});
        public AutomationEntity InfluxFolderSize => new AutomationEntity(_app, new string[]{"automation.influx_folder_size"});
        public AutomationEntity BedroomPowerSaveColorLightstringOn => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_color_lightstring_on"});
        public AutomationEntity TrafficThresholdChanged => new AutomationEntity(_app, new string[]{"automation.traffic_threshold_changed"});
        public AutomationEntity Automation4 => new AutomationEntity(_app, new string[]{"automation.automation_4"});
        public AutomationEntity PlayMusic => new AutomationEntity(_app, new string[]{"automation.play_music"});
        public AutomationEntity MopidyPowerOn => new AutomationEntity(_app, new string[]{"automation.mopidy_power_on"});
        public AutomationEntity BedHeadbackPowerChange => new AutomationEntity(_app, new string[]{"automation.bed_headback_power_change"});
        public AutomationEntity ActivityCinemaAsBackground => new AutomationEntity(_app, new string[]{"automation.activity_cinema_as_background"});
        public AutomationEntity ReceiverVolLevelSetter => new AutomationEntity(_app, new string[]{"automation.receiver_vol_level_setter"});
        public AutomationEntity DoActivityRequest => new AutomationEntity(_app, new string[]{"automation.do_activity_request"});
        public AutomationEntity LeavingHomeActions => new AutomationEntity(_app, new string[]{"automation.leaving_home_actions"});
        public AutomationEntity ArcadeCabinetLampRedChanged => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_lamp_red_changed"});
        public AutomationEntity AssistantPowerOn => new AutomationEntity(_app, new string[]{"automation.assistant_power_on"});
        public AutomationEntity SetTurnOnMediaPcOnHouseLeave => new AutomationEntity(_app, new string[]{"automation.set_turn_on_media_pc_on_house_leave"});
        public AutomationEntity SmartLampGreenChanged => new AutomationEntity(_app, new string[]{"automation.smart_lamp_green_changed"});
        public AutomationEntity AssistantVoiceCommandsOn => new AutomationEntity(_app, new string[]{"automation.assistant_voice_commands_on"});
        public AutomationEntity Automation106 => new AutomationEntity(_app, new string[]{"automation.automation_106"});
        public AutomationEntity TriplePanelMiddle => new AutomationEntity(_app, new string[]{"automation.triple_panel_middle"});
        public AutomationEntity SpeakMopidyRemoveUnfavored => new AutomationEntity(_app, new string[]{"automation.speak_mopidy_remove_unfavored"});
        public AutomationEntity Automation68 => new AutomationEntity(_app, new string[]{"automation.automation_68"});
        public AutomationEntity LcdBacklightModeSet => new AutomationEntity(_app, new string[]{"automation.lcd_backlight_mode_set"});
        public AutomationEntity KodiVolumeTracker => new AutomationEntity(_app, new string[]{"automation.kodi_volume_tracker"});
        public AutomationEntity TriplePanelRightLeft => new AutomationEntity(_app, new string[]{"automation.triple_panel_right_left"});
        public AutomationEntity BedHeadbackPowerChanged => new AutomationEntity(_app, new string[]{"automation.bed_headback_power_changed"});
        public AutomationEntity KodisPlayModeSetDual => new AutomationEntity(_app, new string[]{"automation.kodis_play_mode_set_dual"});
        public AutomationEntity SmartLampScenarioDelayChanged => new AutomationEntity(_app, new string[]{"automation.smart_lamp_scenario_delay_changed"});
        public AutomationEntity LightStringScenarioDelayChange2 => new AutomationEntity(_app, new string[]{"automation.light_string_scenario_delay_change_2"});
        public AutomationEntity E30MinPreCandleLighting => new AutomationEntity(_app, new string[]{"automation.30_min_pre_candle_lighting"});
        public AutomationEntity SetInfinityCubeScenarioSelector => new AutomationEntity(_app, new string[]{"automation.set_infinity_cube_scenario_selector"});
        public AutomationEntity BedroomPowerSaveNoMovement => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_no_movement"});
        public AutomationEntity LgtvPowerSwitchedOff => new AutomationEntity(_app, new string[]{"automation.lgtv_power_switched_off"});
        public AutomationEntity ClimateControlActionRequest => new AutomationEntity(_app, new string[]{"automation.climate_control_action_request"});
        public AutomationEntity ProjectorBackgroundOff => new AutomationEntity(_app, new string[]{"automation.projector_background_off"});
        public AutomationEntity MediaPcVolumeChanged => new AutomationEntity(_app, new string[]{"automation.media_pc_volume_changed"});
        public AutomationEntity PhilipsPowerSwitchedOff => new AutomationEntity(_app, new string[]{"automation.philips_power_switched_off"});
        public AutomationEntity ArcadeCabinetPowerChanged => new AutomationEntity(_app, new string[]{"automation.arcade_cabinet_power_changed"});
        public AutomationEntity DualPanelLeftLeft => new AutomationEntity(_app, new string[]{"automation.dual_panel_left_left"});
        public AutomationEntity Automation66 => new AutomationEntity(_app, new string[]{"automation.automation_66"});
        public AutomationEntity ActivityUseCinema => new AutomationEntity(_app, new string[]{"automation.activity_use_cinema"});
        public AutomationEntity WirelessmotionsesnsorAd0dToBedroomMotionAdapter => new AutomationEntity(_app, new string[]{"automation.wirelessmotionsesnsor_ad0d_to_bedroom_motion_adapter"});
        public AutomationEntity Automation63 => new AutomationEntity(_app, new string[]{"automation.automation_63"});
        public AutomationEntity Automation100 => new AutomationEntity(_app, new string[]{"automation.automation_100"});
        public AutomationEntity ApproachingHomeActions => new AutomationEntity(_app, new string[]{"automation.approaching_home_actions"});
        public AutomationEntity TabletPowerLow => new AutomationEntity(_app, new string[]{"automation.tablet_power_low"});
        public AutomationEntity InfinityCubeGreenChanged => new AutomationEntity(_app, new string[]{"automation.infinity_cube_green_changed"});
        public AutomationEntity BedroomPowerSaveEnabled => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_enabled"});
        public AutomationEntity NeonSignPowerChange => new AutomationEntity(_app, new string[]{"automation.neon_sign_power_change"});
        public AutomationEntity BedHeadbackNightMovement => new AutomationEntity(_app, new string[]{"automation.bed_headback_night_movement"});
        public AutomationEntity Automation142 => new AutomationEntity(_app, new string[]{"automation.automation_142"});
        public AutomationEntity Automation98 => new AutomationEntity(_app, new string[]{"automation.automation_98"});
        public AutomationEntity MediaPcVideoOutputSet => new AutomationEntity(_app, new string[]{"automation.media_pc_video_output_set"});
        public AutomationEntity ActivityGoingToNeedAShower => new AutomationEntity(_app, new string[]{"automation.activity_going_to_need_a_shower"});
        public AutomationEntity KodisPlayFolderSet => new AutomationEntity(_app, new string[]{"automation.kodis_play_folder_set"});
        public AutomationEntity Automation75 => new AutomationEntity(_app, new string[]{"automation.automation_75"});
        public AutomationEntity LcdDateTimeUpdater => new AutomationEntity(_app, new string[]{"automation.lcd_date_time_updater"});
        public AutomationEntity AssistantVoiceCommandsOff => new AutomationEntity(_app, new string[]{"automation.assistant_voice_commands_off"});
        public AutomationEntity LeaveTimeForReading => new AutomationEntity(_app, new string[]{"automation.leave_time_for_reading"});
        public AutomationEntity DoneActivityPlayingTheArcadeMachine => new AutomationEntity(_app, new string[]{"automation.done_activity_playing_the_arcade_machine"});
        public AutomationEntity NeonSignScenarioSet => new AutomationEntity(_app, new string[]{"automation.neon_sign_scenario_set"});
        public AutomationEntity Automation144 => new AutomationEntity(_app, new string[]{"automation.automation_144"});
        public AutomationEntity KodiVolumeSetter => new AutomationEntity(_app, new string[]{"automation.kodi_volume_setter"});
        public AutomationEntity DualPanelLeftRight => new AutomationEntity(_app, new string[]{"automation.dual_panel_left_right"});
        public AutomationEntity MopidyShuffleOff => new AutomationEntity(_app, new string[]{"automation.mopidy_shuffle_off"});
        public AutomationEntity ReceiverVolLevelTracker => new AutomationEntity(_app, new string[]{"automation.receiver_vol_level_tracker"});
        public AutomationEntity Automation133 => new AutomationEntity(_app, new string[]{"automation.automation_133"});
        public AutomationEntity Automation155 => new AutomationEntity(_app, new string[]{"automation.automation_155"});
        public AutomationEntity SetTurnOffMediaPcOnHouseLeave => new AutomationEntity(_app, new string[]{"automation.set_turn_off_media_pc_on_house_leave"});
        public AutomationEntity ShowerNoMovement => new AutomationEntity(_app, new string[]{"automation.shower_no_movement"});
        public AutomationEntity LcdSetBedRoomTemp => new AutomationEntity(_app, new string[]{"automation.lcd_set_bed_room_temp"});
        public AutomationEntity LcdSetLivingRoomTemp => new AutomationEntity(_app, new string[]{"automation.lcd_set_living_room_temp"});
        public AutomationEntity NeonSignPowerChanged => new AutomationEntity(_app, new string[]{"automation.neon_sign_power_changed"});
        public AutomationEntity MediaPcVideoProfileSet => new AutomationEntity(_app, new string[]{"automation.media_pc_video_profile_set"});
        public AutomationEntity KeepChargersOn => new AutomationEntity(_app, new string[]{"automation.keep_chargers_on"});
        public AutomationEntity BulkControlTvNewsSwitchedOn => new AutomationEntity(_app, new string[]{"automation.bulk_control_tv_news_switched_on"});
        public AutomationEntity BedroomPowerSaveNeonOn => new AutomationEntity(_app, new string[]{"automation.bedroom_power_save_neon_on"});
        public AutomationEntity WarehouseDoorOpened => new AutomationEntity(_app, new string[]{"automation.warehouse_door_opened"});
        public AutomationEntity ProfileEnabled => new AutomationEntity(_app, new string[]{"automation.profile_enabled"});
        public AutomationEntity BedHeadbackScenarioSet => new AutomationEntity(_app, new string[]{"automation.bed_headback_scenario_set"});
        public AutomationEntity SunsetWalkIn15Mins => new AutomationEntity(_app, new string[]{"automation.sunset_walk_in_15_mins"});
        public AutomationEntity InfluxFolderSizeGet => new AutomationEntity(_app, new string[]{"automation.influx_folder_size_get"});
        public AutomationEntity GlobalVolumeDown => new AutomationEntity(_app, new string[]{"automation.global_volume_down"});
        public AutomationEntity HttpLsxLocationUpdate => new AutomationEntity(_app, new string[]{"automation.http_lsx_location_update"});
        public AutomationEntity SpeakMopidyMarkFavored => new AutomationEntity(_app, new string[]{"automation.speak_mopidy_mark_favored"});
        public AutomationEntity TvSourceSet2 => new AutomationEntity(_app, new string[]{"automation.tv_source_set_2"});
        public AutomationEntity WarehousePowerUp => new AutomationEntity(_app, new string[]{"automation.warehouse_power_up"});
        public AutomationEntity VoiceCommandApprove => new AutomationEntity(_app, new string[]{"automation.voice_command_approve"});
        public AutomationEntity TvSourceSet => new AutomationEntity(_app, new string[]{"automation.tv_source_set"});
        public AutomationEntity TriplePanelRight => new AutomationEntity(_app, new string[]{"automation.triple_panel_right"});
        public AutomationEntity SmartLampRedChanged => new AutomationEntity(_app, new string[]{"automation.smart_lamp_red_changed"});
    }

    public partial class InputNumberEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputNumberEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputNumberEntity BedhbRedSet => new InputNumberEntity(_app, new string[]{"input_number.bedhb_red_set"});
        public InputNumberEntity InfinitycubeBlueSet => new InputNumberEntity(_app, new string[]{"input_number.infinitycube_blue_set"});
        public InputNumberEntity InfinitycubePaletteDelaySet => new InputNumberEntity(_app, new string[]{"input_number.infinitycube_palette_delay_set"});
        public InputNumberEntity ProfilePrimaryKodiVolume => new InputNumberEntity(_app, new string[]{"input_number.profile_primary_kodi_volume"});
        public InputNumberEntity SmartlampBlueSet => new InputNumberEntity(_app, new string[]{"input_number.smartlamp_blue_set"});
        public InputNumberEntity SmartlampGreenSet => new InputNumberEntity(_app, new string[]{"input_number.smartlamp_green_set"});
        public InputNumberEntity NeonsignBlueSet => new InputNumberEntity(_app, new string[]{"input_number.neonsign_blue_set"});
        public InputNumberEntity BedhbGreenSet => new InputNumberEntity(_app, new string[]{"input_number.bedhb_green_set"});
        public InputNumberEntity NeonsignScenarioDelaySet => new InputNumberEntity(_app, new string[]{"input_number.neonsign_scenario_delay_set"});
        public InputNumberEntity KodiSecondaryVolume => new InputNumberEntity(_app, new string[]{"input_number.kodi_secondary_volume"});
        public InputNumberEntity ArcadecabinetVolumeSet => new InputNumberEntity(_app, new string[]{"input_number.arcadecabinet_volume_set"});
        public InputNumberEntity LightstringScenarioDelaySet => new InputNumberEntity(_app, new string[]{"input_number.lightstring_scenario_delay_set"});
        public InputNumberEntity ProfileLgtvVolume => new InputNumberEntity(_app, new string[]{"input_number.profile_lgtv_volume"});
        public InputNumberEntity LightstringBrightnessSet => new InputNumberEntity(_app, new string[]{"input_number.lightstring_brightness_set"});
        public InputNumberEntity LightstringEndBoundarySet => new InputNumberEntity(_app, new string[]{"input_number.lightstring_end_boundary_set"});
        public InputNumberEntity LightstringcolorStartBoundarySet => new InputNumberEntity(_app, new string[]{"input_number.lightstringcolor_start_boundary_set"});
        public InputNumberEntity Ac1AutoMax => new InputNumberEntity(_app, new string[]{"input_number.ac1_auto_max"});
        public InputNumberEntity XiaomiAirpurifierFavoriteLevel => new InputNumberEntity(_app, new string[]{"input_number.xiaomi_airpurifier_favorite_level"});
        public InputNumberEntity LightstringStartBoundarySet => new InputNumberEntity(_app, new string[]{"input_number.lightstring_start_boundary_set"});
        public InputNumberEntity LightstringcolorBrightnessSet => new InputNumberEntity(_app, new string[]{"input_number.lightstringcolor_brightness_set"});
        public InputNumberEntity MediaPcVolumeSet => new InputNumberEntity(_app, new string[]{"input_number.media_pc_volume_set"});
        public InputNumberEntity AssistantVolumeSet => new InputNumberEntity(_app, new string[]{"input_number.assistant_volume_set"});
        public InputNumberEntity BedhbBlueSet => new InputNumberEntity(_app, new string[]{"input_number.bedhb_blue_set"});
        public InputNumberEntity NeonsignGreenSet => new InputNumberEntity(_app, new string[]{"input_number.neonsign_green_set"});
        public InputNumberEntity ArcadecabinetRedSet => new InputNumberEntity(_app, new string[]{"input_number.arcadecabinet_red_set"});
        public InputNumberEntity MopidyVolume => new InputNumberEntity(_app, new string[]{"input_number.mopidy_volume"});
        public InputNumberEntity Ac2AutoMax => new InputNumberEntity(_app, new string[]{"input_number.ac2_auto_max"});
        public InputNumberEntity ArcadecabinetGreenSet => new InputNumberEntity(_app, new string[]{"input_number.arcadecabinet_green_set"});
        public InputNumberEntity TrafficThreshold => new InputNumberEntity(_app, new string[]{"input_number.traffic_threshold"});
        public InputNumberEntity KodiVolume => new InputNumberEntity(_app, new string[]{"input_number.kodi_volume"});
        public InputNumberEntity Ac2AutoMin => new InputNumberEntity(_app, new string[]{"input_number.ac2_auto_min"});
        public InputNumberEntity Ac1AutoMin => new InputNumberEntity(_app, new string[]{"input_number.ac1_auto_min"});
        public InputNumberEntity InfinitycubeGreenSet => new InputNumberEntity(_app, new string[]{"input_number.infinitycube_green_set"});
        public InputNumberEntity SmartlampRedSet => new InputNumberEntity(_app, new string[]{"input_number.smartlamp_red_set"});
        public InputNumberEntity ArcadecabinetScenarioDelaySet => new InputNumberEntity(_app, new string[]{"input_number.arcadecabinet_scenario_delay_set"});
        public InputNumberEntity BedhbScenarioDelaySet => new InputNumberEntity(_app, new string[]{"input_number.bedhb_scenario_delay_set"});
        public InputNumberEntity ArcadecabinetBlueSet => new InputNumberEntity(_app, new string[]{"input_number.arcadecabinet_blue_set"});
        public InputNumberEntity SmartlampScenarioDelaySet => new InputNumberEntity(_app, new string[]{"input_number.smartlamp_scenario_delay_set"});
        public InputNumberEntity InfinitycubeRedSet => new InputNumberEntity(_app, new string[]{"input_number.infinitycube_red_set"});
        public InputNumberEntity ProfileMediaPcVolume => new InputNumberEntity(_app, new string[]{"input_number.profile_media_pc_volume"});
        public InputNumberEntity LightstringcolorScenarioDelaySet => new InputNumberEntity(_app, new string[]{"input_number.lightstringcolor_scenario_delay_set"});
        public InputNumberEntity NeonsignRedSet => new InputNumberEntity(_app, new string[]{"input_number.neonsign_red_set"});
        public InputNumberEntity BoilerTimerSet => new InputNumberEntity(_app, new string[]{"input_number.boiler_timer_set"});
        public InputNumberEntity LightstringcolorEndBoundarySet => new InputNumberEntity(_app, new string[]{"input_number.lightstringcolor_end_boundary_set"});
        public InputNumberEntity LgtvVolume => new InputNumberEntity(_app, new string[]{"input_number.lgtv_volume"});
    }

    public partial class ScriptEntities
    {
        private readonly NetDaemonRxApp _app;
        public ScriptEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ScriptEntity Ac1Off => new ScriptEntity(_app, new string[]{"script.ac1_off"});
        public ScriptEntity TvGamingConsoleDisableRecieverProcess => new ScriptEntity(_app, new string[]{"script.tv_gaming_console_disable_reciever_process"});
        public ScriptEntity TvPcEnable => new ScriptEntity(_app, new string[]{"script.tv_pc_enable"});
        public ScriptEntity MediaPcConditionalOff => new ScriptEntity(_app, new string[]{"script.media_pc_conditional_off"});
        public ScriptEntity MopidyStop => new ScriptEntity(_app, new string[]{"script.mopidy_stop"});
        public ScriptEntity RhasspyRestart => new ScriptEntity(_app, new string[]{"script.rhasspy_restart"});
        public ScriptEntity ActiveMusicVoldown => new ScriptEntity(_app, new string[]{"script.active_music_voldown"});
        public ScriptEntity Ac2Off => new ScriptEntity(_app, new string[]{"script.ac2_off"});
        public ScriptEntity Ac2Cool => new ScriptEntity(_app, new string[]{"script.ac2_cool"});
        public ScriptEntity ArcadecabinetKill => new ScriptEntity(_app, new string[]{"script.arcadecabinet_kill"});
        public ScriptEntity HeadbackSleep => new ScriptEntity(_app, new string[]{"script.headback_sleep"});
        public ScriptEntity Ac2FanSetup => new ScriptEntity(_app, new string[]{"script.ac2_fan_setup"});
        public ScriptEntity ActiveProfileVolumeDown => new ScriptEntity(_app, new string[]{"script.active_profile_volume_down"});
        public ScriptEntity Rl4mpPresetLowerleft => new ScriptEntity(_app, new string[]{"script.rl4mp_preset_lowerleft"});
        public ScriptEntity WakingUpBoilerProcess => new ScriptEntity(_app, new string[]{"script.waking_up_boiler_process"});
        public ScriptEntity ActiveMusicVolup => new ScriptEntity(_app, new string[]{"script.active_music_volup"});
        public ScriptEntity BulkLaunchMusic => new ScriptEntity(_app, new string[]{"script.bulk_launch_music"});
        public ScriptEntity SonyProjectorLeft => new ScriptEntity(_app, new string[]{"script.sony_projector_left"});
        public ScriptEntity HouseLightThemeReading => new ScriptEntity(_app, new string[]{"script.house_light_theme_reading"});
        public ScriptEntity WakingUp => new ScriptEntity(_app, new string[]{"script.waking_up"});
        public ScriptEntity HouseLightThemeRomantic => new ScriptEntity(_app, new string[]{"script.house_light_theme_romantic"});
        public ScriptEntity ProjectorDisable => new ScriptEntity(_app, new string[]{"script.projector_disable"});
        public ScriptEntity ProfileEnable => new ScriptEntity(_app, new string[]{"script.profile_enable"});
        public ScriptEntity ClearPendingRequest => new ScriptEntity(_app, new string[]{"script.clear_pending_request"});
        public ScriptEntity BulkLaunchLightStringColor => new ScriptEntity(_app, new string[]{"script.bulk_launch_light_string_color"});
        public ScriptEntity Speak => new ScriptEntity(_app, new string[]{"script.speak"});
        public ScriptEntity ProjectorEnable => new ScriptEntity(_app, new string[]{"script.projector_enable"});
        public ScriptEntity Ac2Cold => new ScriptEntity(_app, new string[]{"script.ac2_cold"});
        public ScriptEntity BulkLaunchArcadeCabinet => new ScriptEntity(_app, new string[]{"script.bulk_launch_arcade_cabinet"});
        public ScriptEntity TvGamingConsoleDisableTvProcess => new ScriptEntity(_app, new string[]{"script.tv_gaming_console_disable_tv_process"});
        public ScriptEntity MopidyVolumeUpSinglestep => new ScriptEntity(_app, new string[]{"script.mopidy_volume_up_singlestep"});
        public ScriptEntity KodiPriNext => new ScriptEntity(_app, new string[]{"script.kodi_pri_next"});
        public ScriptEntity LgtvVolumeUpSinglestep => new ScriptEntity(_app, new string[]{"script.lgtv_volume_up_singlestep"});
        public ScriptEntity Ac2NormalIr => new ScriptEntity(_app, new string[]{"script.ac2_normal_ir"});
        public ScriptEntity RhasspyAssistantWakeup => new ScriptEntity(_app, new string[]{"script.rhasspy_assistant_wakeup"});
        public ScriptEntity Ac1Fan => new ScriptEntity(_app, new string[]{"script.ac1_fan"});
        public ScriptEntity ClearActiveProfile => new ScriptEntity(_app, new string[]{"script.clear_active_profile"});
        public ScriptEntity BulkLaunchFrontLight => new ScriptEntity(_app, new string[]{"script.bulk_launch_front_light"});
        public ScriptEntity KodiPlaySelectionClear => new ScriptEntity(_app, new string[]{"script.kodi_play_selection_clear"});
        public ScriptEntity UnpauseByActiveProfile => new ScriptEntity(_app, new string[]{"script.unpause_by_active_profile"});
        public ScriptEntity MopidyShuffle => new ScriptEntity(_app, new string[]{"script.mopidy_shuffle"});
        public ScriptEntity KodiUpdateLibrary => new ScriptEntity(_app, new string[]{"script.kodi_update_library"});
        public ScriptEntity Ac2ToggleByMode => new ScriptEntity(_app, new string[]{"script.ac2_toggle_by_mode"});
        public ScriptEntity Ac1ToggleAutoModeTablet => new ScriptEntity(_app, new string[]{"script.ac1_toggle_auto_mode_tablet"});
        public ScriptEntity SaveLastMovieState => new ScriptEntity(_app, new string[]{"script.save_last_movie_state"});
        public ScriptEntity ActivateProfileFromTarget => new ScriptEntity(_app, new string[]{"script.activate_profile_from_target"});
        public ScriptEntity Ac1ToggleByMode => new ScriptEntity(_app, new string[]{"script.ac1_toggle_by_mode"});
        public ScriptEntity ActiveKodiMusicReplay => new ScriptEntity(_app, new string[]{"script.active_kodi_music_replay"});
        public ScriptEntity TvCableProviderDisable => new ScriptEntity(_app, new string[]{"script.tv_cable_provider_disable"});
        public ScriptEntity MediaPcMuteToggle => new ScriptEntity(_app, new string[]{"script.media_pc_mute_toggle"});
        public ScriptEntity ArcadecabinetLoadpoint2 => new ScriptEntity(_app, new string[]{"script.arcadecabinet_loadpoint2"});
        public ScriptEntity AutoLaunchTvCableProvider => new ScriptEntity(_app, new string[]{"script.auto_launch_tv_cable_provider"});
        public ScriptEntity SmartlampSavepoint1 => new ScriptEntity(_app, new string[]{"script.smartlamp_savepoint1"});
        public ScriptEntity AssistantDoactivityLeavehouse => new ScriptEntity(_app, new string[]{"script.assistant_doactivity_leavehouse"});
        public ScriptEntity GoingToSleep => new ScriptEntity(_app, new string[]{"script.going_to_sleep"});
        public ScriptEntity LcdToggle => new ScriptEntity(_app, new string[]{"script.lcd_toggle"});
        public ScriptEntity KodiPriSaveMovieState => new ScriptEntity(_app, new string[]{"script.kodi_pri_save_movie_state"});
        public ScriptEntity MopidyConditionalUnmute => new ScriptEntity(_app, new string[]{"script.mopidy_conditional_unmute"});
        public ScriptEntity Ac2Fan => new ScriptEntity(_app, new string[]{"script.ac2_fan"});
        public ScriptEntity InfinitycubeSleep => new ScriptEntity(_app, new string[]{"script.infinitycube_sleep"});
        public ScriptEntity RhasspyAssistantUnmuteMedias => new ScriptEntity(_app, new string[]{"script.rhasspy_assistant_unmute_medias"});
        public ScriptEntity Ac1FanSetup => new ScriptEntity(_app, new string[]{"script.ac1_fan_setup"});
        public ScriptEntity MopidyVolumeDownSinglestep => new ScriptEntity(_app, new string[]{"script.mopidy_volume_down_singlestep"});
        public ScriptEntity MopidyVolumeUp => new ScriptEntity(_app, new string[]{"script.mopidy_volume_up"});
        public ScriptEntity HouseTurnOff => new ScriptEntity(_app, new string[]{"script.house_turn_off"});
        public ScriptEntity Ac2OffIr => new ScriptEntity(_app, new string[]{"script.ac2_off_ir"});
        public ScriptEntity Ac2Hot => new ScriptEntity(_app, new string[]{"script.ac2_hot"});
        public ScriptEntity HeadbackSunrise => new ScriptEntity(_app, new string[]{"script.headback_sunrise"});
        public ScriptEntity BulkLaunchCandles => new ScriptEntity(_app, new string[]{"script.bulk_launch_candles"});
        public ScriptEntity BedheadbackSavepoint2 => new ScriptEntity(_app, new string[]{"script.bedheadback_savepoint2"});
        public ScriptEntity ReceiverEntertainmentMode => new ScriptEntity(_app, new string[]{"script.receiver_entertainment_mode"});
        public ScriptEntity MopidyRestart => new ScriptEntity(_app, new string[]{"script.mopidy_restart"});
        public ScriptEntity BulkLaunchInfinityCube => new ScriptEntity(_app, new string[]{"script.bulk_launch_infinity_cube"});
        public ScriptEntity Rl4mpRight => new ScriptEntity(_app, new string[]{"script.rl4mp_right"});
        public ScriptEntity KodiPlaypause => new ScriptEntity(_app, new string[]{"script.kodi_playpause"});
        public ScriptEntity ProfileDisabledUnpause => new ScriptEntity(_app, new string[]{"script.profile_disabled_unpause"});
        public ScriptEntity MediaPcKillGames => new ScriptEntity(_app, new string[]{"script.media_pc_kill_games"});
        public ScriptEntity TogglePlaybackByProfile => new ScriptEntity(_app, new string[]{"script.toggle_playback_by_profile"});
        public ScriptEntity SmartlampLoadpoint2 => new ScriptEntity(_app, new string[]{"script.smartlamp_loadpoint2"});
        public ScriptEntity MopidyRemoveUnfavored => new ScriptEntity(_app, new string[]{"script.mopidy_remove_unfavored"});
        public ScriptEntity AssistantDoactivityPctv => new ScriptEntity(_app, new string[]{"script.assistant_doactivity_pctv"});
        public ScriptEntity KodiPriPrevious => new ScriptEntity(_app, new string[]{"script.kodi_pri_previous"});
        public ScriptEntity BedheadbackLoadpoint1 => new ScriptEntity(_app, new string[]{"script.bedheadback_loadpoint1"});
        public ScriptEntity MopidyPlaylistConditionalShuffle => new ScriptEntity(_app, new string[]{"script.mopidy_playlist_conditional_shuffle"});
        public ScriptEntity Ac1ToggleByModeTablet => new ScriptEntity(_app, new string[]{"script.ac1_toggle_by_mode_tablet"});
        public ScriptEntity BulkLaunchLightString => new ScriptEntity(_app, new string[]{"script.bulk_launch_light_string"});
        public ScriptEntity MopidyShufflePlay => new ScriptEntity(_app, new string[]{"script.mopidy_shuffle_play"});
        public ScriptEntity MopidyMarkUnfavored => new ScriptEntity(_app, new string[]{"script.mopidy_mark_unfavored"});
        public ScriptEntity MopidyNext => new ScriptEntity(_app, new string[]{"script.mopidy_next"});
        public ScriptEntity ArcadecabinetRestart => new ScriptEntity(_app, new string[]{"script.arcadecabinet_restart"});
        public ScriptEntity BulkLaunchArcadeCabinetRgb => new ScriptEntity(_app, new string[]{"script.bulk_launch_arcade_cabinet_rgb"});
        public ScriptEntity SmartlampSavepoint2 => new ScriptEntity(_app, new string[]{"script.smartlamp_savepoint2"});
        public ScriptEntity TurnOffPhilipsTvOnLaptopOff => new ScriptEntity(_app, new string[]{"script.turn_off_philips_tv_on_laptop_off"});
        public ScriptEntity HouseLightThemeEvening => new ScriptEntity(_app, new string[]{"script.house_light_theme_evening"});
        public ScriptEntity MopidyVolumeDown => new ScriptEntity(_app, new string[]{"script.mopidy_volume_down"});
        public ScriptEntity NetdaemonRestart => new ScriptEntity(_app, new string[]{"script.netdaemon_restart"});
        public ScriptEntity SleepKeepMediaPcOn => new ScriptEntity(_app, new string[]{"script.sleep_keep_media_pc_on"});
        public ScriptEntity BulkLaunchTvNews => new ScriptEntity(_app, new string[]{"script.bulk_launch_tv_news"});
        public ScriptEntity BulkLaunch => new ScriptEntity(_app, new string[]{"script.bulk_launch"});
        public ScriptEntity TvPcDisable => new ScriptEntity(_app, new string[]{"script.tv_pc_disable"});
        public ScriptEntity ActiveProfileVolumeUp => new ScriptEntity(_app, new string[]{"script.active_profile_volume_up"});
        public ScriptEntity TvEnableLightingProcess => new ScriptEntity(_app, new string[]{"script.tv_enable_lighting_process"});
        public ScriptEntity RhasspyDoneactivitySleep => new ScriptEntity(_app, new string[]{"script.rhasspy_doneactivity_sleep"});
        public ScriptEntity TvGamingConsoleEnable => new ScriptEntity(_app, new string[]{"script.tv_gaming_console_enable"});
        public ScriptEntity NeonsignSavepoint1 => new ScriptEntity(_app, new string[]{"script.neonsign_savepoint1"});
        public ScriptEntity Ac2ToggleAutoModeTablet => new ScriptEntity(_app, new string[]{"script.ac2_toggle_auto_mode_tablet"});
        public ScriptEntity ProfileDisable => new ScriptEntity(_app, new string[]{"script.profile_disable"});
        public ScriptEntity Ac1Cool => new ScriptEntity(_app, new string[]{"script.ac1_cool"});
        public ScriptEntity MediaPcScreenDesk => new ScriptEntity(_app, new string[]{"script.media_pc_screen_desk"});
        public ScriptEntity AssistantDoactivityWarehouse => new ScriptEntity(_app, new string[]{"script.assistant_doactivity_warehouse"});
        public ScriptEntity Rl4mpPresetHigherright => new ScriptEntity(_app, new string[]{"script.rl4mp_preset_higherright"});
        public ScriptEntity SonyProjectorRight => new ScriptEntity(_app, new string[]{"script.sony_projector_right"});
        public ScriptEntity KodiStop => new ScriptEntity(_app, new string[]{"script.kodi_stop"});
        public ScriptEntity MediaPcScreenProjector => new ScriptEntity(_app, new string[]{"script.media_pc_screen_projector"});
        public ScriptEntity ProfileDisabledPause => new ScriptEntity(_app, new string[]{"script.profile_disabled_pause"});
        public ScriptEntity Rl4mpLeft => new ScriptEntity(_app, new string[]{"script.rl4mp_left"});
        public ScriptEntity TvCableProviderEnable => new ScriptEntity(_app, new string[]{"script.tv_cable_provider_enable"});
        public ScriptEntity Ac1Cold => new ScriptEntity(_app, new string[]{"script.ac1_cold"});
        public ScriptEntity BulkLaunchBackLight => new ScriptEntity(_app, new string[]{"script.bulk_launch_back_light"});
        public ScriptEntity ReceiverCheckPrepare => new ScriptEntity(_app, new string[]{"script.receiver_check_prepare"});
        public ScriptEntity HassRestart => new ScriptEntity(_app, new string[]{"script.hass_restart"});
        public ScriptEntity KodiSetRecieverMode => new ScriptEntity(_app, new string[]{"script.kodi_set_reciever_mode"});
        public ScriptEntity LoadLastMovieState => new ScriptEntity(_app, new string[]{"script.load_last_movie_state"});
        public ScriptEntity WakingUpForce => new ScriptEntity(_app, new string[]{"script.waking_up_force"});
        public ScriptEntity Ac2Warm => new ScriptEntity(_app, new string[]{"script.ac2_warm"});
        public ScriptEntity Rl4mpPresetMiddle => new ScriptEntity(_app, new string[]{"script.rl4mp_preset_middle"});
        public ScriptEntity HouseLightThemeNight => new ScriptEntity(_app, new string[]{"script.house_light_theme_night"});
        public ScriptEntity KodiPriLoadMovieState => new ScriptEntity(_app, new string[]{"script.kodi_pri_load_movie_state"});
        public ScriptEntity SystemReboot => new ScriptEntity(_app, new string[]{"script.system_reboot"});
        public ScriptEntity ProfileCabletvPause => new ScriptEntity(_app, new string[]{"script.profile_cabletv_pause"});
        public ScriptEntity ArcadecabinetMute => new ScriptEntity(_app, new string[]{"script.arcadecabinet_mute"});
        public ScriptEntity InfinitycubeLoadpoint1 => new ScriptEntity(_app, new string[]{"script.infinitycube_loadpoint1"});
        public ScriptEntity NeonsignSunrise => new ScriptEntity(_app, new string[]{"script.neonsign_sunrise"});
        public ScriptEntity BulkLaunchBedHeadback => new ScriptEntity(_app, new string[]{"script.bulk_launch_bed_headback"});
        public ScriptEntity NeonsignLoadpoint2 => new ScriptEntity(_app, new string[]{"script.neonsign_loadpoint2"});
        public ScriptEntity DesktopGamingPcEnable => new ScriptEntity(_app, new string[]{"script.desktop_gaming_pc_enable"});
        public ScriptEntity ProjectorPrepareLighting => new ScriptEntity(_app, new string[]{"script.projector_prepare_lighting"});
        public ScriptEntity SystemShutdown => new ScriptEntity(_app, new string[]{"script.system_shutdown"});
        public ScriptEntity MediaPcSleep => new ScriptEntity(_app, new string[]{"script.media_pc_sleep"});
        public ScriptEntity BedroomPowerSaveOff => new ScriptEntity(_app, new string[]{"script.bedroom_power_save_off"});
        public ScriptEntity ArcadecabinetSavepoint1 => new ScriptEntity(_app, new string[]{"script.arcadecabinet_savepoint1"});
        public ScriptEntity AssistantDoactivitySleep => new ScriptEntity(_app, new string[]{"script.assistant_doactivity_sleep"});
        public ScriptEntity RhasspyAssistantMuteMedias => new ScriptEntity(_app, new string[]{"script.rhasspy_assistant_mute_medias"});
        public ScriptEntity BulkLaunchWarehouseLight => new ScriptEntity(_app, new string[]{"script.bulk_launch_warehouse_light"});
        public ScriptEntity TvPcEnableRecieverProcess => new ScriptEntity(_app, new string[]{"script.tv_pc_enable_reciever_process"});
        public ScriptEntity MediaPcScreenTv => new ScriptEntity(_app, new string[]{"script.media_pc_screen_tv"});
        public ScriptEntity SonyProjectorPower => new ScriptEntity(_app, new string[]{"script.sony_projector_power"});
        public ScriptEntity AssistantDoactivityWatchtelevision => new ScriptEntity(_app, new string[]{"script.assistant_doactivity_watchtelevision"});
        public ScriptEntity LgtvVolumeDownSinglestep => new ScriptEntity(_app, new string[]{"script.lgtv_volume_down_singlestep"});
        public ScriptEntity ProfileTvpcUnpause => new ScriptEntity(_app, new string[]{"script.profile_tvpc_unpause"});
        public ScriptEntity Ac1Hot => new ScriptEntity(_app, new string[]{"script.ac1_hot"});
        public ScriptEntity BulkLaunchArcadeCabinetMarquee => new ScriptEntity(_app, new string[]{"script.bulk_launch_arcade_cabinet_marquee"});
        public ScriptEntity PauseByActiveProfile => new ScriptEntity(_app, new string[]{"script.pause_by_active_profile"});
        public ScriptEntity MediaPcClearMouse => new ScriptEntity(_app, new string[]{"script.media_pc_clear_mouse"});
        public ScriptEntity GoingToSleepForce => new ScriptEntity(_app, new string[]{"script.going_to_sleep_force"});
        public ScriptEntity ArcadecabinetSavepoint2 => new ScriptEntity(_app, new string[]{"script.arcadecabinet_savepoint2"});
        public ScriptEntity InfinitycubeLoadpoint2 => new ScriptEntity(_app, new string[]{"script.infinitycube_loadpoint2"});
        public ScriptEntity TvDisableLightingProcess => new ScriptEntity(_app, new string[]{"script.tv_disable_lighting_process"});
        public ScriptEntity WakingUpAcProcess => new ScriptEntity(_app, new string[]{"script.waking_up_ac_process"});
        public ScriptEntity ProjectorRestoreLightsStates => new ScriptEntity(_app, new string[]{"script.projector_restore_lights_states"});
        public ScriptEntity TvGamingConsoleDisable => new ScriptEntity(_app, new string[]{"script.tv_gaming_console_disable"});
        public ScriptEntity Rl4mpHide => new ScriptEntity(_app, new string[]{"script.rl4mp_hide"});
        public ScriptEntity MopidyMarkFavored => new ScriptEntity(_app, new string[]{"script.mopidy_mark_favored"});
        public ScriptEntity KodiSetTvMode => new ScriptEntity(_app, new string[]{"script.kodi_set_tv_mode"});
        public ScriptEntity TvPcEnableTvProcess => new ScriptEntity(_app, new string[]{"script.tv_pc_enable_tv_process"});
        public ScriptEntity BulkLaunchAc => new ScriptEntity(_app, new string[]{"script.bulk_launch_ac"});
        public ScriptEntity Ac1Warm => new ScriptEntity(_app, new string[]{"script.ac1_warm"});
        public ScriptEntity SmartlampLoadpoint1 => new ScriptEntity(_app, new string[]{"script.smartlamp_loadpoint1"});
        public ScriptEntity BedheadbackLoadpoint2 => new ScriptEntity(_app, new string[]{"script.bedheadback_loadpoint2"});
        public ScriptEntity BulkLaunchSmartlamp => new ScriptEntity(_app, new string[]{"script.bulk_launch_smartlamp"});
        public ScriptEntity BedHeadbackColors => new ScriptEntity(_app, new string[]{"script.bed_headback_colors"});
        public ScriptEntity Ac2ToggleByModeTablet => new ScriptEntity(_app, new string[]{"script.ac2_toggle_by_mode_tablet"});
        public ScriptEntity DesktopGamingPcDisable => new ScriptEntity(_app, new string[]{"script.desktop_gaming_pc_disable"});
        public ScriptEntity InfinitycubeSavepoint1 => new ScriptEntity(_app, new string[]{"script.infinitycube_savepoint1"});
        public ScriptEntity AssistantDoactivityPlayconsole => new ScriptEntity(_app, new string[]{"script.assistant_doactivity_playconsole"});
        public ScriptEntity NeonsignSavepoint2 => new ScriptEntity(_app, new string[]{"script.neonsign_savepoint2"});
        public ScriptEntity ArcadecabinetLoadpoint1 => new ScriptEntity(_app, new string[]{"script.arcadecabinet_loadpoint1"});
        public ScriptEntity InfinitycubeSavepoint2 => new ScriptEntity(_app, new string[]{"script.infinitycube_savepoint2"});
        public ScriptEntity Rl4mpUp => new ScriptEntity(_app, new string[]{"script.rl4mp_up"});
        public ScriptEntity Testing => new ScriptEntity(_app, new string[]{"script.testing"});
        public ScriptEntity ProfileCabletvUnpause => new ScriptEntity(_app, new string[]{"script.profile_cabletv_unpause"});
        public ScriptEntity ProfileTvpcPause => new ScriptEntity(_app, new string[]{"script.profile_tvpc_pause"});
        public ScriptEntity BulkLaunchNeonSign => new ScriptEntity(_app, new string[]{"script.bulk_launch_neon_sign"});
        public ScriptEntity BedroomPowerSaveOn => new ScriptEntity(_app, new string[]{"script.bedroom_power_save_on"});
        public ScriptEntity MediaPcCloseActiveWindow => new ScriptEntity(_app, new string[]{"script.media_pc_close_active_window"});
        public ScriptEntity AssistantDoactivityUseCinemaInBackground => new ScriptEntity(_app, new string[]{"script.assistant_doactivity_use_cinema_in_background"});
        public ScriptEntity NeonsignLoadpoint1 => new ScriptEntity(_app, new string[]{"script.neonsign_loadpoint1"});
        public ScriptEntity Rl4mpDown => new ScriptEntity(_app, new string[]{"script.rl4mp_down"});
        public ScriptEntity AssistantDoactivityUseCinema => new ScriptEntity(_app, new string[]{"script.assistant_doactivity_use_cinema"});
        public ScriptEntity BedheadbackSavepoint1 => new ScriptEntity(_app, new string[]{"script.bedheadback_savepoint1"});
        public ScriptEntity MopidyPrevious => new ScriptEntity(_app, new string[]{"script.mopidy_previous"});
        public ScriptEntity KodiPriPauseOrStop => new ScriptEntity(_app, new string[]{"script.kodi_pri_pause_or_stop"});
        public ScriptEntity SonyProjectorEnter => new ScriptEntity(_app, new string[]{"script.sony_projector_enter"});
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonRxApp _app;
        public SwitchEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SwitchEntity CamerasPower => new SwitchEntity(_app, new string[]{"switch.cameras_power"});
        public SwitchEntity MediaPcPower => new SwitchEntity(_app, new string[]{"switch.media_pc_power"});
        public SwitchEntity WarehouseRadiator => new SwitchEntity(_app, new string[]{"switch.warehouse_radiator"});
        public SwitchEntity ExtraCable => new SwitchEntity(_app, new string[]{"switch.extra_cable"});
        public SwitchEntity WarehouseAlarmState => new SwitchEntity(_app, new string[]{"switch.warehouse_alarm_state"});
        public SwitchEntity SmartlampNightMode => new SwitchEntity(_app, new string[]{"switch.smartlamp_night_mode"});
        public SwitchEntity ColorLightStringPower => new SwitchEntity(_app, new string[]{"switch.color_light_string_power"});
        public SwitchEntity WarehouseFan => new SwitchEntity(_app, new string[]{"switch.warehouse_fan"});
        public SwitchEntity Chargers => new SwitchEntity(_app, new string[]{"switch.chargers"});
        public SwitchEntity LightStringPower => new SwitchEntity(_app, new string[]{"switch.light_string_power"});
        public SwitchEntity ArcadeCabinetMarquee => new SwitchEntity(_app, new string[]{"switch.arcade_cabinet_marquee"});
        public SwitchEntity NetdaemonWifi2IrAppTvPhilips => new SwitchEntity(_app, new string[]{"switch.netdaemon_wifi2_ir_app_tv_philips"});
        public SwitchEntity E3dPrinterPower => new SwitchEntity(_app, new string[]{"switch.3d_printer_power"});
        public SwitchEntity Generic => new SwitchEntity(_app, new string[]{"switch.generic"});
        public SwitchEntity NetdaemonWifi2IrAppTvLg => new SwitchEntity(_app, new string[]{"switch.netdaemon_wifi2_ir_app_tv_lg"});
        public SwitchEntity NetdaemonWifi2IrAppClimate => new SwitchEntity(_app, new string[]{"switch.netdaemon_wifi2_ir_app_climate"});
        public SwitchEntity BedHeadbackPower => new SwitchEntity(_app, new string[]{"switch.bed_headback_power"});
        public SwitchEntity SmartlampAutoSleep => new SwitchEntity(_app, new string[]{"switch.smartlamp_auto_sleep"});
        public SwitchEntity NetdaemonWifi2IrAppReceiver => new SwitchEntity(_app, new string[]{"switch.netdaemon_wifi2_ir_app_receiver"});
        public SwitchEntity WarehouseLight => new SwitchEntity(_app, new string[]{"switch.warehouse_light"});
        public SwitchEntity CrystalStones => new SwitchEntity(_app, new string[]{"switch.crystal_stones"});
        public SwitchEntity WarehouseFloodLight => new SwitchEntity(_app, new string[]{"switch.warehouse_flood_light"});
        public SwitchEntity ArcadeCabinetPower => new SwitchEntity(_app, new string[]{"switch.arcade_cabinet_power"});
        public SwitchEntity BoilerPower => new SwitchEntity(_app, new string[]{"switch.boiler_power"});
        public SwitchEntity LivingRoomBack => new SwitchEntity(_app, new string[]{"switch.living_room_back"});
        public SwitchEntity NetdaemonWifi2IrAppPartnerTv => new SwitchEntity(_app, new string[]{"switch.netdaemon_wifi2_ir_app_partner_tv"});
        public SwitchEntity LivingRoomFront => new SwitchEntity(_app, new string[]{"switch.living_room_front"});
        public SwitchEntity CandlesPower => new SwitchEntity(_app, new string[]{"switch.candles_power"});
    }

    public partial class InputBooleanEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputBooleanEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputBooleanEntity PlaylistShuffle => new InputBooleanEntity(_app, new string[]{"input_boolean.playlist_shuffle"});
        public InputBooleanEntity ShowWakeupLaunchConfiguration => new InputBooleanEntity(_app, new string[]{"input_boolean.show_wakeup_launch_configuration"});
        public InputBooleanEntity BulkControlSmartlamp => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_smartlamp"});
        public InputBooleanEntity BulkControlArcadeCabinet => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_arcade_cabinet"});
        public InputBooleanEntity ShowBoilerElements => new InputBooleanEntity(_app, new string[]{"input_boolean.show_boiler_elements"});
        public InputBooleanEntity LeaveHouseMediaPcState => new InputBooleanEntity(_app, new string[]{"input_boolean.leave_house_media_pc_state"});
        public InputBooleanEntity ArcadecabinetAttractSelectionUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.arcadecabinet_attract_selection_update_in_progress"});
        public InputBooleanEntity InfinitycubePaletteDelayUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.infinitycube_palette_delay_update_in_progress"});
        public InputBooleanEntity BulkControlAc => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_ac"});
        public InputBooleanEntity BoilerTimerUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.boiler_timer_update_in_progress"});
        public InputBooleanEntity LightstringEndPointUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.lightstring_end_point_update_in_progress"});
        public InputBooleanEntity PowerSavingsNeonAutomationPowerSet => new InputBooleanEntity(_app, new string[]{"input_boolean.power_savings_neon_automation_power_set"});
        public InputBooleanEntity LightstringBrightnessUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.lightstring_brightness_update_in_progress"});
        public InputBooleanEntity LightstringScenarioDelayUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.lightstring_scenario_delay_update_in_progress"});
        public InputBooleanEntity ProfileLgtvVolumeSync => new InputBooleanEntity(_app, new string[]{"input_boolean.profile_lgtv_volume_sync"});
        public InputBooleanEntity PowerSavingsArcademarqueeAutomationPowerSet => new InputBooleanEntity(_app, new string[]{"input_boolean.power_savings_arcademarquee_automation_power_set"});
        public InputBooleanEntity NeonsignScenarioDelayUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.neonsign_scenario_delay_update_in_progress"});
        public InputBooleanEntity LightstringScenarioSelectionUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.lightstring_scenario_selection_update_in_progress"});
        public InputBooleanEntity BulkControlInfinityCube => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_infinity_cube"});
        public InputBooleanEntity BulkControlTvNews => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_tv_news"});
        public InputBooleanEntity BulkControlArcadeCabinetRgb => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_arcade_cabinet_rgb"});
        public InputBooleanEntity Ac2 => new InputBooleanEntity(_app, new string[]{"input_boolean.ac2"});
        public InputBooleanEntity PowerSavingsArcadergbAutomationPowerSet => new InputBooleanEntity(_app, new string[]{"input_boolean.power_savings_arcadergb_automation_power_set"});
        public InputBooleanEntity PowerSavingsHeadbackAutomationPowerSet => new InputBooleanEntity(_app, new string[]{"input_boolean.power_savings_headback_automation_power_set"});
        public InputBooleanEntity KodiPrimaryPower => new InputBooleanEntity(_app, new string[]{"input_boolean.kodi_primary_power"});
        public InputBooleanEntity BulkControlArcadeCabinetMarquee => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_arcade_cabinet_marquee"});
        public InputBooleanEntity BedroomPowerSave => new InputBooleanEntity(_app, new string[]{"input_boolean.bedroom_power_save"});
        public InputBooleanEntity ShowToWorkGraph => new InputBooleanEntity(_app, new string[]{"input_boolean.show_to_work_graph"});
        public InputBooleanEntity SleepMediaPcState => new InputBooleanEntity(_app, new string[]{"input_boolean.sleep_media_pc_state"});
        public InputBooleanEntity SmartlampPowerLevelUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.smartlamp_power_level_update_in_progress"});
        public InputBooleanEntity SmartlampScenarioDelayUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.smartlamp_scenario_delay_update_in_progress"});
        public InputBooleanEntity PartnertvPower => new InputBooleanEntity(_app, new string[]{"input_boolean.partnertv_power"});
        public InputBooleanEntity Ac1 => new InputBooleanEntity(_app, new string[]{"input_boolean.ac1"});
        public InputBooleanEntity ArcadecabinetVolumeUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.arcadecabinet_volume_update_in_progress"});
        public InputBooleanEntity Ac1AutoMode => new InputBooleanEntity(_app, new string[]{"input_boolean.ac1_auto_mode"});
        public InputBooleanEntity BedhbScenarioSelectionUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.bedhb_scenario_selection_update_in_progress"});
        public InputBooleanEntity AssistantPower => new InputBooleanEntity(_app, new string[]{"input_boolean.assistant_power"});
        public InputBooleanEntity WakeupAc => new InputBooleanEntity(_app, new string[]{"input_boolean.wakeup_ac"});
        public InputBooleanEntity PhilipsPower => new InputBooleanEntity(_app, new string[]{"input_boolean.philips_power"});
        public InputBooleanEntity BedhbScenarioDelayUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.bedhb_scenario_delay_update_in_progress"});
        public InputBooleanEntity ArcadecabinetScenarioDelayUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.arcadecabinet_scenario_delay_update_in_progress"});
        public InputBooleanEntity InfinitycubePaletteSelectionUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.infinitycube_palette_selection_update_in_progress"});
        public InputBooleanEntity BulkControlCandles => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_candles"});
        public InputBooleanEntity Ac2ToggleByMode => new InputBooleanEntity(_app, new string[]{"input_boolean.ac2_toggle_by_mode"});
        public InputBooleanEntity PowerSavingsLightstringAutomationPowerSet => new InputBooleanEntity(_app, new string[]{"input_boolean.power_savings_lightstring_automation_power_set"});
        public InputBooleanEntity NeonsignPowerLevelUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.neonsign_power_level_update_in_progress"});
        public InputBooleanEntity Assistant => new InputBooleanEntity(_app, new string[]{"input_boolean.assistant"});
        public InputBooleanEntity ShowHomeLaunchConfiguration => new InputBooleanEntity(_app, new string[]{"input_boolean.show_home_launch_configuration"});
        public InputBooleanEntity ProfileMediaPcVolumeSync => new InputBooleanEntity(_app, new string[]{"input_boolean.profile_media_pc_volume_sync"});
        public InputBooleanEntity PowerSavingsColorLightstringAutomationPowerSet => new InputBooleanEntity(_app, new string[]{"input_boolean.power_savings_color_lightstring_automation_power_set"});
        public InputBooleanEntity AssistantVoice => new InputBooleanEntity(_app, new string[]{"input_boolean.assistant_voice"});
        public InputBooleanEntity LightstringcolorStartPointUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.lightstringcolor_start_point_update_in_progress"});
        public InputBooleanEntity TemperatureExpand => new InputBooleanEntity(_app, new string[]{"input_boolean.temperature_expand"});
        public InputBooleanEntity BulkControlGamesCornerNeon => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_games_corner_neon"});
        public InputBooleanEntity Ac2AutoMode => new InputBooleanEntity(_app, new string[]{"input_boolean.ac2_auto_mode"});
        public InputBooleanEntity ReceiverPower => new InputBooleanEntity(_app, new string[]{"input_boolean.receiver_power"});
        public InputBooleanEntity LightstringcolorEndPointUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.lightstringcolor_end_point_update_in_progress"});
        public InputBooleanEntity LightstringcolorScenarioDelayUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.lightstringcolor_scenario_delay_update_in_progress"});
        public InputBooleanEntity BulkControlLightStringColor => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_light_string_color"});
        public InputBooleanEntity LightstringcolorBrightnessUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.lightstringcolor_brightness_update_in_progress"});
        public InputBooleanEntity PrivacyMode => new InputBooleanEntity(_app, new string[]{"input_boolean.privacy_mode"});
        public InputBooleanEntity LightstringStartPointUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.lightstring_start_point_update_in_progress"});
        public InputBooleanEntity InfinitycubeBlendingSelectionUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.infinitycube_blending_selection_update_in_progress"});
        public InputBooleanEntity KodiSecondaryShuffle => new InputBooleanEntity(_app, new string[]{"input_boolean.kodi_secondary_shuffle"});
        public InputBooleanEntity LoadLastMovieState => new InputBooleanEntity(_app, new string[]{"input_boolean.load_last_movie_state"});
        public InputBooleanEntity NeonModeUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.neon_mode_update_in_progress"});
        public InputBooleanEntity LightstringcolorScenarioSelectionUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.lightstringcolor_scenario_selection_update_in_progress"});
        public InputBooleanEntity ProfileKodiGaming => new InputBooleanEntity(_app, new string[]{"input_boolean.profile_kodi_gaming"});
        public InputBooleanEntity PhilipsAmbilight => new InputBooleanEntity(_app, new string[]{"input_boolean.philips_ambilight"});
        public InputBooleanEntity AssistantVoiceCommands => new InputBooleanEntity(_app, new string[]{"input_boolean.assistant_voice_commands"});
        public InputBooleanEntity SmartlampSleepState => new InputBooleanEntity(_app, new string[]{"input_boolean.smartlamp_sleep_state"});
        public InputBooleanEntity WakeupBoilerState => new InputBooleanEntity(_app, new string[]{"input_boolean.wakeup_boiler_state"});
        public InputBooleanEntity MopidyPower => new InputBooleanEntity(_app, new string[]{"input_boolean.mopidy_power"});
        public InputBooleanEntity ShowHomeLeaveConfiguration => new InputBooleanEntity(_app, new string[]{"input_boolean.show_home_leave_configuration"});
        public InputBooleanEntity ProfilePrimaryKodiVolumeSync => new InputBooleanEntity(_app, new string[]{"input_boolean.profile_primary_kodi_volume_sync"});
        public InputBooleanEntity BedhbPowerLevelUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.bedhb_power_level_update_in_progress"});
        public InputBooleanEntity ProjectorPower => new InputBooleanEntity(_app, new string[]{"input_boolean.projector_power"});
        public InputBooleanEntity ShowToHomeGraph => new InputBooleanEntity(_app, new string[]{"input_boolean.show_to_home_graph"});
        public InputBooleanEntity ProfileActivated => new InputBooleanEntity(_app, new string[]{"input_boolean.profile_activated"});
        public InputBooleanEntity BulkControlBackLight => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_back_light"});
        public InputBooleanEntity ArcadecabinetScenarioSelectionUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.arcadecabinet_scenario_selection_update_in_progress"});
        public InputBooleanEntity KodiSecondaryPlayPauseStop => new InputBooleanEntity(_app, new string[]{"input_boolean.kodi_secondary_play_pause_stop"});
        public InputBooleanEntity BulkControlBedHeadback => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_bed_headback"});
        public InputBooleanEntity SmartlampScenarioSelectionUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.smartlamp_scenario_selection_update_in_progress"});
        public InputBooleanEntity ModeKodi => new InputBooleanEntity(_app, new string[]{"input_boolean.mode_kodi"});
        public InputBooleanEntity KodiPrimaryShuffle => new InputBooleanEntity(_app, new string[]{"input_boolean.kodi_primary_shuffle"});
        public InputBooleanEntity NeonsignScenarioSelectionUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.neonsign_scenario_selection_update_in_progress"});
        public InputBooleanEntity InfinitycubePowerLevelUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.infinitycube_power_level_update_in_progress"});
        public InputBooleanEntity BulkControlWarehouseLight => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_warehouse_light"});
        public InputBooleanEntity ProjectorModeAsBackground => new InputBooleanEntity(_app, new string[]{"input_boolean.projector_mode_as_background"});
        public InputBooleanEntity ProfileReceiverVolLevelSync => new InputBooleanEntity(_app, new string[]{"input_boolean.profile_receiver_vol_level_sync"});
        public InputBooleanEntity ArcadecabinetAmbientsoundSelectionUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.arcadecabinet_ambientsound_selection_update_in_progress"});
        public InputBooleanEntity ProfileMediaPcTvVideoProfileSync => new InputBooleanEntity(_app, new string[]{"input_boolean.profile_media_pc_tv_video_profile_sync"});
        public InputBooleanEntity ShowSleepLaunchConfiguration => new InputBooleanEntity(_app, new string[]{"input_boolean.show_sleep_launch_configuration"});
        public InputBooleanEntity LgtvPower => new InputBooleanEntity(_app, new string[]{"input_boolean.lgtv_power"});
        public InputBooleanEntity ArcadecabinetPowerLevelUpdateInProgress => new InputBooleanEntity(_app, new string[]{"input_boolean.arcadecabinet_power_level_update_in_progress"});
        public InputBooleanEntity ShowToDojoGraph => new InputBooleanEntity(_app, new string[]{"input_boolean.show_to_dojo_graph"});
        public InputBooleanEntity BulkControlNeonSign => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_neon_sign"});
        public InputBooleanEntity BulkControlLightString => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_light_string"});
        public InputBooleanEntity BulkControlFrontLight => new InputBooleanEntity(_app, new string[]{"input_boolean.bulk_control_front_light"});
        public InputBooleanEntity SaveLastMovieState => new InputBooleanEntity(_app, new string[]{"input_boolean.save_last_movie_state"});
        public InputBooleanEntity PowerSavingsCandlesAutomationPowerSet => new InputBooleanEntity(_app, new string[]{"input_boolean.power_savings_candles_automation_power_set"});
    }

    public partial class SensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public SensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SensorEntity InternetTime => new SensorEntity(_app, new string[]{"sensor.internet_time"});
        public SensorEntity TpLinkRouterBSent => new SensorEntity(_app, new string[]{"sensor.tp_link_router_b_sent"});
        public SensorEntity WarehouseIndex => new SensorEntity(_app, new string[]{"sensor.warehouse_index"});
        public SensorEntity WarehouseHumidity => new SensorEntity(_app, new string[]{"sensor.warehouse_humidity"});
        public SensorEntity BedRoomTemperature => new SensorEntity(_app, new string[]{"sensor.bed_room_temperature"});
        public SensorEntity Socket3NetworkStatus => new SensorEntity(_app, new string[]{"sensor.socket_3_network_status"});
        public SensorEntity BoilerCircuitTemperature => new SensorEntity(_app, new string[]{"sensor.boiler_circuit_temperature"});
        public SensorEntity Eccef44127e0e6b2 => new SensorEntity(_app, new string[]{"sensor.eccef441_27e0e6b2"});
        public SensorEntity Socket2NetworkStatus => new SensorEntity(_app, new string[]{"sensor.socket_2_network_status"});
        public SensorEntity ToDojoRealtime => new SensorEntity(_app, new string[]{"sensor.to_dojo_realtime"});
        public SensorEntity NextSunset => new SensorEntity(_app, new string[]{"sensor.next_sunset"});
        public SensorEntity BedRoomHumidity => new SensorEntity(_app, new string[]{"sensor.bed_room_humidity"});
        public SensorEntity TpLinkRouterBReceived => new SensorEntity(_app, new string[]{"sensor.tp_link_router_b_received"});
        public SensorEntity LsxLatitude => new SensorEntity(_app, new string[]{"sensor.lsx_latitude"});
        public SensorEntity Hacs => new SensorEntity(_app, new string[]{"sensor.hacs"});
        public SensorEntity ToWorkRealtime => new SensorEntity(_app, new string[]{"sensor.to_work_realtime"});
        public SensorEntity TpLinkRouterPacketsReceived => new SensorEntity(_app, new string[]{"sensor.tp_link_router_packets_received"});
        public SensorEntity ToDojoAverage => new SensorEntity(_app, new string[]{"sensor.to_dojo_average"});
        public SensorEntity TpLinkRouterPacketsSReceived => new SensorEntity(_app, new string[]{"sensor.tp_link_router_packets_s_received"});
        public SensorEntity BedRoomIndex => new SensorEntity(_app, new string[]{"sensor.bed_room_index"});
        public SensorEntity OutsideIndex => new SensorEntity(_app, new string[]{"sensor.outside_index"});
        public SensorEntity LsxLocation => new SensorEntity(_app, new string[]{"sensor.lsx_location"});
        public SensorEntity TpLinkRouterPacketsSent => new SensorEntity(_app, new string[]{"sensor.tp_link_router_packets_sent"});
        public SensorEntity OutsideTemperature => new SensorEntity(_app, new string[]{"sensor.outside_temperature"});
        public SensorEntity EnclosurePowerUsage => new SensorEntity(_app, new string[]{"sensor.enclosure_power_usage"});
        public SensorEntity LsxLongitude => new SensorEntity(_app, new string[]{"sensor.lsx_longitude"});
        public SensorEntity DateTimeIso => new SensorEntity(_app, new string[]{"sensor.date_time_iso"});
        public SensorEntity EnclosureHumidity => new SensorEntity(_app, new string[]{"sensor.enclosure_humidity"});
        public SensorEntity Socket1PowerUsage => new SensorEntity(_app, new string[]{"sensor.socket_1_power_usage"});
        public SensorEntity LivingRoomTemperature => new SensorEntity(_app, new string[]{"sensor.living_room_temperature"});
        public SensorEntity LivingRoomHumidity => new SensorEntity(_app, new string[]{"sensor.living_room_humidity"});
        public SensorEntity OutsideHumidity => new SensorEntity(_app, new string[]{"sensor.outside_humidity"});
        public SensorEntity ToHomeRealtime => new SensorEntity(_app, new string[]{"sensor.to_home_realtime"});
        public SensorEntity Socket1NetworkStatus => new SensorEntity(_app, new string[]{"sensor.socket_1_network_status"});
        public SensorEntity Time => new SensorEntity(_app, new string[]{"sensor.time"});
        public SensorEntity Socket3PowerUsage => new SensorEntity(_app, new string[]{"sensor.socket_3_power_usage"});
        public SensorEntity WarehouseTemperature => new SensorEntity(_app, new string[]{"sensor.warehouse_temperature"});
        public SensorEntity LivingRoomIndex => new SensorEntity(_app, new string[]{"sensor.living_room_index"});
        public SensorEntity BoilerPowerUsage => new SensorEntity(_app, new string[]{"sensor.boiler_power_usage"});
        public SensorEntity TimeUtc => new SensorEntity(_app, new string[]{"sensor.time_utc"});
        public SensorEntity Date => new SensorEntity(_app, new string[]{"sensor.date"});
        public SensorEntity TimeDate => new SensorEntity(_app, new string[]{"sensor.time_date"});
        public SensorEntity Socket2PowerUsage => new SensorEntity(_app, new string[]{"sensor.socket_2_power_usage"});
        public SensorEntity ToWorkAverage => new SensorEntity(_app, new string[]{"sensor.to_work_average"});
        public SensorEntity TpLinkRouterKibSReceived => new SensorEntity(_app, new string[]{"sensor.tp_link_router_kib_s_received"});
        public SensorEntity E3c93d829A6a8fd92 => new SensorEntity(_app, new string[]{"sensor.3c93d829_a6a8fd92"});
        public SensorEntity DateTime => new SensorEntity(_app, new string[]{"sensor.date_time"});
        public SensorEntity TpLinkRouterPacketsSSent => new SensorEntity(_app, new string[]{"sensor.tp_link_router_packets_s_sent"});
        public SensorEntity SmartlampLightSensor => new SensorEntity(_app, new string[]{"sensor.smartlamp_light_sensor"});
        public SensorEntity EnclosureTemperature => new SensorEntity(_app, new string[]{"sensor.enclosure_temperature"});
        public SensorEntity TpLinkRouterKibSSent => new SensorEntity(_app, new string[]{"sensor.tp_link_router_kib_s_sent"});
        public SensorEntity ToHomeAverage => new SensorEntity(_app, new string[]{"sensor.to_home_average"});
    }

    public partial class InputSelectEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputSelectEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputSelectEntity Ac2AutoMode => new InputSelectEntity(_app, new string[]{"input_select.ac2_auto_mode"});
        public InputSelectEntity InfinitycubeBlendingMode => new InputSelectEntity(_app, new string[]{"input_select.infinitycube_blending_mode"});
        public InputSelectEntity Ac1AutoSourceSensor => new InputSelectEntity(_app, new string[]{"input_select.ac1_auto_source_sensor"});
        public InputSelectEntity ArcadecabinetAttractMode => new InputSelectEntity(_app, new string[]{"input_select.arcadecabinet_attract_mode"});
        public InputSelectEntity BulkControlMusic => new InputSelectEntity(_app, new string[]{"input_select.bulk_control_music"});
        public InputSelectEntity GamescornerneonMode => new InputSelectEntity(_app, new string[]{"input_select.gamescornerneon_mode"});
        public InputSelectEntity Ac1AutoMode => new InputSelectEntity(_app, new string[]{"input_select.ac1_auto_mode"});
        public InputSelectEntity LightstringMode => new InputSelectEntity(_app, new string[]{"input_select.lightstring_mode"});
        public InputSelectEntity ProfileMediaPcTvVideoProfile => new InputSelectEntity(_app, new string[]{"input_select.profile_media_pc_tv_video_profile"});
        public InputSelectEntity MopidyPlayPlaylist => new InputSelectEntity(_app, new string[]{"input_select.mopidy_play_playlist"});
        public InputSelectEntity MediaPcTvVideoProfile => new InputSelectEntity(_app, new string[]{"input_select.media_pc_tv_video_profile"});
        public InputSelectEntity ArcadecabinetAmbientsoundMode => new InputSelectEntity(_app, new string[]{"input_select.arcadecabinet_ambientsound_mode"});
        public InputSelectEntity ArcadecabinetScenarioMode => new InputSelectEntity(_app, new string[]{"input_select.arcadecabinet_scenario_mode"});
        public InputSelectEntity LightstringcolorMode => new InputSelectEntity(_app, new string[]{"input_select.lightstringcolor_mode"});
        public InputSelectEntity KodiPlayMode => new InputSelectEntity(_app, new string[]{"input_select.kodi_play_mode"});
        public InputSelectEntity BedhbScenarioMode => new InputSelectEntity(_app, new string[]{"input_select.bedhb_scenario_mode"});
        public InputSelectEntity ProfileReceiverVolLevel => new InputSelectEntity(_app, new string[]{"input_select.profile_receiver_vol_level"});
        public InputSelectEntity KodiPlayFolder => new InputSelectEntity(_app, new string[]{"input_select.kodi_play_folder"});
        public InputSelectEntity Ac2AutoSourceSensor => new InputSelectEntity(_app, new string[]{"input_select.ac2_auto_source_sensor"});
        public InputSelectEntity PhilipsSource => new InputSelectEntity(_app, new string[]{"input_select.philips_source"});
        public InputSelectEntity ReceiverVolLevel => new InputSelectEntity(_app, new string[]{"input_select.receiver_vol_level"});
        public InputSelectEntity SmartlampScenarioMode => new InputSelectEntity(_app, new string[]{"input_select.smartlamp_scenario_mode"});
        public InputSelectEntity InfinitycubePaletteMode => new InputSelectEntity(_app, new string[]{"input_select.infinitycube_palette_mode"});
        public InputSelectEntity XiaomiAirpurifierMode => new InputSelectEntity(_app, new string[]{"input_select.xiaomi_airpurifier_mode"});
        public InputSelectEntity ReceiverInputSound => new InputSelectEntity(_app, new string[]{"input_select.receiver_input_sound"});
        public InputSelectEntity LgtvSource => new InputSelectEntity(_app, new string[]{"input_select.lgtv_source"});
        public InputSelectEntity LcdBacklightMode => new InputSelectEntity(_app, new string[]{"input_select.lcd_backlight_mode"});
        public InputSelectEntity KodiPlayFile => new InputSelectEntity(_app, new string[]{"input_select.kodi_play_file"});
        public InputSelectEntity MediaPcTvVideoOutput => new InputSelectEntity(_app, new string[]{"input_select.media_pc_tv_video_output"});
        public InputSelectEntity WakeupControlStreamChannel => new InputSelectEntity(_app, new string[]{"input_select.wakeup_control_stream_channel"});
        public InputSelectEntity HouseLightTheme => new InputSelectEntity(_app, new string[]{"input_select.house_light_theme"});
        public InputSelectEntity NeonsignScenarioMode => new InputSelectEntity(_app, new string[]{"input_select.neonsign_scenario_mode"});
        public InputSelectEntity HassTheme => new InputSelectEntity(_app, new string[]{"input_select.hass_theme"});
        public InputSelectEntity MediaPcAudioOutput => new InputSelectEntity(_app, new string[]{"input_select.media_pc_audio_output"});
        public InputSelectEntity MediaProfileSelector => new InputSelectEntity(_app, new string[]{"input_select.media_profile_selector"});
    }

    public partial class VarEntities
    {
        private readonly NetDaemonRxApp _app;
        public VarEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public VarEntity ProfileActive => new VarEntity(_app, new string[]{"var.profile_active"});
        public VarEntity DesktopGamingPcAmbilightLast => new VarEntity(_app, new string[]{"var.desktop_gaming_pc_ambilight_last"});
        public VarEntity ProjectorModeLightstringLast => new VarEntity(_app, new string[]{"var.projector_mode_lightstring_last"});
        public VarEntity Test => new VarEntity(_app, new string[]{"var.test"});
        public VarEntity PowerSavingsColorLightstringState => new VarEntity(_app, new string[]{"var.power_savings_color_lightstring_state"});
        public VarEntity PowerSavingsNeonState => new VarEntity(_app, new string[]{"var.power_savings_neon_state"});
        public VarEntity PowerSavingsCandlesState => new VarEntity(_app, new string[]{"var.power_savings_candles_state"});
        public VarEntity AwakeState => new VarEntity(_app, new string[]{"var.awake_state"});
        public VarEntity Ac1TempMeasureStart => new VarEntity(_app, new string[]{"var.ac1_temp_measure_start"});
        public VarEntity WakeupLaunched => new VarEntity(_app, new string[]{"var.wakeup_launched"});
        public VarEntity Ac2FanMeasureStartTime => new VarEntity(_app, new string[]{"var.ac2_fan_measure_start_time"});
        public VarEntity ProjectorModeCandlesLast => new VarEntity(_app, new string[]{"var.projector_mode_candles_last"});
        public VarEntity PendingVoiceCommandTopic => new VarEntity(_app, new string[]{"var.pending_voice_command_topic"});
        public VarEntity ReceiverVolLevelLast => new VarEntity(_app, new string[]{"var.receiver_vol_level_last"});
        public VarEntity LsxDistanceToWork => new VarEntity(_app, new string[]{"var.lsx_distance_to_work"});
        public VarEntity LsxDistanceToHome => new VarEntity(_app, new string[]{"var.lsx_distance_to_home"});
        public VarEntity BedroomLastMovementTime => new VarEntity(_app, new string[]{"var.bedroom_last_movement_time"});
        public VarEntity PendingVoiceCommandPayload => new VarEntity(_app, new string[]{"var.pending_voice_command_payload"});
        public VarEntity PowerSavingsHeadbackState => new VarEntity(_app, new string[]{"var.power_savings_headback_state"});
        public VarEntity PhilipsTvState => new VarEntity(_app, new string[]{"var.philips_tv_state"});
        public VarEntity Ac1FanMeasureStartTime => new VarEntity(_app, new string[]{"var.ac1_fan_measure_start_time"});
        public VarEntity ShowerSensorLastUpdateTime => new VarEntity(_app, new string[]{"var.shower_sensor_last_update_time"});
        public VarEntity LsxDistanceToDojo => new VarEntity(_app, new string[]{"var.lsx_distance_to_dojo"});
        public VarEntity ProjectorModePhilipsTvLast => new VarEntity(_app, new string[]{"var.projector_mode_philips_tv_last"});
        public VarEntity ProjectorModeArcadeMarqueeLast => new VarEntity(_app, new string[]{"var.projector_mode_arcade_marquee_last"});
        public VarEntity PowerSavingsLightstringState => new VarEntity(_app, new string[]{"var.power_savings_lightstring_state"});
        public VarEntity ShowerMotionSensor => new VarEntity(_app, new string[]{"var.shower_motion_sensor"});
        public VarEntity Ac1Current => new VarEntity(_app, new string[]{"var.ac1_current"});
        public VarEntity PowerSavingsArcadergbState => new VarEntity(_app, new string[]{"var.power_savings_arcadergb_state"});
        public VarEntity Ac2Current => new VarEntity(_app, new string[]{"var.ac2_current"});
        public VarEntity ToWorkCongested => new VarEntity(_app, new string[]{"var.to_work_congested"});
        public VarEntity PowerSavingsArcademarqueeState => new VarEntity(_app, new string[]{"var.power_savings_arcademarquee_state"});
        public VarEntity InfluxFolderSize => new VarEntity(_app, new string[]{"var.influx_folder_size"});
        public VarEntity ProfilePlaybackState => new VarEntity(_app, new string[]{"var.profile_playback_state"});
        public VarEntity LsxLocation => new VarEntity(_app, new string[]{"var.lsx_location"});
        public VarEntity ToDojoCongested => new VarEntity(_app, new string[]{"var.to_dojo_congested"});
        public VarEntity ProjectorModeSmartlampLast => new VarEntity(_app, new string[]{"var.projector_mode_smartlamp_last"});
        public VarEntity ProjectorModeHeadbackLast => new VarEntity(_app, new string[]{"var.projector_mode_headback_last"});
        public VarEntity ToHomeCongested => new VarEntity(_app, new string[]{"var.to_home_congested"});
        public VarEntity Ac2TempMeasureStart => new VarEntity(_app, new string[]{"var.ac2_temp_measure_start"});
        public VarEntity ProjectorModeArcadeRgbLast => new VarEntity(_app, new string[]{"var.projector_mode_arcade_rgb_last"});
        public VarEntity TabletModeMainMessage => new VarEntity(_app, new string[]{"var.tablet_mode_main_message"});
        public VarEntity OnPowerSavingState => new VarEntity(_app, new string[]{"var.on_power_saving_state"});
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonRxApp _app;
        public MediaPlayerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public MediaPlayerEntity LivingRoomTv => new MediaPlayerEntity(_app, new string[]{"media_player.living_room_tv"});
        public MediaPlayerEntity Eccef44127e0e6b2 => new MediaPlayerEntity(_app, new string[]{"media_player.eccef441_27e0e6b2"});
        public MediaPlayerEntity E3c93d829A6a8fd92 => new MediaPlayerEntity(_app, new string[]{"media_player.3c93d829_a6a8fd92"});
        public MediaPlayerEntity KodiPrimary => new MediaPlayerEntity(_app, new string[]{"media_player.kodi_primary"});
        public MediaPlayerEntity Mopidy => new MediaPlayerEntity(_app, new string[]{"media_player.mopidy"});
        public MediaPlayerEntity LivingRoomTv2 => new MediaPlayerEntity(_app, new string[]{"media_player.living_room_tv_2"});
    }

    public partial class BinarySensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public BinarySensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public BinarySensorEntity PhilipsTvLaptopPowerState => new BinarySensorEntity(_app, new string[]{"binary_sensor.philips_tv_laptop_power_state"});
        public BinarySensorEntity Updater => new BinarySensorEntity(_app, new string[]{"binary_sensor.updater"});
        public BinarySensorEntity HomePresence => new BinarySensorEntity(_app, new string[]{"binary_sensor.home_presence"});
        public BinarySensorEntity LivingRoomMotionSensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.living_room_motion_sensor"});
        public BinarySensorEntity LgTvPowerState => new BinarySensorEntity(_app, new string[]{"binary_sensor.lg_tv_power_state"});
        public BinarySensorEntity TtsSpeaking => new BinarySensorEntity(_app, new string[]{"binary_sensor.tts_speaking"});
        public BinarySensorEntity WarehouseAlarmTrigger => new BinarySensorEntity(_app, new string[]{"binary_sensor.warehouse_alarm_trigger"});
        public BinarySensorEntity SmartlampAwakeModeState => new BinarySensorEntity(_app, new string[]{"binary_sensor.smartlamp_awake_mode_state"});
        public BinarySensorEntity SmartphoneConnected => new BinarySensorEntity(_app, new string[]{"binary_sensor.smartphone_connected"});
        public BinarySensorEntity HousePower => new BinarySensorEntity(_app, new string[]{"binary_sensor.house_power"});
        public BinarySensorEntity BedRoomMotionSensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.bed_room_motion_sensor"});
    }

    public partial class CameraEntities
    {
        private readonly NetDaemonRxApp _app;
        public CameraEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CameraEntity EyetoyWarehouse => new CameraEntity(_app, new string[]{"camera.eyetoy_warehouse"});
        public CameraEntity E3dPrinterCamera => new CameraEntity(_app, new string[]{"camera.3d_printer_camera"});
    }

    public partial class NetdaemonEntities
    {
        private readonly NetDaemonRxApp _app;
        public NetdaemonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public NetdaemonEntity Status => new NetdaemonEntity(_app, new string[]{"netdaemon.status"});
    }

    public partial class LightEntities
    {
        private readonly NetDaemonRxApp _app;
        public LightEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public LightEntity SmartlampLight => new LightEntity(_app, new string[]{"light.smartlamp_light"});
        public LightEntity BedHeadbackRgb => new LightEntity(_app, new string[]{"light.bed_headback_rgb"});
        public LightEntity InfinityCubeLight => new LightEntity(_app, new string[]{"light.infinity_cube_light"});
        public LightEntity NeonSignRgb => new LightEntity(_app, new string[]{"light.neon_sign_rgb"});
        public LightEntity E3dPrinterLight => new LightEntity(_app, new string[]{"light.3d_printer_light"});
        public LightEntity ArcadeCabinetRgb => new LightEntity(_app, new string[]{"light.arcade_cabinet_rgb"});
        public LightEntity Eccef44127e0e6b2 => new LightEntity(_app, new string[]{"light.eccef441_27e0e6b2"});
        public LightEntity E3c93d829A6a8fd92 => new LightEntity(_app, new string[]{"light.3c93d829_a6a8fd92"});
    }

    public partial class WeatherEntities
    {
        private readonly NetDaemonRxApp _app;
        public WeatherEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public WeatherEntity Home => new WeatherEntity(_app, new string[]{"weather.home"});
    }

    public partial class ZoneEntities
    {
        private readonly NetDaemonRxApp _app;
        public ZoneEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ZoneEntity Home => new ZoneEntity(_app, new string[]{"zone.home"});
    }

    public partial class InputTextEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputTextEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputTextEntity CurrentLocationUrl => new InputTextEntity(_app, new string[]{"input_text.current_location_url"});
    }

    public partial class SunEntities
    {
        private readonly NetDaemonRxApp _app;
        public SunEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SunEntity Sun => new SunEntity(_app, new string[]{"sun.sun"});
    }
}