using Exiled.API.Features;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using UnityEngine;

namespace AWPPlugin
{
    [CustomItem(ItemType.GunE11SR)]
    public class AWP : CustomWeapon
    {
        public override uint Id { get; set; } = 100;

        public override string Name { get; set; } = "AWP";

        public override string Description { get; set; } = "一把高伤低子弹的狙击枪";

        public override float Weight { get; set; } = 3.5f;

        public override SpawnProperties SpawnProperties { get; set; }

        public override float Damage { get; set; } = 100f;

        public override byte ClipSize { get; set; } = 5;
    }
}