using Duck.MediaRemote.Server.Properties;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server.Controls
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            Icon = Resources.icon_logo_ico;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
        }
    }
}
