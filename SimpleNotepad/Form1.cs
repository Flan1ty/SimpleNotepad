namespace SimpleNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK &&
                    openFileDialog1.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                        RichTextBoxStreamType.RichText);
                }
                catch (System.ArgumentException ex)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                        RichTextBoxStreamType.PlainText);
                }
                this.Text = "Τΰιλ[" + openFileDialog1.FileName + "]";
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}