using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class IronPellet : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Iron Pellet");
            Tooltip.SetDefault("Stronger version of normal Seeds");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 8;
            item.height = 8;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.IronPellet>();
            item.damage = 8;
            item.knockBack = 2;
            item.crit = 4;
            item.consumable = true;
            item.value = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
        }
    }
}