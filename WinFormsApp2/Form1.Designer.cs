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
            label1 = new Label();
            txtHuesped = new TextBox();
            nudnoches = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            nudTarifa = new NumericUpDown();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            LSTresultados = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudnoches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 74);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "LblHuesped";
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(181, 74);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(278, 23);
            txtHuesped.TabIndex = 4;
            txtHuesped.Text = "txtHuesped";
            txtHuesped.TextChanged += textBox1_TextChanged;
            // 
            // nudnoches
            // 
            nudnoches.Location = new Point(181, 108);
            nudnoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudnoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudnoches.Name = "nudnoches";
            nudnoches.Size = new Size(120, 23);
            nudnoches.TabIndex = 5;
            nudnoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudnoches.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 116);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "noches";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 123);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 7;
            label3.Text = "lbl Tarifa por noche  (USD)";
            label3.Click += label3_Click;
            // 
            // nudTarifa
            // 
            nudTarifa.Location = new Point(181, 150);
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(120, 23);
            nudTarifa.TabIndex = 8;
            nudTarifa.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(291, 143);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Temporada alta (25%)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(291, 168);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(372, 168);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 199);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cotizador";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(166, 157);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "BntIperativo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 189);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Totales";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(87, 149);
            label14.Name = "label14";
            label14.Size = new Size(13, 15);
            label14.TabIndex = 10;
            label14.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(87, 119);
            label13.Name = "label13";
            label13.Size = new Size(13, 15);
            label13.TabIndex = 9;
            label13.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(87, 84);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 8;
            label12.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(87, 58);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 7;
            label11.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(87, 32);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 6;
            label10.Text = "0";
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
            label8.Location = new Point(11, 149);
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
            button3.Text = "Copy to whats app";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LSTresultados
            // 
            LSTresultados.FormattingEnabled = true;
            LSTresultados.ItemHeight = 15;
            LSTresultados.Location = new Point(495, 65);
            LSTresultados.Name = "LSTresultados";
            LSTresultados.Size = new Size(300, 469);
            LSTresultados.TabIndex = 16;
            LSTresultados.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 561);
            Controls.Add(LSTresultados);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(nudTarifa);
            Controls.Add(label2);
            Controls.Add(nudnoches);
            Controls.Add(txtHuesped);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Cotizador Villa Coral Rhyan Duquesne 2024-3489";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudnoches).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtHuesped;
        private NumericUpDown nudnoches;
        private Label label2;
        private Label label3;
        private NumericUpDown nudTarifa;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button button3;
        private ListBox LSTresultados;
        private Button button4;
    }
}
