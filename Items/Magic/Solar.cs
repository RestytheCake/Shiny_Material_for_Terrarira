using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShinyMaterial.Items
{
	public class Solar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shiny Solar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shiny Solar to use");
		}

		public override void SetDefaults()
		{
			Item.damage = 11;
			Item.DamageType = DamageClass.Summon;
			Item.width = 1;
			Item.height = 1;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.accessory = false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FragmentSolar, 111);
			recipe.AddIngredient(ItemID.LunarBar, 55);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}