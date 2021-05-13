using Terraria.ID;
using Terraria.ModLoader;

namespace SlimySupport.Root.Items.Misc
{
	public class SlimeCoin : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Could be of value to someone");
		}

		public override void SetDefaults()
		{
			
			item.value = 100000; 
			item.rare = ItemRarityID.Green; 

		}

        


    }
}
