namespace ExamenFinalTUP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxDir = new System.Windows.Forms.TextBox();
            this.btnPresu = new System.Windows.Forms.Button();
            this.btnCerrarPre = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cbxProd = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnIm = new System.Windows.Forms.Button();
            this.tbxPrecioB = new System.Windows.Forms.TextBox();
            this.tbxAncho = new System.Windows.Forms.TextBox();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.tbxLargo = new System.Windows.Forms.TextBox();
            this.tbxGrosor = new System.Windows.Forms.TextBox();
            this.btnEx = new System.Windows.Forms.Button();
            this.rbxMesa = new System.Windows.Forms.RadioButton();
            this.rbxBanco = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxProd);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnCerrarPre);
            this.groupBox1.Controls.Add(this.btnPresu);
            this.groupBox1.Controls.Add(this.tbxDir);
            this.groupBox1.Controls.Add(this.tbxNom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(75, 23);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(100, 20);
            this.tbxNom.TabIndex = 1;
            this.tbxNom.Text = "nombre:";
            // 
            // tbxDir
            // 
            this.tbxDir.Location = new System.Drawing.Point(75, 49);
            this.tbxDir.Name = "tbxDir";
            this.tbxDir.Size = new System.Drawing.Size(100, 20);
            this.tbxDir.TabIndex = 3;
            this.tbxDir.Text = "direccion";
            // 
            // btnPresu
            // 
            this.btnPresu.Location = new System.Drawing.Point(20, 96);
            this.btnPresu.Name = "btnPresu";
            this.btnPresu.Size = new System.Drawing.Size(85, 35);
            this.btnPresu.TabIndex = 1;
            this.btnPresu.Text = "Iniciar Presupuesto";
            this.btnPresu.UseVisualStyleBackColor = true;
            this.btnPresu.Click += new System.EventHandler(this.btnPresu_Click);
            // 
            // btnCerrarPre
            // 
            this.btnCerrarPre.Location = new System.Drawing.Point(128, 96);
            this.btnCerrarPre.Name = "btnCerrarPre";
            this.btnCerrarPre.Size = new System.Drawing.Size(85, 35);
            this.btnCerrarPre.TabIndex = 4;
            this.btnCerrarPre.Text = "Cerrar Presupuesto";
            this.btnCerrarPre.UseVisualStyleBackColor = true;
            this.btnCerrarPre.Click += new System.EventHandler(this.btnCerrarPre_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(128, 181);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(85, 35);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cbxProd
            // 
            this.cbxProd.FormattingEnabled = true;
            this.cbxProd.Location = new System.Drawing.Point(20, 189);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(99, 21);
            this.cbxProd.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbxBanco);
            this.groupBox2.Controls.Add(this.rbxMesa);
            this.groupBox2.Controls.Add(this.btnEx);
            this.groupBox2.Controls.Add(this.tbxGrosor);
            this.groupBox2.Controls.Add(this.tbxLargo);
            this.groupBox2.Controls.Add(this.tbxCode);
            this.groupBox2.Controls.Add(this.tbxAncho);
            this.groupBox2.Controls.Add(this.tbxPrecioB);
            this.groupBox2.Controls.Add(this.btnIm);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(291, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(135, 96);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 35);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnIm
            // 
            this.btnIm.Location = new System.Drawing.Point(19, 181);
            this.btnIm.Name = "btnIm";
            this.btnIm.Size = new System.Drawing.Size(99, 35);
            this.btnIm.TabIndex = 8;
            this.btnIm.Text = "importar";
            this.btnIm.UseVisualStyleBackColor = true;
            this.btnIm.Click += new System.EventHandler(this.btnIm_Click);
            // 
            // tbxPrecioB
            // 
            this.tbxPrecioB.Location = new System.Drawing.Point(19, 19);
            this.tbxPrecioB.Name = "tbxPrecioB";
            this.tbxPrecioB.Size = new System.Drawing.Size(71, 20);
            this.tbxPrecioB.TabIndex = 10;
            this.tbxPrecioB.Text = "precioB";
            // 
            // tbxAncho
            // 
            this.tbxAncho.Location = new System.Drawing.Point(19, 43);
            this.tbxAncho.Name = "tbxAncho";
            this.tbxAncho.Size = new System.Drawing.Size(71, 20);
            this.tbxAncho.TabIndex = 11;
            this.tbxAncho.Text = "Ancho";
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(19, 69);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(71, 20);
            this.tbxCode.TabIndex = 12;
            this.tbxCode.Text = "Codigo";
            // 
            // tbxLargo
            // 
            this.tbxLargo.Location = new System.Drawing.Point(187, 16);
            this.tbxLargo.Name = "tbxLargo";
            this.tbxLargo.Size = new System.Drawing.Size(71, 20);
            this.tbxLargo.TabIndex = 13;
            this.tbxLargo.Text = "largo";
            // 
            // tbxGrosor
            // 
            this.tbxGrosor.Location = new System.Drawing.Point(187, 46);
            this.tbxGrosor.Name = "tbxGrosor";
            this.tbxGrosor.Size = new System.Drawing.Size(71, 20);
            this.tbxGrosor.TabIndex = 14;
            this.tbxGrosor.Text = "grosor";
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(135, 181);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(99, 35);
            this.btnEx.TabIndex = 15;
            this.btnEx.Text = "exportar";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // rbxMesa
            // 
            this.rbxMesa.AutoSize = true;
            this.rbxMesa.Location = new System.Drawing.Point(19, 135);
            this.rbxMesa.Name = "rbxMesa";
            this.rbxMesa.Size = new System.Drawing.Size(51, 17);
            this.rbxMesa.TabIndex = 16;
            this.rbxMesa.TabStop = true;
            this.rbxMesa.Text = "Mesa";
            this.rbxMesa.UseVisualStyleBackColor = true;
            // 
            // rbxBanco
            // 
            this.rbxBanco.AutoSize = true;
            this.rbxBanco.Location = new System.Drawing.Point(19, 158);
            this.rbxBanco.Name = "rbxBanco";
            this.rbxBanco.Size = new System.Drawing.Size(56, 17);
            this.rbxBanco.TabIndex = 17;
            this.rbxBanco.TabStop = true;
            this.rbxBanco.Text = "Banco";
            this.rbxBanco.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxProd;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrarPre;
        private System.Windows.Forms.Button btnPresu;
        private System.Windows.Forms.TextBox tbxDir;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxGrosor;
        private System.Windows.Forms.TextBox tbxLargo;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.TextBox tbxAncho;
        private System.Windows.Forms.TextBox tbxPrecioB;
        private System.Windows.Forms.Button btnIm;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.RadioButton rbxBanco;
        private System.Windows.Forms.RadioButton rbxMesa;
    }
}

