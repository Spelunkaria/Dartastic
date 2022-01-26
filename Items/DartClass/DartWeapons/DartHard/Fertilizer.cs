using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class Fertilizer : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fertilizer");
            Tooltip.SetDefault("Has a 33% chance of not consuming ammo");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 66;
            item.height = 22;
            item.rare = ItemRarityID.Lime;
            item.useAmmo = AmmoID.Dart;
            item.damage = 110;
            item.knockBack = 6;
            item.crit = 25;
            item.useTime = 16;
            item.useAnimation = 16;
            item.autoReuse = true;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= 0.33f;
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

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(3, 0);
        }
    }
}