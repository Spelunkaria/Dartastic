using Terraria;
using Terraria.ID;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class Fertilizer : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fertilizer");
            Tooltip.SetDefault("Has a 33% chance of not consuming ammo");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 66;
            item.height = 22;
            item.rare = ItemRarityID.Lime;
            item.useAmmo = AmmoID.Dart;
            item.damage = 110;
            item.knockBack = 6;
            item.crit = 25;
            item.useTime = 16;
            item.useAnimation = 16;
            item.autoReuse = true;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= 0.33f;
        }
    }
}