using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class NightAssassin : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Night Assassin");
            Tooltip.SetDefault("The Night's Edge of dart weapons, basically");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 60;
            item.height = 24;
            item.rare = ItemRarityID.Orange;
            item.useAmmo = AmmoID.Dart;
            item.damage = 32;
            item.knockBack = 6;
            item.crit = 10;
            item.useTime = 17;
            item.useAnimation = 17;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<DemonBlower>());
            recipe.AddIngredient(ModContent.ItemType<SpineShot>());
            recipe.AddIngredient(ModContent.ItemType<Dartogany>());
            recipe.AddIngredient(ModContent.ItemType<HellsRage>());
            recipe.AddIngredient(ModContent.ItemType<Asteroid>());
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<TendonShot>());
            recipe.AddIngredient(ModContent.ItemType<SpineShot>());
            recipe.AddIngredient(ModContent.ItemType<Dartogany>());
            recipe.AddIngredient(ModContent.ItemType<HellsRage>());
            recipe.AddIngredient(ModContent.ItemType<Asteroid>());
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}