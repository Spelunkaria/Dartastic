using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class MidnightReaper : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Midnight Reaper");
            Tooltip.SetDefault("Shoots an extra Demon Thorn every shot"
            + "\nThe True Night's Edge of dart weapons, basically");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 96;
            item.height = 40;
            item.rare = ItemRarityID.Pink;
            item.useAmmo = AmmoID.Dart;
            item.damage = 85;
            item.knockBack = 6;
            item.crit = 25;
            item.useTime = 26;
            item.useAnimation = 26;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<DartPre.NightAssassin>());
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("DemonThorn"), damage, knockBack, player.whoAmI);
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 90f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
            return true;
		}
    }
}