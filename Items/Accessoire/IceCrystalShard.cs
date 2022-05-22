using ShinyMaterial.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShinyMaterial.Items.Accessoire;

public class IceCrystalShard : ModItem
{
    
    public override void SetStaticDefaults() {
        
        DisplayName.SetDefault("Ice Crystal Shard");
        Tooltip.SetDefault("Make Enemies Frosty");
        
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
        recipe.AddIngredient(ItemID.IceBlock, 155);
        recipe.AddIngredient(ItemID.Bottle, 1);
        recipe.AddTile(TileID.TinkerersWorkbench);
        recipe.Register();
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.GetModPlayer<GlobalPlayer>().IceCrystalShard = true;
    }
    
}