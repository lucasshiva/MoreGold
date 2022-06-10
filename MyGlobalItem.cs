using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreGold
{
    internal class MyGlobalItem : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
			// Do nothing if it's not a treasure bag.
			if (context != "bossBag")
				return;

			// Do nothing if `IncludeBosses` is false.
			var config = ModContent.GetInstance<Config>();
			if (!config.IncludeBosses)
				return;

			// Vanilla treasure bags.
			int bossID = -1;
			if (arg == 3318)
				bossID = 50;

			if (arg == 3319)
				bossID = 4;

			if (arg == 3320)
				bossID = 13;

			if (arg == 3321)
				bossID = 266;

			if (arg == 3322)
				bossID = 222;

			if (arg == 3323)
				bossID = 35;

			if (arg == 3324)
				bossID = 113;

			if (arg == 3325)
				bossID = 134;

			if (arg == 3326)
				bossID = 125;

			if (arg == 3327)
				bossID = 127;

			if (arg == 3328)
				bossID = 262;

			if (arg == 3329)
				bossID = 245;

			if (arg == 3330)
				bossID = 370;

			if (arg == 3331)
				bossID = 439;

			if (arg == 3332)
				bossID = 398;

			if (arg == 3860)
				bossID = 551;

			if (arg == 3861)
				bossID = 576;

			if (arg == 3862)
				bossID = 564;

			if (arg == 4782)
				bossID = 636;

			if (arg == 4957)
				bossID = 657;

			if (arg == 5111)
				bossID = 668;

			// For modded treasure bags.
			ItemLoader.OpenBossBag(arg, player, ref bossID);

			// We construct a new NPC (just like the source code does), which lets us access its value.
			var npc = ContentSamples.NpcsByNetId[bossID];

			// Then, we subtract `npc.value`, as the default `npc.value` is already included in the treasure bag.
			float value = (npc.value * config.GoldRate) - npc.value;

			// Finally, we spawn the extra coins.
			var entitySource = player.GetSource_OpenItem(arg);
			while ((int)value > 0)
			{
				if (value > 1000000f)
				{
					int num12 = (int)(value / 1000000f);
					value -= (float)(1000000 * num12);
					player.QuickSpawnItem(entitySource, ItemID.PlatinumCoin, num12);
					continue;
				}

				if (value > 10000f)
				{
					int num13 = (int)(value / 10000f);
					value -= (float)(10000 * num13);
					player.QuickSpawnItem(entitySource, ItemID.GoldCoin, num13);
					continue;
				}

				if (value > 100f)
				{
					int num14 = (int)(value / 100f);
					value -= (float)(100 * num14);
					player.QuickSpawnItem(entitySource, ItemID.SilverCoin, num14);
					continue;
				}

				int num15 = (int)value;
				if (num15 < 1)
					num15 = 1;

				value -= (float)num15;
				player.QuickSpawnItem(entitySource, ItemID.CopperCoin, num15);
			}
        }
    }
}
