using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Projectiles
{
    public class JesterDart : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.JestersArrow);
            projectile.width = 14;
            projectile.height = 24;
            projectile.extraUpdates = 1;
            projectile.timeLeft = 9999999;
        }

        public override void Kill(int timeLeft)
        {
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
        }

        public override void AI()
        {
            Lighting.AddLight(projectile.Center, 1f, 1f, 1f);
        }
    }
}