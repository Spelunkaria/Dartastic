using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class LuminiteDart : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Luminite Dart");
            Tooltip.SetDefault("Unaffected by gravity"
            + "\nSplits in five after colliding"
            + "\nInfinitely pierces");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 14;
            item.height = 24;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.LuminiteDart>();
            item.rare = ItemRarityID.Red;
            item.damage = 30;
            item.knockBack = 3;
            item.crit = 15;
            item.consumable = true;
            item.value = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 333);
            recipe.AddRecipe();
        }
    }
}