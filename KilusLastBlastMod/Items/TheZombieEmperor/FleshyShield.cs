using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace KilusLastBlastMod.Items.TheZombieEmperor
{
	public class FleshyShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fleshy Shield");
			Tooltip.SetDefault("it's a flesh... and a shield... perfection.");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 4));
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = Item.buyPrice(0, 15, 1, 0);
			item.rare = ItemRarityID.Cyan;
			item.expert = true;
			item.accessory = true;
			item.defense = 3;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

		public override bool CanEquipAccessory(Player player, int slot)
		{
			if (slot < 10) // This allows the accessory to equip in Vanity slots with no reservations.
			{
				int maxAccessoryIndex = 0 + player.extraAccessorySlots;
				for (int i = 3; i < 3 + maxAccessoryIndex; i++)
				{
					// We need "slot != i" because we don't care what is currently in the slot we will be replacing.
					if (slot != i && player.armor[i].type == ItemID.AnkhShield)
					{
						return false;
					}
				}
			}
			return true;
		}
	}

	// We need to do the same for the AnkhShield so our restriction is enforced both ways.
	public class AnkhShield : GlobalItem
	{
		public override bool CanEquipAccessory(Item item, Player player, int slot)
		{
			if (item.type == ItemID.AnkhShield)
			{
				if (slot < 10) // This allows the accessory to equip in Vanity slots with no reservations.
				{
					int maxAccessoryIndex = 0 + player.extraAccessorySlots;
					for (int i = 3; i < 3 + maxAccessoryIndex; i++)
					{
						// We need "slot != i" because we don't care what is currently in the slot we will be replacing.
						if (slot != i && player.armor[i].type == ItemType<FleshyShield>())
						{
							return false;
						}
					}
				}
			}
			return true;
		}
	}
}