using System;
using System.ComponentModel;
using System.Drawing;

namespace JN.ControlsLibrary.Controls
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BorderColorConfig
    {
        [DisplayName("Top")]
        public Color Top { get; set; } = Color.DarkGray;
        [DisplayName("Bottom")]
        public Color Bottom { get; set; } = Color.Gray;
        [DisplayName("Inner Rim")]
        public Color InnerRim { get; set; } = Color.Black;
        [DisplayName("Outer Rim")]
        public Color OuterRim { get; set; } = Color.Silver;
        public override string ToString() // Text when collapsed
        {
            return $"T:{Top.ToString()}, B:{Bottom.ToString()}";
        }
    }
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BorderConfig
    {
        [DisplayName("Enabled")]
        public bool Enabled { get; set; } = false;
        [DisplayName("Width")]
        public int Width { get; set; } = 2;
        [
            DisplayName("Rim Ratio"),
            Description("Rim Ratio configures how much of the border width is replaced with rim ( Width / Ratio )")
        ]
        public int RimRatio { get; set; } = 2;
        [
            DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
            DisplayName("Colors")
        ]
        public BorderColorConfig Colors { get; set; }  = new BorderColorConfig();
        public override string ToString() // Text when collapsed
        {
            return $"Enabled {Enabled}, W{Width}";
        }
    }
}
