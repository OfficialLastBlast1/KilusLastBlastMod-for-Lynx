using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using KilusLastBlastMod.Items;
using static Terraria.ModLoader.ModContent;
namespace KilusLastBlastMod.NPCs.TheZombieEmperor
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class TheZombieEmperor : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("The Zombie Emperor");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];

		}

		public override void SetDefaults()
		{
			npc.width = 23;
			npc.height = 45;
			npc.damage = 30;
			npc.defense = 20;
			npc.lifeMax = 2300;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
			banner = Item.NPCtoBanner(NPCID.Zombie);
			bannerItem = Item.BannerToItem(banner);
			npc.boss = true;
			music = MusicID.Boss5;

			bossBag = mod.ItemType("ZombieEmperorTreasureBag");
		}
		

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldNight.Chance * 0.0f;
		}
		public override void NPCLoot()
		{
			if (Main.expertMode)
				npc.DropBossBags();
		}






        public override void HitEffect(int hitDirection, double damage) {
			for (int i = 0; i < 10; i++) {
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
	}
}
