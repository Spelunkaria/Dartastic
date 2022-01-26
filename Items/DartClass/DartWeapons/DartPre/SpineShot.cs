using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class SpineShot : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spine Shot");
            Tooltip.SetDefault("Converts normal darts in Bone Darts, dealing pretty good knockback");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 34;
            item.height = 22;
            item.rare = ItemRarityID.Orange;
            item.useAmmo = AmmoID.Dart;
            item.damage = 20;
            item.knockBack = 6;
            item.crit = 8;
            item.useTime = 18;
            item.useAnimation = 18;
            item.UseSound = SoundID.NPCHit2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bone, 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ModContent.ProjectileType<Projectiles.Dart>())
			{
				type = ModContent.ProjectileType<Projectiles.BoneDart>();
			}
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
			return true;
        }
    }
}