using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class DirtBallItem : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dirt Ball");
            Tooltip.SetDefault("Sacrifices damage for being very easy to produce");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 20;
            item.height = 20;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.DirtBall>();
            item.damage = 2;
            item.knockBack = 1;
            item.crit = 4;
            item.consumable = true;
            item.value = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
        }
    }
}