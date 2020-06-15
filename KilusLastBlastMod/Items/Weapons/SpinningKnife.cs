using Terraria.ID;
using Terraria.ModLoader;

namespace KilusLastBlastMod.Items.Weapons
{
	public class SpinningKnife : ModItem
	{
        public override void SetStaticDefaults() => Tooltip.SetDefault("Knife of the hallowed gods of light.");

        public override void SetDefaults()
		{
			item.damage = 55;
			item.melee = true;
			item.width = 15;
			item.height = 15;
			item.useTime = 6;
			item.useAnimation = 6;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}