using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Projectiles
{
    public class GlassDart : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 24;
            projectile.aiStyle = 1;
            projectile.knockBack = 3;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }

        public override void Kill(int timeLeft)
        {
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
        }

        public override void AI()
        {
            projectile.ai[0] += 1f; // Use a timer to wait 15 ticks before applying gravity.
            if (projectile.ai[0] >= 15f)
            {
	            projectile.ai[0] = 15f;
	            projectile.velocity.Y = projectile.velocity.Y + 0.3f;
            }
            if (projectile.velocity.Y > 16f)
            {
	            projectile.velocity.Y = 16f;
            }
        }
    }
}