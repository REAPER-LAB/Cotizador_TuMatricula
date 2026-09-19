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
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            // textBox1
            // 
            textBox1.Location = new Point(181, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "txtHuesped";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(181, 108);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 116);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "noches";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 158);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 7;
            label3.Text = "lbl Tarifa por noche  (USD)";
            label3.Click += label3_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(181, 150);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 203);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Temporada alta (25%)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(18, 526);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(99, 526);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 199);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cotizador";
            groupBox1.Enter += groupBox1_Enter;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 84);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 2;
            label6.Text = "ITBIS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 136);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 3;
            label7.Text = "Sevicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 160);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 4;
            label8.Text = "Total";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 119);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 5;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(87, 58);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 7;
            label11.Text = "0";
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(87, 136);
            label13.Name = "label13";
            label13.Size = new Size(13, 15);
            label13.TabIndex = 9;
            label13.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(87, 160);
            label14.Name = "label14";
            label14.Size = new Size(13, 15);
            label14.TabIndex = 10;
            label14.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Cotizador Villa Coral Rhyan Duquesne 2024-3489";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown2;
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
    }
}
