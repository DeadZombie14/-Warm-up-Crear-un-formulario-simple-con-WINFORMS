using System.Text.RegularExpressions;

namespace HolaMundoWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * Incorporar a la vista dos campos de texto y un bot�n que validen la estructura de una contrase�a, la contrase�a deber� exigir:
             * Al menos una letra may�scula
             * Al menos una letra min�scula
             * Al menos un s�mbolo
             * Al menos un n�mero
             */

            // Obtener la referencia de textbox1 y textbox2
            string password = textBox1.Text;
            string verificarPassword = textBox2.Text;

            // Mensaje a mostrar al usuario
            string mensaje = "";

            //*** Validaciones ***
            bool valida = true;
            // mayuscula
            bool mayus = Regex.IsMatch(password, @"[A-Z]");
            if (!mayus) {
                mensaje += "La contrase�a debe contener al menos una letra may�scula.\n";
                valida = false;
            }
            // minuscula
            bool minus = Regex.IsMatch(password, @"[a-z]");
            if (!minus) { 
                mensaje += "La contrase�a debe contener al menos una letra min�scula.\n";
                valida = false;
            }
            // simbolo
            bool sim = Regex.IsMatch(password, @"[!@#$%^&*(),.?""':;{}|<>]");
            if (!sim) { 
                mensaje += "La contrase�a debe contener al menos un s�mbolo.\n";
                valida = false;
            }
            // numero
            bool num = Regex.IsMatch(password, @"[0-9]");
            if (!num) { 
                mensaje += "La contrase�a debe contener al menos un n�mero.\n";
                valida = false;
            }
            
            if (valida)
            {
                // iguales
                if (password == verificarPassword)
                {
                    mensaje = "Contrase�a v�lida y coincidente.";
                    MessageBox.Show("La contrase�a ha sido validada", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    mensaje = "Las contrase�as no coinciden.";
                }
            }

            // Mostrar el mensaje al usuario en label3
            label3.Text = mensaje;
        }
    }
}
