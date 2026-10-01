namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rich Text Format|*.rtf|Text Files|*.txt|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (System.IO.Path.GetExtension(openFileDialog1.FileName).ToLower() == ".rtf")
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    else
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file: " + ex.Message);
                }
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Format|*.rtf|Text Files|*.txt|All Files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (System.IO.Path.GetExtension(saveFileDialog1.FileName).ToLower() == ".rtf")
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    else
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Font_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont ?? richTextBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void ToggleBold_Click(object sender, EventArgs e)
        {
            ToggleStyle(System.Drawing.FontStyle.Bold, tsBold.Checked);
        }

        private void ToggleItalic_Click(object sender, EventArgs e)
        {
            ToggleStyle(System.Drawing.FontStyle.Italic, tsItalic.Checked);
        }

        private void ToggleUnderline_Click(object sender, EventArgs e)
        {
            ToggleStyle(System.Drawing.FontStyle.Underline, tsUnderline.Checked);
        }

        private void ToggleStyle(System.Drawing.FontStyle style, bool enable)
        {
            var selFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            System.Drawing.FontStyle newStyle = selFont.Style;
            if (enable)
                newStyle |= style;
            else
                newStyle &= ~style;
            richTextBox1.SelectionFont = new System.Drawing.Font(selFont, newStyle);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var text = richTextBox1.Text;
            int wordCount = 0;
            if (!string.IsNullOrWhiteSpace(text))
            {
                var parts = text.Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount = parts.Length;
            }
            toolStripStatusLabel1.Text = "Words: " + wordCount;
        }

        private void FontCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var family = toolStripComboBoxFont.Text;
                float size = 12f;
                if (!string.IsNullOrWhiteSpace(toolStripComboBoxSize.Text))
                    float.TryParse(toolStripComboBoxSize.Text, out size);
                var selFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
                richTextBox1.SelectionFont = new System.Drawing.Font(family, size, selFont.Style);
            }
            catch { }
        }

        private void SizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var family = richTextBox1.SelectionFont?.FontFamily.Name ?? toolStripComboBoxFont.Text;
                float size = 12f;
                if (!string.IsNullOrWhiteSpace(toolStripComboBoxSize.Text))
                    float.TryParse(toolStripComboBoxSize.Text, out size);
                var selFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
                richTextBox1.SelectionFont = new System.Drawing.Font(family, size, selFont.Style);
            }
            catch { }
        }
    }
}
