using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class LunarDart : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunar Marker");
            Tooltip.SetDefault("66% chance of not consuming ammo"
            + "\nThe culmination of darts themselves");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 70;
            item.height = 32;
            item.rare = ItemRarityID.Red;
            item.useAmmo = AmmoID.Dart;
            item.damage = 150;
            item.knockBack = 8;
            item.crit = 40;
            item.useTime = 10;
            item.useAnimation = 10;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentVortex, 15);
            recipe.AddIngredient(ItemID.IllegalGunParts);
            recipe.AddIngredient(ModContent.ItemType<DartPre.Tranquilizer>());
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .66f;
        }
    }
}