using Terraria.ID;
using Terraria.ModLoader;

namespace SlimySupport.Root.Items.Weapons
{
	public class SlimyStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shoots Slime");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 100;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("SlimeProj2");
			item.shootSpeed = 4f;
			item.mana = 3;
		}

		//public override void AddRecipes()
		//{
		//ModRecipe recipe = new ModRecipe(mod);
		//recipe.SetResult(this);
		//recipe.AddRecipe();
		//}


	}
}