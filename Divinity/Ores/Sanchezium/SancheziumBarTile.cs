using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Divinity.Ores.Sanchezium
{
    public class SancheziumBarTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.Height = 1;
            AddMapEntry(new Color(0, 191, 255));
            Main.tileSolid[Type] = true;
            drop = mod.ItemType("SancheziumBar");
        }
    }
}