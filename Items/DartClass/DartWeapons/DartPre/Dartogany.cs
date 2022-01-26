using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class Dartogany : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dartogany");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 44;
            item.height = 30;
            item.rare = ItemRarityID.Orange;
            item.useAmmo = AmmoID.Dart;
            item.damage = 14;
            item.knockBack = 4;
            item.crit = 8;
            item.useTime = 18;
            item.useAnimation = 18;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Vine, 5);
            recipe.AddIngredient(ItemID.Stinger, 6);
            recipe.AddIngredient(ItemID.JungleSpores, 3);
            recipe.AddIngredient(ItemID.RichMahogany, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-5, 0);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if(type == ModContent.ProjectileType<Projectiles.Dart>()){

                type = ProjectileID.PoisonDartBlowgun;
            }
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 2f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
            return true;
        }
    }
}