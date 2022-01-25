using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartAccessories{

    public class TargetPractice : ModItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Target Practice");
            Tooltip.SetDefault("Increases dart damage by 10%"
            + "\nIncreases dart crits by 15%");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 22;
            item.height = 22;
            item.rare = ItemRarityID.Orange;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            DartClassPlayer modPlayer = DartClassPlayer.ModPlayer(player);
            modPlayer.dartDamageMult += 1f;
            modPlayer.dartCrit = 15;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<DartAccessories.DartBoard>());
            recipe.AddIngredient(ModContent.ItemType<DartAccessories.DartslingersGlove>());
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}