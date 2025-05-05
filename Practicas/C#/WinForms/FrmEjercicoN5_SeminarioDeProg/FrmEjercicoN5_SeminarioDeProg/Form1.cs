using System.Diagnostics;
using System.Windows.Forms.Design;

namespace FrmEjercicoN5_SeminarioDeProg
{
    public partial class FrasesApp : Form
    {
        public FrasesApp()
        {
            InitializeComponent();
        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstFrases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFrases.SelectedIndex != -1)
            {
                string FraseLST = lstFrases.SelectedItem.ToString();
                //cada método con su respectiva nomenclatura retornan el valor indicado.
                lblResult.Text = "La frase seleccionada: " + '"' + FraseLST + '"' + "\nContiene: " + lenght(FraseLST) + " letras." +
                    "\nContiene: " + spaces(FraseLST) + " espacios" +
                    "\nComienza con la palabra: " + primeraPalabra(FraseLST) +
                    "\nTermina con la palabra: " + ultimaPalabra(FraseLST);

                lblNota.Text = "*NOTA: No se cuentan los espacios del inicio ni final*";
            }

        }

        private void txtFrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtFrase.Text != "")
                {
                    DialogResult Result = MessageBox.Show("¿Desea agregar esta frase a la lista?", "AGREGAR FRASE", buttons: MessageBoxButtons.OKCancel);
                    if (Result == DialogResult.OK)
                    {
                        lstFrases.Items.Add(txtFrase.Text);
                    }
                    else if (Result == DialogResult.Cancel)
                    {
                        txtFrase.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error, debe ingresar una frase.", "ERROR", buttons: MessageBoxButtons.OK);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string lenght(string Frase)
        {
            int LenghtFrase = Frase.Length;
            for (int i = 0; i < Frase.Length; i++)
            {
                if (Frase[i] == ' ')
                {
                    LenghtFrase -= 1;
                }
            }

            return LenghtFrase.ToString();
        }

        private string spaces(string Frase2)
        {
            Frase2 = Frase2.Trim();
            int SpacesFrase = 0;
            for (int i = 0; i < Frase2.Length; i++)
            {
                if (Frase2[i] == ' ')
                {
                    SpacesFrase += 1;
                }
            }

            return SpacesFrase.ToString();
        }

        private string primeraPalabra(string Frase3)
        {
            Frase3 = Frase3.Trim();
            string Palabra = "";
            for (int i = 0; i < Frase3.Length; i++)
            {
                Palabra += Frase3[i];
                if (Frase3[i] == ' ')
                {
                    break;
                }
            }

            return Palabra;
        }

        private string ultimaPalabra(string Frase4)
        {
            Frase4 = Frase4.Trim();

            string Palabra2 = "";
            string PalabraRev = "";
            for (int i = Frase4.Length - 1; i >= 0; i--)
            {
                PalabraRev += Frase4[i];
                if (Frase4[i] == ' ')
                {
                    break;
                }
            }
            for (int j = PalabraRev.Length - 1; j >= 0; j--)
            {
                Palabra2 += PalabraRev[j];
            }

            return Palabra2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstFrases.Items.Clear();
            lblResult.Text = "";
            txtFrase.Text = "";
        }

        private void FrasesApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Exit = MessageBox.Show("¿Está seguro que desea salir del programa?", "SALIR", buttons: MessageBoxButtons.YesNo);
            if (Exit == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void FrasesApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("¡Gracias por utilizar este programa!","Gracias"); 
        }
    }
}