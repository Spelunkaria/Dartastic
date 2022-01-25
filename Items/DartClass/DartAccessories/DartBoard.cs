using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Dartastic.Items.DartClass.DartAccessories{

    public class DartBoard : ModItem{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dart Board");
            Tooltip.SetDefault("Increases dart damage by 10%");
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
            modPlayer.dartDamageMult += 1f;
        }
    }
}