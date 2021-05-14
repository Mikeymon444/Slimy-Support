using Terraria;
using Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace SlimySupport.Root.Items.Mounts
{
    public class SlimeSurfer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SlimeSurfer");
            Tooltip.SetDefault("Slime Squelch");
        }

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 34;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6f;
            item.value = Item.buyPrice(silver: 15);
            item.UseSound = SoundID.Item81;
            item.noMelee = true;
            item.mountType = mod.MountType("SlimeSurfer");
        }
    }
}