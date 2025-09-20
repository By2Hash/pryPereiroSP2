namespace pryPereiroSP2
{
    partial class frmReserva
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
            lblTipoCabaña = new Label();
            lblTipo = new Label();
            panel1 = new Panel();
            cmbPersonas = new ComboBox();
            nudDias = new NumericUpDown();
            cmbTipo = new ComboBox();
            lblDias = new Label();
            lblPersona = new Label();
            panel2 = new Panel();
            chkTelevisor = new CheckBox();
            chkHeladera = new CheckBox();
            chkCocina = new CheckBox();
            panel3 = new Panel();
            cmbTarjetas = new ComboBox();
            lblTarjetas = new Label();
            optTrajeta = new RadioButton();
            optEfectivo = new RadioButton();
            panel4 = new Panel();
            mtbTelefono = new MaskedTextBox();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblNombre = new Label();
            lblAdicionales = new Label();
            lblPago = new Label();
            label3 = new Label();
            btnAceptar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTipoCabaña
            // 
            lblTipoCabaña.AutoSize = true;
            lblTipoCabaña.Location = new Point(17, 15);
            lblTipoCabaña.Margin = new Padding(4, 0, 4, 0);
            lblTipoCabaña.Name = "lblTipoCabaña";
            lblTipoCabaña.Size = new Size(136, 25);
            lblTipoCabaña.TabIndex = 0;
            lblTipoCabaña.Text = "Tipo de Cabaña";
            lblTipoCabaña.Click += lblTipoCabaña_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(30, 48);
            lblTipo.Margin = new Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(47, 25);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(cmbPersonas);
            panel1.Controls.Add(nudDias);
            panel1.Controls.Add(cmbTipo);
            panel1.Controls.Add(lblDias);
            panel1.Controls.Add(lblPersona);
            panel1.Controls.Add(lblTipo);
            panel1.Location = new Point(17, 47);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 137);
            panel1.TabIndex = 2;
            // 
            // cmbPersonas
            // 
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Location = new Point(368, 43);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(79, 33);
            cmbPersonas.TabIndex = 7;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(563, 43);
            nudDias.Margin = new Padding(4, 5, 4, 5);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(80, 31);
            nudDias.TabIndex = 6;
            nudDias.ValueChanged += nudDias_ValueChanged;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(81, 43);
            cmbTipo.Margin = new Padding(4, 5, 4, 5);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(171, 33);
            cmbTipo.TabIndex = 4;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(513, 48);
            lblDias.Margin = new Padding(4, 0, 4, 0);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(46, 25);
            lblDias.TabIndex = 3;
            lblDias.Text = "Días";
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Location = new Point(279, 48);
            lblPersona.Margin = new Padding(4, 0, 4, 0);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(82, 25);
            lblPersona.TabIndex = 2;
            lblPersona.Text = "Personas";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(chkTelevisor);
            panel2.Controls.Add(chkHeladera);
            panel2.Controls.Add(chkCocina);
            panel2.Location = new Point(21, 228);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 219);
            panel2.TabIndex = 3;
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(19, 148);
            chkTelevisor.Margin = new Padding(4, 5, 4, 5);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(105, 29);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "&Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            chkTelevisor.CheckedChanged += chkTelevisor_CheckedChanged;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(19, 90);
            chkHeladera.Margin = new Padding(4, 5, 4, 5);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(108, 29);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "&Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            chkHeladera.CheckedChanged += chkHeladera_CheckedChanged;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(19, 28);
            chkCocina.Margin = new Padding(4, 5, 4, 5);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(91, 29);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "&Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            chkCocina.CheckedChanged += chkCocina_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(cmbTarjetas);
            panel3.Controls.Add(lblTarjetas);
            panel3.Controls.Add(optTrajeta);
            panel3.Controls.Add(optEfectivo);
            panel3.Location = new Point(280, 228);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(461, 219);
            panel3.TabIndex = 4;
            // 
            // cmbTarjetas
            // 
            cmbTarjetas.FormattingEnabled = true;
            cmbTarjetas.Location = new Point(83, 142);
            cmbTarjetas.Margin = new Padding(4, 5, 4, 5);
            cmbTarjetas.Name = "cmbTarjetas";
            cmbTarjetas.Size = new Size(188, 33);
            cmbTarjetas.TabIndex = 3;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(16, 148);
            lblTarjetas.Margin = new Padding(4, 0, 4, 0);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(62, 25);
            lblTarjetas.TabIndex = 2;
            lblTarjetas.Text = "Tarjeta";
            // 
            // optTrajeta
            // 
            optTrajeta.AutoSize = true;
            optTrajeta.Location = new Point(16, 88);
            optTrajeta.Margin = new Padding(4, 5, 4, 5);
            optTrajeta.Name = "optTrajeta";
            optTrajeta.Size = new Size(87, 29);
            optTrajeta.TabIndex = 1;
            optTrajeta.TabStop = true;
            optTrajeta.Text = "&Tarjeta";
            optTrajeta.UseVisualStyleBackColor = true;
            optTrajeta.CheckedChanged += optTrajeta_CheckedChanged;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(16, 27);
            optEfectivo.Margin = new Padding(4, 5, 4, 5);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(99, 29);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "&Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(mtbTelefono);
            panel4.Controls.Add(txtNombre);
            panel4.Controls.Add(lblTelefono);
            panel4.Controls.Add(lblNombre);
            panel4.Location = new Point(21, 485);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(720, 176);
            panel4.TabIndex = 5;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(113, 109);
            mtbTelefono.Margin = new Padding(4, 5, 4, 5);
            mtbTelefono.Mask = "000-000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(103, 31);
            mtbTelefono.TabIndex = 3;
            mtbTelefono.MaskInputRejected += mtbTelefono_MaskInputRejected;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 37);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(572, 31);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(26, 115);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 37);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblAdicionales
            // 
            lblAdicionales.AutoSize = true;
            lblAdicionales.Location = new Point(21, 198);
            lblAdicionales.Margin = new Padding(4, 0, 4, 0);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(102, 25);
            lblAdicionales.TabIndex = 0;
            lblAdicionales.Text = "Adicionales";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(280, 198);
            lblPago.Margin = new Padding(4, 0, 4, 0);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(133, 25);
            lblPago.TabIndex = 6;
            lblPago.Text = "Forma de Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 455);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 7;
            label3.Text = "Tiular de la Reserva";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(607, 698);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(107, 38);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 757);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(lblPago);
            Controls.Add(lblAdicionales);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblTipoCabaña);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservas de Cabañas";
            Load += frmReserva_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoCabaña;
        private Label lblTipo;
        private Panel panel1;
        private NumericUpDown nudDias;
        private ComboBox cmbTipo;
        private Label lblDias;
        private Label lblPersona;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblAdicionales;
        private Label lblPago;
        private Label label3;
        private CheckBox chkTelevisor;
        private CheckBox chkHeladera;
        private CheckBox chkCocina;
        private ComboBox cmbTarjetas;
        private Label lblTarjetas;
        private RadioButton optTrajeta;
        private RadioButton optEfectivo;
        private TextBox textBox2;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Label lblNombre;
        private Button btnAceptar;
        private MaskedTextBox mtbTelefono;
        private ComboBox cmbPersonas;
    }
}
