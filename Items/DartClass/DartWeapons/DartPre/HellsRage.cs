using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class HellsRage : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hell's Rage");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 60;
            item.height = 24;
            item.rare = ItemRarityID.Orange;
            item.useAmmo = AmmoID.Dart;
            item.damage = 28;
            item.knockBack = 6;
            item.crit = 6;
            item.useTime = 16;
            item.useAnimation = 16;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 8);
            recipe.AddIngredient(ItemID.Blowgun);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}