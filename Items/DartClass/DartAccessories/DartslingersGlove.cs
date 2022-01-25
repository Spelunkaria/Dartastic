using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartAccessories{

    public class DartslingersGlove : ModItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dartslinger's Glove");
            Tooltip.SetDefault("Increases dart crits by 15%");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 22;
            item.height = 22;
            item.rare = ItemRarityID.Green;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            DartClassPlayer modPlayer = DartClassPlayer.ModPlayer(player);
            modPlayer.dartCrit = 15;
        }
    }
}