using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class DemonBlower : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demon Blower");
            Tooltip.SetDefault("This sounds like an innuendo");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 32;
            item.height = 22;
            item.rare = ItemRarityID.Blue;
            item.useAmmo = AmmoID.Dart;
            item.damage = 16;
            item.knockBack = 2;
            item.crit = 8;
            item.useTime = 20;
            item.useAnimation = 20;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}