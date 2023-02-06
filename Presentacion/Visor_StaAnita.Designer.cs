namespace Presentacion
{
    partial class Visor_StaAnita
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visor_StaAnita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer_Marcacion = new System.Windows.Forms.Timer(this.components);
            this.timer_FechaHora = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binNvgListado = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dtpFeFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFeInicio = new System.Windows.Forms.DateTimePicker();
            this.btnCopiarDatos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvListaSantaAnita = new System.Windows.Forms.DataGridView();
            this.intIdMarcacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNoUsuario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCoUsuario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dttFeMarcacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnActualizar2 = new System.Windows.Forms.Button();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerarTxt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha_GeneraTxt = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRutaArchivoTexto = new System.Windows.Forms.TextBox();
            this.btnRutaArchivoTexto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binNvgListado)).BeginInit();
            this.binNvgListado.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSantaAnita)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 710);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(730, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 710);
            this.panel3.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(558, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(116, 38);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCerrar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 666);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(720, 54);
            this.panel5.TabIndex = 5;
            // 
            // timer_Marcacion
            // 
            this.timer_Marcacion.Interval = 20000;
            this.timer_Marcacion.Tick += new System.EventHandler(this.timer_Marcacion_Tick);
            // 
            // timer_FechaHora
            // 
            this.timer_FechaHora.Interval = 1000;
            this.timer_FechaHora.Tick += new System.EventHandler(this.timer_FechaHora_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRegistro);
            this.tabPage2.Controls.Add(this.binNvgListado);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registros de Asistencia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistro.Location = new System.Drawing.Point(3, 124);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.RowHeadersWidth = 20;
            this.dgvRegistro.Size = new System.Drawing.Size(706, 503);
            this.dgvRegistro.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "intIdMarcacion";
            this.dataGridViewTextBoxColumn1.HeaderText = "intIdMarcacion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "strNoUsuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Personal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 320;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "intCoUsuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código Personal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 170;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dttFeMarcacion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora de Marcación";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 170;
            // 
            // binNvgListado
            // 
            this.binNvgListado.AddNewItem = null;
            this.binNvgListado.CountItem = this.bindingNavigatorCountItem;
            this.binNvgListado.DeleteItem = null;
            this.binNvgListado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.binNvgListado.Location = new System.Drawing.Point(3, 99);
            this.binNvgListado.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.binNvgListado.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.binNvgListado.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.binNvgListado.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.binNvgListado.Name = "binNvgListado";
            this.binNvgListado.PositionItem = this.bindingNavigatorPositionItem;
            this.binNvgListado.Size = new System.Drawing.Size(706, 25);
            this.binNvgListado.TabIndex = 14;
            this.binNvgListado.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtBusqueda);
            this.panel4.Controls.Add(this.dtpFeFin);
            this.panel4.Controls.Add(this.dtpFeInicio);
            this.panel4.Controls.Add(this.btnCopiarDatos);
            this.panel4.Controls.Add(this.btnBuscar);
            this.panel4.Controls.Add(this.btnLimpiar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(706, 96);
            this.panel4.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicio";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.Info;
            this.txtBusqueda.Location = new System.Drawing.Point(12, 62);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(226, 20);
            this.txtBusqueda.TabIndex = 2;
            // 
            // dtpFeFin
            // 
            this.dtpFeFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFeFin.Location = new System.Drawing.Point(146, 25);
            this.dtpFeFin.Name = "dtpFeFin";
            this.dtpFeFin.Size = new System.Drawing.Size(92, 20);
            this.dtpFeFin.TabIndex = 1;
            // 
            // dtpFeInicio
            // 
            this.dtpFeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFeInicio.Location = new System.Drawing.Point(12, 25);
            this.dtpFeInicio.Name = "dtpFeInicio";
            this.dtpFeInicio.Size = new System.Drawing.Size(92, 20);
            this.dtpFeInicio.TabIndex = 1;
            // 
            // btnCopiarDatos
            // 
            this.btnCopiarDatos.AutoSize = true;
            this.btnCopiarDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiarDatos.Image")));
            this.btnCopiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopiarDatos.Location = new System.Drawing.Point(306, 44);
            this.btnCopiarDatos.Name = "btnCopiarDatos";
            this.btnCopiarDatos.Size = new System.Drawing.Size(116, 38);
            this.btnCopiarDatos.TabIndex = 0;
            this.btnCopiarDatos.Text = "Copiar Datos";
            this.btnCopiarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopiarDatos.UseVisualStyleBackColor = true;
            this.btnCopiarDatos.Click += new System.EventHandler(this.btnCopiarDatos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(244, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 57);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(428, 44);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 38);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 656);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvListaSantaAnita);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(712, 630);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asistencia Santa Anita";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvListaSantaAnita
            // 
            this.dgvListaSantaAnita.AllowUserToAddRows = false;
            this.dgvListaSantaAnita.AllowUserToDeleteRows = false;
            this.dgvListaSantaAnita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSantaAnita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intIdMarcacion2,
            this.strNoUsuario2,
            this.intCoUsuario2,
            this.dttFeMarcacion2});
            this.dgvListaSantaAnita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaSantaAnita.Location = new System.Drawing.Point(3, 86);
            this.dgvListaSantaAnita.Name = "dgvListaSantaAnita";
            this.dgvListaSantaAnita.ReadOnly = true;
            this.dgvListaSantaAnita.RowHeadersWidth = 20;
            this.dgvListaSantaAnita.Size = new System.Drawing.Size(706, 541);
            this.dgvListaSantaAnita.TabIndex = 12;
            // 
            // intIdMarcacion2
            // 
            this.intIdMarcacion2.DataPropertyName = "intIdMarcacion";
            this.intIdMarcacion2.HeaderText = "intIdMarcacion";
            this.intIdMarcacion2.Name = "intIdMarcacion2";
            this.intIdMarcacion2.ReadOnly = true;
            this.intIdMarcacion2.Visible = false;
            this.intIdMarcacion2.Width = 60;
            // 
            // strNoUsuario2
            // 
            this.strNoUsuario2.DataPropertyName = "strNoUsuario";
            this.strNoUsuario2.HeaderText = "Personal";
            this.strNoUsuario2.Name = "strNoUsuario2";
            this.strNoUsuario2.ReadOnly = true;
            this.strNoUsuario2.Width = 320;
            // 
            // intCoUsuario2
            // 
            this.intCoUsuario2.DataPropertyName = "intCoUsuario";
            this.intCoUsuario2.HeaderText = "Código Personal";
            this.intCoUsuario2.Name = "intCoUsuario2";
            this.intCoUsuario2.ReadOnly = true;
            this.intCoUsuario2.Width = 170;
            // 
            // dttFeMarcacion2
            // 
            this.dttFeMarcacion2.DataPropertyName = "dttFeMarcacion";
            this.dttFeMarcacion2.HeaderText = "Hora de Marcación";
            this.dttFeMarcacion2.Name = "dttFeMarcacion2";
            this.dttFeMarcacion2.ReadOnly = true;
            this.dttFeMarcacion2.Width = 170;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnActualizar2);
            this.panel7.Controls.Add(this.lblHora2);
            this.panel7.Controls.Add(this.lblFecha2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(706, 83);
            this.panel7.TabIndex = 13;
            // 
            // btnActualizar2
            // 
            this.btnActualizar2.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar2.Image")));
            this.btnActualizar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar2.Location = new System.Drawing.Point(573, 14);
            this.btnActualizar2.Name = "btnActualizar2";
            this.btnActualizar2.Size = new System.Drawing.Size(116, 29);
            this.btnActualizar2.TabIndex = 0;
            this.btnActualizar2.Text = "Actualizar";
            this.btnActualizar2.UseVisualStyleBackColor = true;
            this.btnActualizar2.Click += new System.EventHandler(this.btnActualizar2_Click);
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora2.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHora2.Location = new System.Drawing.Point(6, 7);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(150, 31);
            this.lblHora2.TabIndex = 3;
            this.lblHora2.Text = "HH:mm:ss";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFecha2.Location = new System.Drawing.Point(6, 38);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(149, 29);
            this.lblFecha2.TabIndex = 3;
            this.lblFecha2.Text = "dd/MM/yyyy";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(712, 630);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Generar Txt Asistencia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerarTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpFecha_GeneraTxt);
            this.groupBox2.Location = new System.Drawing.Point(26, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 92);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btnGenerarTxt
            // 
            this.btnGenerarTxt.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarTxt.Image")));
            this.btnGenerarTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarTxt.Location = new System.Drawing.Point(154, 31);
            this.btnGenerarTxt.Name = "btnGenerarTxt";
            this.btnGenerarTxt.Size = new System.Drawing.Size(100, 36);
            this.btnGenerarTxt.TabIndex = 15;
            this.btnGenerarTxt.Text = "Genera txt";
            this.btnGenerarTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarTxt.UseVisualStyleBackColor = true;
            this.btnGenerarTxt.Click += new System.EventHandler(this.btnGenerarTxt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha";
            // 
            // dtpFecha_GeneraTxt
            // 
            this.dtpFecha_GeneraTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_GeneraTxt.Location = new System.Drawing.Point(20, 47);
            this.dtpFecha_GeneraTxt.Name = "dtpFecha_GeneraTxt";
            this.dtpFecha_GeneraTxt.Size = new System.Drawing.Size(111, 20);
            this.dtpFecha_GeneraTxt.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRutaArchivoTexto);
            this.groupBox1.Controls.Add(this.btnRutaArchivoTexto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(26, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 83);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // txtRutaArchivoTexto
            // 
            this.txtRutaArchivoTexto.BackColor = System.Drawing.Color.SeaShell;
            this.txtRutaArchivoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivoTexto.Location = new System.Drawing.Point(17, 40);
            this.txtRutaArchivoTexto.Name = "txtRutaArchivoTexto";
            this.txtRutaArchivoTexto.ReadOnly = true;
            this.txtRutaArchivoTexto.Size = new System.Drawing.Size(389, 21);
            this.txtRutaArchivoTexto.TabIndex = 8;
            // 
            // btnRutaArchivoTexto
            // 
            this.btnRutaArchivoTexto.Image = ((System.Drawing.Image)(resources.GetObject("btnRutaArchivoTexto.Image")));
            this.btnRutaArchivoTexto.Location = new System.Drawing.Point(412, 22);
            this.btnRutaArchivoTexto.Name = "btnRutaArchivoTexto";
            this.btnRutaArchivoTexto.Size = new System.Drawing.Size(46, 39);
            this.btnRutaArchivoTexto.TabIndex = 7;
            this.btnRutaArchivoTexto.UseVisualStyleBackColor = true;
            this.btnRutaArchivoTexto.Click += new System.EventHandler(this.btnRutaArchivoTexto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ruta de Archivos Texto (.txt)";
            // 
            // Visor_StaAnita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 720);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visor_StaAnita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visor de Marcaciones - Santa Anita";
            this.Load += new System.EventHandler(this.Visor_StaAnita_Load);
            this.panel5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binNvgListado)).EndInit();
            this.binNvgListado.ResumeLayout(false);
            this.binNvgListado.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSantaAnita)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer_Marcacion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Timer timer_FechaHora;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.BindingNavigator binNvgListado;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFeFin;
        private System.Windows.Forms.DateTimePicker dtpFeInicio;
        private System.Windows.Forms.Button btnCopiarDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvListaSantaAnita;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnActualizar2;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn intIdMarcacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNoUsuario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCoUsuario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dttFeMarcacion2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRutaArchivoTexto;
        private System.Windows.Forms.Button btnRutaArchivoTexto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerarTxt;
        private System.Windows.Forms.DateTimePicker dtpFecha_GeneraTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}

