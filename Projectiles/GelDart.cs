using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Dartastic.Projectiles
{
    public class GelDart : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 24;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }
        
        public override bool OnTileCollide(Vector2 oldVelocity) {
			projectile.penetrate--;
			if (projectile.penetrate <= 0) {
				projectile.Kill();
			}
			else {
				Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
				Main.PlaySound(SoundID.Item10, projectile.position);
				if (projectile.velocity.X != oldVelocity.X) {
					projectile.velocity.X = -oldVelocity.X;
				}
				if (projectile.velocity.Y != oldVelocity.Y) {
					projectile.velocity.Y = -oldVelocity.Y;
				}
			}
			return false;
		}

        public override void AI()
        {
            projectile.ai[0] += 1f;
            if(projectile.ai[0] >= 15f)
            {
                projectile.ai[0] = 15f;
                projectile.velocity.Y = projectile.velocity.Y + 0.15f;
            } 
            if(projectile.ai[0] >= 16f)
            {
                projectile.velocity.Y = 16f;
            }
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if(Main.rand.Next(0,3) == 0){
                target.AddBuff(ModContent.BuffType<Buffs.Slimy>(), 300);
            }
        }
    }
}