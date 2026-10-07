namespace WinFormsApp2
{
    partial class Form2
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
            button1 = new Button();
            btnNivel1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 12);
            button1.Name = "button1";
            button1.Size = new Size(129, 89);
            button1.TabIndex = 3;
            button1.Text = "Tu Real Boton";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(22, 130);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(75, 23);
            btnNivel1.TabIndex = 4;
            btnNivel1.Text = "btnNivel1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNivel1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnNivel1;
    }
}