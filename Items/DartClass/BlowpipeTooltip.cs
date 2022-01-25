using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;

namespace Dartastic{

    public class BlowpipeTooltip : GlobalItem{

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) 
        {
            if(item.type == ItemID.Blowpipe){
                TooltipLine tt = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.mod == "Terraria");
			    if (tt != null) {
				string[] splitText = tt.text.Split(' ');
				string damageValue = splitText.First();
				string damageWord = splitText.Last();
				tt.text = damageValue + " dart " + damageWord;
			}
            }
        }
    }
}