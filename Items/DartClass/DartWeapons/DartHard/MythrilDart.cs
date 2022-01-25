using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class MythrilDart : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mythril Tranquilizer");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 54;
            item.height = 22;
            item.rare = ItemRarityID.LightRed;
            item.useAmmo = AmmoID.Dart;
            item.damage = 48;
            item.knockBack = 5;
            item.crit = 15;
            item.useTime = 35;
            item.useAnimation = 35;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MythrilBar, 14);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}