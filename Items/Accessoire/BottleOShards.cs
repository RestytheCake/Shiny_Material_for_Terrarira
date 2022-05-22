using ShinyMaterial.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShinyMaterial.Items.Accessoire;

public class BottleOShards : ModItem
{
    
    public override void SetStaticDefaults() {
        
        DisplayName.SetDefault("Bottle o' Shards");
        Tooltip.SetDefault("Pure Frost from Icy Shards");
        
    }
    
    public override void SetDefaults()
    {

        Item.buyPrice(0, 12, 24, 43);
        Item.sellPrice(0, 4, 27, 45);
        Item.rare = ItemRarityID.Cyan;
        Item.UseSound = SoundID.Item1;

        Item.autoReuse = false;
        Item.accessory = true;
    }

    public override void AddRecipes()
    {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.CrystalShard, 25);
        recipe.AddIngredient(ItemID.LunarBar, 1);
        recipe.AddIngredient(ItemID.Bottle, 1);
        recipe.AddTile(TileID.WorkBenches);
        recipe.Register();
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.GetModPlayer<GlobalPlayer>().BottleOShards = true;
    }
    
}