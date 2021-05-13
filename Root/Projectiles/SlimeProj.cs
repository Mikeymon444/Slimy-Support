using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SlimySupport.Root.Projectiles
{
	public class SlimeProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slime");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			aiType = ProjectileID.WoodenArrowFriendly;
		}


	}
}
