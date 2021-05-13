using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace SlimySupport.Root.NPCs.Town
{
    [AutoloadHead]
    public class NinjaNPC : ModNPC
    {
        //public override string Texture
        //{
        //    get { return "TMMC/NPCs/Town/TMMCTownNPC"; }
        //}

        //public override string[] AltTextures
        //{
        //    get { return new[] { "TMMC/NPCs/Town/TMMCTownNPC_Alt_1" }; }
        //}

        public override bool Autoload(ref string name)
        {
            name = "Ninja";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 26;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 5;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7; // Town NPC AI Style
            npc.damage = 12;
            npc.defense = 17;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (!player.active)
                {
                    continue;
                }

                foreach (Item item in player.inventory)
                {
                    if (item.type == mod.ItemType("SlimeCoin"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(4))
            {
                case 0:
                    return "Ninja";
                case 1:
                    return "Jin";
                case 2:
                    return "Karl";
                default: // Default is the default if no other case is true. In this case if the random number is 3 or more
                    return "Llyod";
            }
        }

        public override string GetChat()
        {
            int otherNPC = NPC.FindFirstNPC(NPCID.Angler);
            if (otherNPC >= 0 && Main.rand.NextBool(4))
            {
                return "I HATE " + Main.npc[otherNPC].GivenName + "THE ANGLER BECAUSE HE IS AN ONION";
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "I AM A SPINJITSU MASTER";
                case 1:
                    return "GIMME MOOLAH YOU GET ITEMS";
                case 2:
                    return "BOOP";
                default:
                    return "MOOT MOOT";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
            button2 = "Custom";

        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                // This is makes it a shop
                shop = true;
            }
            else
            {
                Main.npcChatText = "NOOOOOOOOOOOOT NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOT";
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            // For every slot, you must have these lines.
            shop.item[nextSlot].SetDefaults(mod.ItemType("SlimeShooter"));
            nextSlot++;
            // You can have a max of 40?
            shop.item[nextSlot].SetDefaults(mod.ItemType("SlimyScimatar"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("SlimyStaff"));
            nextSlot++;
            // You can also have conditions
            if (Main.moonPhase == 2) // The Phase of the Moon
            {
                shop.item[nextSlot].SetDefaults(ItemID.MoonCharm);
                nextSlot++;
            }
            if (Main.hardMode) // If in hardmode
            {
                shop.item[nextSlot].SetDefaults(ItemID.GuideVoodooDoll);
                nextSlot++;
            }
            if (Main.LocalPlayer.HasBuff(BuffID.Regeneration)) // If we have a certain buff
            {
                shop.item[nextSlot].SetDefaults(ItemID.RecallPotion);
                nextSlot++;
            }
            
        }

        public override void NPCLoot()
        {
            //Item.NewItem(npc.getRect(), mod.ItemType("TMMCAccessory"));
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 25;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 25;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            mod.ProjectileType("SlimeProj");
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 5f;
            randomOffset = 2f;
        }


        // This is for if you want custom spawn conditions
        // This example will check for the TMMCTile and TMMCWall
       

    }
}