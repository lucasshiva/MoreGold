using MoreGold.Common.Configs;
using Terraria;
using Terraria.ModLoader;

namespace MoreGold
{
    public class MoreGoldNpc : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            var config = ModContent.GetInstance<MoreGoldConfig>();
            npc.value *= config.GoldMultiplierSlider;
        }
    }
}
