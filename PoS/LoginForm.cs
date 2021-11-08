using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PoS
{
    public partial class FormLogin : Form
    {

        public static String username;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txt_username.Text) || !String.IsNullOrWhiteSpace(txt_username.Text) ||
                !String.IsNullOrEmpty(txt_password.Text) || !String.IsNullOrWhiteSpace(txt_password.Text))
            {
                String query = $"SELECT numero_de_empleado, nombre, apellido1, apellido2 FROM usuarios WHERE nombre = '{txt_username.Text}' AND celular = '{txt_password.Text}';";
                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=posapi; SSL mode=none");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    if (mySqlDataReader.HasRows)
                    {
                        mySqlDataReader.Read();
                        username = $"{mySqlDataReader.GetString(1)} {mySqlDataReader.GetString(2)} {mySqlDataReader.GetString(3)}";
                        MessageBox.Show("Bienvenido/a");
                        this.Hide();
                        new PuntoDeVenta().ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Este usuario no existe.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
            else
            {
                MessageBox.Show("Rellena los datos necesarios.");
            }
        }
	}
}
