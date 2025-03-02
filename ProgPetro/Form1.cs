using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgPetro
{
    public partial class Backbolivar : Form
    {
        public Backbolivar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btncorre_Click(object sender, EventArgs e)
        {
            TMRflash.Enabled = true;

        }

        private void Backbolivar_Load(object sender, EventArgs e)
        {

        }
        bool salto = true;

        int X = 0;
        private void TMRflash_Tick(object sender, EventArgs e)
        {
            imgPetro.Location = new Point(X, 12);

            if (salto)
            {
                X += 12;

            }
            else
            {
                X -= 12;



            }

            if (X >= this.Size.Width - imgPetro.Width)
            {
                salto = false;



            }

            if (X <= 10)
            {
                salto |= true;



            }
        }

    }
}
