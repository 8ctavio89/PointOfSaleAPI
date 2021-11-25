
namespace PoS
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_salir = new System.Windows.Forms.Button();
            this.cmb_reporte = new System.Windows.Forms.ComboBox();
            this.lb_reporte = new System.Windows.Forms.Label();
            this.dgv_reporte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(422, 12);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 30);
            this.lbl_username.TabIndex = 28;
            this.lbl_username.Text = "usuario";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_logo
            // 
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(720, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(221, 81);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 29;
            this.pb_logo.TabStop = false;
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_fecha.Location = new System.Drawing.Point(397, 42);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(134, 30);
            this.lb_fecha.TabIndex = 30;
            this.lb_fecha.Text = "Hora y Fecha";
            this.lb_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_salir
            // 
            this.bt_salir.BackColor = System.Drawing.Color.White;
            this.bt_salir.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_salir.Location = new System.Drawing.Point(12, 24);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(126, 60);
            this.bt_salir.TabIndex = 31;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // cmb_reporte
            // 
            this.cmb_reporte.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_reporte.FormattingEnabled = true;
            this.cmb_reporte.Items.AddRange(new object[] {
            "Producto más vendido",
            "Producto menos vendido",
            "Vendedor con más ventas",
            "Vendedor con menos ventas",
            "Ventas por día"});
            this.cmb_reporte.Location = new System.Drawing.Point(169, 106);
            this.cmb_reporte.Name = "cmb_reporte";
            this.cmb_reporte.Size = new System.Drawing.Size(400, 38);
            this.cmb_reporte.TabIndex = 32;
            this.cmb_reporte.SelectedIndexChanged += new System.EventHandler(this.cmb_reporte_SelectedIndexChanged);
            // 
            // lb_reporte
            // 
            this.lb_reporte.AutoSize = true;
            this.lb_reporte.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_reporte.Location = new System.Drawing.Point(68, 114);
            this.lb_reporte.Name = "lb_reporte";
            this.lb_reporte.Size = new System.Drawing.Size(85, 30);
            this.lb_reporte.TabIndex = 33;
            this.lb_reporte.Text = "Reporte";
            this.lb_reporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_reporte
            // 
            this.dgv_reporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_reporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_reporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_reporte.Location = new System.Drawing.Point(68, 159);
            this.dgv_reporte.Name = "dgv_reporte";
            this.dgv_reporte.RowTemplate.Height = 25;
            this.dgv_reporte.Size = new System.Drawing.Size(800, 320);
            this.dgv_reporte.TabIndex = 34;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.dgv_reporte);
            this.Controls.Add(this.lb_reporte);
            this.Controls.Add(this.cmb_reporte);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.lb_fecha);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem corteXStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem corteZStripMenuItem2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.ComboBox cmb_reporte;
        private System.Windows.Forms.Label lb_reporte;
        private System.Windows.Forms.DataGridView dgv_reporte;
    }
}