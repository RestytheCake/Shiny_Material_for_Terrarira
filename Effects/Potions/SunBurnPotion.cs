using Terraria.ID;
using Terraria.ModLoader;
using ShinyMaterial.Effects.Debuffs;
using Terraria;

namespace ShinyMaterial.Effects.Potions;

public class SunBurnPotion : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Sun Burn");
        Tooltip.SetDefault("You're burning really hot");
    }

    public override void SetDefaults()
    {
        Item.width = 16;
        Item.height = 16;

        Item.useStyle = ItemUseStyleID.HoldUp;
        Item.useTime = 20;
        Item.useAnimation = 20;
        Item.useTurn = true;
        Item.maxStack = 30;
        Item.consumable = true;
        Item.UseSound = SoundID.Item3;
        
        Item.buffType = ModContent.BuffType<SunBurn>();
        Item.buffTime = 600;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.FragmentSolar, 25);
        recipe.AddIngredient(ItemID.LunarBar, 1);
        recipe.AddIngredient(ItemID.Bottle, 1);
        recipe.AddTile(TileID.WorkBenches);
        recipe.Register();
    }
    
}