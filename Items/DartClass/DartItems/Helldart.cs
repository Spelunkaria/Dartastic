using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class Helldart : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Helldart");
            Tooltip.SetDefault("50% chance of setting enemies on fire");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 14;
            item.height = 24;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.Helldart>();
            item.damage = 13;
            item.knockBack = 2;
            item.crit = 4;
            item.consumable = true;
            item.value = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 1);
            recipe.AddIngredient(ModContent.ItemType<DartClass.DartItems.DartItem>(), 100);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
        }
    }
}