using Terraria.ID;
using Terraria.ModLoader;

namespace SlimySupport.Root.Items.Weapons
{
	public class SlimeShooter : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shoots Slime" + "Consumes Gel");
		}

		public override void SetDefaults()
		{
			item.damage = 15; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 30; 
			item.useAnimation = 20; 
			item.useStyle = ItemUseStyleID.HoldingOut; 
			item.noMelee = true; 
			item.knockBack = 2; 
			item.value = 100; 
			item.rare = ItemRarityID.Green; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("SlimeProj");
			item.shootSpeed = 8f; 
			item.useAmmo = AmmoID.Gel; 
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddIngredient(ItemID.SlimeGun , 1);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}
