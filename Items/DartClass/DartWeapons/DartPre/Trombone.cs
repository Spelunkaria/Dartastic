using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class Trombone : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trombone");
            Tooltip.SetDefault("TOOT");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 28;
            item.height = 18;
            item.rare = ItemRarityID.Orange;
            item.useAmmo = AmmoID.Dart;
            item.damage = 23;
            item.knockBack = 3;
            item.crit = 15;
            item.useTime = 16;
            item.useAnimation = 16;
            item.autoReuse = true;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Skull");
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(1, 2);
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