using ShinyMaterial.Effects.Debuffs;
using ShinyMaterial.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShinyMaterial.Items.Accessoire;

public class SparkleofFireflies : ModItem {
    
    public override void SetStaticDefaults() {
        
        DisplayName.SetDefault("Sparkle of Fireflies"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
        Tooltip.SetDefault("Be warned\n Anything will burn");
        
    }
    
    public override void SetDefaults()
    {

        Item.buyPrice(0, 12, 24, 43);
        Item.sellPrice(0, 4, 27, 45);
        Item.rare = ItemRarityID.Orange;
        Item.UseSound = SoundID.Item1;

        Item.autoReuse = false;
        Item.accessory = true;
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

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.GetModPlayer<GlobalPlayer>().SparkleofFireflies = true;
        player.AddBuff(ModContent.BuffType<Effects.Buffs.SparkleofFireflies>(), 1, false, false);
        
    }

}