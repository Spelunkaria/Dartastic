using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class Trombone : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trombone");
            Tooltip.SetDefault("TOOT");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 28;
            item.height = 18;
            item.rare = ItemRarityID.Orange;
            item.useAmmo = AmmoID.Dart;
            item.damage = 23;
            item.knockBack = 3;
            item.crit = 15;
            item.useTime = 16;
            item.useAnimation = 16;
            item.autoReuse = true;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Skull");
        }
    }
}