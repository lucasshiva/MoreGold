using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MoreGold
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Rate")]
        [Tooltip("Multiply all gold dropped by an X amount.")]
        [DefaultValue(2f)]
        [Range(1, 10)]
        [Slider]
        public int GoldRate;
    }
}
