using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Projectiles
{
    public class DemonThorn : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 16;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }

        public override void Kill(int timeLeft)
        {
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
        }
    }
}