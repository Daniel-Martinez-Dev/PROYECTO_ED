
namespace ED2021_II
{
    partial class VentanaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaClientes));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.B_NuevoCliente = new System.Windows.Forms.Button();
            this.L_Top = new System.Windows.Forms.Label();
            this.B_Por = new System.Windows.Forms.Button();
            this.B_Consultar = new System.Windows.Forms.Button();
            this.B_Editar = new System.Windows.Forms.Button();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.CB_TOP = new System.Windows.Forms.NumericUpDown();
            this.CB_ID = new System.Windows.Forms.ComboBox();
            this.CB_Nombre = new System.Windows.Forms.ComboBox();
            this.DGV_Clientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CB_VER = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CB_TOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(330, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "CLIENTES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "CONTROL DE BASE DE DATOS SQL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_ID.Location = new System.Drawing.Point(41, 45);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(37, 32);
            this.L_ID.TabIndex = 10;
            this.L_ID.Text = "ID";
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_Nombre.Location = new System.Drawing.Point(52, 19);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(200, 32);
            this.L_Nombre.TabIndex = 11;
            this.L_Nombre.Text = "PRIMER NOMBRE";
            // 
            // B_NuevoCliente
            // 
            this.B_NuevoCliente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_NuevoCliente.Location = new System.Drawing.Point(26, 415);
            this.B_NuevoCliente.Name = "B_NuevoCliente";
            this.B_NuevoCliente.Size = new System.Drawing.Size(266, 48);
            this.B_NuevoCliente.TabIndex = 15;
            this.B_NuevoCliente.Text = "CREAR NUEVO CLIENTE";
            this.B_NuevoCliente.UseVisualStyleBackColor = true;
            this.B_NuevoCliente.Click += new System.EventHandler(this.B_NuevoCliente_Click);
            // 
            // L_Top
            // 
            this.L_Top.AutoSize = true;
            this.L_Top.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_Top.Location = new System.Drawing.Point(9, 35);
            this.L_Top.Name = "L_Top";
            this.L_Top.Size = new System.Drawing.Size(306, 30);
            this.L_Top.TabIndex = 16;
            this.L_Top.Text = "TOP CLIENTES POR COMPRAS";
            // 
            // B_Por
            // 
            this.B_Por.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Por.Location = new System.Drawing.Point(105, 97);
            this.B_Por.Name = "B_Por";
            this.B_Por.Size = new System.Drawing.Size(75, 39);
            this.B_Por.TabIndex = 18;
            this.B_Por.Text = "IR";
            this.B_Por.UseVisualStyleBackColor = true;
            this.B_Por.Click += new System.EventHandler(this.B_Por_Click);
            // 
            // B_Consultar
            // 
            this.B_Consultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Consultar.Location = new System.Drawing.Point(76, 200);
            this.B_Consultar.Name = "B_Consultar";
            this.B_Consultar.Size = new System.Drawing.Size(178, 39);
            this.B_Consultar.TabIndex = 19;
            this.B_Consultar.Text = "CONSULTAR";
            this.B_Consultar.UseVisualStyleBackColor = true;
            this.B_Consultar.Click += new System.EventHandler(this.B_Consultar_Click);
            // 
            // B_Editar
            // 
            this.B_Editar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Editar.Location = new System.Drawing.Point(163, 100);
            this.B_Editar.Name = "B_Editar";
            this.B_Editar.Size = new System.Drawing.Size(121, 39);
            this.B_Editar.TabIndex = 20;
            this.B_Editar.Text = "EDITAR";
            this.B_Editar.UseVisualStyleBackColor = true;
            this.B_Editar.Click += new System.EventHandler(this.B_Editar_Click);
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Eliminar.Location = new System.Drawing.Point(629, 200);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(129, 39);
            this.B_Eliminar.TabIndex = 21;
            this.B_Eliminar.Text = "ELIMINAR";
            this.B_Eliminar.UseVisualStyleBackColor = true;
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // CB_TOP
            // 
            this.CB_TOP.Location = new System.Drawing.Point(105, 68);
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
            this.CB_TOP.Size = new System.Drawing.Size(74, 23);
            this.CB_TOP.TabIndex = 23;
            this.CB_TOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CB_TOP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CB_TOP.ValueChanged += new System.EventHandler(this.CB_TOP_ValueChanged);
            // 
            // CB_ID
            // 
            this.CB_ID.FormattingEnabled = true;
            this.CB_ID.Location = new System.Drawing.Point(121, 54);
            this.CB_ID.Name = "CB_ID";
            this.CB_ID.Size = new System.Drawing.Size(283, 23);
            this.CB_ID.TabIndex = 24;
            this.CB_ID.SelectedIndexChanged += new System.EventHandler(this.CB_ID_SelectedIndexChanged);
            // 
            // CB_Nombre
            // 
            this.CB_Nombre.FormattingEnabled = true;
            this.CB_Nombre.Location = new System.Drawing.Point(33, 169);
            this.CB_Nombre.Name = "CB_Nombre";
            this.CB_Nombre.Size = new System.Drawing.Size(259, 23);
            this.CB_Nombre.TabIndex = 25;
            this.CB_Nombre.SelectedIndexChanged += new System.EventHandler(this.CB_Nombre_SelectedIndexChanged);
            // 
            // DGV_Clientes
            // 
            this.DGV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Clientes.Location = new System.Drawing.Point(339, 267);
            this.DGV_Clientes.Name = "DGV_Clientes";
            this.DGV_Clientes.RowTemplate.Height = 25;
            this.DGV_Clientes.Size = new System.Drawing.Size(432, 196);
            this.DGV_Clientes.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.L_Nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 161);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CB_VER);
            this.groupBox2.Controls.Add(this.CB_ID);
            this.groupBox2.Controls.Add(this.L_ID);
            this.groupBox2.Controls.Add(this.B_Editar);
            this.groupBox2.Location = new System.Drawing.Point(339, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 161);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edicion/Eliminacion";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CB_VER
            // 
            this.CB_VER.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_VER.Location = new System.Drawing.Point(36, 100);
            this.CB_VER.Name = "CB_VER";
            this.CB_VER.Size = new System.Drawing.Size(121, 39);
            this.CB_VER.TabIndex = 25;
            this.CB_VER.Text = "VER";
            this.CB_VER.UseVisualStyleBackColor = true;
            this.CB_VER.Click += new System.EventHandler(this.CB_VER_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.B_Por);
            this.groupBox3.Controls.Add(this.L_Top);
            this.groupBox3.Controls.Add(this.CB_TOP);
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 142);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta General";
            // 
            // VentanaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.DGV_Clientes);
            this.Controls.Add(this.CB_Nombre);
            this.Controls.Add(this.B_Eliminar);
            this.Controls.Add(this.B_Consultar);
            this.Controls.Add(this.B_NuevoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaClientes";
            this.Text = " Control BD SQL";
            this.Load += new System.EventHandler(this.VentanaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CB_TOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Button B_NuevoCliente;
        private System.Windows.Forms.Label L_Top;
        private System.Windows.Forms.Button B_Por;
        private System.Windows.Forms.Button B_Consultar;
        private System.Windows.Forms.Button B_Editar;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.NumericUpDown CB_TOP;
        private System.Windows.Forms.ComboBox CB_ID;
        private System.Windows.Forms.ComboBox CB_Nombre;
        private System.Windows.Forms.DataGridView DGV_Clientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CB_VER;
    }
}

