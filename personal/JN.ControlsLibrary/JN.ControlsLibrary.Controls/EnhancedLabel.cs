using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;
using JN.ControlsLibrary.Controls.Internal;

// TODO: More and Better comments and documentation

namespace JN.ControlsLibrary.Controls
{
    public class EnhancedLabel : Label
    {
        // The stuff in square brackets is for how the properties show up in the properties panel
        // Add 3D Border properties to properties (BorderConfig from Internal/Common.cs)
        [
            DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
            Category("Appearance"),
            DisplayName("3D Border"),
            Description("3D Border reimplementation with more customization options.")
        ]
        public BorderConfig Border3D { get; set; } = new BorderConfig();
        // Add Transparency toggle to properties
        [
            Category("Appearance"),
            DisplayName("Transparent Background"),
            Description("May not work as intended if changed dynamically, use with discretion.")
        ]
        public bool TransparentBackground { get; set; } = false;

        // We disable double buffering because transparency causes a lot
        // of issues with it like streaking and things.
        // Disable DoubleBuffered property and make it only return false
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        protected override bool DoubleBuffered { get => false; set { } }

        public EnhancedLabel()
        {
            // Ensure double buffering is disabled
            SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
        }

        // Adding transparency flags/params
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // Add transparent parameter if the background is transparent
                if (TransparentBackground) cp = Common.AddTransparentParam(cp);
                return cp;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            // For context "Invalidate" causes a redraw/rerender of a specific control and/or area
            if (TransparentBackground)
            {
                // If we have a transparent background find the form we're a part of
                Form frmParent = FindForm();
                // Make sure we could find the form and that it's ready if so invalidate our area/bounds
                if (frmParent != null && frmParent.IsHandleCreated)
                {
                    frmParent.Invalidate(Bounds, true);
                }
            }
            // Invalidate ourselves just in case and for if we don't have transparency then end by redirecting to base behaviobur
            Invalidate();
            base.OnTextChanged(e);
        }

        protected override void OnPaintBackground(PaintEventArgs pe)
        {
            // Cancel background painting if transparent
            if (TransparentBackground) return;
            base.OnPaintBackground(pe);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Let base/inherited paint call do it's thing
            base.OnPaint(pe);
            // If Border3D is enabled draw it
            // Doing after base so it appears on top of the base.
            if (Border3D.Enabled)
            {
                Common.DrawCustomBorder3D(
                    pe.Graphics,
                    ClientRectangle,
                    Border3D.Colors.Top,
                    Border3D.Colors.Bottom,
                    Border3D.Colors.InnerRim,
                    Border3D.Colors.OuterRim,
                    Border3D.Width,
                    Border3D.RimRatio
                );
            }
        }
    }
}
