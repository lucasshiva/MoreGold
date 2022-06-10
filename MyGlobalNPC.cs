using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;

namespace MoreGold
{
    public class MyGlobalNPC : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            var config = ModContent.GetInstance<Config>();

            if ((config.IncludeBosses && npc.boss) || (config.IncludeEnemies && !npc.boss))
                npc.value *= config.GoldRate;

            base.OnKill(npc);
        }
    }
}
