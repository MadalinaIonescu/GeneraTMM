namespace TabelaDeMortalitate
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAn1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerere = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "M",
            "F",
            "T"});
            this.cbSex.Location = new System.Drawing.Point(182, 82);
            this.cbSex.Margin = new System.Windows.Forms.Padding(4);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(210, 30);
            this.cbSex.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Din anul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sex";
            // 
            // cbAn1
            // 
            this.cbAn1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAn1.FormattingEnabled = true;
            this.cbAn1.Location = new System.Drawing.Point(182, 174);
            this.cbAn1.Margin = new System.Windows.Forms.Padding(4);
            this.cbAn1.Name = "cbAn1";
            this.cbAn1.Size = new System.Drawing.Size(85, 30);
            this.cbAn1.TabIndex = 34;
            this.cbAn1.SelectedIndexChanged += new System.EventHandler(this.cbAn1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(292, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Pana in";
            // 
            // tbAnFinal
            // 
            this.tbAnFinal.Location = new System.Drawing.Point(397, 174);
            this.tbAnFinal.Name = "tbAnFinal";
            this.tbAnFinal.ReadOnly = true;
            this.tbAnFinal.Size = new System.Drawing.Size(85, 28);
            this.tbAnFinal.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tara";
            // 
            // btnCerere
            // 
            this.btnCerere.BackColor = System.Drawing.Color.Transparent;
            this.btnCerere.FlatAppearance.BorderSize = 0;
            this.btnCerere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnCerere.ForeColor = System.Drawing.Color.White;
            this.btnCerere.Image = ((System.Drawing.Image)(resources.GetObject("btnCerere.Image")));
            this.btnCerere.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerere.Location = new System.Drawing.Point(182, 337);
            this.btnCerere.Name = "btnCerere";
            this.btnCerere.Size = new System.Drawing.Size(200, 76);
            this.btnCerere.TabIndex = 39;
            this.btnCerere.Text = "Creeaza";
            this.btnCerere.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerere.UseVisualStyleBackColor = false;
            this.btnCerere.Click += new System.EventHandler(this.btnCerere_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(182, 264);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(4);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(210, 30);
            this.cbCountry.TabIndex = 40;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(612, 455);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.btnCerere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAnFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAn1);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerere;
        private System.Windows.Forms.ComboBox cbCountry;

    }
}