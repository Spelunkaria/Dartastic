using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartAccessories{

    public class DartslingersEmblem : ModItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dart Board");
            Tooltip.SetDefault("Increases dart damage by 15%");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 28;
            item.height = 28;
            item.rare = ItemRarityID.LightRed;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            DartClassPlayer modPlayer = DartClassPlayer.ModPlayer(player);
            modPlayer.dartDamageMult += 1.5f;
        }
    }
}