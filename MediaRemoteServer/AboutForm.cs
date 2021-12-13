using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaRemote
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            var type = Assembly.GetExecutingAssembly().GetType("Builtin");
            lblBuid.Text = (string)type.GetField("CompileTime").GetValue(null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
