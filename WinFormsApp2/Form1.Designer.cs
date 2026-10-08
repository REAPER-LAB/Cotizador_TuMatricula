namespace WinFormsApp2
{
    partial class Form1
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
            lblHuesped = new Label();
            txtHuesped = new TextBox();
            nudNoches = new NumericUpDown();
            lblNoches = new Label();
            lblTarifa = new Label();
            ckTemporada = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gbCotizador = new GroupBox();
            txtTarifa = new TextBox();
            btnImperativo = new Button();
            gbTotales = new GroupBox();
            lblTotal = new Label();
            lblServicio = new Label();
            lblITBS = new Label();
            lblDescuento = new Label();
            lblSubTotal = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            lstResultados = new ListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            nudTasa = new NumericUpDown();
            label1 = new Label();
            btnPesos = new Button();
            nudPersonas = new NumericUpDown();
            btnPorPersona = new Button();
            btnDeposito = new Button();
            chkFinSemana = new CheckBox();
            btnFinSemana = new Button();
            btnDesglose = new Button();
            btnTraslado = new Button();
            btnExcursion = new Button();
            btnMinibar = new Button();
            btnCuentaTotal = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizador.SuspendLayout();
            gbTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(23, 74);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(54, 15);
            lblHuesped.TabIndex = 3;
            lblHuesped.Text = "Huesped";
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(181, 74);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(278, 23);
            txtHuesped.TabIndex = 4;
            txtHuesped.Text = "Ponga el nombre";
            txtHuesped.TextChanged += textBox1_TextChanged;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(181, 108);
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(120, 23);
            nudNoches.TabIndex = 5;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(23, 116);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(45, 15);
            lblNoches.TabIndex = 6;
            lblNoches.Text = "noches";
            lblNoches.Click += label2_Click;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(11, 123);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(129, 15);
            lblTarifa.TabIndex = 7;
            lblTarifa.Text = "Tarifa por noche  (USD)";
            lblTarifa.Click += label3_Click;
            // 
            // ckTemporada
            // 
            ckTemporada.AutoSize = true;
            ckTemporada.Location = new Point(6, 156);
            ckTemporada.Name = "ckTemporada";
            ckTemporada.Size = new Size(141, 19);
            ckTemporada.TabIndex = 9;
            ckTemporada.Text = "Temporada alta (25%)";
            ckTemporada.UseVisualStyleBackColor = true;
            ckTemporada.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 464);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(93, 464);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button2_Click;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(txtTarifa);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Controls.Add(ckTemporada);
            gbCotizador.Location = new Point(12, 35);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Size = new Size(466, 199);
            gbCotizador.TabIndex = 13;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            gbCotizador.Enter += groupBox1_Enter;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(169, 115);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(100, 23);
            txtTarifa.TabIndex = 10;
            txtTarifa.TextChanged += txtTarifa_TextChanged;
            // 
            // btnImperativo
            // 
            btnImperativo.Location = new Point(181, 464);
            btnImperativo.Name = "btnImperativo";
            btnImperativo.Size = new Size(75, 23);
            btnImperativo.TabIndex = 13;
            btnImperativo.Text = "BntIperativo";
            btnImperativo.UseVisualStyleBackColor = true;
            btnImperativo.Click += button4_Click;
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(lblITBS);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblSubTotal);
            gbTotales.Controls.Add(label9);
            gbTotales.Controls.Add(label8);
            gbTotales.Controls.Add(label7);
            gbTotales.Controls.Add(label6);
            gbTotales.Controls.Add(label5);
            gbTotales.Controls.Add(label4);
            gbTotales.Location = new Point(12, 250);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(466, 189);
            gbTotales.TabIndex = 14;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(87, 149);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 15);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "0";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(87, 119);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(13, 15);
            lblServicio.TabIndex = 9;
            lblServicio.Text = "0";
            // 
            // lblITBS
            // 
            lblITBS.AutoSize = true;
            lblITBS.Location = new Point(87, 84);
            lblITBS.Name = "lblITBS";
            lblITBS.Size = new Size(13, 15);
            lblITBS.TabIndex = 8;
            lblITBS.Text = "0";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(87, 58);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(13, 15);
            lblDescuento.TabIndex = 7;
            lblDescuento.Text = "0";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(87, 32);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(13, 15);
            lblSubTotal.TabIndex = 6;
            lblSubTotal.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 119);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 149);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 4;
            label8.Text = "Total";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 119);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 3;
            label7.Text = "Sevicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 84);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 2;
            label6.Text = "ITBIS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 58);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 1;
            label5.Text = "Descuento";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 32);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 0;
            label4.Text = "SubTotal";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(18, 493);
            button3.Name = "button3";
            button3.Size = new Size(460, 47);
            button3.TabIndex = 15;
            button3.Text = "Copy to whatsapp";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(495, 65);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(300, 469);
            lstResultados.TabIndex = 16;
            lstResultados.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(960, 74);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(120, 23);
            nudTasa.TabIndex = 17;
            nudTasa.ValueChanged += nudTasa_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(905, 45);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 18;
            label1.Text = "Tasa del dólar";
            label1.Click += label1_Click;
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(832, 74);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(112, 23);
            btnPesos.TabIndex = 19;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(960, 133);
            nudPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(120, 23);
            nudPersonas.TabIndex = 20;
            nudPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPorPersona
            // 
            btnPorPersona.Location = new Point(832, 133);
            btnPorPersona.Name = "btnPorPersona";
            btnPorPersona.Size = new Size(112, 23);
            btnPorPersona.TabIndex = 21;
            btnPorPersona.Text = "PorPersona";
            btnPorPersona.UseVisualStyleBackColor = true;
            btnPorPersona.Click += btnPorPersona_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(832, 195);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(75, 23);
            btnDeposito.TabIndex = 22;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Location = new Point(960, 199);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(103, 19);
            chkFinSemana.TabIndex = 23;
            chkFinSemana.Text = "chkFinSemana";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(832, 250);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(75, 23);
            btnFinSemana.TabIndex = 24;
            btnFinSemana.Text = "FinSemana";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.Click += btnFinSemana_Click_1;
            // 
            // btnDesglose
            // 
            btnDesglose.Location = new Point(960, 250);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(75, 23);
            btnDesglose.TabIndex = 25;
            btnDesglose.Text = "btnDesglose ";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // btnTraslado
            // 
            btnTraslado.Location = new Point(832, 304);
            btnTraslado.Name = "btnTraslado";
            btnTraslado.Size = new Size(75, 23);
            btnTraslado.TabIndex = 26;
            btnTraslado.Text = "Traslado";
            btnTraslado.UseVisualStyleBackColor = true;
            btnTraslado.Click += btnTraslado_Click_1;
            // 
            // btnExcursion
            // 
            btnExcursion.Location = new Point(960, 304);
            btnExcursion.Name = "btnExcursion";
            btnExcursion.Size = new Size(75, 23);
            btnExcursion.TabIndex = 27;
            btnExcursion.Text = "Excursion";
            btnExcursion.UseVisualStyleBackColor = true;
            btnExcursion.Click += btnExcursion_Click;
            // 
            // btnMinibar
            // 
            btnMinibar.Location = new Point(832, 365);
            btnMinibar.Name = "btnMinibar";
            btnMinibar.Size = new Size(75, 23);
            btnMinibar.TabIndex = 28;
            btnMinibar.Text = "Minibar";
            btnMinibar.UseVisualStyleBackColor = true;
            btnMinibar.Click += btnMinibar_Click;
            // 
            // btnCuentaTotal
            // 
            btnCuentaTotal.Location = new Point(960, 365);
            btnCuentaTotal.Name = "btnCuentaTotal";
            btnCuentaTotal.Size = new Size(75, 23);
            btnCuentaTotal.TabIndex = 29;
            btnCuentaTotal.Text = "CuentaTotal";
            btnCuentaTotal.UseVisualStyleBackColor = true;
            btnCuentaTotal.Click += btnCuentaTotal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 561);
            Controls.Add(btnCuentaTotal);
            Controls.Add(btnMinibar);
            Controls.Add(btnExcursion);
            Controls.Add(btnTraslado);
            Controls.Add(btnDesglose);
            Controls.Add(btnFinSemana);
            Controls.Add(chkFinSemana);
            Controls.Add(btnDeposito);
            Controls.Add(btnPorPersona);
            Controls.Add(nudPersonas);
            Controls.Add(btnPesos);
            Controls.Add(label1);
            Controls.Add(nudTasa);
            Controls.Add(btnImperativo);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(lstResultados);
            Controls.Add(button3);
            Controls.Add(gbTotales);
            Controls.Add(lblNoches);
            Controls.Add(nudNoches);
            Controls.Add(txtHuesped);
            Controls.Add(lblHuesped);
            Controls.Add(gbCotizador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Cotizador Villa Coral Rhyan Duquesne 2024-3489";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHuesped;
        private TextBox txtHuesped;
        private NumericUpDown nudNoches;
        private Label lblNoches;
        private Label lblTarifa;
        private CheckBox ckTemporada;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox gbCotizador;
        private GroupBox gbTotales;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblTotal;
        private Label lblServicio;
        private Label lblITBS;
        private Label lblDescuento;
        private Label lblSubTotal;
        private Button button3;
        private ListBox lstResultados;
        private Button btnImperativo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown nudTasa;
        private Label label1;
        private Button btnPesos;
        private TextBox txtTarifa;
        private NumericUpDown nudPersonas;
        private Button btnPorPersona;
        private Button btnDeposito;
        private CheckBox chkFinSemana;
        private Button btnFinSemana;
        private Button btnDesglose;
        private Button btnTraslado;
        private Button btnExcursion;
        private Button btnMinibar;
        private Button btnCuentaTotal;
    }
}
