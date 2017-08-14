using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace choco_ngin
{
    public partial class frmUnwrap : Form
    {
        Point loc = new Point(7, 6);
        bool complete=false;
        int next_count = 0;

        public void print(string str)
        {
            txbxPrint.Text += str + "\r\n";
        }
        public void pgbarchange(object sender, DownloadProgressChangedEventArgs e)
        {
            pgbar.Value = e.ProgressPercentage;
        }


        public void donwloadcomplete(object sender, AsyncCompletedEventArgs e)
        {
            print("완료!");
            complete = true;
            if (next_count <= 0)
            {
                progress_download(++next_count);
                return;
            }
            return;
        }
        public void download_case(int i) 
        {
            classDownload download = new classDownload();
            download.install = i;
            download.Download(this);
            complete = false;
        }
        public void progress_main()
        {
            
        }
        public void progress_download(int i)
        {
            switch(i)
            {
                case 0:
                    print("NginX 다운로드중....");
                    break;
                case 1:
                    print("PHP 다운로드중....");
                    break;
            }
            download_case(i);
        }
        public frmUnwrap()
        {
            InitializeComponent();
        }

        private void frmUnwrap_Load(object sender, EventArgs e)
        {
            this.Size = new Size(644, 324);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelMain.Location = loc;
            print("시작중...");
            progress_download(0);
        }
    }
}
