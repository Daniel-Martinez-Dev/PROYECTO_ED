
namespace ED2021_II
{
    partial class VentanaTiendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaTiendas));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Por = new System.Windows.Forms.ComboBox();
            this.CB_City = new System.Windows.Forms.ComboBox();
            this.CB_ID = new System.Windows.Forms.ComboBox();
            this.CB_TOP = new System.Windows.Forms.NumericUpDown();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.B_Editar = new System.Windows.Forms.Button();
            this.B_Consultar = new System.Windows.Forms.Button();
            this.B_Por = new System.Windows.Forms.Button();
            this.L_Por = new System.Windows.Forms.Label();
            this.L_Top = new System.Windows.Forms.Label();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.DGV_Tiendas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Country = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_state = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CB_TOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tiendas)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "TIENDAS";
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
            // CB_Por
            // 
            this.CB_Por.FormattingEnabled = true;
            this.CB_Por.Items.AddRange(new object[] {
            "Numero de Ventas",
            "Monto de Ventas"});
            this.CB_Por.Location = new System.Drawing.Point(72, 119);
            this.CB_Por.Name = "CB_Por";
            this.CB_Por.Size = new System.Drawing.Size(137, 23);
            this.CB_Por.TabIndex = 52;
            // 
            // CB_City
            // 
            this.CB_City.FormattingEnabled = true;
            this.CB_City.Location = new System.Drawing.Point(287, 94);
            this.CB_City.Name = "CB_City";
            this.CB_City.Size = new System.Drawing.Size(261, 23);
            this.CB_City.TabIndex = 51;
            this.CB_City.SelectedIndexChanged += new System.EventHandler(this.CB_City_SelectedIndexChanged);
            this.CB_City.SelectionChangeCommitted += new System.EventHandler(this.CB_City_SelectionChangeCommitted);
            // 
            // CB_ID
            // 
            this.CB_ID.FormattingEnabled = true;
            this.CB_ID.Location = new System.Drawing.Point(101, 42);
            this.CB_ID.Name = "CB_ID";
            this.CB_ID.Size = new System.Drawing.Size(92, 23);
            this.CB_ID.TabIndex = 50;
            this.CB_ID.SelectedIndexChanged += new System.EventHandler(this.CB_ID_SelectedIndexChanged);
            // 
            // CB_TOP
            // 
            this.CB_TOP.Location = new System.Drawing.Point(72, 83);
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
            this.CB_TOP.Size = new System.Drawing.Size(137, 23);
            this.CB_TOP.TabIndex = 49;
            this.CB_TOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CB_TOP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Eliminar.Location = new System.Drawing.Point(102, 99);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(92, 39);
            this.B_Eliminar.TabIndex = 48;
            this.B_Eliminar.Text = "ELIMINAR";
            this.B_Eliminar.UseVisualStyleBackColor = true;
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // B_Editar
            // 
            this.B_Editar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Editar.Location = new System.Drawing.Point(13, 99);
            this.B_Editar.Name = "B_Editar";
            this.B_Editar.Size = new System.Drawing.Size(76, 39);
            this.B_Editar.TabIndex = 47;
            this.B_Editar.Text = "EDITAR";
            this.B_Editar.UseVisualStyleBackColor = true;
            this.B_Editar.Click += new System.EventHandler(this.B_Editar_Click);
            // 
            // B_Consultar
            // 
            this.B_Consultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Consultar.Location = new System.Drawing.Point(218, 129);
            this.B_Consultar.Name = "B_Consultar";
            this.B_Consultar.Size = new System.Drawing.Size(178, 39);
            this.B_Consultar.TabIndex = 46;
            this.B_Consultar.Text = "CONSULTAR";
            this.B_Consultar.UseVisualStyleBackColor = true;
            this.B_Consultar.Click += new System.EventHandler(this.B_Consultar_Click);
            // 
            // B_Por
            // 
            this.B_Por.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Por.Location = new System.Drawing.Point(87, 160);
            this.B_Por.Name = "B_Por";
            this.B_Por.Size = new System.Drawing.Size(75, 39);
            this.B_Por.TabIndex = 45;
            this.B_Por.Text = "Ir";
            this.B_Por.UseVisualStyleBackColor = true;
            this.B_Por.Click += new System.EventHandler(this.B_Por_Click);
            // 
            // L_Por
            // 
            this.L_Por.AutoSize = true;
            this.L_Por.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_Por.Location = new System.Drawing.Point(2, 110);
            this.L_Por.Name = "L_Por";
            this.L_Por.Size = new System.Drawing.Size(64, 32);
            this.L_Por.TabIndex = 44;
            this.L_Por.Text = "POR:";
            // 
            // L_Top
            // 
            this.L_Top.AutoSize = true;
            this.L_Top.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_Top.Location = new System.Drawing.Point(4, 74);
            this.L_Top.Name = "L_Top";
            this.L_Top.Size = new System.Drawing.Size(62, 32);
            this.L_Top.TabIndex = 43;
            this.L_Top.Text = "TOP:";
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_Nombre.Location = new System.Drawing.Point(6, 87);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(230, 30);
            this.L_Nombre.TabIndex = 41;
            this.L_Nombre.Text = "CIUDAD DE LA TIENDA";
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_ID.Location = new System.Drawing.Point(8, 44);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(82, 21);
            this.L_ID.TabIndex = 40;
            this.L_ID.Text = "ID TIENDA";
            this.L_ID.Click += new System.EventHandler(this.L_ID_Click);
            // 
            // DGV_Tiendas
            // 
            this.DGV_Tiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Tiendas.Location = new System.Drawing.Point(12, 280);
            this.DGV_Tiendas.Name = "DGV_Tiendas";
            this.DGV_Tiendas.RowTemplate.Height = 25;
            this.DGV_Tiendas.Size = new System.Drawing.Size(554, 205);
            this.DGV_Tiendas.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 32);
            this.label3.TabIndex = 54;
            this.label3.Text = "TOP TIENDAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CB_Country);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CB_state);
            this.groupBox1.Controls.Add(this.L_Nombre);
            this.groupBox1.Controls.Add(this.B_Consultar);
            this.groupBox1.Controls.Add(this.CB_City);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 174);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 30);
            this.label5.TabIndex = 54;
            this.label5.Text = "PAIS DE LA TIENDA";
            // 
            // CB_Country
            // 
            this.CB_Country.FormattingEnabled = true;
            this.CB_Country.Location = new System.Drawing.Point(287, 34);
            this.CB_Country.Name = "CB_Country";
            this.CB_Country.Size = new System.Drawing.Size(261, 23);
            this.CB_Country.TabIndex = 55;
            this.CB_Country.SelectedIndexChanged += new System.EventHandler(this.CB_Country_SelectedIndexChanged);
            this.CB_Country.SelectionChangeCommitted += new System.EventHandler(this.CB_Country_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 30);
            this.label4.TabIndex = 52;
            this.label4.Text = "ESTADO LA TIENDA";
            // 
            // CB_state
            // 
            this.CB_state.FormattingEnabled = true;
            this.CB_state.Location = new System.Drawing.Point(287, 63);
            this.CB_state.Name = "CB_state";
            this.CB_state.Size = new System.Drawing.Size(261, 23);
            this.CB_state.TabIndex = 53;
            this.CB_state.SelectionChangeCommitted += new System.EventHandler(this.CB_state_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CB_ID);
            this.groupBox2.Controls.Add(this.B_Eliminar);
            this.groupBox2.Controls.Add(this.B_Editar);
            this.groupBox2.Controls.Add(this.L_ID);
            this.groupBox2.Location = new System.Drawing.Point(572, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 174);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edición/Eliminación";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CB_Por);
            this.groupBox3.Controls.Add(this.L_Por);
            this.groupBox3.Controls.Add(this.B_Por);
            this.groupBox3.Controls.Add(this.CB_TOP);
            this.groupBox3.Controls.Add(this.L_Top);
            this.groupBox3.Location = new System.Drawing.Point(572, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 205);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta General";
            // 
            // VentanaTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.DGV_Tiendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaTiendas";
            this.Text = "Control BD SQL";
            this.Load += new System.EventHandler(this.VentanaTiendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CB_TOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tiendas)).EndInit();
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
        private System.Windows.Forms.ComboBox CB_Por;
        private System.Windows.Forms.ComboBox CB_City;
        private System.Windows.Forms.ComboBox CB_ID;
        private System.Windows.Forms.NumericUpDown CB_TOP;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Button B_Editar;
        private System.Windows.Forms.Button B_Consultar;
        private System.Windows.Forms.Button B_Por;
        private System.Windows.Forms.Label L_Por;
        private System.Windows.Forms.Label L_Top;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.DataGridView DGV_Tiendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_Country;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_state;
    }
}

