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
                Personas = 4,             
                PrecioPorPersona = 90m     
            };
            lstResultados.Items.Add($"Excursión: US$ {excursion.Total:N2}");
        }

        private void btnMinibar_Click(object sender, EventArgs e)
        {
            var minibar = new ConsumoMinibar
            {
                Cantidad = 11,             
                PrecioUnitario = 3.50m
            };
            lstResultados.Items.Add($"Minibar: US$ {minibar.Total:N2}");
        }

        private void btnCuentaTotal_Click(object sender, EventArgs e)
        {

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = Convert.ToDecimal(txtTarifa.Text)
            };

            var traslado = new TrasladoAeropuerto { Pasajeros = 2, Nocturno = true };
            var excursion = new Excursion { Personas = 4, PrecioPorPersona = 90m };
            var minibar = new ConsumoMinibar { Cantidad = 11, PrecioUnitario = 3.50m };

            decimal cuenta = reserva.Total + traslado.Total + excursion.Total + minibar.Total;
            lstResultados.Items.Add($"Cuenta total: US$ {cuenta:N2}");

        }

        private void btnviejo_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Add($"Depósito de 1000: {SistemaViejo.CalcularDeposito(1000m):N2} (debe dar 300.00)");
            lstResultados.Items.Add($"100 USD a tasa 60: {SistemaViejo.APesos(100m, 60m):N2} (debe dar 6,000.00)");
            lstResultados.Items.Add($"Tarifa 200 fin de semana: {SistemaViejo.TarifaFinDeSemana(200m, true):N2} (debe dar 230.00)");
            lstResultados.Items.Add($"Excursión 4 × 50: {SistemaViejo.TotalExcursion(4, 50m):N2} (debe dar 180.00)");
            lstResultados.Items.Add($"Minibar 3 × 4: {SistemaViejo.TotalMinibar(3, 4m):N2} (debe dar 14.16)");
        }

        private void btnFactura_Click(object sender, EventArgs e)
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


            var traslado = new TrasladoAeropuerto { Pasajeros = 2, Nocturno = true };
            var excursion = new Excursion { Personas = 4, PrecioPorPersona = 90m };
            var minibar = new ConsumoMinibar { Cantidad = 11, PrecioUnitario = 3.50m };


            decimal totalGeneral = reserva.Total + traslado.Total + excursion.Total + minibar.Total;
            decimal totalPesos = totalGeneral * nudTasa.Value;

            decimal deposito = SistemaViejo.CalcularDeposito(totalGen eral);

            lstResultados.Items.Clear();
            lstResultados.Items.Add($"Huésped: {reserva.Huesped}");
            lstResultados.Items.Add($"Reserva: US$ {reserva.Total:N2}");
            lstResultados.Items.Add($"Traslado: US$ {traslado.Total:N2}");
            lstResultados.Items.Add($"Excursión: US$ {excursion.Total:N2}");
            lstResultados.Items.Add($"Minibar: US$ {minibar.Total:N2}");
            lstResultados.Items.Add($"TOTAL GENERAL: US$ {totalGeneral:N2}");
            lstResultados.Items.Add($"TOTAL GENERAL: RD$ {totalPesos:N2}");
            lstResultados.Items.Add($"Depósito (30%): US$ {deposito:N2}");
        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            // 1.1
            {
                int a = 10;
                int b = 3;
                int r = a / b;
                lstResultados.Items.Add($"1.1 r = {r}");
            }

            // 1.2
            {
                decimal r = 10 / 4m;
                lstResultados.Items.Add($"1.2 r = {r}");
            }

            // 1.3
            {
                int x = 5;
                x = x + 2;
                x = x * 3;
                lstResultados.Items.Add($"1.3 x = {x}");
            }

            // 1.4
            {
                decimal p = 200m;
                decimal r = p * 0.18m;
                lstResultados.Items.Add($"1.4 r = {r}");
            }

            // 1.5
            {
                int n = 7;
                decimal d = 0m;
                if (n > 7)
                {
                    d = 50m;
                }
                lstResultados.Items.Add($"1.5 d = {d}");
            }

            // 1.6
            {
                int n = 7;
                bool larga = n >= 7;
                lstResultados.Items.Add($"1.6 larga = {larga}");
            }

            // 1.7
            {
                string s = "Villa" + "Coral";
                lstResultados.Items.Add($"1.7 s = {s}");
            }

            // 1.8
            {
                int n = 4;
                decimal t = 100m;
                decimal total = n * t * 1.28m;
                lstResultados.Items.Add($"1.8 total = {total}");
            }

            // 1.9
            {
                decimal t = 120m;
                t = t + t * 0.25m;
                lstResultados.Items.Add($"1.9 t = {t}");
            }

            // 1.10
            {
                int noches = (int)8.9m;
                lstResultados.Items.Add($"1.10 noches = {noches}");
            }
        }
    }
}
