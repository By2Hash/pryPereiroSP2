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
            nudDias = new NumericUpDown();
            nudPersonas = new NumericUpDown();
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
            rdbTrajeta = new RadioButton();
            rdbEfectivo = new RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTipoCabaña
            // 
            lblTipoCabaña.AutoSize = true;
            lblTipoCabaña.Location = new Point(12, 9);
            lblTipoCabaña.Name = "lblTipoCabaña";
            lblTipoCabaña.Size = new Size(89, 15);
            lblTipoCabaña.TabIndex = 0;
            lblTipoCabaña.Text = "Tipo de Cabaña";
            lblTipoCabaña.Click += lblTipoCabaña_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(21, 29);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(nudDias);
            panel1.Controls.Add(nudPersonas);
            panel1.Controls.Add(cmbTipo);
            panel1.Controls.Add(lblDias);
            panel1.Controls.Add(lblPersona);
            panel1.Controls.Add(lblTipo);
            panel1.Location = new Point(12, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 84);
            panel1.TabIndex = 2;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(394, 26);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(56, 23);
            nudDias.TabIndex = 6;
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(255, 26);
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(56, 23);
            nudPersonas.TabIndex = 5;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(57, 26);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 4;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(359, 29);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 3;
            lblDias.Text = "Días";
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Location = new Point(195, 29);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(54, 15);
            lblPersona.TabIndex = 2;
            lblPersona.Text = "Personas";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(chkTelevisor);
            panel2.Controls.Add(chkHeladera);
            panel2.Controls.Add(chkCocina);
            panel2.Location = new Point(15, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 133);
            panel2.TabIndex = 3;
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(13, 89);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(71, 19);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "&Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(13, 54);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(73, 19);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "&Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(13, 17);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(63, 19);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "&Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(cmbTarjetas);
            panel3.Controls.Add(lblTarjetas);
            panel3.Controls.Add(rdbTrajeta);
            panel3.Controls.Add(rdbEfectivo);
            panel3.Location = new Point(196, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 133);
            panel3.TabIndex = 4;
            // 
            // cmbTarjetas
            // 
            cmbTarjetas.FormattingEnabled = true;
            cmbTarjetas.Location = new Point(58, 85);
            cmbTarjetas.Name = "cmbTarjetas";
            cmbTarjetas.Size = new Size(133, 23);
            cmbTarjetas.TabIndex = 3;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(11, 89);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(41, 15);
            lblTarjetas.TabIndex = 2;
            lblTarjetas.Text = "Tarjeta";
            // 
            // rdbTrajeta
            // 
            rdbTrajeta.AutoSize = true;
            rdbTrajeta.Location = new Point(11, 53);
            rdbTrajeta.Name = "rdbTrajeta";
            rdbTrajeta.Size = new Size(59, 19);
            rdbTrajeta.TabIndex = 1;
            rdbTrajeta.TabStop = true;
            rdbTrajeta.Text = "&Tarjeta";
            rdbTrajeta.UseVisualStyleBackColor = true;
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Location = new Point(11, 16);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(67, 19);
            rdbEfectivo.TabIndex = 0;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "&Efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(mtbTelefono);
            panel4.Controls.Add(txtNombre);
            panel4.Controls.Add(lblTelefono);
            panel4.Controls.Add(lblNombre);
            panel4.Location = new Point(15, 291);
            panel4.Name = "panel4";
            panel4.Size = new Size(505, 107);
            panel4.TabIndex = 5;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(75, 61);
            mtbTelefono.Mask = "000-000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(73, 23);
            mtbTelefono.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 14);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(410, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(18, 69);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblAdicionales
            // 
            lblAdicionales.AutoSize = true;
            lblAdicionales.Location = new Point(15, 119);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(68, 15);
            lblAdicionales.TabIndex = 0;
            lblAdicionales.Text = "Adicionales";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(196, 119);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(87, 15);
            lblPago.TabIndex = 6;
            lblPago.Text = "Forma de Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 273);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "Tiular de la Reserva";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(425, 419);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 454);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(lblPago);
            Controls.Add(lblAdicionales);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblTipoCabaña);
            Controls.Add(panel1);
            Name = "frmReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservas de Cabañas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
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
        private NumericUpDown nudPersonas;
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
        private RadioButton rdbTrajeta;
        private RadioButton rdbEfectivo;
        private TextBox textBox2;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Label lblNombre;
        private Button btnAceptar;
        private MaskedTextBox mtbTelefono;
    }
}
