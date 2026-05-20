using Exiled.API.Features;
using System;

namespace AWPPlugin
{
    public class AWPPlugin : Plugin<Config>
    {
        private EventHandlers _eventHandlers;

        public static AWPPlugin Instance { get; private set; }

        public override string Name => "AWPPlugin";

        public override string Prefix => "AWPPlugin";

        public override string Author => "MMK";

        public override Version Version => new Version(1, 0, 0);

        public override Version RequiredExiledVersion => new Version(9, 0, 0);

        public override void OnEnabled()
        {
            try
            {
                Instance = this;

                _eventHandlers = new EventHandlers();

                Exiled.Events.Handlers.Player.PickingUpItem += _eventHandlers.OnPickingUpItem;
                Exiled.Events.Handlers.Server.RespawningTeam += _eventHandlers.OnRespawningTeam;

                Log.Info("[AWPPlugin] 插件已启用 - AWP 自定义狙击枪已注册");
            }
            catch (Exception ex)
            {
                Log.Error($"[AWPPlugin] OnEnabled 初始化失败: {ex}");
            }
        }

        public override void OnDisabled()
        {
            try
            {
                if (_eventHandlers != null)
                {
                    Exiled.Events.Handlers.Player.PickingUpItem -= _eventHandlers.OnPickingUpItem;
                    Exiled.Events.Handlers.Server.RespawningTeam -= _eventHandlers.OnRespawningTeam;
                    _eventHandlers = null;
                }

                Instance = null;

                Log.Info("[AWPPlugin] 插件已禁用 - AWP 自定义狙击枪已注销");
            }
            catch (Exception ex)
            {
                Log.Error($"[AWPPlugin] OnDisabled 清理失败: {ex}");
            }
        }
    }
}