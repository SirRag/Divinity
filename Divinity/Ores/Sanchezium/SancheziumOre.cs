using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Divinity.Ores.Sanchezium
{
    public class SancheziumOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sanchezium Ore");
            Tooltip.SetDefault("'Unrefined Sanchezium, not pretty useful.'");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.autoReuse = true;
            item.rare = 5;
            item.consumable = true;
            item.createTile = mod.TileType("SancheziumOreTile");
        }
    }
}