using Terraria.ID;
using Terraria.ModLoader;

namespace Divinity.Items.Sanchezium
{
	public class SancheziumSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sanchezium Sword");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 55;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}
