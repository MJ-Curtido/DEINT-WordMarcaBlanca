using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_WordMarcaBlanca
{
    public partial class Form1 : Form
    {
        private String ruta;

        public Form1()
        {
            InitializeComponent();

            this.ruta = "";
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.Text[this.Text.Length - 1].ToString().Equals("*"))
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea salir? Se perderá todo el proceso de ésta.", "Salir de WordMarcaBlanca", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (this.Text[this.Text.Length - 1].ToString().Equals("*"))
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea crear una nueva pestaña? Se perderá todo el proceso de ésta.", "Nueva pestaña", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.ruta = "";
                    tb.Text = "";
                }
            }
            else
            {
                this.ruta = "";
                tb.Text = "";
                tb.Enabled = true;
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
            if (ventanaFuentes.ShowDialog() == DialogResult.OK)
            {
                tb.SelectionFont = ventanaFuentes.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (ventanaColor.ShowDialog() == DialogResult.OK)
            {
                tb.SelectionColor = ventanaColor.Color;
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (!this.Text[this.Text.Length - 1].ToString().Equals("*"))
            {
                this.Text = this.Text + " *";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.Text[this.Text.Length - 1].ToString().Equals("*"))
            {
                if (this.ruta.Equals(""))
                {
                    Stream myStream;

                    ventanaGuardar.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    ventanaGuardar.FilterIndex = 2;
                    ventanaGuardar.RestoreDirectory = true;

                    if (ventanaGuardar.ShowDialog() == DialogResult.OK)
                    {
                        if ((myStream = ventanaGuardar.OpenFile()) != null)
                        {
                            this.ruta = ventanaGuardar.FileName;

                            myStream.Close();

                            if (Path.GetExtension(this.ruta).ToLower().Equals(".rtf"))
                            {
                                tb.SaveFile(ruta);
                            }
                            else
                            {
                                String texto = tb.Text;
                                File.Create(ruta);
                                File.WriteAllText(ruta, texto);
                            }

                            this.Text = this.Text.Substring(0, this.Text.Length - 2);
                        }
                    }
                }
                else
                {
                    if (Path.GetExtension(this.ruta).ToLower().Equals(".rtf"))
                    {
                        tb.SaveFile(ruta);
                    }
                    else
                    {
                        String texto = tb.Text;
                        File.WriteAllText(ruta, texto);
                    }
                    this.Text = this.Text.Substring(0, this.Text.Length - 2);
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (this.Text[this.Text.Length - 1].ToString().Equals("*"))
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea abrir otro archivo? Se perderá todo el proceso de ésta.", "Abrir Archivo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                }
            }
            else
            {
                //Comprobar si está bien
                var fileContent = string.Empty;
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                    }
                }

                MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            }
        }
    }
}
