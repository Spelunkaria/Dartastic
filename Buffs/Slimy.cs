using Terraria;
using Terraria.ModLoader;

namespace Dartastic.Buffs {

    public class Slimy : ModBuff{

        public override void SetDefaults()
        {   
            Main.debuff[Type] = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.drippingSlime = true;
            npc.velocity = npc.velocity*(0.8f);
        }
    }
}