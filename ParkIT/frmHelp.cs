using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParkIT
{
    public partial class frmHelp : Form
    {
        private int tbTop;
        public frmHelp()
        {
            InitializeComponent();
            tbTop = tbPreHelp.Location.Y;
            Program.lblTitle.Text = this.Text;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            tbPreHelp.Visible = true;
            tbPostHelp.Visible = false;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            tbPreHelp.Visible = false;
            tbPostHelp.Location = new Point(tbPostHelp.Location.X, tbTop+40);
            tbPostHelp.Visible = true;
        }
    }
}
