
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
            this.TListaSocios.Location = new System.Drawing.Point(47, 165);
            this.TListaSocios.Multiline = true;
            this.TListaSocios.Name = "TListaSocios";
            this.TListaSocios.ReadOnly = true;
            this.TListaSocios.Size = new System.Drawing.Size(933, 311);
            this.TListaSocios.TabIndex = 0;
            // 
            // TTelefonoo
            // 
            this.TTelefonoo.Location = new System.Drawing.Point(807, 30);
            this.TTelefonoo.Name = "TTelefonoo";
            this.TTelefonoo.Size = new System.Drawing.Size(173, 22);
            this.TTelefonoo.TabIndex = 1;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(135, 30);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(173, 22);
            this.TNombre.TabIndex = 2;
            // 
            // TApeellidos
            // 
            this.TApeellidos.Location = new System.Drawing.Point(453, 30);
            this.TApeellidos.Name = "TApeellidos";
            this.TApeellidos.Size = new System.Drawing.Size(173, 22);
            this.TApeellidos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista Socios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TApeellidos);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TTelefonoo);
            this.Controls.Add(this.TListaSocios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

