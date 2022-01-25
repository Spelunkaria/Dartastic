using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Dartastic.Projectiles
{
    public class Helldart : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 28;
            projectile.aiStyle = 1;
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

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if(Main.rand.Next(0,1) == 0){
                target.AddBuff(BuffID.OnFire, Main.rand.Next(300,600));
            }
        }
    }
}