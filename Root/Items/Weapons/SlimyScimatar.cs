using Terraria.ID;
using Terraria.ModLoader;

namespace SlimySupport.Root.Items.Weapons
{
	public class SlimyScimatar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Blade of slime");
		}

		public override void SetDefaults()
		{
			item.damage = 20; 
			item.melee = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 30; 
			item.useAnimation = 20; 
			item.useStyle = ItemUseStyleID.SwingThrow; 
			item.noMelee = false; 
			item.knockBack = 2; 
			item.value = 100; 
			item.rare = ItemRarityID.Green; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = false;
			item.scale = 0.75f;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddIngredient(ItemID.IronShortsword , 1);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}
