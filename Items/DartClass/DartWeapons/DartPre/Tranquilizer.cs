using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class Tranquilizer : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tranquilizer");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 28;
            item.height = 16;
            item.rare = ItemRarityID.Green;
            item.useAmmo = AmmoID.Dart;
            item.damage = 14;
            item.knockBack = 3;
            item.crit = 5;
            item.useTime = 18;
            item.useAnimation = 18;
            item.autoReuse = true;
        }
    }
}