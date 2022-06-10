using Terraria;
using Terraria.ModLoader;

namespace MoreGold
{
    public class MyGlobalNPC : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            var config = ModContent.GetInstance<Config>();
            if (npc.value > 0)
                npc.value *= config.GoldRate;

            base.OnKill(npc);
        }
    }
}
