using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class OrichalcumDart : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orichalcum Dart Rifle");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 54;
            item.height = 22;
            item.rare = ItemRarityID.LightRed;
            item.useAmmo = AmmoID.Dart;
            item.damage = 46;
            item.knockBack = 5;
            item.crit = 15;
            item.useTime = 32;
            item.useAnimation = 32;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.OrichalcumBar, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}