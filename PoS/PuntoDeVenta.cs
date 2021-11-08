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
    public partial class PuntoDeVenta : Form
    {
        private double total = 0.0;
        private string input = "";
        public PuntoDeVenta()
        {
            InitializeComponent();
        }

        private void PuntoDeVenta_Load(object sender, EventArgs e)
        {
            //lb_bienvenido.Location = new Point(this.Width / 2 - lb_bienvenido.Width / 2, 0);
            //lb_autor.Location = new Point(this.Width / 2 - lb_autor.Width / 2, lb_bienvenido.Height);
            pb_logo.Location = new Point(this.Width / 2 - pb_logo.Width / 2, 0);
            lb_fecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            lb_fecha.Location = new Point(this.Width / 2 - lb_fecha.Width / 2, pb_logo.Height);
            dgv_productos.Location = new Point(10, lb_fecha.Location.Y + lb_fecha.Height);
            dgv_productos.Width = (int)Math.Round((this.Width-10) * 0.7);
            dgv_productos.Height = this.Height - pb_logo.Height - lb_fecha.Height;
            //MessageBox.Show(this.Width + "  " + this.Height);
            //this.BackColor = Color.FromArgb(213, 232, 212);
            dgv_productos.Columns[0].Width = dgv_productos.Width * 15 / 100;
            dgv_productos.Columns[1].Width = dgv_productos.Width * 45 / 100;
            dgv_productos.Columns[2].Width = dgv_productos.Width * 20 / 100;
            dgv_productos.Columns[3].Width = dgv_productos.Width * 20 / 100;
            dgv_productos.RowTemplate.Height = 60;
            tb_input.Location = new Point(dgv_productos.Location.X + dgv_productos.Width + 10, dgv_productos.Location.Y);
            tb_input.Width = this.Width - dgv_productos.Width - 50;
            lb_total.Location = new Point(dgv_productos.Width +10, dgv_productos.Location.Y + dgv_productos.Height - lb_total.Height);
            dgv_productos.Columns[2].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns[3].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            int bt_numpad_padding = 20;
            int bt_numpad_size = (int)Math.Round(((this.Width * 0.3) - bt_numpad_padding*5) / 4);
            int currentbutton = 0;

            Button[] bt_numpad = { bt_numpad7, bt_numpad8, bt_numpad9, bt_numpad_del, bt_numpad4, bt_numpad5, bt_numpad6, bt_numpad_dot, bt_numpad1, bt_numpad2, bt_numpad3, bt_numpad0 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int row = i;
                    int column = j;
                    bt_numpad[currentbutton].Size = new Size(bt_numpad_size, bt_numpad_size);
                    bt_numpad[currentbutton].Location = new Point(dgv_productos.Width + bt_numpad_padding + (bt_numpad_size * column) + (bt_numpad_padding * column),
                        tb_input.Height + bt_numpad_padding + dgv_productos.Location.Y + (bt_numpad_size * row) + (bt_numpad_padding * row));
                    currentbutton++;
                }
            }

            bt_agregar.Size = new Size((bt_numpad_size * 2) + bt_numpad_padding, bt_numpad_size);
            bt_agregar.Location = new Point(bt_numpad1.Location.X , bt_numpad1.Location.Y + bt_numpad1.Height + bt_numpad_padding);

            bt_cancelar.Size = new Size((bt_numpad_size * 2) + bt_numpad_padding, bt_numpad_size);
            bt_cancelar.Location = new Point(bt_numpad3.Location.X, bt_numpad3.Location.Y + bt_numpad3.Height + bt_numpad_padding);

            bt_remover.Size = new Size((bt_numpad_size * 2) + bt_numpad_padding, bt_numpad_size);
            bt_remover.Location = new Point(bt_agregar.Location.X, bt_agregar.Location.Y + bt_agregar.Height + bt_numpad_padding);

            bt_remover_todo.Text = "REMOVER" + Environment.NewLine + "TODO";
            bt_remover_todo.Size = new Size((bt_numpad_size * 2) + bt_numpad_padding, bt_numpad_size);
            bt_remover_todo.Location = new Point(bt_cancelar.Location.X, bt_cancelar.Location.Y + bt_cancelar.Height + bt_numpad_padding);

            bt_pago.Text = "INTRODUCIR" + Environment.NewLine + "PAGO";
            bt_pago.Size = new Size((bt_numpad_size * 2) + bt_numpad_padding, bt_numpad_size);
            bt_pago.Location = new Point(bt_remover.Location.X, bt_remover.Location.Y + bt_remover.Height + bt_numpad_padding);

            bt_limpiar.Size = new Size((bt_numpad_size * 2) + bt_numpad_padding, bt_numpad_size);
            bt_limpiar.Location = new Point(bt_remover_todo.Location.X, bt_remover_todo.Location.Y + bt_remover_todo.Height + bt_numpad_padding);

            bt_personalizar.Size = new Size((bt_numpad_size * 2) + bt_numpad_padding, bt_numpad_size);
            bt_personalizar.Location = new Point(dgv_productos.Location.X, dgv_productos.Location.Y - bt_numpad_size - bt_numpad_padding);

            bt_salir.Size = new Size((bt_numpad_size * 2) + bt_numpad_padding, bt_numpad_size);
            bt_salir.Location = new Point(tb_input.Location.X + tb_input.Width - bt_salir.Width, dgv_productos.Location.Y - bt_numpad_size - bt_numpad_padding);
            lbl_username.Location = new Point(bt_personalizar.Location.X + bt_personalizar.Width + bt_numpad_padding, bt_personalizar.Location.Y);
            lbl_username.Text = "Le atiende: " + FormLogin.username;
            CalcularTotal();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_fecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void CalcularTotal()
        {
            total = 0;
            for (int i = 0; i < dgv_productos.Rows.Count; i++)
            {
                total += Double.Parse(dgv_productos[3,i].Value.ToString());
            }
            lb_total.Text = "Total: " + String.Format("{0:0.00}",total);
        }

        private void AgregarProducto()
        {
            if (!int.TryParse(input, out int temp))
            {
                input = "-1";
                tb_input.Text = "";
            }
            String query = "SELECT * FROM productos WHERE producto_codigo =" + input;

            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=posapi; SSL mode=none");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    mySqlDataReader.Read();
                    dgv_productos.Rows.Add("1", mySqlDataReader.GetString(1), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)), String.Format("{0:0.00}", mySqlDataReader.GetDouble(3)));

                    CalcularTotal();
                    input = "";
                    tb_input.Clear();
                    tb_input.Focus();
                }
                else
                {
                    input = "";
                    tb_input.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ManejarPago()
        {
            if (!double.TryParse(tb_input.Text, out double temp))
            {
                input = "";
                tb_input.Clear();
                return;
            }

            lb_total.Text = $"Cambio: {Math.Round(Convert.ToDouble(tb_input.Text) - total, 2)}";
            dgv_productos.Rows.Clear();
            total = 0;
            input = "";
            tb_input.Clear();
            tb_input.Focus();
        }

        private void PuntoDeVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                if (dgv_productos.Rows.Count > 0)
                {
                    dgv_productos.Rows.RemoveAt(dgv_productos.Rows.Count - 1);
                    CalcularTotal();
                }
            }
            else if (e.KeyChar == 13)
            {
                AgregarProducto();
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                if (input.Length > 0)
                {
                    input = input.Remove(input.Length - 1);
                    tb_input.Text = input;
                }
            }
            else if (e.KeyChar == 'P' || e.KeyChar == 'p')
            {
                e.Handled = true;
                //MessageBox.Show($"¿Va a pagar? {textBox1.Text} {total} {Environment.NewLine} " +
                //    $"{Convert.ToDouble(textBox1.Text) - total}");

                ManejarPago();
            }
            else if (input.Length < 9)
            {
                input += e.KeyChar;
                tb_input.Text = input;
            }
        }


        private void bt_numpad_num_Click(object sender, EventArgs e)
        {
            if (input.Length < 9)
            {
                input += (sender as Button).Text;
                tb_input.Text = input;
            }
            tb_input.Focus();
        }

        private void bt_numpad_del_Click(object sender, EventArgs e)
        {
            if (input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
                tb_input.Text = input;
            }
            tb_input.Focus();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            tb_input.Focus();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            input = "";
            tb_input.Clear();
            tb_input.Focus();
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            if (dgv_productos.Rows.Count > 0)
            {
                dgv_productos.Rows.RemoveAt(dgv_productos.Rows.Count - 1);
                CalcularTotal();
            }
            tb_input.Focus();
        }

        private void bt_remover_todo_Click(object sender, EventArgs e)
        {
            while (dgv_productos.Rows.Count > 0)
            {
                dgv_productos.Rows.RemoveAt(dgv_productos.Rows.Count - 1);
                CalcularTotal();
            }
            tb_input.Focus();
        }

        private void bt_pago_Click(object sender, EventArgs e)
        {
            ManejarPago();
            tb_input.Focus();
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            while (dgv_productos.Rows.Count > 0)
            {
                dgv_productos.Rows.RemoveAt(dgv_productos.Rows.Count - 1);
                CalcularTotal();
            }
            CalcularTotal();
            input = "";
            tb_input.Clear();
            tb_input.Focus();
        }

        private void bt_personalizar_Click(object sender, EventArgs e)
        {
            cd_color.ShowDialog();
            this.BackColor = cd_color.Color;
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
