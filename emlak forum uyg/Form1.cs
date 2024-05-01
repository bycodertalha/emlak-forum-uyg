namespace emlak_forum_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emlak_Defteri form2 = new Emlak_Defteri();
            form2.Show();
        }


    }
}