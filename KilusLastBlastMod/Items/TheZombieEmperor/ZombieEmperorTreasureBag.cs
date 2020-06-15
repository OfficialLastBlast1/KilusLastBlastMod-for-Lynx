
using KilusLastBlastMod.Items.TheZombieEmperor;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace KilusLastBlastMod.Items.TheZombieEmperor
{
	public class ZombieEmperorTreasureBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 99;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Cyan;
			item.expert = true;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			{
			}
			player.QuickSpawnItem(ItemType<FleshyShield>()); }

		public override int BossBagNPC => mod.NPCType("TheZombieEmperor");
	}
}