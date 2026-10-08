namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //=====Imperativo:
            string Huesped = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {

                descuento = subtotal * 0.10m;

            }
            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;

            lstResultados.Items.Add($"[Imperativo] {Huesped} : US$ {total: N2}");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            txtHuesped.Clear();
            nudNoches.Value = 1;
            txtTarifa.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,

                TarifaPorNoche = Convert.ToDecimal(txtTarifa.Text)
            };


            decimal tasa = nudTasa.Value;
            decimal pesos = reserva.Total * tasa;
            lstResultados.Items.Add($"Total en pesos: RD$ {pesos:N2}");
        }

        private void txtTarifa_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudTasa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPorPersona_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = Convert.ToDecimal(txtTarifa.Text)
            };

            decimal porPersona = reserva.Total / nudPersonas.Value;
            lstResultados.Items.Add($"Cada persona paga: US$ {porPersona:N2}");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = Convert.ToDecimal(txtTarifa.Text)
            };

            decimal deposito = reserva.Total * 0.30m;
            decimal saldo = reserva.Total - deposito;

            lstResultados.Items.Add($"Depósito: US$ {deposito:N2}");
            lstResultados.Items.Add($"Saldo pendiente: US$ {saldo:N2}");
        }

        private void btnFinSemana_Click(object sender, EventArgs e)
        {
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);
            if (chkFinSemana.Checked)
            {
                tarifa = tarifa * 1.15m;
            }

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa
            };

            lstResultados.Items.Add($"Total fin de semana: US$ {reserva.Total:N2}");
        }

        private void btnFinSemana_Click_1(object sender, EventArgs e)
        {
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);

            if (chkFinSemana.Checked)
            {
                tarifa = tarifa * 1.15m;
            }

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa
            };

            lstResultados.Items.Add($"Total fin de semana: US$ {reserva.Total:N2}");
        }

        private void btnDesglose_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = Convert.ToDecimal(txtTarifa.Text)
            };

            lstResultados.Items.Add($"Subtotal: {reserva.Subtotal:N2}");
            lstResultados.Items.Add($"Descuento: {reserva.Descuento:N2}");
            lstResultados.Items.Add($"Base imponible: {reserva.BaseImponible:N2}");
            lstResultados.Items.Add($"ITBIS: {reserva.Itbis:N2}");
            lstResultados.Items.Add($"Servicio: {reserva.Servicio:N2}");
            lstResultados.Items.Add($"Total: {reserva.Total:N2}");
        }




        private void btnTraslado_Click_1(object sender, EventArgs e)
        {
            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = 2,
                Nocturno = true
            };
            lstResultados.Items.Add($"Traslado: US$ {traslado.Total:N2}");
        }

        private void btnExcursion_Click(object sender, EventArgs e)
        {
            var excursion = new Excursion
            {
                Personas = 4,              // tus personas + 2
                PrecioPorPersona = 90m     // 45 + 5 × tu último dígito
            };
            lstResultados.Items.Add($"Excursión: US$ {excursion.Total:N2}");
        }

        private void btnMinibar_Click(object sender, EventArgs e)
        {
            var minibar = new ConsumoMinibar
            {
                Cantidad = 11,             // tu último dígito + 2
                PrecioUnitario = 3.50m
            };
            lstResultados.Items.Add($"Minibar: US$ {minibar.Total:N2}");
        }
    }
}
