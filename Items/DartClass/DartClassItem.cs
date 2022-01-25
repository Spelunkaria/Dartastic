using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass
{
	public abstract class DartClassItem : ModItem
	{
		public override bool CloneNewInstances => true;		
		public virtual void SafeSetDefaults() {
		}
		public sealed override void SetDefaults() {
			SafeSetDefaults();
			item.melee = false;
			item.ranged = false;
			item.magic = false;
			item.thrown = false;
			item.summon = false;
		}

		public override void ModifyWeaponDamage(Player player, ref float add, ref float mult, ref float flat) {
			add += DartClassPlayer.ModPlayer(player).dartDamageAdd;
			mult *= DartClassPlayer.ModPlayer(player).dartDamageMult;
		}

		public override void GetWeaponKnockback(Player player, ref float knockback) {
			knockback += DartClassPlayer.ModPlayer(player).dartKnockback;
		}

		public override void GetWeaponCrit(Player player, ref int crit) {
			crit += DartClassPlayer.ModPlayer(player).dartCrit;
		}
		public override void ModifyTooltips(List<TooltipLine> tooltips) {
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