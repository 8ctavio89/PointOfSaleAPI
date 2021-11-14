using System;
using System.Text;
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

        public string MD5encode(string str_encode)
        {
            System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(str_encode));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_username.Text) || !String.IsNullOrWhiteSpace(txt_username.Text) ||
                !String.IsNullOrEmpty(txt_password.Text) || !String.IsNullOrWhiteSpace(txt_password.Text))
            {
                String md5Pass = MD5encode(txt_password.Text);
                String query = $"SELECT numero_de_empleado, nombre, apellido1, apellido2 FROM usuarios WHERE usuario = '{txt_username.Text}' AND pass = '{md5Pass}';";
                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=pos; SSL mode=none");
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
                        MessageBox.Show("Usuario y/o contraseña inválidos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Rellene los datos necesarios.");
            }
        }
    }
}
