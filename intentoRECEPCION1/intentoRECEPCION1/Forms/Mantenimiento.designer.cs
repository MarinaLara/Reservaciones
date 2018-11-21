namespace intentoRECEPCION1
{
    partial class Mantenimiento
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
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ins_habit_txt = new System.Windows.Forms.TextBox();
            this.busc_cli_hab_txt = new System.Windows.Forms.TextBox();
            this.cbx_solicitud = new System.Windows.Forms.ComboBox();
            this.enviar_btn = new System.Windows.Forms.Button();
            this.consultar_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.hotelDataSet = new intentoRECEPCION1.HotelDataSet();
            this.solicitudesrecepcionmantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudes_recepcion_mantenimientoTableAdapter = new intentoRECEPCION1.HotelDataSetTableAdapters.solicitudes_recepcion_mantenimientoTableAdapter();
            this.fechasolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesrecepcionmantenimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(78)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservacionesToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // ins_habit_txt
            // 
            this.ins_habit_txt.Location = new System.Drawing.Point(52, 319);
            this.ins_habit_txt.Name = "ins_habit_txt";
            this.ins_habit_txt.Size = new System.Drawing.Size(100, 20);
            this.ins_habit_txt.TabIndex = 1;
            // 
            // busc_cli_hab_txt
            // 
            this.busc_cli_hab_txt.Location = new System.Drawing.Point(60, 72);
            this.busc_cli_hab_txt.Name = "busc_cli_hab_txt";
            this.busc_cli_hab_txt.Size = new System.Drawing.Size(182, 20);
            this.busc_cli_hab_txt.TabIndex = 2;
            // 
            // cbx_solicitud
            // 
            this.cbx_solicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_solicitud.FormattingEnabled = true;
            this.cbx_solicitud.Items.AddRange(new object[] {
            "Limpieza",
            "Mantenimiento"});
            this.cbx_solicitud.Location = new System.Drawing.Point(213, 316);
            this.cbx_solicitud.Name = "cbx_solicitud";
            this.cbx_solicitud.Size = new System.Drawing.Size(121, 21);
            this.cbx_solicitud.TabIndex = 3;
            // 
            // enviar_btn
            // 
            this.enviar_btn.Location = new System.Drawing.Point(368, 316);
            this.enviar_btn.Name = "enviar_btn";
            this.enviar_btn.Size = new System.Drawing.Size(113, 24);
            this.enviar_btn.TabIndex = 4;
            this.enviar_btn.Text = "Enviar";
            this.enviar_btn.UseVisualStyleBackColor = true;
            this.enviar_btn.Click += new System.EventHandler(this.enviar_btn_Click);
            // 
            // consultar_btn
            // 
            this.consultar_btn.Location = new System.Drawing.Point(326, 72);
            this.consultar_btn.Name = "consultar_btn";
            this.consultar_btn.Size = new System.Drawing.Size(155, 23);
            this.consultar_btn.TabIndex = 5;
            this.consultar_btn.Text = "Consultar";
            this.consultar_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(38, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 150);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Entrada o Salida";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechasolicitudDataGridViewTextBoxColumn,
            this.solicitaDataGridViewTextBoxColumn,
            this.habitacionDataGridViewTextBoxColumn,
            this.estadosolicitudDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.solicitudesrecepcionmantenimientoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 124);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(49, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Habitación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Solicitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cliente/Habitación";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 28);
            this.button3.TabIndex = 18;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudesrecepcionmantenimientoBindingSource
            // 
            this.solicitudesrecepcionmantenimientoBindingSource.DataMember = "solicitudes_recepcion_mantenimiento";
            this.solicitudesrecepcionmantenimientoBindingSource.DataSource = this.hotelDataSet;
            // 
            // solicitudes_recepcion_mantenimientoTableAdapter
            // 
            this.solicitudes_recepcion_mantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // fechasolicitudDataGridViewTextBoxColumn
            // 
            this.fechasolicitudDataGridViewTextBoxColumn.DataPropertyName = "Fecha_solicitud";
            this.fechasolicitudDataGridViewTextBoxColumn.HeaderText = "Fecha_solicitud";
            this.fechasolicitudDataGridViewTextBoxColumn.Name = "fechasolicitudDataGridViewTextBoxColumn";
            // 
            // solicitaDataGridViewTextBoxColumn
            // 
            this.solicitaDataGridViewTextBoxColumn.DataPropertyName = "Solicita";
            this.solicitaDataGridViewTextBoxColumn.HeaderText = "Solicita";
            this.solicitaDataGridViewTextBoxColumn.Name = "solicitaDataGridViewTextBoxColumn";
            // 
            // habitacionDataGridViewTextBoxColumn
            // 
            this.habitacionDataGridViewTextBoxColumn.DataPropertyName = "Habitacion";
            this.habitacionDataGridViewTextBoxColumn.HeaderText = "Habitacion";
            this.habitacionDataGridViewTextBoxColumn.Name = "habitacionDataGridViewTextBoxColumn";
            // 
            // estadosolicitudDataGridViewTextBoxColumn
            // 
            this.estadosolicitudDataGridViewTextBoxColumn.DataPropertyName = "Estado_solicitud";
            this.estadosolicitudDataGridViewTextBoxColumn.HeaderText = "Estado_solicitud";
            this.estadosolicitudDataGridViewTextBoxColumn.Name = "estadosolicitudDataGridViewTextBoxColumn";
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(533, 423);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.consultar_btn);
            this.Controls.Add(this.enviar_btn);
            this.Controls.Add(this.cbx_solicitud);
            this.Controls.Add(this.busc_cli_hab_txt);
            this.Controls.Add(this.ins_habit_txt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesrecepcionmantenimientoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.TextBox ins_habit_txt;
        private System.Windows.Forms.TextBox busc_cli_hab_txt;
        private System.Windows.Forms.ComboBox cbx_solicitud;
        private System.Windows.Forms.Button enviar_btn;
        private System.Windows.Forms.Button consultar_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource solicitudesrecepcionmantenimientoBindingSource;
        private HotelDataSetTableAdapters.solicitudes_recepcion_mantenimientoTableAdapter solicitudes_recepcion_mantenimientoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasolicitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadosolicitudDataGridViewTextBoxColumn;
    }
}