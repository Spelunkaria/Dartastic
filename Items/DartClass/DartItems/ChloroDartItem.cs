using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartItems{

    public class ChloroDartItem : DartClassItem{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chlorophyte Dart");
            Tooltip.SetDefault("Unaffected by gravity"
            + "\nSplits in two after some time"
            + "\nChases after enemies");
        }

        public override void SafeSetDefaults()
        {
            item.maxStack = 999;
            item.width = 14;
            item.height = 24;
            item.ammo = AmmoID.Dart;
            item.shoot = ModContent.ProjectileType<Projectiles.ChloroDart>();
            item.damage = 15;
            item.knockBack = 2;
            item.crit = 8;
            item.consumable = true;
            item.value = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<DartItem>(), 100);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
        }
    }
}