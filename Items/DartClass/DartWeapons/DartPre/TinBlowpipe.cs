using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class TinBlowpipe : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tin Blowpipe");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 34;
            item.height = 16;
            item.rare = ItemRarityID.White;
            item.useAmmo = AmmoID.Dart;
            item.damage = 3;
            item.knockBack = 2;
            item.crit = 8;
            item.useTime = 40;
            item.useAnimation = 40;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TinBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}