using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class PalladiumDart : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Palladium Hand Cannon");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 38;
            item.height = 20;
            item.rare = ItemRarityID.LightRed;
            item.useAmmo = AmmoID.Dart;
            item.damage = 42;
            item.knockBack = 4;
            item.crit = 15;
            item.useTime = 40;
            item.useAnimation = 40;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalladiumBar, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}