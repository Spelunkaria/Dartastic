using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class CrystalDart : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystalline Enforcer");
            Tooltip.SetDefault("Converts basic Darts in Crystal Darts"
            + "\nShoots three darts at a time");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 80;
            item.height = 30;
            item.rare = ItemRarityID.Pink;
            item.useAmmo = AmmoID.Dart;
            item.damage = 65;
            item.knockBack = 6;
            item.crit = 25;
            item.useTime = 18;
            item.useAnimation = 18;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 20);
            recipe.AddIngredient(ItemID.SoulofMight, 15);
            recipe.AddIngredient(ItemID.SoulofFright, 15);
            recipe.AddIngredient(ItemID.SoulofLight, 20);
            recipe.AddIngredient(ItemID.CrystalShard, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 2;
            if(type == ModContent.ProjectileType<Projectiles.Dart>()){

                type = ProjectileID.CrystalDart;
            }
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
            return true;
		}
    }
}