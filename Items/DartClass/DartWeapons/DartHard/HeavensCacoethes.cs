using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class HeavensCacoethes : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heaven's Cacoethes");
            Tooltip.SetDefault("Shoots an extra Crystal Dart every shot"
            + "\nThe True Excalibur of dart weapons, basically");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 102;
            item.height = 38;
            item.rare = ItemRarityID.Pink;
            item.useAmmo = AmmoID.Dart;
            item.damage = 125;
            item.knockBack = 6;
            item.crit = 25;
            item.useTime = 40;
            item.useAnimation = 40;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<DartHard.HallowDart>());
            recipe.AddIngredient(ModContent.ItemType<DartHard.CrystalDart>());
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ItemID.CrystalShard, 15);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.CrystalDart, damage, knockBack, player.whoAmI);
            return true;
		}
    }
}