using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MoreGold
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Rate")]
        [Tooltip("Multiply the gold dropped by the rate.")]
        [DefaultValue(2f)]
        [Range(1, 10)]
        [Slider]
        public int GoldRate;

        [Label("Enemies")]
        [Tooltip("Increase the gold dropped from normal enemies.")]
        [DefaultValue(true)]
        public bool IncludeEnemies;

        [Label("Bosses")]
        [Tooltip("Increase the gold dropped from bosses. In expert worlds, this increases the gold gained from opening treasure bags.")]
        [DefaultValue(true)]
        public bool IncludeBosses;
    }
}
