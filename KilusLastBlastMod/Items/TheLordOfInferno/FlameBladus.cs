using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;

namespace KilusLastBlastMod.Items.TheLordOfInferno
{
	public class FlameBladus : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flame Bladus"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("No the fire can burn it! Maybe bacause its fire...");
		}

		public override void SetDefaults()
		{
			item.damage = 95;
			item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = Item.sellPrice(gold: 10);

		}
	}
}