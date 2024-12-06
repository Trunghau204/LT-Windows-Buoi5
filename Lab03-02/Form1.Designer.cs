namespace Lab03_02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createText = new System.Windows.Forms.ToolStripMenuItem();
            this.openText = new System.Windows.Forms.ToolStripMenuItem();
            this.saveText = new System.Windows.Forms.ToolStripMenuItem();
            this.exitText = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createText2 = new System.Windows.Forms.ToolStripButton();
            this.saveText2 = new System.Windows.Forms.ToolStripButton();
            this.cmbFonts = new System.Windows.Forms.ToolStripComboBox();
            this.cmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolBold = new System.Windows.Forms.ToolStripButton();
            this.toolItalic = new System.Windows.Forms.ToolStripButton();
            this.toolUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệToolStripMenuItem
            // 
            this.hệToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createText,
            this.openText,
            this.saveText,
            this.exitText});
            this.hệToolStripMenuItem.Name = "hệToolStripMenuItem";
            this.hệToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệToolStripMenuItem.Text = "Hệ thống";
            // 
            // createText
            // 
            this.createText.Image = global::Lab03_02.Properties.Resources.Screenshot_2024_12_06_102900;
            this.createText.Name = "createText";
            this.createText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createText.Size = new System.Drawing.Size(285, 26);
            this.createText.Text = "Tạo văn bản mới";
            this.createText.Click += new System.EventHandler(this.tạoToolStripMenuItem_Click);
            // 
            // openText
            // 
            this.openText.Image = global::Lab03_02.Properties.Resources.Screenshot_2024_12_06_103036;
            this.openText.Name = "openText";
            this.openText.Size = new System.Drawing.Size(285, 26);
            this.openText.Text = "Mở tập tin";
            this.openText.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
            // 
            // saveText
            // 
            this.saveText.Image = global::Lab03_02.Properties.Resources.Screenshot_2024_12_06_102947;
            this.saveText.Name = "saveText";
            this.saveText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveText.Size = new System.Drawing.Size(285, 26);
            this.saveText.Text = "Lưu nội dung văn bản";
            this.saveText.Click += new System.EventHandler(this.lưuNộiDungVănBảnToolStripMenuItem_Click);
            // 
            // exitText
            // 
            this.exitText.Name = "exitText";
            this.exitText.Size = new System.Drawing.Size(285, 26);
            this.exitText.Text = "Thoát";
            this.exitText.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.địnhDạngToolStripMenuItem.Text = "Định dạng ";
            this.địnhDạngToolStripMenuItem.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createText2,
            this.saveText2,
            this.cmbFonts,
            this.cmbSize,
            this.toolBold,
            this.toolItalic,
            this.toolUnderline,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createText2
            // 
            this.createText2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createText2.Image = global::Lab03_02.Properties.Resources.Screenshot_2024_12_06_102900;
            this.createText2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createText2.Name = "createText2";
            this.createText2.Size = new System.Drawing.Size(29, 28);
            this.createText2.Text = "toolStripButton1";
            this.createText2.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // saveText2
            // 
            this.saveText2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveText2.Image = global::Lab03_02.Properties.Resources.Screenshot_2024_12_06_102947;
            this.saveText2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveText2.Name = "saveText2";
            this.saveText2.Size = new System.Drawing.Size(29, 28);
            this.saveText2.Text = "toolStripButton2";
            this.saveText2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbFonts
            // 
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new System.Drawing.Size(121, 31);
            this.cmbFonts.SelectedIndexChanged += new System.EventHandler(this.cmbFonts_Click);
            // 
            // cmbSize
            // 
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 31);
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_Click);
            // 
            // toolBold
            // 
            this.toolBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBold.Image = global::Lab03_02.Properties.Resources.Screenshot_2024_12_06_103126;
            this.toolBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBold.Name = "toolBold";
            this.toolBold.Size = new System.Drawing.Size(29, 28);
            this.toolBold.Text = "toolStripButton3";
            this.toolBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // toolItalic
            // 
            this.toolItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolItalic.Image = global::Lab03_02.Properties.Resources.Screenshot_2024_12_06_103146;
            this.toolItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolItalic.Name = "toolItalic";
            this.toolItalic.Size = new System.Drawing.Size(29, 28);
            this.toolItalic.Text = "toolStripButton4";
            this.toolItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // toolUnderline
            // 
            this.toolUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUnderline.Image = global::Lab03_02.Properties.Resources.Screenshot_2024_12_06_103207;
            this.toolUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUnderline.Name = "toolUnderline";
            this.toolUnderline.Size = new System.Drawing.Size(29, 28);
            this.toolUnderline.Text = "toolStripButton5";
            this.toolUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 28);
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(0, 62);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(786, 379);
            this.richText.TabIndex = 2;
            this.richText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soạn thảo văn bản ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton createText2;
        private System.Windows.Forms.ToolStripButton saveText2;
        private System.Windows.Forms.ToolStripComboBox cmbFonts;
        private System.Windows.Forms.ToolStripComboBox cmbSize;
        private System.Windows.Forms.ToolStripButton toolBold;
        private System.Windows.Forms.ToolStripButton toolItalic;
        private System.Windows.Forms.ToolStripButton toolUnderline;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.ToolStripMenuItem createText;
        private System.Windows.Forms.ToolStripMenuItem openText;
        private System.Windows.Forms.ToolStripMenuItem saveText;
        private System.Windows.Forms.ToolStripMenuItem exitText;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

