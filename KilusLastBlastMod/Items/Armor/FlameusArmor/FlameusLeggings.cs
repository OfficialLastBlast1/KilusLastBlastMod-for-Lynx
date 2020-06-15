using System;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace KilusLastBlastMod.Items.Armor.FlameusArmor
{
	[AutoloadEquip(EquipType.Legs)]

	public class FlameusLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Just a shoes of Fire Gods."
				+ "\n20% increased magic speed");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Pink;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "FlameusBar", 13);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}