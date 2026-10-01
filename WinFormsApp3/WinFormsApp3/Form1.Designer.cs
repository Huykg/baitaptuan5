namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Biến được designer yêu cầu.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Giải phóng mọi tài nguyên đang được sử dụng.
        /// </summary>
        /// <param name="disposing">true nếu các tài nguyên được quản lý cần được giải phóng; ngược lại false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Mã do Windows Form Designer sinh

        /// <summary>
        ///  Phương thức cần thiết cho hỗ trợ Designer - không sửa
        ///  nội dung phương thức này bằng trình chỉnh sửa mã.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsNew = new ToolStripButton();
            tsOpen = new ToolStripButton();
            tsSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsBold = new ToolStripButton();
            tsItalic = new ToolStripButton();
            tsUnderline = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsFont = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripComboBoxFont = new ToolStripComboBox();
            toolStripComboBoxSize = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(85, 24);
            systemToolStripMenuItem.Text = "Hệ thống";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(256, 26);
            newToolStripMenuItem.Text = "Tạo văn bản mới";
            newToolStripMenuItem.Click += NewFile_Click;
            // đặt biểu tượng nhỏ cho Tạo mới
            try { newToolStripMenuItem.Image = System.Drawing.SystemIcons.Application.ToBitmap(); } catch { }
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(256, 26);
            openToolStripMenuItem.Text = "Mở tập tin";
            openToolStripMenuItem.Click += OpenFile_Click;
            // đặt biểu tượng nhỏ cho Mở
            try { openToolStripMenuItem.Image = System.Drawing.SystemIcons.WinLogo.ToBitmap(); } catch { }
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(256, 26);
            saveToolStripMenuItem.Text = "Lưu tập tin";
            saveToolStripMenuItem.Click += SaveFile_Click;
            // đặt biểu tượng nhỏ cho Lưu
            try { saveToolStripMenuItem.Image = System.Drawing.SystemIcons.Shield.ToBitmap(); } catch { }
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(256, 26);
            exitToolStripMenuItem.Text = "Thoát";
            exitToolStripMenuItem.Click += Exit_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(92, 24);
            formatToolStripMenuItem.Text = "Định dạng";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(158, 26);
            fontToolStripMenuItem.Text = "Font...";
            fontToolStripMenuItem.Click += Font_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(158, 26);
            colorToolStripMenuItem.Text = "Màu chữ...";
            colorToolStripMenuItem.Click += Color_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsNew, tsOpen, tsSave, toolStripSeparator1, toolStripLabel1, toolStripComboBoxFont, toolStripComboBoxSize, toolStripSeparator3, tsBold, tsItalic, tsUnderline, toolStripSeparator2, tsFont });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            // 
            // tsNew
            // 
            tsNew.Name = "tsNew";
            tsNew.Size = new Size(43, 24);
            tsNew.Text = "New";
            tsNew.Click += NewFile_Click;
            // 
            // tsOpen
            // 
            tsOpen.Name = "tsOpen";
            tsOpen.Size = new Size(49, 24);
            tsOpen.Text = "Open";
            tsOpen.Click += OpenFile_Click;
            // 
            // tsSave
            // 
            tsSave.Name = "tsSave";
            tsSave.Size = new Size(44, 24);
            tsSave.Text = "Save";
            tsSave.Click += SaveFile_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tsBold
            // 
            tsBold.CheckOnClick = true;
            tsBold.Name = "tsBold";
            tsBold.Size = new Size(29, 24);
            tsBold.Text = "B";
            tsBold.Click += ToggleBold_Click;
            // 
            // tsItalic
            // 
            tsItalic.CheckOnClick = true;
            tsItalic.Name = "tsItalic";
            tsItalic.Size = new Size(29, 24);
            tsItalic.Text = "I";
            tsItalic.Click += ToggleItalic_Click;
            // 
            // tsUnderline
            // 
            tsUnderline.CheckOnClick = true;
            tsUnderline.Name = "tsUnderline";
            tsUnderline.Size = new Size(29, 24);
            tsUnderline.Text = "U";
            tsUnderline.Click += ToggleUnderline_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // tsFont
            // 
            tsFont.Name = "tsFont";
            tsFont.Size = new Size(42, 24);
            tsFont.Text = "Font";
            tsFont.Click += Font_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Text = "";
            // 
            // toolStripComboBoxFont
            // 
            toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            toolStripComboBoxFont.Size = new Size(200, 27);
            // populate font families
            for (int i = 0; i < FontFamily.Families.Length; i++)
            {
                FontFamily ff = System.Drawing.FontFamily.Families[i];
                try { toolStripComboBoxFont.Items.Add(ff.Name); } catch { }
            }
            toolStripComboBoxFont.Text = "Tahoma";
            toolStripComboBoxFont.SelectedIndexChanged += FontCombo_SelectedIndexChanged;
            // 
            // toolStripComboBoxSize
            // 
            toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            toolStripComboBoxSize.Size = new Size(75, 27);
            string[] sizes = new string[] { "8","9","10","11","12","14","16","18","20","22","24","26","28","36","48","72" };
            toolStripComboBoxSize.Items.AddRange(sizes);
            toolStripComboBoxSize.Text = "14";
            toolStripComboBoxSize.SelectedIndexChanged += SizeCombo_SelectedIndexChanged;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(0, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 363);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(66, 20);
            toolStripStatusLabel1.Text = "Words: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Soạn thảo văn bản";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsOpen;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFont;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBold;
        private System.Windows.Forms.ToolStripButton tsItalic;
        private System.Windows.Forms.ToolStripButton tsUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsFont;
    }
}
