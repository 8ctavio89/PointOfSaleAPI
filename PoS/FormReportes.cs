using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoS
{
    public partial class FormReportes : Form
    {
        FormLogin formLogin;

        public FormReportes(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            int padding = 10;
            pb_logo.Location = new Point(this.Width - pb_logo.Width - padding*2, padding);
            lb_fecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            lbl_username.Text = $"Usuario: {Usuario.NombreEmpleado} {Usuario.ApellidoPaternoEmpleado} {Usuario.ApellidoMaternoEmpleado}";
            lbl_username.Location = new Point(this.Width / 2 - lbl_username.Width / 2, padding);
            lb_fecha.Location = new Point(this.Width / 2 - lb_fecha.Width / 2, lbl_username.Location.Y + lbl_username.Height);

            bt_salir.Size = new Size(100, 50);
            bt_salir.Location = new Point(padding, padding);

            lb_reporte.Location = new Point(bt_salir.Location.X + (padding * 4), bt_salir.Location.Y + bt_salir.Height + padding*4);
            cmb_reporte.Location = new Point(lb_reporte.Location.X + lb_reporte.Width + (padding * 2), lb_reporte.Location.Y);

            dgv_reporte.Width = this.Width - (lb_reporte.Location.X + (padding * 7));
            dgv_reporte.Height = this.Height - (lb_reporte.Location.Y + lb_reporte.Height + (10 * padding));
            dgv_reporte.Location = new Point(lb_reporte.Location.X, lb_reporte.Location.Y + lb_reporte.Height + (2 * padding));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_fecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            formLogin.CleanFields();
            formLogin.Show();
            this.Close();
        }

        private void QueryToDBToDataGridView(string query, DataGridView dgv)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("server=127.0.0.1; user=root; database=pos; SSL mode=none");
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, mySqlConnection);

                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgv.ReadOnly = true;
                dgv.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_reporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            switch (cmb_reporte.SelectedIndex)
            {
                case 0:
                    query = 
                        "SELECT ventas_detalle.id_producto as ID, productos.producto_nombre as Producto, SUM(ventas_detalle.producto_cantidad) as Cantidad " +
                        "FROM ventas_detalle " +
                        "JOIN productos ON(ventas_detalle.id_producto = productos.producto_codigo) " +
                        "GROUP BY ventas_detalle.id_producto " +
                        "HAVING cantidad = ( " +
                        "SELECT SUM(ventas_detalle.producto_cantidad) " +
                        "FROM ventas_detalle " +
                        "GROUP BY ventas_detalle.id_producto " +
                        "ORDER BY SUM(ventas_detalle.producto_cantidad) " +
                        "DESC LIMIT 1 " +
                        ") " +
                        "ORDER BY cantidad DESC";
                    QueryToDBToDataGridView(query, dgv_reporte);
                    break;
                case 1:
                    query =
                        "SELECT ventas_detalle.id_producto as ID, productos.producto_nombre as Producto, SUM(ventas_detalle.producto_cantidad) as Cantidad " +
                        "FROM ventas_detalle " +
                        "JOIN productos ON(ventas_detalle.id_producto = productos.producto_codigo) " +
                        "GROUP BY ventas_detalle.id_producto " +
                        "HAVING cantidad = ( " +
                        "SELECT SUM(ventas_detalle.producto_cantidad) " +
                        "FROM ventas_detalle " +
                        "GROUP BY ventas_detalle.id_producto " +
                        "ORDER BY SUM(ventas_detalle.producto_cantidad) " +
                        "LIMIT 1 " +
                        ") " +
                        "ORDER BY cantidad";
                    QueryToDBToDataGridView(query, dgv_reporte);
                    break;
                case 2:
                    query =
                        "SELECT COUNT(ventas.operador_venta) as Ventas, ventas.operador_venta as ID, usuarios.nombre as Nombre, usuarios.apellido1 as `Apellido paterno`, usuarios.apellido2 as `Apellido materno` " +
                        "FROM(usuarios JOIN ventas ON(usuarios.numero_de_empleado = ventas.operador_venta)) " +
                        "GROUP BY ventas.operador_venta " +
                        "HAVING COUNT(ventas.operador_venta) = ( " +
                        "SELECT COUNT(ventas.operador_venta) " +
                        "FROM(usuarios JOIN ventas ON(usuarios.numero_de_empleado = ventas.operador_venta)) " +
                        "GROUP BY ventas.operador_venta " +
                        "ORDER BY COUNT(ventas.operador_venta) DESC LIMIT 1 " +
                        ")";
                    QueryToDBToDataGridView(query, dgv_reporte);
                    break;
                case 3:
                    query =
                        "SELECT COUNT(ventas.operador_venta) as Ventas, ventas.operador_venta as ID, usuarios.nombre as Nombre, usuarios.apellido1 as `Apellido paterno`, usuarios.apellido2 as `Apellido materno` " +
                        "FROM(usuarios JOIN ventas ON(usuarios.numero_de_empleado = ventas.operador_venta)) " +
                        "GROUP BY ventas.operador_venta " +
                        "HAVING COUNT(ventas.operador_venta) = ( " +
                        "SELECT COUNT(ventas.operador_venta) " +
                        "FROM(usuarios JOIN ventas ON(usuarios.numero_de_empleado = ventas.operador_venta)) " +
                        "GROUP BY ventas.operador_venta " +
                        "ORDER BY COUNT(ventas.operador_venta) ASC LIMIT 1 " +
                        ")";
                    QueryToDBToDataGridView(query, dgv_reporte);
                    break;
                case 4:
                    query =
                        "SELECT ventas.fecha_venta as Fecha, COUNT(0) as Ventas " +
                        "FROM ventas " +
                        "GROUP BY ventas.fecha_venta " +
                        "ORDER BY ventas.fecha_venta DESC";
                    QueryToDBToDataGridView(query, dgv_reporte);
                    break;
                default:
                    break;
            }
        }
    }
}
