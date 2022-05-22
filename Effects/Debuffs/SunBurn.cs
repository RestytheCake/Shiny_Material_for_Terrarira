using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ShinyMaterial.Effects.Debuffs;
public class SunBurn : ModBuff {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sun Burn");
            Description.SetDefault("You're burning really hot");
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.lifeRegen -= 50;
            Dust.NewDust(npc.position, npc.width, npc.height, DustID.FlameBurst, 0f, 0f, 0, Color.GreenYellow);

        }
    

    }
