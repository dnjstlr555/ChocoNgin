namespace choco_ngin
{
    partial class frmInstall
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstall));
            this.labelChoco = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelContinue = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelPrevious = new System.Windows.Forms.Label();
            this.picPrevious = new System.Windows.Forms.PictureBox();
            this.panelDesc = new System.Windows.Forms.Panel();
            this.richtxtDesc = new System.Windows.Forms.RichTextBox();
            this.picChoco = new System.Windows.Forms.PictureBox();
            this.picContinueBtn = new System.Windows.Forms.PictureBox();
            this.panelStart = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.picContinueLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelchocologo = new System.Windows.Forms.Label();
            this.picmainchoco = new System.Windows.Forms.PictureBox();
            this.panelinstallselect = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAdvance = new System.Windows.Forms.Label();
            this.labelDescInstall = new System.Windows.Forms.Label();
            this.labelChocoinstall = new System.Windows.Forms.Label();
            this.picKitty = new System.Windows.Forms.PictureBox();
            this.picAdvance = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).BeginInit();
            this.panelDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChoco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContinueBtn)).BeginInit();
            this.panelStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContinueLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmainchoco)).BeginInit();
            this.panelinstallselect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKitty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvance)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChoco
            // 
            this.labelChoco.AutoSize = true;
            this.labelChoco.Font = new System.Drawing.Font("맑은 고딕 Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelChoco.Location = new System.Drawing.Point(3, 3);
            this.labelChoco.Name = "labelChoco";
            this.labelChoco.Size = new System.Drawing.Size(206, 50);
            this.labelChoco.TabIndex = 1;
            this.labelChoco.Text = "ChocoNgin";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDesc.Location = new System.Drawing.Point(8, 55);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(334, 20);
            this.labelDesc.TabIndex = 2;
            this.labelDesc.Text = "초코엔진의 설치를 위해 계속 버튼을 클릭하세요";
            // 
            // labelContinue
            // 
            this.labelContinue.AutoSize = true;
            this.labelContinue.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelContinue.Location = new System.Drawing.Point(298, 245);
            this.labelContinue.Name = "labelContinue";
            this.labelContinue.Size = new System.Drawing.Size(39, 20);
            this.labelContinue.TabIndex = 4;
            this.labelContinue.Text = "계속";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelPrevious);
            this.panelMain.Controls.Add(this.picPrevious);
            this.panelMain.Controls.Add(this.panelDesc);
            this.panelMain.Controls.Add(this.picChoco);
            this.panelMain.Controls.Add(this.labelContinue);
            this.panelMain.Controls.Add(this.labelChoco);
            this.panelMain.Controls.Add(this.picContinueBtn);
            this.panelMain.Controls.Add(this.labelDesc);
            this.panelMain.Location = new System.Drawing.Point(7, 6);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(614, 271);
            this.panelMain.TabIndex = 5;
            // 
            // labelPrevious
            // 
            this.labelPrevious.AutoSize = true;
            this.labelPrevious.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPrevious.Location = new System.Drawing.Point(252, 245);
            this.labelPrevious.Name = "labelPrevious";
            this.labelPrevious.Size = new System.Drawing.Size(39, 20);
            this.labelPrevious.TabIndex = 9;
            this.labelPrevious.Text = "뒤로";
            // 
            // picPrevious
            // 
            this.picPrevious.Image = global::choco_ngin.Properties.Resources.noun_103629_cc;
            this.picPrevious.Location = new System.Drawing.Point(251, 202);
            this.picPrevious.Name = "picPrevious";
            this.picPrevious.Size = new System.Drawing.Size(40, 40);
            this.picPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPrevious.TabIndex = 8;
            this.picPrevious.TabStop = false;
            this.picPrevious.Click += new System.EventHandler(this.picPrevious_Click);
            // 
            // panelDesc
            // 
            this.panelDesc.Controls.Add(this.richtxtDesc);
            this.panelDesc.Location = new System.Drawing.Point(5, 78);
            this.panelDesc.Name = "panelDesc";
            this.panelDesc.Size = new System.Drawing.Size(345, 118);
            this.panelDesc.TabIndex = 7;
            // 
            // richtxtDesc
            // 
            this.richtxtDesc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richtxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtDesc.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.richtxtDesc.Location = new System.Drawing.Point(7, 0);
            this.richtxtDesc.Name = "richtxtDesc";
            this.richtxtDesc.ReadOnly = true;
            this.richtxtDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richtxtDesc.Size = new System.Drawing.Size(332, 118);
            this.richtxtDesc.TabIndex = 6;
            this.richtxtDesc.Text = resources.GetString("richtxtDesc.Text");
            // 
            // picChoco
            // 
            this.picChoco.ErrorImage = null;
            this.picChoco.Image = global::choco_ngin.Properties.Resources.noun_850576_cc;
            this.picChoco.InitialImage = null;
            this.picChoco.Location = new System.Drawing.Point(356, 7);
            this.picChoco.Name = "picChoco";
            this.picChoco.Size = new System.Drawing.Size(256, 256);
            this.picChoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picChoco.TabIndex = 0;
            this.picChoco.TabStop = false;
            // 
            // picContinueBtn
            // 
            this.picContinueBtn.Image = global::choco_ngin.Properties.Resources.noun_103629_cc;
            this.picContinueBtn.Location = new System.Drawing.Point(297, 202);
            this.picContinueBtn.Name = "picContinueBtn";
            this.picContinueBtn.Size = new System.Drawing.Size(40, 40);
            this.picContinueBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContinueBtn.TabIndex = 3;
            this.picContinueBtn.TabStop = false;
            this.picContinueBtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.label2);
            this.panelStart.Controls.Add(this.picContinueLogo);
            this.panelStart.Controls.Add(this.label1);
            this.panelStart.Controls.Add(this.labelchocologo);
            this.panelStart.Controls.Add(this.picmainchoco);
            this.panelStart.Location = new System.Drawing.Point(5, 283);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(614, 271);
            this.panelStart.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(283, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "계속";
            // 
            // picContinueLogo
            // 
            this.picContinueLogo.Image = global::choco_ngin.Properties.Resources.noun_103629_cc;
            this.picContinueLogo.Location = new System.Drawing.Point(282, 207);
            this.picContinueLogo.Name = "picContinueLogo";
            this.picContinueLogo.Size = new System.Drawing.Size(40, 40);
            this.picContinueLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContinueLogo.TabIndex = 5;
            this.picContinueLogo.TabStop = false;
            this.picContinueLogo.Click += new System.EventHandler(this.picContinueLogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(140, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "초코엔진의 설치를 위해 계속 버튼을 클릭하세요";
            // 
            // labelchocologo
            // 
            this.labelchocologo.AutoSize = true;
            this.labelchocologo.Font = new System.Drawing.Font("맑은 고딕 Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelchocologo.Location = new System.Drawing.Point(197, 134);
            this.labelchocologo.Name = "labelchocologo";
            this.labelchocologo.Size = new System.Drawing.Size(206, 50);
            this.labelchocologo.TabIndex = 2;
            this.labelchocologo.Text = "ChocoNgin";
            // 
            // picmainchoco
            // 
            this.picmainchoco.ErrorImage = null;
            this.picmainchoco.Image = global::choco_ngin.Properties.Resources.noun_850576_cc;
            this.picmainchoco.InitialImage = null;
            this.picmainchoco.Location = new System.Drawing.Point(237, 3);
            this.picmainchoco.Name = "picmainchoco";
            this.picmainchoco.Size = new System.Drawing.Size(128, 128);
            this.picmainchoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picmainchoco.TabIndex = 1;
            this.picmainchoco.TabStop = false;
            // 
            // panelinstallselect
            // 
            this.panelinstallselect.Controls.Add(this.label3);
            this.panelinstallselect.Controls.Add(this.labelAdvance);
            this.panelinstallselect.Controls.Add(this.labelDescInstall);
            this.panelinstallselect.Controls.Add(this.labelChocoinstall);
            this.panelinstallselect.Controls.Add(this.picKitty);
            this.panelinstallselect.Controls.Add(this.picAdvance);
            this.panelinstallselect.Location = new System.Drawing.Point(5, 560);
            this.panelinstallselect.Name = "panelinstallselect";
            this.panelinstallselect.Size = new System.Drawing.Size(614, 271);
            this.panelinstallselect.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "알아서 설치\r\n(대부분 권장)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAdvance
            // 
            this.labelAdvance.AutoSize = true;
            this.labelAdvance.Location = new System.Drawing.Point(178, 218);
            this.labelAdvance.Name = "labelAdvance";
            this.labelAdvance.Size = new System.Drawing.Size(112, 34);
            this.labelAdvance.TabIndex = 5;
            this.labelAdvance.Text = "내맘대로 설치\r\n(전문가에게 권장)";
            this.labelAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescInstall
            // 
            this.labelDescInstall.AutoSize = true;
            this.labelDescInstall.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDescInstall.Location = new System.Drawing.Point(174, 53);
            this.labelDescInstall.Name = "labelDescInstall";
            this.labelDescInstall.Size = new System.Drawing.Size(249, 20);
            this.labelDescInstall.TabIndex = 4;
            this.labelDescInstall.Text = "초코엔진의 설치 방법을 선택하세요";
            // 
            // labelChocoinstall
            // 
            this.labelChocoinstall.AutoSize = true;
            this.labelChocoinstall.Font = new System.Drawing.Font("맑은 고딕 Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelChocoinstall.Location = new System.Drawing.Point(196, 3);
            this.labelChocoinstall.Name = "labelChocoinstall";
            this.labelChocoinstall.Size = new System.Drawing.Size(206, 50);
            this.labelChocoinstall.TabIndex = 3;
            this.labelChocoinstall.Text = "ChocoNgin";
            // 
            // picKitty
            // 
            this.picKitty.Image = global::choco_ngin.Properties.Resources.noun_753254_cc;
            this.picKitty.Location = new System.Drawing.Point(304, 99);
            this.picKitty.Name = "picKitty";
            this.picKitty.Size = new System.Drawing.Size(116, 116);
            this.picKitty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKitty.TabIndex = 1;
            this.picKitty.TabStop = false;
            // 
            // picAdvance
            // 
            this.picAdvance.Image = global::choco_ngin.Properties.Resources.noun_2402;
            this.picAdvance.Location = new System.Drawing.Point(177, 99);
            this.picAdvance.Name = "picAdvance";
            this.picAdvance.Size = new System.Drawing.Size(116, 116);
            this.picAdvance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdvance.TabIndex = 0;
            this.picAdvance.TabStop = false;
            this.picAdvance.Click += new System.EventHandler(this.picAdvance_Click);
            // 
            // frmInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(628, 838);
            this.Controls.Add(this.panelinstallselect);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInstall";
            this.Text = "ChocoNgin 설치";
            this.Load += new System.EventHandler(this.frmInstall_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).EndInit();
            this.panelDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChoco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContinueBtn)).EndInit();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContinueLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picmainchoco)).EndInit();
            this.panelinstallselect.ResumeLayout(false);
            this.panelinstallselect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKitty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picChoco;
        private System.Windows.Forms.Label labelChoco;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.PictureBox picContinueBtn;
        private System.Windows.Forms.Label labelContinue;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.RichTextBox richtxtDesc;
        private System.Windows.Forms.Panel panelDesc;
        private System.Windows.Forms.Label labelPrevious;
        private System.Windows.Forms.PictureBox picPrevious;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picContinueLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelchocologo;
        private System.Windows.Forms.PictureBox picmainchoco;
        private System.Windows.Forms.Panel panelinstallselect;
        private System.Windows.Forms.PictureBox picKitty;
        private System.Windows.Forms.PictureBox picAdvance;
        private System.Windows.Forms.Label labelDescInstall;
        private System.Windows.Forms.Label labelChocoinstall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAdvance;
    }
}

