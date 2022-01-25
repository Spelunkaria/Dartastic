using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class HallowDart : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heavenly Exterminator");
            Tooltip.SetDefault("Autofires");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 48;
            item.height = 22;
            item.rare = ItemRarityID.LightRed;
            item.useAmmo = AmmoID.Dart;
            item.damage = 70;
            item.knockBack = 6;
            item.crit = 20;
            item.useTime = 18;
            item.useAnimation = 18;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}