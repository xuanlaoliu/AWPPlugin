using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using PlayerRoles;
using System;
using UnityEngine;

namespace AWPPlugin
{
    public class EventHandlers
    {
        public void OnPickingUpItem(PickingUpItemEventArgs ev)
        {
            if (ev.Player == null || ev.Pickup == null)
                return;

            if (!CustomItem.TryGet(ev.Pickup, out CustomItem customItem))
                return;

            if (!(customItem is AWP))
                return;

            if (ev.Player.Role.Type == RoleTypeId.Scp3114)
            {
                ev.IsAllowed = false;
                return;
            }

            ev.Player.Broadcast(5, "你捡起了AWP:一把高伤低子弹的狙击枪");
        }

        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            try
            {
                SpawnableFaction faction = ev.Wave.SpawnableFaction;

                bool isChaos = faction == SpawnableFaction.ChaosWave || faction == SpawnableFaction.ChaosMiniWave;
                bool isNtf = faction == SpawnableFaction.NtfWave || faction == SpawnableFaction.NtfMiniWave;

                if (!isChaos && !isNtf)
                    return;

                if (!CustomItem.TryGet(100u, out CustomItem awp))
                    return;

                Vector3 spawn1 = new Vector3(0.614f, 302.5f, -39.853f);
                Vector3 spawn2 = new Vector3(134.933f, 297.552f, -43.236f);

                for (int i = 0; i < 2; i++)
                {
                    awp.Spawn(spawn1);
                    awp.Spawn(spawn2);
                }

                Log.Info("[AWPPlugin] 已在两个坐标点各生成 2 把 AWP，共 4 把");
            }
            catch (Exception ex)
            {
                Log.Error($"[AWPPlugin] OnRespawningTeam 执行时发生错误: {ex}");
            }
        }
    }
}