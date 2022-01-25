using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class Terragon : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terragon");
            Tooltip.SetDefault("Shoots three darts at a time"
            + "\nShoots an extra Terra Dart every shot"
            + "\nFREAKING HUGE"
            + "\nThe Terra Blade of dart weapons, basically");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 142;
            item.height = 54;
            item.rare = ItemRarityID.Yellow;
            item.useAmmo = AmmoID.Dart;
            item.damage = 120;
            item.knockBack = 6;
            item.crit = 30;
            item.useTime = 20;
            item.useAnimation = 20;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<DartHard.MidnightReaper>());
            recipe.AddIngredient(ModContent.ItemType<DartHard.HeavensCacoethes>());
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<Projectiles.TerraDart>(), damage, knockBack, player.whoAmI);
            int numberProjectiles = 2;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
            return true;
		}
    }
}