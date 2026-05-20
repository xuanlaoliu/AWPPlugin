using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.API.Features.Pickups;
using Exiled.CustomItems.API.Features;
using InventorySystem.Items.Firearms;
using PlayerRoles;
using UnityEngine;

namespace AWPPlugin
{
    public class AWP : CustomWeapon
    {
        public override uint Id { get; set; } = 100;

        public override string Name { get; set; } = "AWP";

        public override string Description { get; set; } = "一把高伤低子弹的狙击枪";

        public override ItemType Type { get; set; } = ItemType.GunE11SR;

        public override float Weight { get; set; } = 3.5f;

        protected override void OnSpawned(Pickup pickup)
        {
            FirearmPickup firearmPickup = pickup.Base as FirearmPickup;
            if (firearmPickup == null)
                return;

            firearmPickup.NetworkStatus = new FirearmStatus(5, FirearmStatusFlags.MagazineInserted, 0);
        }

        protected override void OnAcquired(Player player, Pickup pickup)
        {
            Firearm firearm = player.CurrentItem as Firearm;
            if (firearm == null)
                return;

            firearm.BaseDamage = 100f;

            Firearm firearmBase = firearm.Base as Firearm;
            if (firearmBase == null)
                return;

            firearmBase.Status = new FirearmStatus(5, FirearmStatusFlags.MagazineInserted, 0);
        }
    }
}