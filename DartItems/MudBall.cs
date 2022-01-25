using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class MudBall : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mud Ball");
            Tooltip.SetDefault("Its mud liquid form affects its gravity a bit");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 20;
            item.height = 20;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.MudBall>();
            item.damage = 5;
            item.knockBack = 1;
            item.crit = 4;
            item.consumable = true;
            item.value = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MudBlock, 1);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<DirtBallItem>(), 25);
            recipe.needWater = true;
            recipe.SetResult(this, 25);
            recipe.AddRecipe();
        }
    }
}