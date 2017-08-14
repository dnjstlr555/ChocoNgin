using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace choco_ngin
{
    public partial class frmInstall : Form
    {
        int phase = 0;
        Point loc = new Point(7, 6);
        public frmInstall()
        {
            InitializeComponent();
        }
        private void process()
        {
            switch(phase)
            {
                case 0:
                    labelDesc.Text = "아래 설명을 읽고 계속 버튼을 누르세요";
                    return;
                case 1:
                    labelDesc.Text = "아래 라이선스를 읽고 계속 버튼을 누르세요";
                    return;
                case 2:
                    panelinstallselect.Location = loc;
                    panelMain.Visible = false;
                    panelMain.Enabled = false;
                    return;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            phase += 1;
            process();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmInstall_Load(object sender, EventArgs e)
        {
            panelStart.Location = loc;
            this.Size = new Size(644, 324);

        }

        private void picContinueLogo_Click(object sender, EventArgs e)
        {
            panelStart.Visible = false;
            panelStart.Enabled = false;
            process();
        }

        private void picPrevious_Click(object sender, EventArgs e)
        {
            phase -= 1;
            process();
        }

        private void picAdvance_Click(object sender, EventArgs e)
        {
            Form frmUnwrap = new frmUnwrap();
            frmUnwrap.Show();
            this.Visible = false;
        }
    }
}
