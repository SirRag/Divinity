using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Divinity.Tiles.UnigiteCrafter
{
	public class UCItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unigite Crafter");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.rare = 5;
			item.consumable = true;
			item.createTile = mod.TileType("UCTile");
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "UCChassis", 1);
            recipe.AddIngredient(null, "UCPowerStabilizer", 1);
            recipe.AddIngredient(null, "UCControlModule", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}