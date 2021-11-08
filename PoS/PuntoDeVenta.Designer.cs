
namespace PoS
{
    partial class PuntoDeVenta
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lb_fecha = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dgv_productos = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tb_input = new System.Windows.Forms.TextBox();
			this.lb_total = new System.Windows.Forms.Label();
			this.pb_logo = new System.Windows.Forms.PictureBox();
			this.bt_numpad7 = new System.Windows.Forms.Button();
			this.bt_numpad8 = new System.Windows.Forms.Button();
			this.bt_numpad9 = new System.Windows.Forms.Button();
			this.bt_numpad6 = new System.Windows.Forms.Button();
			this.bt_numpad5 = new System.Windows.Forms.Button();
			this.bt_numpad4 = new System.Windows.Forms.Button();
			this.bt_numpad3 = new System.Windows.Forms.Button();
			this.bt_numpad2 = new System.Windows.Forms.Button();
			this.bt_numpad1 = new System.Windows.Forms.Button();
			this.bt_numpad0 = new System.Windows.Forms.Button();
			this.bt_numpad_dot = new System.Windows.Forms.Button();
			this.bt_numpad_del = new System.Windows.Forms.Button();
			this.bt_agregar = new System.Windows.Forms.Button();
			this.bt_cancelar = new System.Windows.Forms.Button();
			this.bt_remover = new System.Windows.Forms.Button();
			this.bt_remover_todo = new System.Windows.Forms.Button();
			this.bt_pago = new System.Windows.Forms.Button();
			this.bt_limpiar = new System.Windows.Forms.Button();
			this.cd_color = new System.Windows.Forms.ColorDialog();
			this.bt_personalizar = new System.Windows.Forms.Button();
			this.bt_salir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_fecha
			// 
			this.lb_fecha.AutoSize = true;
			this.lb_fecha.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lb_fecha.Location = new System.Drawing.Point(319, 113);
			this.lb_fecha.Name = "lb_fecha";
			this.lb_fecha.Size = new System.Drawing.Size(170, 37);
			this.lb_fecha.TabIndex = 2;
			this.lb_fecha.Text = "Hora y Fecha";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// dgv_productos
			// 
			this.dgv_productos.AllowUserToAddRows = false;
			this.dgv_productos.AllowUserToDeleteRows = false;
			this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dgv_productos.Location = new System.Drawing.Point(29, 153);
			this.dgv_productos.Name = "dgv_productos";
			this.dgv_productos.ReadOnly = true;
			this.dgv_productos.RowHeadersVisible = false;
			this.dgv_productos.RowHeadersWidth = 51;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.NullValue = null;
			this.dgv_productos.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_productos.RowTemplate.Height = 60;
			this.dgv_productos.Size = new System.Drawing.Size(460, 214);
			this.dgv_productos.TabIndex = 3;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Cantidad";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Producto";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			dataGridViewCellStyle2.NullValue = null;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column3.HeaderText = "Precio";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Total";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// tb_input
			// 
			this.tb_input.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.tb_input.Location = new System.Drawing.Point(524, 12);
			this.tb_input.Name = "tb_input";
			this.tb_input.ReadOnly = true;
			this.tb_input.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tb_input.Size = new System.Drawing.Size(100, 46);
			this.tb_input.TabIndex = 4;
			// 
			// lb_total
			// 
			this.lb_total.AutoSize = true;
			this.lb_total.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lb_total.Location = new System.Drawing.Point(51, 394);
			this.lb_total.Name = "lb_total";
			this.lb_total.Size = new System.Drawing.Size(100, 50);
			this.lb_total.TabIndex = 5;
			this.lb_total.Text = "Total";
			// 
			// pb_logo
			// 
			this.pb_logo.Location = new System.Drawing.Point(284, 3);
			this.pb_logo.Name = "pb_logo";
			this.pb_logo.Size = new System.Drawing.Size(234, 107);
			this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_logo.TabIndex = 6;
			this.pb_logo.TabStop = false;
			// 
			// bt_numpad7
			// 
			this.bt_numpad7.BackColor = System.Drawing.Color.White;
			this.bt_numpad7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad7.Location = new System.Drawing.Point(524, 64);
			this.bt_numpad7.Name = "bt_numpad7";
			this.bt_numpad7.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad7.TabIndex = 7;
			this.bt_numpad7.Text = "7";
			this.bt_numpad7.UseVisualStyleBackColor = false;
			this.bt_numpad7.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad8
			// 
			this.bt_numpad8.BackColor = System.Drawing.Color.White;
			this.bt_numpad8.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad8.Location = new System.Drawing.Point(590, 64);
			this.bt_numpad8.Name = "bt_numpad8";
			this.bt_numpad8.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad8.TabIndex = 8;
			this.bt_numpad8.Text = "8";
			this.bt_numpad8.UseVisualStyleBackColor = false;
			this.bt_numpad8.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad9
			// 
			this.bt_numpad9.BackColor = System.Drawing.Color.White;
			this.bt_numpad9.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad9.Location = new System.Drawing.Point(656, 64);
			this.bt_numpad9.Name = "bt_numpad9";
			this.bt_numpad9.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad9.TabIndex = 9;
			this.bt_numpad9.Text = "9";
			this.bt_numpad9.UseVisualStyleBackColor = false;
			this.bt_numpad9.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad6
			// 
			this.bt_numpad6.BackColor = System.Drawing.Color.White;
			this.bt_numpad6.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad6.Location = new System.Drawing.Point(656, 130);
			this.bt_numpad6.Name = "bt_numpad6";
			this.bt_numpad6.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad6.TabIndex = 12;
			this.bt_numpad6.Text = "6";
			this.bt_numpad6.UseVisualStyleBackColor = false;
			this.bt_numpad6.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad5
			// 
			this.bt_numpad5.BackColor = System.Drawing.Color.White;
			this.bt_numpad5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad5.Location = new System.Drawing.Point(590, 130);
			this.bt_numpad5.Name = "bt_numpad5";
			this.bt_numpad5.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad5.TabIndex = 11;
			this.bt_numpad5.Text = "5";
			this.bt_numpad5.UseVisualStyleBackColor = false;
			this.bt_numpad5.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad4
			// 
			this.bt_numpad4.BackColor = System.Drawing.Color.White;
			this.bt_numpad4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad4.Location = new System.Drawing.Point(524, 130);
			this.bt_numpad4.Name = "bt_numpad4";
			this.bt_numpad4.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad4.TabIndex = 10;
			this.bt_numpad4.Text = "4";
			this.bt_numpad4.UseVisualStyleBackColor = false;
			this.bt_numpad4.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad3
			// 
			this.bt_numpad3.BackColor = System.Drawing.Color.White;
			this.bt_numpad3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad3.Location = new System.Drawing.Point(656, 196);
			this.bt_numpad3.Name = "bt_numpad3";
			this.bt_numpad3.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad3.TabIndex = 15;
			this.bt_numpad3.Text = "3";
			this.bt_numpad3.UseVisualStyleBackColor = false;
			this.bt_numpad3.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad2
			// 
			this.bt_numpad2.BackColor = System.Drawing.Color.White;
			this.bt_numpad2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad2.Location = new System.Drawing.Point(590, 196);
			this.bt_numpad2.Name = "bt_numpad2";
			this.bt_numpad2.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad2.TabIndex = 14;
			this.bt_numpad2.Text = "2";
			this.bt_numpad2.UseVisualStyleBackColor = false;
			this.bt_numpad2.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad1
			// 
			this.bt_numpad1.BackColor = System.Drawing.Color.White;
			this.bt_numpad1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad1.Location = new System.Drawing.Point(524, 196);
			this.bt_numpad1.Name = "bt_numpad1";
			this.bt_numpad1.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad1.TabIndex = 13;
			this.bt_numpad1.Text = "1";
			this.bt_numpad1.UseVisualStyleBackColor = false;
			this.bt_numpad1.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad0
			// 
			this.bt_numpad0.BackColor = System.Drawing.Color.White;
			this.bt_numpad0.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad0.Location = new System.Drawing.Point(722, 196);
			this.bt_numpad0.Name = "bt_numpad0";
			this.bt_numpad0.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad0.TabIndex = 18;
			this.bt_numpad0.Text = "0";
			this.bt_numpad0.UseVisualStyleBackColor = false;
			this.bt_numpad0.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad_dot
			// 
			this.bt_numpad_dot.BackColor = System.Drawing.Color.White;
			this.bt_numpad_dot.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad_dot.Location = new System.Drawing.Point(722, 130);
			this.bt_numpad_dot.Name = "bt_numpad_dot";
			this.bt_numpad_dot.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad_dot.TabIndex = 17;
			this.bt_numpad_dot.Text = ".";
			this.bt_numpad_dot.UseVisualStyleBackColor = false;
			this.bt_numpad_dot.Click += new System.EventHandler(this.bt_numpad_num_Click);
			// 
			// bt_numpad_del
			// 
			this.bt_numpad_del.BackColor = System.Drawing.Color.White;
			this.bt_numpad_del.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_numpad_del.Location = new System.Drawing.Point(722, 64);
			this.bt_numpad_del.Name = "bt_numpad_del";
			this.bt_numpad_del.Size = new System.Drawing.Size(60, 60);
			this.bt_numpad_del.TabIndex = 16;
			this.bt_numpad_del.Text = "DEL";
			this.bt_numpad_del.UseVisualStyleBackColor = false;
			this.bt_numpad_del.Click += new System.EventHandler(this.bt_numpad_del_Click);
			// 
			// bt_agregar
			// 
			this.bt_agregar.BackColor = System.Drawing.Color.White;
			this.bt_agregar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_agregar.Location = new System.Drawing.Point(524, 262);
			this.bt_agregar.Name = "bt_agregar";
			this.bt_agregar.Size = new System.Drawing.Size(126, 60);
			this.bt_agregar.TabIndex = 19;
			this.bt_agregar.Text = "AGREGAR";
			this.bt_agregar.UseVisualStyleBackColor = false;
			this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
			// 
			// bt_cancelar
			// 
			this.bt_cancelar.BackColor = System.Drawing.Color.White;
			this.bt_cancelar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_cancelar.Location = new System.Drawing.Point(656, 262);
			this.bt_cancelar.Name = "bt_cancelar";
			this.bt_cancelar.Size = new System.Drawing.Size(126, 60);
			this.bt_cancelar.TabIndex = 20;
			this.bt_cancelar.Text = "CANCELAR";
			this.bt_cancelar.UseVisualStyleBackColor = false;
			this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
			// 
			// bt_remover
			// 
			this.bt_remover.BackColor = System.Drawing.Color.White;
			this.bt_remover.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_remover.Location = new System.Drawing.Point(524, 328);
			this.bt_remover.Name = "bt_remover";
			this.bt_remover.Size = new System.Drawing.Size(126, 60);
			this.bt_remover.TabIndex = 21;
			this.bt_remover.Text = "REMOVER";
			this.bt_remover.UseVisualStyleBackColor = false;
			this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
			// 
			// bt_remover_todo
			// 
			this.bt_remover_todo.BackColor = System.Drawing.Color.White;
			this.bt_remover_todo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_remover_todo.Location = new System.Drawing.Point(656, 328);
			this.bt_remover_todo.Name = "bt_remover_todo";
			this.bt_remover_todo.Size = new System.Drawing.Size(126, 60);
			this.bt_remover_todo.TabIndex = 22;
			this.bt_remover_todo.Text = "REMOVER TODO";
			this.bt_remover_todo.UseVisualStyleBackColor = false;
			this.bt_remover_todo.Click += new System.EventHandler(this.bt_remover_todo_Click);
			// 
			// bt_pago
			// 
			this.bt_pago.BackColor = System.Drawing.Color.White;
			this.bt_pago.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_pago.Location = new System.Drawing.Point(524, 394);
			this.bt_pago.Name = "bt_pago";
			this.bt_pago.Size = new System.Drawing.Size(126, 60);
			this.bt_pago.TabIndex = 23;
			this.bt_pago.Text = "INTRODUCIR PAGO";
			this.bt_pago.UseVisualStyleBackColor = false;
			this.bt_pago.Click += new System.EventHandler(this.bt_pago_Click);
			// 
			// bt_limpiar
			// 
			this.bt_limpiar.BackColor = System.Drawing.Color.White;
			this.bt_limpiar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_limpiar.Location = new System.Drawing.Point(656, 394);
			this.bt_limpiar.Name = "bt_limpiar";
			this.bt_limpiar.Size = new System.Drawing.Size(126, 60);
			this.bt_limpiar.TabIndex = 24;
			this.bt_limpiar.Text = "LIMPIAR";
			this.bt_limpiar.UseVisualStyleBackColor = false;
			this.bt_limpiar.Click += new System.EventHandler(this.bt_limpiar_Click);
			// 
			// bt_personalizar
			// 
			this.bt_personalizar.BackColor = System.Drawing.Color.White;
			this.bt_personalizar.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_personalizar.Location = new System.Drawing.Point(12, 3);
			this.bt_personalizar.Name = "bt_personalizar";
			this.bt_personalizar.Size = new System.Drawing.Size(126, 60);
			this.bt_personalizar.TabIndex = 25;
			this.bt_personalizar.Text = "Personalizar";
			this.bt_personalizar.UseVisualStyleBackColor = false;
			this.bt_personalizar.Click += new System.EventHandler(this.bt_personalizar_Click);
			// 
			// bt_salir
			// 
			this.bt_salir.BackColor = System.Drawing.Color.White;
			this.bt_salir.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.bt_salir.Location = new System.Drawing.Point(662, 3);
			this.bt_salir.Name = "bt_salir";
			this.bt_salir.Size = new System.Drawing.Size(126, 60);
			this.bt_salir.TabIndex = 26;
			this.bt_salir.Text = "Salir";
			this.bt_salir.UseVisualStyleBackColor = false;
			this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
			// 
			// PuntoDeVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bt_salir);
			this.Controls.Add(this.bt_personalizar);
			this.Controls.Add(this.bt_limpiar);
			this.Controls.Add(this.bt_pago);
			this.Controls.Add(this.bt_remover_todo);
			this.Controls.Add(this.bt_remover);
			this.Controls.Add(this.bt_cancelar);
			this.Controls.Add(this.bt_agregar);
			this.Controls.Add(this.bt_numpad0);
			this.Controls.Add(this.bt_numpad_dot);
			this.Controls.Add(this.bt_numpad_del);
			this.Controls.Add(this.bt_numpad3);
			this.Controls.Add(this.bt_numpad2);
			this.Controls.Add(this.bt_numpad1);
			this.Controls.Add(this.bt_numpad6);
			this.Controls.Add(this.bt_numpad5);
			this.Controls.Add(this.bt_numpad4);
			this.Controls.Add(this.bt_numpad9);
			this.Controls.Add(this.bt_numpad8);
			this.Controls.Add(this.bt_numpad7);
			this.Controls.Add(this.pb_logo);
			this.Controls.Add(this.lb_total);
			this.Controls.Add(this.tb_input);
			this.Controls.Add(this.dgv_productos);
			this.Controls.Add(this.lb_fecha);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "PuntoDeVenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PuntoDeVenta";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.PuntoDeVenta_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PuntoDeVenta_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label lb_total;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button bt_numpad7;
        private System.Windows.Forms.Button bt_numpad8;
        private System.Windows.Forms.Button bt_numpad9;
        private System.Windows.Forms.Button bt_numpad6;
        private System.Windows.Forms.Button bt_numpad5;
        private System.Windows.Forms.Button bt_numpad4;
        private System.Windows.Forms.Button bt_numpad3;
        private System.Windows.Forms.Button bt_numpad2;
        private System.Windows.Forms.Button bt_numpad1;
        private System.Windows.Forms.Button bt_numpad0;
        private System.Windows.Forms.Button bt_numpad_dot;
        private System.Windows.Forms.Button bt_numpad_del;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button bt_remover_todo;
        private System.Windows.Forms.Button bt_pago;
        private System.Windows.Forms.Button bt_limpiar;
        private System.Windows.Forms.ColorDialog cd_color;
        private System.Windows.Forms.Button bt_personalizar;
        private System.Windows.Forms.Button bt_salir;
    }
}