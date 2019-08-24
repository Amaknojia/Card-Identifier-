using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card_identifier
{
    public partial class frmCardIdentifier : Form
    {
        public frmCardIdentifier()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblDisplayCardName.Text = "King of Diamonds";
        }

        private void frmCardIdentifier_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblDisplayCardName.Text = "Ace of Hearts"; 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblDisplayCardName.Text = "Eight of Hearts";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblDisplayCardName.Text = "Ten of Diamonds";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lblDisplayCardName.Text = "Queen of Hearts";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
