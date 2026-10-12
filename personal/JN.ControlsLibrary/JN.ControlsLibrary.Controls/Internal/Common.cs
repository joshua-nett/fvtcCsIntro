using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JN.ControlsLibrary.Controls.Internal
{
    internal static class Common
    {
        public static void DrawCustomBorder3D(
            Graphics graphics, Rectangle clientRect,
            Color topColor, Color bottomColor, Color innerRimColor, Color outerRimColor,
            int width = 3, int rimRatio = 2
            )
        {
            int rimWidth = width / rimRatio;
            // Main border
            ControlPaint.DrawBorder(
                graphics, clientRect,
                topColor, width, ButtonBorderStyle.Solid,
                topColor, width, ButtonBorderStyle.Solid,
                bottomColor, width, ButtonBorderStyle.Solid,
                bottomColor, width, ButtonBorderStyle.Solid
                );
            // Outer rim
            ControlPaint.DrawBorder(
                graphics, clientRect,
                Color.Black, 0, ButtonBorderStyle.None,
                Color.Black, 0, ButtonBorderStyle.None,
                outerRimColor, rimWidth, ButtonBorderStyle.Solid,
                outerRimColor, rimWidth, ButtonBorderStyle.Solid
                );
            // Inner rim
            ControlPaint.DrawBorder(
                graphics, Rectangle.Inflate(clientRect, -width, -width),
                innerRimColor, rimWidth, ButtonBorderStyle.Solid,
                innerRimColor, rimWidth, ButtonBorderStyle.Solid,
                innerRimColor, rimWidth, ButtonBorderStyle.Solid,
                Color.Black, 0, ButtonBorderStyle.None
                );
            return;
        }
        public static CreateParams AddTransparentParam(CreateParams cp)
        {
            cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT: Forces parent/underlying controls to paint first
            return cp;
        }
    }
}
