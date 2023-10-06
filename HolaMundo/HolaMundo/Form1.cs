using System.Text.RegularExpressions;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        //Función para redondear las esquinas del form
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
            //Se llama a la función "CreateRoundRectRgn" para añadir las esquinas redondeadas al form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        //Función del botón que se encarga de validar la contraseña ingresada
        private void btnValidar_Click(object sender, EventArgs e)
        {
            //Expresión regular utilizada para validar la contraseña
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[\\W_]).*$");
            //Condicional que válida que no se ha ingresado la contraseña
            //en ambos campos de texto
            if (string.IsNullOrEmpty(txtContrasena1.Text) &&
                    string.IsNullOrEmpty(txtContrasena2.Text))
            {
                //En caso de que se ingrese nada, aparecerá el
                //siguiente mensaje
                MessageBox.Show("Los campos están vacíos");
                return;
            }
            //Condicional que valida si no son iguales los textos contenidos
            //El signo de exclamación indica negación
            //Condicional que verifica que las contraseñas NO son iguales
            if (!txtContrasena1.Text.Equals(txtContrasena2.Text))
            {
                //En caso de que ambas contraseñas ingresadas sean diferentes
                //aparecerá en pantalla el siguiente mensaje
                MessageBox.Show("Las contraseñas no son iguales");
                return;
            }
            //Condicional que verifica que la contraseña cumple con la
            //expresión regular establecida
            if (validacion.IsMatch(txtContrasena1.Text))
            {
                //En caso de que la contraseña ingresada cumpla con la 
                //expresión regular establecida, aparecerá en pantalla
                //el siguiente mensaje
                //indicando que la contraseña es válida
                MessageBox.Show("La contraseña es VALIDA");
            }
            //Condicional que se establece en caso de que no se cumpla
            //la condicional if
            else
            {
                //En caso de que las contraseñas ingresadas NO cumplan
                //con la expresión regular establecida, aparecerá en
                //pantalla el siguiente mensaje
                //indicando que la contraseña NO es válida
                MessageBox.Show("La contraseña NO es VALIDA");
            }
        }
    }
}