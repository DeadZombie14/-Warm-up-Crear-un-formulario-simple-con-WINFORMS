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
             * Incorporar a la vista dos campos de texto y un botón que validen la estructura de una contraseña, la contraseña deberá exigir:
             * Al menos una letra mayúscula
             * Al menos una letra minúscula
             * Al menos un símbolo
             * Al menos un número
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
                mensaje += "La contraseña debe contener al menos una letra mayúscula.\n";
                valida = false;
            }
            // minuscula
            bool minus = Regex.IsMatch(password, @"[a-z]");
            if (!minus) { 
                mensaje += "La contraseña debe contener al menos una letra minúscula.\n";
                valida = false;
            }
            // simbolo
            bool sim = Regex.IsMatch(password, @"[!@#$%^&*(),.?""':;{}|<>]");
            if (!sim) { 
                mensaje += "La contraseña debe contener al menos un símbolo.\n";
                valida = false;
            }
            // numero
            bool num = Regex.IsMatch(password, @"[0-9]");
            if (!num) { 
                mensaje += "La contraseña debe contener al menos un número.\n";
                valida = false;
            }
            
            if (valida)
            {
                // iguales
                if (password == verificarPassword)
                {
                    mensaje = "Contraseña válida y coincidente.";
                    MessageBox.Show("La contraseña ha sido validada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    mensaje = "Las contraseñas no coinciden.";
                }
            }

            // Mostrar el mensaje al usuario en label3
            label3.Text = mensaje;
        }
    }
}
