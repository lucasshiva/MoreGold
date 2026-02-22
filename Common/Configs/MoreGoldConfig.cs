using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MoreGold.Common.Configs
{
    public class MoreGoldConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("General")]
        [DefaultValue(2)]
        [Range(1, 25)]
        [Slider]
        [ReloadRequired]
        public int GoldMultiplierSlider;
    }
}
