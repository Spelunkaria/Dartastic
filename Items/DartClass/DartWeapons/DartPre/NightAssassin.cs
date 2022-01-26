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

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, -3);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
            return true;
        }
    }
}