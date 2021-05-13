using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace SlimySupport.Root.NPCs
{
	
	public class NinjaSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ninja Slime");
			Terraria.Main.npcFrameCount[npc.type] = Terraria.Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 35;
			npc.defense = 2; 
			npc.lifeMax = 75;
			npc.HitSound = SoundID.NPCHit54;
			npc.DeathSound = SoundID.NPCDeath54;
			npc.value = 60f;
			npc.knockBackResist = 2f;
			npc.scale = 1f;
			npc.aiStyle = 1;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
			npc.boss = false;
		}



		public override void NPCLoot()
		{ 
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.5f;
		}

	}
}