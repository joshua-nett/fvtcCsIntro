using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * FIXIT: Redo this entire implementation
 * This is not ready for production DO NOT USE
 * I do not know what errors it will cause
 */

namespace JN.ControlsLibrary.Controls
{
    public class EnhancedTextbox : TextBox
    {
        [Category("Appearance")]
        public Color BorderTopColor { get; set; } = Color.White;
        [Category("Appearance")]
        public Color BorderBottomColor { get; set; } = Color.White;
        [Category("Appearance")]
        public int BorderWidth { get; set; } = 0;
        [Category("Appearance"), Description("May not work if changed dynamically, use discretion.")]
        public bool HasBackground { get; set; } = true; // May not apply if changed at runtime

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override bool DoubleBuffered { get => false; set { } }


        public EnhancedTextbox()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (!HasBackground)
                    cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT: Makes other controls render first
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pe)
        {
            if (!HasBackground)
            {
                return;
            }
            base.OnPaintBackground(pe);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            ControlPaint.DrawBorder(
                pe.Graphics,
                ClientRectangle,
                BorderTopColor, BorderWidth, ButtonBorderStyle.Solid,
                BorderTopColor, BorderWidth, ButtonBorderStyle.Solid,
                BorderBottomColor, BorderWidth, ButtonBorderStyle.Solid,
                BorderBottomColor, BorderWidth, ButtonBorderStyle.Solid
                );
        }
    }
}
