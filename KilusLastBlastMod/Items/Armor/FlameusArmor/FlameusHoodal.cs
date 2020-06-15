using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace KilusLastBlastMod.Items.Armor.FlameusArmor
{
	[AutoloadEquip(EquipType.Head)]

	public class FlameusHoodal : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Gives Curse Buff.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Pink;
			item.defense = 9;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ItemType<FlameusWizardRobe>() && legs.type == ItemType<FlameusLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Immune to Fire, BUT NOT TO LAVA!";
			player.AddBuff(BuffID.Cursed, 2);
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "FlameusBar", 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}