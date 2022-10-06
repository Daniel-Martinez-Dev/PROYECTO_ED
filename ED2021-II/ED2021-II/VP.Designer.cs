
namespace ED2021_II
{
    partial class VentanaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaProductos));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Nombre = new System.Windows.Forms.ComboBox();
            this.CB_ID = new System.Windows.Forms.ComboBox();
            this.CB_TOP = new System.Windows.Forms.NumericUpDown();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.B_Editar = new System.Windows.Forms.Button();
            this.B_Consultar = new System.Windows.Forms.Button();
            this.B_Por = new System.Windows.Forms.Button();
            this.L_Top = new System.Windows.Forms.Label();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.DGV_Productos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.B_VER = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_POR = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CB_TOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(330, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "PRODUCTOS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "CONTROL DE BASE DE DATOS SQL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CB_Nombre
            // 
            this.CB_Nombre.FormattingEnabled = true;
            this.CB_Nombre.Location = new System.Drawing.Point(38, 174);
            this.CB_Nombre.Name = "CB_Nombre";
            this.CB_Nombre.Size = new System.Drawing.Size(313, 23);
            this.CB_Nombre.TabIndex = 38;
            // 
            // CB_ID
            // 
            this.CB_ID.FormattingEnabled = true;
            this.CB_ID.Location = new System.Drawing.Point(203, 41);
            this.CB_ID.Name = "CB_ID";
            this.CB_ID.Size = new System.Drawing.Size(183, 23);
            this.CB_ID.TabIndex = 37;
            // 
            // CB_TOP
            // 
            this.CB_TOP.Location = new System.Drawing.Point(78, 90);
            this.CB_TOP.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CB_TOP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CB_TOP.Name = "CB_TOP";
            this.CB_TOP.Size = new System.Drawing.Size(56, 23);
            this.CB_TOP.TabIndex = 36;
            this.CB_TOP.Tag = "";
            this.CB_TOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CB_TOP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Eliminar.Location = new System.Drawing.Point(261, 106);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(125, 39);
            this.B_Eliminar.TabIndex = 35;
            this.B_Eliminar.Text = "ELIMINAR";
            this.B_Eliminar.UseVisualStyleBackColor = true;
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // B_Editar
            // 
            this.B_Editar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Editar.Location = new System.Drawing.Point(137, 106);
            this.B_Editar.Name = "B_Editar";
            this.B_Editar.Size = new System.Drawing.Size(102, 39);
            this.B_Editar.TabIndex = 34;
            this.B_Editar.Text = "EDITAR";
            this.B_Editar.UseVisualStyleBackColor = true;
            this.B_Editar.Click += new System.EventHandler(this.B_Editar_Click);
            // 
            // B_Consultar
            // 
            this.B_Consultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Consultar.Location = new System.Drawing.Point(89, 106);
            this.B_Consultar.Name = "B_Consultar";
            this.B_Consultar.Size = new System.Drawing.Size(178, 39);
            this.B_Consultar.TabIndex = 33;
            this.B_Consultar.Text = "CONSULTAR";
            this.B_Consultar.UseVisualStyleBackColor = true;
            this.B_Consultar.Click += new System.EventHandler(this.B_Consultar_Click);
            // 
            // B_Por
            // 
            this.B_Por.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Por.Location = new System.Drawing.Point(141, 134);
            this.B_Por.Name = "B_Por";
            this.B_Por.Size = new System.Drawing.Size(75, 36);
            this.B_Por.TabIndex = 32;
            this.B_Por.Text = "Ir";
            this.B_Por.UseVisualStyleBackColor = true;
            this.B_Por.Click += new System.EventHandler(this.B_Por_Click);
            // 
            // L_Top
            // 
            this.L_Top.AutoSize = true;
            this.L_Top.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_Top.Location = new System.Drawing.Point(78, 33);
            this.L_Top.Name = "L_Top";
            this.L_Top.Size = new System.Drawing.Size(200, 32);
            this.L_Top.TabIndex = 30;
            this.L_Top.Text = "TOP PRODUCTOS";
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_Nombre.Location = new System.Drawing.Point(54, 130);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(289, 32);
            this.L_Nombre.TabIndex = 28;
            this.L_Nombre.Text = "NOMBRE DEL PRODUCTO";
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_ID.Location = new System.Drawing.Point(24, 32);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(167, 32);
            this.L_ID.TabIndex = 27;
            this.L_ID.Text = "ID PRODUCTO";
            // 
            // DGV_Productos
            // 
            this.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Productos.Location = new System.Drawing.Point(387, 293);
            this.DGV_Productos.Name = "DGV_Productos";
            this.DGV_Productos.RowTemplate.Height = 25;
            this.DGV_Productos.Size = new System.Drawing.Size(401, 176);
            this.DGV_Productos.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Consultar);
            this.groupBox1.Location = new System.Drawing.Point(22, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 163);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.B_VER);
            this.groupBox2.Controls.Add(this.CB_ID);
            this.groupBox2.Controls.Add(this.L_ID);
            this.groupBox2.Controls.Add(this.B_Eliminar);
            this.groupBox2.Controls.Add(this.B_Editar);
            this.groupBox2.Location = new System.Drawing.Point(387, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 163);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edición/Eliminación";
            // 
            // B_VER
            // 
            this.B_VER.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_VER.Location = new System.Drawing.Point(15, 106);
            this.B_VER.Name = "B_VER";
            this.B_VER.Size = new System.Drawing.Size(102, 39);
            this.B_VER.TabIndex = 38;
            this.B_VER.Text = "VER";
            this.B_VER.UseVisualStyleBackColor = true;
            this.B_VER.Click += new System.EventHandler(this.B_VER_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CB_POR);
            this.groupBox3.Controls.Add(this.L_Top);
            this.groupBox3.Controls.Add(this.B_Por);
            this.groupBox3.Controls.Add(this.CB_TOP);
            this.groupBox3.Location = new System.Drawing.Point(22, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 176);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta General";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(141, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 32);
            this.label4.TabIndex = 39;
            this.label4.Text = "POR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "TOP:";
            // 
            // CB_POR
            // 
            this.CB_POR.FormattingEnabled = true;
            this.CB_POR.Items.AddRange(new object[] {
            "Precio",
            "Cantidad Vendida",
            "Monto Vendido"});
            this.CB_POR.Location = new System.Drawing.Point(209, 89);
            this.CB_POR.Name = "CB_POR";
            this.CB_POR.Size = new System.Drawing.Size(121, 23);
            this.CB_POR.TabIndex = 37;
            // 
            // VentanaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.DGV_Productos);
            this.Controls.Add(this.CB_Nombre);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaProductos";
            this.Text = "Control BD SQL";
            this.Load += new System.EventHandler(this.VentanaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CB_TOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Nombre;
        private System.Windows.Forms.ComboBox CB_ID;
        private System.Windows.Forms.NumericUpDown CB_TOP;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Button B_Editar;
        private System.Windows.Forms.Button B_Consultar;
        private System.Windows.Forms.Button B_Por;
        private System.Windows.Forms.Label L_Top;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.DataGridView DGV_Productos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CB_POR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_VER;
    }
}

