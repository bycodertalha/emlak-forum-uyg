using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlak_forum_uyg
{
    public partial class Emlak_Defteri : Form
    {
        public Emlak_Defteri()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sorgu form3 = new sorgu();
            form3.Show();
        }
    }
}
