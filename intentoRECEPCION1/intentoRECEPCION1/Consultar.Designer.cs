namespace intentoRECEPCION1
{
    partial class Consultar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.habitacionesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new intentoRECEPCION1.HotelDataSet();
            this.reservacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservacionesDataSet1 = new intentoRECEPCION1.reservacionesDataSet1();
            this.reservacionesDataSet = new intentoRECEPCION1.reservacionesDataSet();
            this.reservacionesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionesTableAdapter = new intentoRECEPCION1.reservacionesDataSetTableAdapters.habitacionesTableAdapter();
            this.reservasTableAdapter = new intentoRECEPCION1.reservacionesDataSet1TableAdapters.reservasTableAdapter();
            this.reservacionesTableAdapter = new intentoRECEPCION1.HotelDataSetTableAdapters.ReservacionesTableAdapter();
            this.habitacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionesTableAdapter1 = new intentoRECEPCION1.HotelDataSetTableAdapters.HabitacionesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Habitación});
            this.dataGridView1.DataSource = this.habitacionesBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(61, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // habitacionesBindingSource2
            // 
            this.habitacionesBindingSource2.DataMember = "Habitaciones";
            this.habitacionesBindingSource2.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservacionesBindingSource
            // 
            this.reservacionesBindingSource.DataMember = "Reservaciones";
            this.reservacionesBindingSource.DataSource = this.hotelDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservacionesToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            this.reservacionesToolStripMenuItem.Click += new System.EventHandler(this.reservacionesToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre cliente a buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha ingreso";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "reservas";
            this.reservasBindingSource.DataSource = this.reservacionesDataSet1;
            // 
            // reservacionesDataSet1
            // 
            this.reservacionesDataSet1.DataSetName = "reservacionesDataSet1";
            this.reservacionesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservacionesDataSet
            // 
            this.reservacionesDataSet.DataSetName = "reservacionesDataSet";
            this.reservacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservacionesDataSetBindingSource
            // 
            this.reservacionesDataSetBindingSource.DataSource = this.reservacionesDataSet;
            this.reservacionesDataSetBindingSource.Position = 0;
            // 
            // habitacionesBindingSource
            // 
            this.habitacionesBindingSource.DataMember = "habitaciones";
            this.habitacionesBindingSource.DataSource = this.reservacionesDataSet;
            // 
            // habitacionesTableAdapter
            // 
            this.habitacionesTableAdapter.ClearBeforeFill = true;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // reservacionesTableAdapter
            // 
            this.reservacionesTableAdapter.ClearBeforeFill = true;
            // 
            // habitacionesBindingSource1
            // 
            this.habitacionesBindingSource1.DataMember = "Habitaciones";
            this.habitacionesBindingSource1.DataSource = this.hotelDataSet;
            // 
            // habitacionesTableAdapter1
            // 
            this.habitacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(553, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Id_habitacion";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Habitación
            // 
            this.Habitación.DataPropertyName = "Id_habitacion";
            this.Habitación.HeaderText = "Habitación";
            this.Habitación.Name = "Habitación";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(725, 463);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.BindingSource reservacionesDataSetBindingSource;
        private reservacionesDataSet reservacionesDataSet;
        private System.Windows.Forms.BindingSource habitacionesBindingSource;
        private reservacionesDataSetTableAdapters.habitacionesTableAdapter habitacionesTableAdapter;
        private reservacionesDataSet1 reservacionesDataSet1;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private reservacionesDataSet1TableAdapters.reservasTableAdapter reservasTableAdapter;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource reservacionesBindingSource;
        private HotelDataSetTableAdapters.ReservacionesTableAdapter reservacionesTableAdapter;
        private System.Windows.Forms.BindingSource habitacionesBindingSource1;
        private HotelDataSetTableAdapters.HabitacionesTableAdapter habitacionesTableAdapter1;
        private System.Windows.Forms.BindingSource habitacionesBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitación;
    }
}