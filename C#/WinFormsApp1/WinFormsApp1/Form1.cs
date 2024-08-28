namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void protudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form2 j1 = new Form2();
                j1.Show();
                j1.MdiParent = this;
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
