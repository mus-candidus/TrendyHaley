using Microsoft.Xna.Framework;


namespace TrendyHaley.Framework {
    internal class ConfigEntry {
        /// <summary>Haley's current hair color.</summary>
        public Color HairColor { get; set; } = Color.Transparent;

        /// <summary>Indicates whether the color fades away until the end of season.</summary>
        public bool ColorIsFading { get; set; } = true;

        /// <summary>Use alpha blending so Haley becomes blonde again during the season.</summary>
        public bool AlphaBlend { get; set; } = false;

        /// <summary>Indicates whether Haley's spouse has the same hair color.</summary>
        public bool SpouseLookAlike { get; set; } = false;
    }
}
