
namespace ED2021_II
{
    partial class FormularioProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_ID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_Cost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_Weight = new System.Windows.Forms.TextBox();
            this.LB_SKU = new System.Windows.Forms.Label();
            this.B_Editar = new System.Windows.Forms.Button();
            this.LB_Brand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(102, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "EDICION DE PRODUCTOS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "CONTROL DE BASE DE DATOS SQL";
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_ID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_ID.Location = new System.Drawing.Point(258, 122);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(165, 27);
            this.LB_ID.TabIndex = 12;
            this.LB_ID.Text = "                    label4";
            this.LB_ID.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(65, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "PRODUCT BRAND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(65, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "PRODUCT NAME";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(258, 205);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(163, 23);
            this.TB_Name.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(65, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "PRODUCT SKU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(65, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "PRODUCT PRICE";
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(258, 286);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(163, 23);
            this.TB_Price.TabIndex = 18;
            this.TB_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(65, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "PRODUCT COST";
            // 
            // TB_Cost
            // 
            this.TB_Cost.Location = new System.Drawing.Point(258, 325);
            this.TB_Cost.Name = "TB_Cost";
            this.TB_Cost.Size = new System.Drawing.Size(163, 23);
            this.TB_Cost.TabIndex = 20;
            this.TB_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(65, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "PRODUCT WEIGHT";
            // 
            // TB_Weight
            // 
            this.TB_Weight.Location = new System.Drawing.Point(258, 363);
            this.TB_Weight.Name = "TB_Weight";
            this.TB_Weight.Size = new System.Drawing.Size(163, 23);
            this.TB_Weight.TabIndex = 22;
            this.TB_Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_SKU
            // 
            this.LB_SKU.AutoSize = true;
            this.LB_SKU.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LB_SKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_SKU.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_SKU.Location = new System.Drawing.Point(258, 248);
            this.LB_SKU.Name = "LB_SKU";
            this.LB_SKU.Size = new System.Drawing.Size(160, 27);
            this.LB_SKU.TabIndex = 26;
            this.LB_SKU.Text = "                 label12";
            // 
            // B_Editar
            // 
            this.B_Editar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Editar.Location = new System.Drawing.Point(160, 421);
            this.B_Editar.Name = "B_Editar";
            this.B_Editar.Size = new System.Drawing.Size(178, 39);
            this.B_Editar.TabIndex = 27;
            this.B_Editar.Text = "ENVIAR";
            this.B_Editar.UseVisualStyleBackColor = true;
            this.B_Editar.Click += new System.EventHandler(this.B_Editar_Click);
            // 
            // LB_Brand
            // 
            this.LB_Brand.AutoSize = true;
            this.LB_Brand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LB_Brand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Brand.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Brand.Location = new System.Drawing.Point(258, 165);
            this.LB_Brand.Name = "LB_Brand";
            this.LB_Brand.Size = new System.Drawing.Size(165, 27);
            this.LB_Brand.TabIndex = 28;
            this.LB_Brand.Text = "                    label4";
            // 
            // FormularioProductos
            // 
            this.ClientSize = new System.Drawing.Size(479, 483);
            this.Controls.Add(this.LB_Brand);
            this.Controls.Add(this.B_Editar);
            this.Controls.Add(this.LB_SKU);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_Weight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_Cost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioProductos";
            this.Text = "Control BD SQL";
            this.Load += new System.EventHandler(this.FormularioProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Cost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_Weight;
        private System.Windows.Forms.Label LB_SKU;
        private System.Windows.Forms.Button B_Editar;
        private System.Windows.Forms.Label LB_Brand;
    }
}

