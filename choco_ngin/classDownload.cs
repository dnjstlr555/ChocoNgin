using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace choco_ngin
{
    class classDownload
    {
        public int install;     
        frmUnwrap form;
        public void Download(frmUnwrap frm)
        {
            this.form = frm;
            WebClient webClient = new WebClient();
            var url="";
            switch (install)
            {
                case 0: //nginx
                    url = "http://nginx.org/download/nginx-1.12.0.zip";
                    break;
                case 1: //php
                    url = "http://windows.php.net/downloads/releases/php-7.1.8-Win32-VC14-x86.zip";
                    break;
                case 2: //mysql
                    break;
            }
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(frm.donwloadcomplete);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(frm.pgbarchange);
            var loc = url.Substring(url.LastIndexOf("/") + 1, url.Length - url.LastIndexOf("/") - 1);
            if (!System.IO.Directory.Exists(@"download\"))
                System.IO.Directory.CreateDirectory(@"download\");
            webClient.DownloadFileAsync(new Uri(url), @"download\" + loc);
        }
    }
}
