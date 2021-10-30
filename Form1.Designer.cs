
namespace SimulacionCoccion
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
            this.CarneComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CombustibleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SimularButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TiempoCoccionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CarneCocinadaTextBox = new System.Windows.Forms.TextBox();
            this.ReiniciarButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // CarneComboBox
            // 
            this.CarneComboBox.FormattingEnabled = true;
            this.CarneComboBox.Items.AddRange(new object[] {
            "De Puerco",
            "De Vaca"});
            this.CarneComboBox.Location = new System.Drawing.Point(262, 74);
            this.CarneComboBox.Name = "CarneComboBox";
            this.CarneComboBox.Size = new System.Drawing.Size(339, 28);
            this.CarneComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar Carne:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar Combustible: ";
            // 
            // CombustibleComboBox
            // 
            this.CombustibleComboBox.FormattingEnabled = true;
            this.CombustibleComboBox.Items.AddRange(new object[] {
            "Hoja Seca",
            "Cascara de Platano",
            "Carbon Vegetal",
            "Madera"});
            this.CombustibleComboBox.Location = new System.Drawing.Point(262, 137);
            this.CombustibleComboBox.Name = "CombustibleComboBox";
            this.CombustibleComboBox.Size = new System.Drawing.Size(339, 28);
            this.CombustibleComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(119, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Simulador de Coccion de Carnes";
            // 
            // SimularButton
            // 
            this.SimularButton.Location = new System.Drawing.Point(345, 272);
            this.SimularButton.Name = "SimularButton";
            this.SimularButton.Size = new System.Drawing.Size(148, 38);
            this.SimularButton.TabIndex = 6;
            this.SimularButton.Text = "Simular Cocción";
            this.SimularButton.UseVisualStyleBackColor = true;
            this.SimularButton.Click += new System.EventHandler(this.SimularButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleccionar Intensidad del fuego: ";
            // 
            // TiempoCoccionTextBox
            // 
            this.TiempoCoccionTextBox.Location = new System.Drawing.Point(262, 356);
            this.TiempoCoccionTextBox.Name = "TiempoCoccionTextBox";
            this.TiempoCoccionTextBox.Size = new System.Drawing.Size(339, 27);
            this.TiempoCoccionTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiempo de cocción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de carne cocinada:";
            // 
            // CarneCocinadaTextBox
            // 
            this.CarneCocinadaTextBox.Location = new System.Drawing.Point(262, 430);
            this.CarneCocinadaTextBox.Name = "CarneCocinadaTextBox";
            this.CarneCocinadaTextBox.Size = new System.Drawing.Size(339, 27);
            this.CarneCocinadaTextBox.TabIndex = 11;
            // 
            // ReiniciarButton
            // 
            this.ReiniciarButton.Location = new System.Drawing.Point(345, 501);
            this.ReiniciarButton.Name = "ReiniciarButton";
            this.ReiniciarButton.Size = new System.Drawing.Size(168, 38);
            this.ReiniciarButton.TabIndex = 13;
            this.ReiniciarButton.Text = "Reiniciar Simulador";
            this.ReiniciarButton.UseVisualStyleBackColor = true;
            this.ReiniciarButton.Click += new System.EventHandler(this.ReiniciarButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(274, 204);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 24);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "0";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(376, 204);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 24);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "1/3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(318, 203);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 24);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "1/4";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(441, 203);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 24);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "1/2";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(499, 204);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(53, 24);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Full";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 584);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ReiniciarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CarneCocinadaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TiempoCoccionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SimularButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CombustibleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarneComboBox);
            this.Name = "Form1";
            this.Text = "Simulador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CarneComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CombustibleComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SimularButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TiempoCoccionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CarneCocinadaTextBox;
        private System.Windows.Forms.Button ReiniciarButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}

