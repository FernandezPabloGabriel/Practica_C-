namespace Practica_V2
{
    partial class AltaPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaPersona));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.mtxtNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lblFNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radOtro = new System.Windows.Forms.RadioButton();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.comTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.mtxtNroDoc = new System.Windows.Forms.MaskedTextBox();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.chkSoltero = new System.Windows.Forms.CheckBox();
            this.chkHijos = new System.Windows.Forms.CheckBox();
            this.mtxtCantHijos = new System.Windows.Forms.MaskedTextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.comCarrera = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gdrPersonas = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(149, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(245, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(245, 117);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(214, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(147, 117);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(76, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // mtxtNacimiento
            // 
            this.mtxtNacimiento.Location = new System.Drawing.Point(245, 156);
            this.mtxtNacimiento.Mask = "00/00/0000";
            this.mtxtNacimiento.Name = "mtxtNacimiento";
            this.mtxtNacimiento.Size = new System.Drawing.Size(95, 22);
            this.mtxtNacimiento.TabIndex = 4;
            this.mtxtNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lblFNacimiento
            // 
            this.lblFNacimiento.AutoSize = true;
            this.lblFNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNacimiento.Location = new System.Drawing.Point(37, 156);
            this.lblFNacimiento.Name = "lblFNacimiento";
            this.lblFNacimiento.Size = new System.Drawing.Size(186, 20);
            this.lblFNacimiento.TabIndex = 5;
            this.lblFNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(173, 195);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 20);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radOtro);
            this.panel1.Controls.Add(this.radFemenino);
            this.panel1.Controls.Add(this.radMasculino);
            this.panel1.Location = new System.Drawing.Point(245, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 100);
            this.panel1.TabIndex = 7;
            // 
            // radOtro
            // 
            this.radOtro.AutoSize = true;
            this.radOtro.Location = new System.Drawing.Point(24, 69);
            this.radOtro.Name = "radOtro";
            this.radOtro.Size = new System.Drawing.Size(70, 20);
            this.radOtro.TabIndex = 2;
            this.radOtro.TabStop = true;
            this.radOtro.Text = "Otro >:(";
            this.radOtro.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Location = new System.Drawing.Point(24, 38);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(88, 20);
            this.radFemenino.TabIndex = 1;
            this.radFemenino.TabStop = true;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(24, 8);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(89, 20);
            this.radMasculino.TabIndex = 0;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(51, 318);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(172, 20);
            this.lblTipoDoc.TabIndex = 9;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // comTipoDocumento
            // 
            this.comTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTipoDocumento.FormattingEnabled = true;
            this.comTipoDocumento.Location = new System.Drawing.Point(245, 318);
            this.comTipoDocumento.Name = "comTipoDocumento";
            this.comTipoDocumento.Size = new System.Drawing.Size(214, 24);
            this.comTipoDocumento.TabIndex = 10;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(57, 362);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(166, 20);
            this.lblNroDoc.TabIndex = 11;
            this.lblNroDoc.Text = "Nro de Documento";
            // 
            // mtxtNroDoc
            // 
            this.mtxtNroDoc.Location = new System.Drawing.Point(245, 362);
            this.mtxtNroDoc.Mask = "99999999";
            this.mtxtNroDoc.Name = "mtxtNroDoc";
            this.mtxtNroDoc.Size = new System.Drawing.Size(95, 22);
            this.mtxtNroDoc.TabIndex = 12;
            this.mtxtNroDoc.ValidatingType = typeof(int);
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(245, 445);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(214, 22);
            this.txtNroCalle.TabIndex = 16;
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCalle.Location = new System.Drawing.Point(135, 445);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(88, 20);
            this.lblNroCalle.TabIndex = 15;
            this.lblNroCalle.Text = "Nro Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(245, 406);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(214, 22);
            this.txtCalle.TabIndex = 14;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(171, 406);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(52, 20);
            this.lblCalle.TabIndex = 13;
            this.lblCalle.Text = "Calle";
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(245, 484);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(77, 20);
            this.chkCasado.TabIndex = 17;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // chkSoltero
            // 
            this.chkSoltero.AutoSize = true;
            this.chkSoltero.Location = new System.Drawing.Point(245, 511);
            this.chkSoltero.Name = "chkSoltero";
            this.chkSoltero.Size = new System.Drawing.Size(72, 20);
            this.chkSoltero.TabIndex = 18;
            this.chkSoltero.Text = "Soltero";
            this.chkSoltero.UseVisualStyleBackColor = true;
            // 
            // chkHijos
            // 
            this.chkHijos.AutoSize = true;
            this.chkHijos.Location = new System.Drawing.Point(245, 537);
            this.chkHijos.Name = "chkHijos";
            this.chkHijos.Size = new System.Drawing.Size(124, 20);
            this.chkHijos.TabIndex = 19;
            this.chkHijos.Text = "Hijos - Cantidad";
            this.chkHijos.UseVisualStyleBackColor = true;
            this.chkHijos.CheckedChanged += new System.EventHandler(this.chkHijos_CheckedChanged);
            // 
            // mtxtCantHijos
            // 
            this.mtxtCantHijos.Location = new System.Drawing.Point(375, 537);
            this.mtxtCantHijos.Mask = "99";
            this.mtxtCantHijos.Name = "mtxtCantHijos";
            this.mtxtCantHijos.Size = new System.Drawing.Size(36, 22);
            this.mtxtCantHijos.TabIndex = 20;
            this.mtxtCantHijos.ValidatingType = typeof(int);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(150, 578);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(73, 20);
            this.lblCarrera.TabIndex = 21;
            this.lblCarrera.Text = "Carrera";
            // 
            // comCarrera
            // 
            this.comCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCarrera.FormattingEnabled = true;
            this.comCarrera.Location = new System.Drawing.Point(245, 578);
            this.comCarrera.Name = "comCarrera";
            this.comCarrera.Size = new System.Drawing.Size(214, 24);
            this.comCarrera.TabIndex = 22;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(57, 625);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 66);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargar.Location = new System.Drawing.Point(245, 625);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(166, 66);
            this.btnCargar.TabIndex = 24;
            this.btnCargar.Text = "Cargar Persona";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Añadir Nueva Persona";
            // 
            // gdrPersonas
            // 
            this.gdrPersonas.AllowUserToAddRows = false;
            this.gdrPersonas.AllowUserToDeleteRows = false;
            this.gdrPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.Nombre,
            this.Apellido});
            this.gdrPersonas.Location = new System.Drawing.Point(509, 78);
            this.gdrPersonas.Name = "gdrPersonas";
            this.gdrPersonas.ReadOnly = true;
            this.gdrPersonas.RowHeadersWidth = 51;
            this.gdrPersonas.RowTemplate.Height = 24;
            this.gdrPersonas.Size = new System.Drawing.Size(677, 613);
            this.gdrPersonas.TabIndex = 26;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Documento.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 250;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido.Width = 250;
            // 
            // AltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 733);
            this.Controls.Add(this.gdrPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.comCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.mtxtCantHijos);
            this.Controls.Add(this.chkHijos);
            this.Controls.Add(this.chkSoltero);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.lblNroCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.mtxtNroDoc);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.comTipoDocumento);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblFNacimiento);
            this.Controls.Add(this.mtxtNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Nueva Persona";
            this.Load += new System.EventHandler(this.AltaPersona_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.MaskedTextBox mtxtNacimiento;
        private System.Windows.Forms.Label lblFNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radOtro;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox comTipoDocumento;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.MaskedTextBox mtxtNroDoc;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.CheckBox chkSoltero;
        private System.Windows.Forms.CheckBox chkHijos;
        private System.Windows.Forms.MaskedTextBox mtxtCantHijos;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox comCarrera;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdrPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}