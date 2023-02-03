namespace Presentacion.GeneraTxt_Marcacion
{
    partial class GeneraTxtMarcacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneraTxtMarcacion));
            this.btnRutaArchivoTexto = new System.Windows.Forms.Button();
            this.txtRutaArchivoTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGenerarTxt = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ruta de Archivos Texto (.txt)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRutaArchivoTexto);
            this.groupBox1.Controls.Add(this.btnRutaArchivoTexto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 83);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 106);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(29, 22);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(111, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGenerarTxt);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 54);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 28);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(605, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 28);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(595, 10);
            this.panel5.TabIndex = 15;
            // 
            // btnGenerarTxt
            // 
            this.btnGenerarTxt.Location = new System.Drawing.Point(191, 6);
            this.btnGenerarTxt.Name = "btnGenerarTxt";
            this.btnGenerarTxt.Size = new System.Drawing.Size(100, 36);
            this.btnGenerarTxt.TabIndex = 11;
            this.btnGenerarTxt.Text = "Genera txt";
            this.btnGenerarTxt.UseVisualStyleBackColor = true;
            this.btnGenerarTxt.Click += new System.EventHandler(this.btnGenerarTxt_Click);
            // 
            // GeneraTxtMarcacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 188);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GeneraTxtMarcacion";
            this.Text = "GeneraTxtMarcacion";
            this.Load += new System.EventHandler(this.GeneraTxtMarcacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRutaArchivoTexto;
        private System.Windows.Forms.TextBox txtRutaArchivoTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnGenerarTxt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}