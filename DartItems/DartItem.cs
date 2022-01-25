using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class DartItem : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dart");
            Tooltip.SetDefault("Doesn't get more basic than this");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 14;
            item.height = 24;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.Dart>();
            item.damage = 8;
            item.knockBack = 2;
            item.crit = 4;
            item.consumable = true;
            item.value = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 25);
            recipe.AddRecipe();

            recipe.AddIngredient(this, 100);
            recipe.AddIngredient(ItemID.Stinger, 10);
            recipe.SetResult(ItemID.PoisonDart, 100);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 100);
            recipe.AddIngredient(ItemID.CursedFlame, 10);
            recipe.SetResult(ItemID.CursedDart, 100);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 100);
            recipe.AddIngredient(ItemID.Ichor, 10);
            recipe.SetResult(ItemID.IchorDart, 100);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 100);
            recipe.AddIngredient(ItemID.CrystalShard, 10);
            recipe.SetResult(ItemID.CrystalDart, 100);
            recipe.AddRecipe();
        }
    }
}