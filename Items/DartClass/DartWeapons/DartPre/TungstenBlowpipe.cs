using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class TungstenBlowpipe : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tungsten Blowpipe");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 38;
            item.height = 16;
            item.rare = ItemRarityID.White;
            item.useAmmo = AmmoID.Dart;
            item.damage = 10;
            item.knockBack = 4;
            item.crit = 8;
            item.useTime = 25;
            item.useAnimation = 25;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TungstenBar, 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}