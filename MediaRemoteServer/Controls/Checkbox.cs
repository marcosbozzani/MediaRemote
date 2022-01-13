using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server.Controls
{
    [DesignerCategory("Code")]
    class CheckBox : System.Windows.Forms.CheckBox
    {
        [Browsable(false)]
        public override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = false; }
        }

        private int boxPadding = 3;
        public int BoxPadding
        {
            get { return boxPadding; }
            set
            {
                boxPadding = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush foreBrush = new SolidBrush(ForeColor))
            {
                var textSize = TextRenderer.MeasureText(Text, Font);
                var boxSize = new Size(textSize.Height, textSize.Height);
                var boxLocation = new Point(0, Height / 2 - boxSize.Height / 2);
                var textLocation = new Point(boxSize.Width + boxPadding, (Height / 2 - textSize.Height / 2));

                e.Graphics.Clear(BackColor);
                ControlPaint.DrawCheckBox(e.Graphics, new Rectangle(boxLocation, boxSize), GetButtonState());
                e.Graphics.DrawString(Text, Font, foreBrush, textLocation);
            }
        }

        private ButtonState GetButtonState()
        {
            return ButtonState.Flat | (Checked ? ButtonState.Checked : ButtonState.Normal);
        }
    }
}
