using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class BloodSpike : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Spike");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 10;
            item.height = 16;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.BloodSpike>();
            item.damage = 14;
            item.knockBack = 2;
            item.crit = 4;
            item.consumable = true;
            item.value = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 80);
            recipe.AddRecipe();
        }
    }
}