using Terraria.ID;
using Terraria.ModLoader;

namespace KilusLastBlastMod.Items
{
	public class WoodenSpinningStick : ModItem
	{
		public override void SetStaticDefaults() => Tooltip.SetDefault("Spin it...");

		public override void SetDefaults()
		{
			item.damage = 5;
			item.melee = true;
			item.width = 15;
			item.height = 15;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 7;
			item.value = 1000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}