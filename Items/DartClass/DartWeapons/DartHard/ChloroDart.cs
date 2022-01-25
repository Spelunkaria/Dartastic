using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartHard{

    public class ChloroDart : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nature's Tranquility");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 66;
            item.height = 22;
            item.rare = ItemRarityID.Lime;
            item.useAmmo = AmmoID.Dart;
            item.damage = 120;
            item.knockBack = 6;
            item.crit = 25;
            item.useTime = 40;
            item.useAnimation = 40;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= 0.33f;
        }
    }
}