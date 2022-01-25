using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class GelDart : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gel Dart");
            Tooltip.SetDefault("Bounces 3 times before destroying itself");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 14;
            item.height = 24;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.GelDart>();
            item.damage = 10;
            item.knockBack = 2;
            item.crit = 4;
            item.consumable = true;
            item.value = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gel, 20);
            recipe.AddIngredient(ModContent.ItemType<DartClass.DartItems.DartItem>(), 100);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
        }
    }
}