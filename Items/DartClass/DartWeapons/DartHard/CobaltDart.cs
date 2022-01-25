using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class CobaltDart : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cobalt Dart Launcher");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 40;
            item.height = 16;
            item.rare = ItemRarityID.LightRed;
            item.useAmmo = AmmoID.Dart;
            item.damage = 40;
            item.knockBack = 3;
            item.crit = 15;
            item.useTime = 40;
            item.useAnimation = 40;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CobaltBar, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}