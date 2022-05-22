using System;
using Microsoft.Xna.Framework;
using ShinyMaterial.Effects.Debuffs;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ShinyMaterial.Global;

public class GlobalPlayer : ModPlayer
{
    public bool SparkleofFireflies = false;
    public bool BottleOShards = false;

    public override void PostUpdate()
    {
    }
    

    public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
    {
        if (SparkleofFireflies == true)
        {
            target.AddBuff(ModContent.BuffType<SunBurn>(), 300, false);
        }

        if (BottleOShards == true)
        {
            target.AddBuff(BuffID.Frostburn, 300, false);
        }
    }
}