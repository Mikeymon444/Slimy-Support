using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace SlimySupport.Root.NPCs
{
	
	public class Prateor : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elite Guard");
			Terraria.Main.npcFrameCount[npc.type] = Terraria.Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 50;
			npc.defense = 7;
			npc.lifeMax = 500;
			npc.HitSound = SoundID.NPCHit54;
			npc.DeathSound = SoundID.NPCDeath54;
			npc.value = 100f;
			npc.knockBackResist = 1f;
			npc.scale = 2f;
			npc.aiStyle = 1;
			aiType = NPCID.SpikedJungleSlime;
			animationType = NPCID.MotherSlime;
			npc.boss = false;
		}



		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), mod.ItemType("SlimeCoin"));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0.05f;
		}

	}
}