using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class Tranquilizer : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tranquilizer");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 28;
            item.height = 16;
            item.rare = ItemRarityID.Green;
            item.useAmmo = AmmoID.Dart;
            item.damage = 14;
            item.knockBack = 3;
            item.crit = 5;
            item.useTime = 18;
            item.useAnimation = 18;
            item.autoReuse = true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-1, 0);
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