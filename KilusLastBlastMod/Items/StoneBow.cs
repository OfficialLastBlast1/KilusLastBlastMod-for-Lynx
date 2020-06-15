using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Linq;
using Microsoft.VisualBasic;
using Terraria;

namespace KilusLastBlastMod.Items
{
	public class StoneBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
	
			Tooltip.SetDefault("You've got fooled...");
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.knockBack = 5;
			item.useAmmo = AmmoID.Arrow;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 60);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}