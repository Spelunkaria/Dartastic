using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Dartastic.Items.DartClass{

	public class DartClassPlayer : ModPlayer{
		
		public static DartClassPlayer ModPlayer(Player player) {
			return player.GetModPlayer<DartClassPlayer>();
		}
		public float dartDamageAdd;
		public float dartDamageMult = 1f;
		public float dartKnockback;
		public int dartCrit;
		public override void ResetEffects() {
			ResetVariables();
		}
		public override void UpdateDead() {
			ResetVariables();
		}

		private void ResetVariables() {
			dartDamageAdd = 0f;
			dartDamageMult = 1f;
			dartKnockback = 0f;
			dartCrit = 0;
		}
	}
}