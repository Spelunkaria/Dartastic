using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Dartastic.Projectiles
{
    public class LuminiteDartNew : ModProjectile
    {
        public override void SetStaticDefaults(){
            ProjectileID.Sets.Homing[projectile.type] = true;
        }
        
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 24;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.timeLeft = 6000;
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
        }

        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
        }
    }
}