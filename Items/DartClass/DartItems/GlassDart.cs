using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class GlassDart : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glass Dart");
            Tooltip.SetDefault("Great offense, great gravity");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 14;
            item.height = 24;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.GlassDart>();
            item.damage = 20;
            item.knockBack = 2;
            item.crit = 4;
            item.consumable = true;
            item.value = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Glass, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}