namespace BMICALCULATOR
{
    partial class Form1
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.centi = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.kilo = new System.Windows.Forms.Label();
            this.btncompute = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(13, 13);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(66, 13);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Your Height:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(85, 10);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(143, 20);
            this.txtHeight.TabIndex = 1;
            // 
            // centi
            // 
            this.centi.AutoSize = true;
            this.centi.Location = new System.Drawing.Point(85, 37);
            this.centi.Name = "centi";
            this.centi.Size = new System.Drawing.Size(68, 13);
            this.centi.TabIndex = 2;
            this.centi.Text = "(Centimeters)";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(13, 69);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(69, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Your Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(85, 66);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(136, 20);
            this.txtWeight.TabIndex = 4;
            // 
            // kilo
            // 
            this.kilo.AutoSize = true;
            this.kilo.Location = new System.Drawing.Point(85, 98);
            this.kilo.Name = "kilo";
            this.kilo.Size = new System.Drawing.Size(58, 13);
            this.kilo.TabIndex = 5;
            this.kilo.Text = "(Kilograms)";
            // 
            // btncompute
            // 
            this.btncompute.Location = new System.Drawing.Point(85, 154);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(136, 50);
            this.btncompute.TabIndex = 6;
            this.btncompute.Text = "Compute BMI";
            this.btncompute.UseVisualStyleBackColor = true;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(40, 243);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(57, 13);
            this.lblBMI.TabIndex = 7;
            this.lblBMI.Text = "Your BMI: ";
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(43, 272);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(85, 20);
            this.txtBMI.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 363);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btncompute);
            this.Controls.Add(this.kilo);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.centi);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label centi;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label kilo;
        private System.Windows.Forms.Button btncompute;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtBMI;
    }
}

