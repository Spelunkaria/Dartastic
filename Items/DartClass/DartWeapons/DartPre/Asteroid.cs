using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class Asteroid : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Asteroid");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 34;
            item.height = 18;
            item.rare = ItemRarityID.Green;
            item.useAmmo = AmmoID.Dart;
            item.damage = 14;
            item.knockBack = 4;
            item.crit = 6;
            item.useTime = 12;
            item.useAnimation = 12;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}