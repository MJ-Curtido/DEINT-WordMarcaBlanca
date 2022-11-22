using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_WordMarcaBlanca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.Text[this.Text.Length].Equals("*"))
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea salir? Se perderá todo el proceso de ésta.", "Salir de WordMarcaBlanca", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (this.Text[this.Text.Length].Equals("*"))
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea crear una nueva pestaña? Se perderá todo el proceso de ésta.", "Nueva pestaña", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tb.Text = "";
                }
            }

            menuEdicion.Enabled = true;
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            tb.Select();
            tb.Cut();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            tb.Select();
            tb.Copy();
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            tb.Paste();
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            /*
            if (ventanaFuentes.ShowDialog = ventanaFuentes.)
            {

            }
            */
        }
    }
}
