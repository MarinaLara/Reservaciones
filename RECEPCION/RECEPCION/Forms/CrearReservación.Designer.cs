﻿namespace RECEPCION
{
    partial class CrearReservación
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_tipo_hab = new System.Windows.Forms.ComboBox();
            this.disponibilidad_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_cuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idhabitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nocuartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipohabitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadohabitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacionesBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new RECEPCION.HotelDataSet();
            this.habitacionesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSetServidor1 = new RECEPCION.HotelDataSetServidor1();
            this.habitacionesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Cliente_nombre_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.habitacionesTableAdapter = new RECEPCION.HotelDataSetTableAdapters.HabitacionesTableAdapter();
            this.hotelDataSetServidor = new RECEPCION.HotelDataSetServidor();
            this.habitacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionesTableAdapter1 = new RECEPCION.HotelDataSetServidorTableAdapters.HabitacionesTableAdapter();
            this.habitacionesTableAdapter2 = new RECEPCION.HotelDataSetServidor1TableAdapters.HabitacionesTableAdapter();
            this.reservacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservacionesTableAdapter = new RECEPCION.HotelDataSetServidor1TableAdapters.ReservacionesTableAdapter();
            this.habitacionesBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetServidor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetServidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservacionesToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.solicitarToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem});
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.buscarToolStripMenuItem.Text = "Consultar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // solicitarToolStripMenuItem
            // 
            this.solicitarToolStripMenuItem.Name = "solicitarToolStripMenuItem";
            this.solicitarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.solicitarToolStripMenuItem.Text = "Solicitar";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha salida";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2018, 11, 20, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Location = new System.Drawing.Point(262, 60);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Value = new System.DateTime(2018, 11, 20, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de habitación";
            // 
            // cbx_tipo_hab
            // 
            this.cbx_tipo_hab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_hab.FormattingEnabled = true;
            this.cbx_tipo_hab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbx_tipo_hab.Items.AddRange(new object[] {
            "Sencilla",
            "Doble"});
            this.cbx_tipo_hab.Location = new System.Drawing.Point(498, 60);
            this.cbx_tipo_hab.Name = "cbx_tipo_hab";
            this.cbx_tipo_hab.Size = new System.Drawing.Size(92, 21);
            this.cbx_tipo_hab.TabIndex = 7;
            // 
            // disponibilidad_btn
            // 
            this.disponibilidad_btn.Location = new System.Drawing.Point(631, 47);
            this.disponibilidad_btn.Name = "disponibilidad_btn";
            this.disponibilidad_btn.Size = new System.Drawing.Size(94, 36);
            this.disponibilidad_btn.TabIndex = 10;
            this.disponibilidad_btn.Text = "Comprobar disponibilidad";
            this.disponibilidad_btn.UseVisualStyleBackColor = true;
            this.disponibilidad_btn.Click += new System.EventHandler(this.disponibilidad_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.disponibilidad_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbx_tipo_hab);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disponibilidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 261);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habitaciones disponibles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_habitacion,
            this.No_cuarto,
            this.Tipo_habitacion,
            this.Precio,
            this.Seleccionar,
            this.idhabitacionDataGridViewTextBoxColumn,
            this.nocuartoDataGridViewTextBoxColumn,
            this.tipohabitacionDataGridViewTextBoxColumn,
            this.estadohabitacionDataGridViewTextBoxColumn,
            this.disponibilidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.habitacionesBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(74, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(515, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_habitacion
            // 
            this.Id_habitacion.DataPropertyName = "Id_habitacion";
            this.Id_habitacion.HeaderText = "Id_habitacion";
            this.Id_habitacion.Name = "Id_habitacion";
            this.Id_habitacion.ReadOnly = true;
            // 
            // No_cuarto
            // 
            this.No_cuarto.DataPropertyName = "No_cuarto";
            this.No_cuarto.HeaderText = "Habitación";
            this.No_cuarto.Name = "No_cuarto";
            // 
            // Tipo_habitacion
            // 
            this.Tipo_habitacion.DataPropertyName = "Tipo_habitacion";
            this.Tipo_habitacion.HeaderText = "Tipo_habitacion";
            this.Tipo_habitacion.Name = "Tipo_habitacion";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // idhabitacionDataGridViewTextBoxColumn
            // 
            this.idhabitacionDataGridViewTextBoxColumn.DataPropertyName = "Id_habitacion";
            this.idhabitacionDataGridViewTextBoxColumn.HeaderText = "Id_habitacion";
            this.idhabitacionDataGridViewTextBoxColumn.Name = "idhabitacionDataGridViewTextBoxColumn";
            this.idhabitacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nocuartoDataGridViewTextBoxColumn
            // 
            this.nocuartoDataGridViewTextBoxColumn.DataPropertyName = "No_cuarto";
            this.nocuartoDataGridViewTextBoxColumn.HeaderText = "No_cuarto";
            this.nocuartoDataGridViewTextBoxColumn.Name = "nocuartoDataGridViewTextBoxColumn";
            // 
            // tipohabitacionDataGridViewTextBoxColumn
            // 
            this.tipohabitacionDataGridViewTextBoxColumn.DataPropertyName = "Tipo_habitacion";
            this.tipohabitacionDataGridViewTextBoxColumn.HeaderText = "Tipo_habitacion";
            this.tipohabitacionDataGridViewTextBoxColumn.Name = "tipohabitacionDataGridViewTextBoxColumn";
            // 
            // estadohabitacionDataGridViewTextBoxColumn
            // 
            this.estadohabitacionDataGridViewTextBoxColumn.DataPropertyName = "Estado_habitacion";
            this.estadohabitacionDataGridViewTextBoxColumn.HeaderText = "Estado_habitacion";
            this.estadohabitacionDataGridViewTextBoxColumn.Name = "estadohabitacionDataGridViewTextBoxColumn";
            // 
            // disponibilidadDataGridViewTextBoxColumn
            // 
            this.disponibilidadDataGridViewTextBoxColumn.DataPropertyName = "Disponibilidad";
            this.disponibilidadDataGridViewTextBoxColumn.HeaderText = "Disponibilidad";
            this.disponibilidadDataGridViewTextBoxColumn.Name = "disponibilidadDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // habitacionesBindingSource5
            // 
            this.habitacionesBindingSource5.DataMember = "Habitaciones";
            this.habitacionesBindingSource5.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitacionesBindingSource4
            // 
            this.habitacionesBindingSource4.DataMember = "Habitaciones";
            this.habitacionesBindingSource4.DataSource = this.hotelDataSetServidor1;
            // 
            // hotelDataSetServidor1
            // 
            this.hotelDataSetServidor1.DataSetName = "HotelDataSetServidor1";
            this.hotelDataSetServidor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitacionesBindingSource3
            // 
            this.habitacionesBindingSource3.DataMember = "Habitaciones";
            this.habitacionesBindingSource3.DataSource = this.hotelDataSet;
            // 
            // habitacionesBindingSource2
            // 
            this.habitacionesBindingSource2.DataMember = "Habitaciones";
            this.habitacionesBindingSource2.DataSource = this.hotelDataSetServidor1;
            // 
            // habitacionesBindingSource
            // 
            this.habitacionesBindingSource.DataMember = "Habitaciones";
            this.habitacionesBindingSource.DataSource = this.hotelDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.Cliente_nombre_txt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(743, 93);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos cliente";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(580, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Efectivo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Total: $";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(456, 20);
            this.textBox5.MaxLength = 16;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 23;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tarjeta";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // Cliente_nombre_txt
            // 
            this.Cliente_nombre_txt.Location = new System.Drawing.Point(103, 24);
            this.Cliente_nombre_txt.Name = "Cliente_nombre_txt";
            this.Cliente_nombre_txt.Size = new System.Drawing.Size(190, 20);
            this.Cliente_nombre_txt.TabIndex = 16;
            this.Cliente_nombre_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cliente_nombre_txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 554);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(454, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Crear reserva";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 554);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // habitacionesTableAdapter
            // 
            this.habitacionesTableAdapter.ClearBeforeFill = true;
            // 
            // hotelDataSetServidor
            // 
            this.hotelDataSetServidor.DataSetName = "HotelDataSetServidor";
            this.hotelDataSetServidor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitacionesBindingSource1
            // 
            this.habitacionesBindingSource1.DataMember = "Habitaciones";
            this.habitacionesBindingSource1.DataSource = this.hotelDataSetServidor;
            // 
            // habitacionesTableAdapter1
            // 
            this.habitacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // habitacionesTableAdapter2
            // 
            this.habitacionesTableAdapter2.ClearBeforeFill = true;
            // 
            // reservacionesBindingSource
            // 
            this.reservacionesBindingSource.DataMember = "Reservaciones";
            this.reservacionesBindingSource.DataSource = this.hotelDataSetServidor1;
            // 
            // reservacionesTableAdapter
            // 
            this.reservacionesTableAdapter.ClearBeforeFill = true;
            // 
            // habitacionesBindingSource6
            // 
            this.habitacionesBindingSource6.DataMember = "Habitaciones";
            this.habitacionesBindingSource6.DataSource = this.hotelDataSetServidor1;
            // 
            // CrearReservación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CrearReservación";
            this.Text = "CrearReservación";
            this.Load += new System.EventHandler(this.CrearReservación_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetServidor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetServidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_tipo_hab;
        private System.Windows.Forms.Button disponibilidad_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Cliente_nombre_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource habitacionesBindingSource;
        private HotelDataSetTableAdapters.HabitacionesTableAdapter habitacionesTableAdapter;
        private HotelDataSetServidor hotelDataSetServidor;
        private System.Windows.Forms.BindingSource habitacionesBindingSource1;
        private HotelDataSetServidorTableAdapters.HabitacionesTableAdapter habitacionesTableAdapter1;
        private HotelDataSetServidor1 hotelDataSetServidor1;
        private System.Windows.Forms.BindingSource habitacionesBindingSource2;
        private HotelDataSetServidor1TableAdapters.HabitacionesTableAdapter habitacionesTableAdapter2;
        private System.Windows.Forms.BindingSource habitacionesBindingSource3;
        private System.Windows.Forms.BindingSource reservacionesBindingSource;
        private HotelDataSetServidor1TableAdapters.ReservacionesTableAdapter reservacionesTableAdapter;
        private System.Windows.Forms.BindingSource habitacionesBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_cuarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nocuartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipohabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadohabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource habitacionesBindingSource5;
        private System.Windows.Forms.BindingSource habitacionesBindingSource6;
    }
}