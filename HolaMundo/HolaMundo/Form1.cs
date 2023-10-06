using System.Text.RegularExpressions;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        //Funci�n para redondear las esquinas del form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //Coordenadas que indican las esquinas que se deben redondear
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // coordenada x de la esquina superior izquierda
            int nTopRect,      // coordenada y de la esquina superior izquierda
            int nRightRect,    // coordenada x de la esquina inferior derecha
            int nBottomRect,   // coordenada y de la esquina inferior derecha
            int nWidthEllipse, // altura de la elipse
            int nHeightEllipse // ancho de la elipse
        );
        public Form1()
        {
            InitializeComponent();
            //Se redondean las esquinas del form
            this.FormBorderStyle = FormBorderStyle.None;
            //Se llama a la funci�n "CreateRoundRectRgn" para a�adir las esquinas redondeadas al form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        //Funci�n del bot�n que se encarga de validar la contrase�a ingresada
        private void btnValidar_Click(object sender, EventArgs e)
        {
            //Expresi�n regular utilizada para validar la contrase�a
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[\\W_]).*$");
            //Condicional que v�lida que no se ha ingresado la contrase�a
            //en ambos campos de texto
            if (string.IsNullOrEmpty(txtContrasena1.Text) &&
                    string.IsNullOrEmpty(txtContrasena2.Text))
            {
                //En caso de que se ingrese nada, aparecer� el
                //siguiente mensaje
                MessageBox.Show("Los campos est�n vac�os");
                return;
            }
            //Condicional que valida si no son iguales los textos contenidos
            //El signo de exclamaci�n indica negaci�n
            //Condicional que verifica que las contrase�as NO son iguales
            if (!txtContrasena1.Text.Equals(txtContrasena2.Text))
            {
                //En caso de que ambas contrase�as ingresadas sean diferentes
                //aparecer� en pantalla el siguiente mensaje
                MessageBox.Show("Las contrase�as no son iguales");
                return;
            }
            //Condicional que verifica que la contrase�a cumple con la
            //expresi�n regular establecida
            if (validacion.IsMatch(txtContrasena1.Text))
            {
                //En caso de que la contrase�a ingresada cumpla con la 
                //expresi�n regular establecida, aparecer� en pantalla
                //el siguiente mensaje
                //indicando que la contrase�a es v�lida
                MessageBox.Show("La contrase�a es VALIDA");
            }
            //Condicional que se establece en caso de que no se cumpla
            //la condicional if
            else
            {
                //En caso de que las contrase�as ingresadas NO cumplan
                //con la expresi�n regular establecida, aparecer� en
                //pantalla el siguiente mensaje
                //indicando que la contrase�a NO es v�lida
                MessageBox.Show("La contrase�a NO es VALIDA");
            }
        }
    }
}