using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace KilusLastBlastMod.Items.TheLordOfInferno
{
    public class BurningFlame : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(50, 100);
            item.rare = ItemRarityID.Yellow;
            item.value = Item.sellPrice(gold: 15) ;

            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;  
            
            item.noMelee = true;
            item.ranged = true;
            item.damage = 70;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = ProjectileID.WoodenArrowFriendly;
            item.shootSpeed = 7.5f;
        }

        
        }
    }
