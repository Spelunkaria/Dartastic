using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartWeapons.DartPre{

    public class LeadBlowpipe : DartClassItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lead Blowpipe");
            Tooltip.SetDefault("This is NOT safe");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Blowpipe);
            item.width = 36;
            item.height = 16;
            item.rare = ItemRarityID.White;
            item.useAmmo = AmmoID.Dart;
            item.damage = 8;
            item.knockBack = 2;
            item.crit = 8;
            item.useTime = 30;
            item.useAnimation = 30;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadBar, 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}