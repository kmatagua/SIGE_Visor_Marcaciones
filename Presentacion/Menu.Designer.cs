namespace Presentacion
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnStaAnita = new System.Windows.Forms.Button();
            this.btnCallao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnStaAnita);
            this.groupBox1.Controls.Add(this.btnCallao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(406, 42);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(175, 71);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "             SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnStaAnita
            // 
            this.btnStaAnita.Image = ((System.Drawing.Image)(resources.GetObject("btnStaAnita.Image")));
            this.btnStaAnita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaAnita.Location = new System.Drawing.Point(20, 42);
            this.btnStaAnita.Name = "btnStaAnita";
            this.btnStaAnita.Size = new System.Drawing.Size(175, 71);
            this.btnStaAnita.TabIndex = 0;
            this.btnStaAnita.Text = "SEDE SANTA ANITA";
            this.btnStaAnita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaAnita.UseVisualStyleBackColor = true;
            this.btnStaAnita.Click += new System.EventHandler(this.btnStaAnita_Click);
            // 
            // btnCallao
            // 
            this.btnCallao.Image = ((System.Drawing.Image)(resources.GetObject("btnCallao.Image")));
            this.btnCallao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCallao.Location = new System.Drawing.Point(212, 42);
            this.btnCallao.Name = "btnCallao";
            this.btnCallao.Size = new System.Drawing.Size(175, 71);
            this.btnCallao.TabIndex = 0;
            this.btnCallao.Text = "   SEDE CALLAO";
            this.btnCallao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCallao.UseVisualStyleBackColor = true;
            this.btnCallao.Click += new System.EventHandler(this.btnCallao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vs.20230206.1401";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 180);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISOR DE ASISTENCIA";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnStaAnita;
        private System.Windows.Forms.Button btnCallao;
        private System.Windows.Forms.Label label1;
    }
}