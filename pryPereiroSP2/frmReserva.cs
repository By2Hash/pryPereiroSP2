namespace pryPereiroSP2
{
    public partial class frmReserva : Form
    {

        public frmReserva()
        {
            InitializeComponent();
        }
        // constantes para los c�lculos     
        private const float TIPOA = 20;
        public const float TIPOB = 34;
        const float COCINA = 1;
        const float HELADERA = 1.5f;
        const float TELEVISOR = 2;
        const float PORPERSONA = 1;

        private void lblTipoCaba�a_Click(object sender, EventArgs e)
        {

        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            // cargar los items en el primer control combobox       
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Tipo A");
            cmbTipo.Items.Add("Tipo B");
            // esta acci�n provoca el disparo del evento "SelectedIndexChanged"            cmbTipo.SelectedIndex = 0;    
            // se inicializa la cantidad de d�as en 1      
            txtDias.Text = "1";
            // inicialzar los dem�s controles de la interfaz      
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            // en los radiobuttons se asigna s�lo el que debe quedar en true      
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            mtbTelefono.Text = "";
            // cargar los items del combo de tarjetas     
            cmbTarjetas.Items.Clear();
            cmbTarjetas.Items.Add("Card Red");
            cmbTarjetas.Items.Add("Card Green");
            cmbTarjetas.Items.Add("Card Blue");
            // deshabiliar el bot�n "Aceptar"     
            btnAceptar.Enabled = false;




        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            // se deshabilita el combo y no se muestra nada   
            cmbTarjetas.Enabled = false;
            cmbTarjetas.SelectedIndex = -1;

        }
        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            // se habilita el combo y se muestra el primer item           
            cmbTarjetas.Enabled = true;
            cmbTarjetas.SelectedIndex = 0;

        }

        private void optTrajeta_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cuando ocurra el evento se debe actualizar el       
            // contenido del combo de personas         
            int I = 0;
            // limpiar los items de personas       
            cmbPersonas.Items.Clear();
            // si es tipo de caba�a A ->> cargar los items del 1 al 4        
            if (cmbTipo.SelectedIndex == 0) // o cmbTipo.SelectedItem == "Tipo A"    
            {
                for (I = 1; I <= 4; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }
            else
            { // si es tipo de caba�a B ->> cargar los items del 1 al 8     
                for (I = 1; I <= 8; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }
            // establecer como preseleccionado el item 0 del combo       
            cmbPersonas.SelectedIndex = 0;

        }

        private void nudDias_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkCocina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkHeladera_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTelevisor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            int Dias;
            float Total;

            // obtener la cantidad de d�as ingresados            
            Dias = int.Parse(txtDias.Text);
            // controlar el tipo de caba�a para determinar el precio base    
            if (cmbTipo.SelectedIndex == 0)
            { PrecioBase = TIPOA; }
            else
            { PrecioBase = TIPOB; }

            // sumar al precio base el importe extra por persona (US$ 1)         
            PrecioBase = PrecioBase + (PORPERSONA * int.Parse(cmbPersonas.Text));
            // controlar los adicionales por las opciones         
            Opcionales = 0;
            if (chkCocina.Checked == true)
            { Opcionales = Opcionales + COCINA; }
            if (chkHeladera.Checked == true)
            { Opcionales = Opcionales + HELADERA; }
            if (chkTelevisor.Checked == true)
            { Opcionales = Opcionales + TELEVISOR; }
            // determinar el total por la cantidad de d�as    
            Total = (PrecioBase + Opcionales) * Dias;
            // controlar la forma de pago        
            if (optTrajeta.Checked == true)
            {
                if (cmbTarjetas.SelectedIndex == 0)
                { Recargo = Total * 10 / 100; }
                else { Recargo = Total * 20 / 100; }
                Total = Total + Recargo;
            }
            // mostrar el resultado    
            MessageBox.Show("Total = " + Total.ToString(), "Importe de la reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // inicialzar los controles de la interfaz
            cmbTipo.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false; // en los radiobuttons se asigna s�lo el que debe quedar en true        
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            mtbTelefono.Text = "";

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el bot�n "Aceptar"  
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != "" && mtbTelefono.Text != "")
            { btnAceptar.Enabled = true; }
            else
            { btnAceptar.Enabled = false; }





        }



        private void mtbTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // condiciones para habilitar o no el bot�n "Aceptar"       
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != "" && mtbTelefono.Text != "")
            { btnAceptar.Enabled = true; }
            else
            {
                btnAceptar.Enabled = false;
            }

        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el bot�n "Aceptar"    
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != "" && mtbTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            { btnAceptar.Enabled = false; }

        }

        private void cmbTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
