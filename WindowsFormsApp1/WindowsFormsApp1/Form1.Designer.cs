
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.TListaSocios = new System.Windows.Forms.TextBox();
            this.TTelefonoo = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApeellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TListaSocios
            // 
            this.TListaSocios.Location = new System.Drawing.Point(35, 134);
            this.TListaSocios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TListaSocios.Multiline = true;
            this.TListaSocios.Name = "TListaSocios";
            this.TListaSocios.ReadOnly = true;
            this.TListaSocios.Size = new System.Drawing.Size(701, 253);
            this.TListaSocios.TabIndex = 0;
            // 
            // TTelefonoo
            // 
            this.TTelefonoo.Location = new System.Drawing.Point(605, 24);
            this.TTelefonoo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TTelefonoo.Name = "TTelefonoo";
            this.TTelefonoo.Size = new System.Drawing.Size(131, 20);
            this.TTelefonoo.TabIndex = 1;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(101, 24);
            this.TNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(131, 20);
            this.TNombre.TabIndex = 2;
            // 
            // TApeellidos
            // 
            this.TApeellidos.Location = new System.Drawing.Point(340, 24);
            this.TApeellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TApeellidos.Name = "TApeellidos";
            this.TApeellidos.Size = new System.Drawing.Size(131, 20);
            this.TApeellidos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Móvil";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista Socios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TApeellidos);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TTelefonoo);
            this.Controls.Add(this.TListaSocios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TListaSocios;
        private System.Windows.Forms.TextBox TTelefonoo;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApeellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

