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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnStaAnita);
            this.groupBox1.Controls.Add(this.btnCallao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(447, 47);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(175, 71);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnStaAnita
            // 
            this.btnStaAnita.Image = ((System.Drawing.Image)(resources.GetObject("btnStaAnita.Image")));
            this.btnStaAnita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaAnita.Location = new System.Drawing.Point(24, 47);
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
            this.btnCallao.Location = new System.Drawing.Point(216, 47);
            this.btnCallao.Name = "btnCallao";
            this.btnCallao.Size = new System.Drawing.Size(175, 71);
            this.btnCallao.TabIndex = 0;
            this.btnCallao.Text = "   SEDE CALLAO";
            this.btnCallao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCallao.UseVisualStyleBackColor = true;
            this.btnCallao.Click += new System.EventHandler(this.btnCallao_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 197);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnStaAnita;
        private System.Windows.Forms.Button btnCallao;
    }
}