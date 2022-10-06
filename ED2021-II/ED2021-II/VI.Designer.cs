
namespace ED2021_II
{
    partial class VentanaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInicial));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BCLIENTES = new System.Windows.Forms.Button();
            this.BPRODUCTOS = new System.Windows.Forms.Button();
            this.BTIENDAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(207, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "VENTANA INICIAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "CONTROL DE BASE DE DATOS SQL";
            // 
            // BCLIENTES
            // 
            this.BCLIENTES.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCLIENTES.Location = new System.Drawing.Point(235, 132);
            this.BCLIENTES.Name = "BCLIENTES";
            this.BCLIENTES.Size = new System.Drawing.Size(139, 54);
            this.BCLIENTES.TabIndex = 12;
            this.BCLIENTES.Text = "CLIENTES";
            this.BCLIENTES.UseVisualStyleBackColor = true;
            this.BCLIENTES.Click += new System.EventHandler(this.BCLIENTES_Click);
            // 
            // BPRODUCTOS
            // 
            this.BPRODUCTOS.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BPRODUCTOS.Location = new System.Drawing.Point(235, 231);
            this.BPRODUCTOS.Name = "BPRODUCTOS";
            this.BPRODUCTOS.Size = new System.Drawing.Size(139, 54);
            this.BPRODUCTOS.TabIndex = 13;
            this.BPRODUCTOS.Text = "PRODUCTOS";
            this.BPRODUCTOS.UseVisualStyleBackColor = true;
            this.BPRODUCTOS.Click += new System.EventHandler(this.BPRODUCTOS_Click);
            // 
            // BTIENDAS
            // 
            this.BTIENDAS.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTIENDAS.Location = new System.Drawing.Point(235, 327);
            this.BTIENDAS.Name = "BTIENDAS";
            this.BTIENDAS.Size = new System.Drawing.Size(139, 54);
            this.BTIENDAS.TabIndex = 14;
            this.BTIENDAS.Text = "TIENDAS";
            this.BTIENDAS.UseVisualStyleBackColor = true;
            this.BTIENDAS.Click += new System.EventHandler(this.BTIENDAS_Click);
            // 
            // VentanaInicial
            // 
            this.ClientSize = new System.Drawing.Size(644, 441);
            this.Controls.Add(this.BTIENDAS);
            this.Controls.Add(this.BPRODUCTOS);
            this.Controls.Add(this.BCLIENTES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaInicial";
            this.Text = "Control BD SQL";
            this.Load += new System.EventHandler(this.VentanaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BCLIENTES;
        private System.Windows.Forms.Button BPRODUCTOS;
        private System.Windows.Forms.Button BTIENDAS;
    }
}

