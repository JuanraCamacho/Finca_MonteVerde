using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finca_Monteverde
{
    public partial class frm_Homebase : Form
    {
        int WidthO = 0;
        public frm_Homebase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.pnl_nav.Size.Width > 62)
            {
                WidthO = this.pnl_nav.Size.Width;
                this.pnl_nav.Size = new Size(62, 608);
                this.pbarrow.Image = global::Finca_Monteverde.Properties.Resources.arrowright2;
            }
            else
            {
                this.pnl_nav.Size = new Size(WidthO, 608);
                this.pbarrow.Image = global::Finca_Monteverde.Properties.Resources.arrowleft;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frm_Homebase_Load(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.FromArgb(12, 94, 98);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
