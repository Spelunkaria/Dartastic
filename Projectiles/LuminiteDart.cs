using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace Dartastic.Projectiles
{
    public class LuminiteDart : ModProjectile
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
        }

        public override void Kill(int timeLeft)
        {
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
            
                if (projectile.owner == Main.myPlayer)
                {
	                for (int i = 0; i < 5; i++)
	                {
                        float speedX = -projectile.velocity.X * Main.rand.NextFloat(.7f, .7f) + Main.rand.NextFloat(-8f, 8f);
		                float speedY = -projectile.velocity.Y * Main.rand.Next(70, 70) * 0.01f + Main.rand.Next(-20, 21) * 0.4f;
                        Projectile.NewProjectile(projectile.position.X + speedX, projectile.position.Y + speedY, speedX, speedY, mod.ProjectileType("LuminiteDartNew"), (int)(projectile.damage * 0.5), 0f, projectile.owner, 0f, 0f);
	                }
                }
        }

        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
        }
    }
}