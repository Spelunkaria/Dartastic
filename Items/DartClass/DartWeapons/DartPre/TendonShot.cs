using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class TendonShot : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tendon Shot");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 32;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.useAmmo = AmmoID.Dart;
            item.damage = 14;
            item.knockBack = 2;
            item.crit = 8;
            item.useTime = 18;
            item.useAnimation = 18;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}