using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class JesterDart : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jester Dart");
            Tooltip.SetDefault("Goes through enemies");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 14;
            item.height = 24;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.JesterDart>();
            item.damage = 15;
            item.knockBack = 2;
            item.consumable = true;
            item.crit = 4;
            item.value = 50;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<DartClass.DartItems.DartItem>(), 80);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.SetResult(this, 80);
            recipe.AddRecipe();
        }
    }
}