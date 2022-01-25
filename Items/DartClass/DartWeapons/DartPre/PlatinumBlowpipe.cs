using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class PlatinumBlowpipe : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Platinum Blowpipe");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 38;
            item.height = 16;
            item.rare = ItemRarityID.Blue;
            item.useAmmo = AmmoID.Dart;
            item.damage = 14;
            item.knockBack = 4;
            item.crit = 8;
            item.useTime = 20;
            item.useAnimation = 20;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumBar, 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}