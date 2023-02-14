
namespace Aplicativo_Automóviles
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaludar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPlacaBus = new System.Windows.Forms.TextBox();
            this.btnBicola = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.dgvOrdenado = new System.Windows.Forms.DataGridView();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.dgvBicolaOrdenado = new System.Windows.Forms.DataGridView();
            this.PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBicolaOrdenado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(115, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // txtSaludar
            // 
            this.txtSaludar.AutoSize = true;
            this.txtSaludar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaludar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtSaludar.Location = new System.Drawing.Point(129, 54);
            this.txtSaludar.Name = "txtSaludar";
            this.txtSaludar.Size = new System.Drawing.Size(0, 25);
            this.txtSaludar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.groupBox1.Location = new System.Drawing.Point(46, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LOS AUTOS";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregar.Location = new System.Drawing.Point(66, 234);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 49);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR\r\n";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(130, 183);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(137, 26);
            this.txtColor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(130, 141);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(137, 26);
            this.txtModelo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(130, 93);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(137, 26);
            this.txtMarca.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(130, 51);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(137, 26);
            this.txtPlaca.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCerrar.Location = new System.Drawing.Point(1184, 686);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(134, 49);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "CERRA SESÍON";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvArbol
            // 
            this.dgvArbol.AllowUserToAddRows = false;
            this.dgvArbol.AllowUserToDeleteRows = false;
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Location = new System.Drawing.Point(407, 82);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.ReadOnly = true;
            this.dgvArbol.Size = new System.Drawing.Size(911, 221);
            this.dgvArbol.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(746, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "ARBOL PLACA";
            // 
            // btnAltura
            // 
            this.btnAltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.btnAltura.FlatAppearance.BorderSize = 0;
            this.btnAltura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnAltura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnAltura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAltura.Location = new System.Drawing.Point(1184, 27);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(134, 49);
            this.btnAltura.TabIndex = 12;
            this.btnAltura.Text = "AULTURA DEL ARBOL";
            this.btnAltura.UseVisualStyleBackColor = false;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.btnPeso.FlatAppearance.BorderSize = 0;
            this.btnPeso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnPeso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnPeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPeso.Location = new System.Drawing.Point(407, 27);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(134, 49);
            this.btnPeso.TabIndex = 16;
            this.btnPeso.Text = "PESO DEL ARBOL";
            this.btnPeso.UseVisualStyleBackColor = false;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscar.Location = new System.Drawing.Point(46, 468);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 49);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "BUSCAR PLACA";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPlacaBus
            // 
            this.txtPlacaBus.Location = new System.Drawing.Point(196, 497);
            this.txtPlacaBus.Name = "txtPlacaBus";
            this.txtPlacaBus.Size = new System.Drawing.Size(134, 20);
            this.txtPlacaBus.TabIndex = 12;
            // 
            // btnBicola
            // 
            this.btnBicola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.btnBicola.FlatAppearance.BorderSize = 0;
            this.btnBicola.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnBicola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnBicola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBicola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBicola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBicola.Location = new System.Drawing.Point(46, 547);
            this.btnBicola.Name = "btnBicola";
            this.btnBicola.Size = new System.Drawing.Size(134, 49);
            this.btnBicola.TabIndex = 12;
            this.btnBicola.Text = "BICOLA";
            this.btnBicola.UseVisualStyleBackColor = false;
            this.btnBicola.Click += new System.EventHandler(this.btnBicola_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Escribe el numero de placa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplicativo_Automóviles.Properties.Resources.Parquin;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(407, 322);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(911, 22);
            this.dgvLista.TabIndex = 18;
            // 
            // dgvOrdenado
            // 
            this.dgvOrdenado.AllowUserToAddRows = false;
            this.dgvOrdenado.AllowUserToDeleteRows = false;
            this.dgvOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenado.Location = new System.Drawing.Point(407, 372);
            this.dgvOrdenado.Name = "dgvOrdenado";
            this.dgvOrdenado.ReadOnly = true;
            this.dgvOrdenado.Size = new System.Drawing.Size(911, 21);
            this.dgvOrdenado.TabIndex = 19;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.btnOrdenar.FlatAppearance.BorderSize = 0;
            this.btnOrdenar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnOrdenar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOrdenar.Location = new System.Drawing.Point(46, 623);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(134, 49);
            this.btnOrdenar.TabIndex = 20;
            this.btnOrdenar.Text = "INVERTIR";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // dgvBicolaOrdenado
            // 
            this.dgvBicolaOrdenado.AllowUserToAddRows = false;
            this.dgvBicolaOrdenado.AllowUserToDeleteRows = false;
            this.dgvBicolaOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBicolaOrdenado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PLACA,
            this.MARCA,
            this.MODELO,
            this.COLOR});
            this.dgvBicolaOrdenado.Location = new System.Drawing.Point(623, 414);
            this.dgvBicolaOrdenado.Name = "dgvBicolaOrdenado";
            this.dgvBicolaOrdenado.ReadOnly = true;
            this.dgvBicolaOrdenado.Size = new System.Drawing.Size(444, 221);
            this.dgvBicolaOrdenado.TabIndex = 21;
            // 
            // PLACA
            // 
            this.PLACA.HeaderText = "PLACA";
            this.PLACA.Name = "PLACA";
            this.PLACA.ReadOnly = true;
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            this.MODELO.ReadOnly = true;
            // 
            // COLOR
            // 
            this.COLOR.HeaderText = "COLOR";
            this.COLOR.Name = "COLOR";
            this.COLOR.ReadOnly = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenerar.Location = new System.Drawing.Point(779, 650);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(134, 49);
            this.btnGenerar.TabIndex = 22;
            this.btnGenerar.Text = "GENERAR REPORTE";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1349, 747);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvBicolaOrdenado);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.dgvOrdenado);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBicola);
            this.Controls.Add(this.txtPlacaBus);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvArbol);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSaludar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBicolaOrdenado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtSaludar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPlacaBus;
        private System.Windows.Forms.Button btnBicola;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridView dgvOrdenado;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridView dgvBicolaOrdenado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
    }
}