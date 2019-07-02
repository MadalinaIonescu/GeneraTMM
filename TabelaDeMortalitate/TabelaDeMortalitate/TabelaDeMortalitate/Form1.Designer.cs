namespace TabelaDeMortalitate
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
            this.title = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnGenerateTable = new System.Windows.Forms.Button();
            this.btnGenerateGraphic = new System.Windows.Forms.Button();
            this.lblStatusExcel = new System.Windows.Forms.Label();
            this.btnExcludeExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Rosewood Std Regular", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SaddleBrown;
            this.title.Location = new System.Drawing.Point(239, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(345, 56);
            this.title.TabIndex = 0;
            this.title.Text = "TM-Generator";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(256, 78);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(312, 17);
            this.description.TabIndex = 1;
            this.description.Text = "Aplicatie pentru generarea tabelei de mortalitate";
            // 
            // logo
            // 
            this.logo.Image = global::TabelaDeMortalitate.Properties.Resources.icon;
            this.logo.Location = new System.Drawing.Point(636, 22);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(163, 171);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightSalmon;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(60, 197);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(226, 76);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Inserare Excel-date";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnGenerateTable
            // 
            this.btnGenerateTable.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGenerateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTable.Location = new System.Drawing.Point(60, 355);
            this.btnGenerateTable.Name = "btnGenerateTable";
            this.btnGenerateTable.Size = new System.Drawing.Size(226, 76);
            this.btnGenerateTable.TabIndex = 4;
            this.btnGenerateTable.Text = "Generare tabela";
            this.btnGenerateTable.UseVisualStyleBackColor = false;
            this.btnGenerateTable.Click += new System.EventHandler(this.btnGenerateTable_Click);
            // 
            // btnGenerateGraphic
            // 
            this.btnGenerateGraphic.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGenerateGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateGraphic.Location = new System.Drawing.Point(60, 517);
            this.btnGenerateGraphic.Name = "btnGenerateGraphic";
            this.btnGenerateGraphic.Size = new System.Drawing.Size(226, 76);
            this.btnGenerateGraphic.TabIndex = 5;
            this.btnGenerateGraphic.Text = "Generare grafice";
            this.btnGenerateGraphic.UseVisualStyleBackColor = false;
            this.btnGenerateGraphic.Click += new System.EventHandler(this.btnGenerateGraphic_Click);
            // 
            // lblStatusExcel
            // 
            this.lblStatusExcel.AutoSize = true;
            this.lblStatusExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusExcel.Location = new System.Drawing.Point(365, 249);
            this.lblStatusExcel.Name = "lblStatusExcel";
            this.lblStatusExcel.Size = new System.Drawing.Size(177, 24);
            this.lblStatusExcel.TabIndex = 6;
            this.lblStatusExcel.Text = "Niciun fisier incarcat";
            // 
            // btnExcludeExcel
            // 
            this.btnExcludeExcel.BackColor = System.Drawing.Color.Red;
            this.btnExcludeExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcludeExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcludeExcel.Location = new System.Drawing.Point(369, 209);
            this.btnExcludeExcel.Name = "btnExcludeExcel";
            this.btnExcludeExcel.Size = new System.Drawing.Size(40, 37);
            this.btnExcludeExcel.TabIndex = 7;
            this.btnExcludeExcel.Text = "X";
            this.btnExcludeExcel.UseVisualStyleBackColor = false;
            this.btnExcludeExcel.Visible = false;
            this.btnExcludeExcel.Click += new System.EventHandler(this.btnExcludeExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(834, 623);
            this.Controls.Add(this.btnExcludeExcel);
            this.Controls.Add(this.lblStatusExcel);
            this.Controls.Add(this.btnGenerateGraphic);
            this.Controls.Add(this.btnGenerateTable);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "TMGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnGenerateTable;
        private System.Windows.Forms.Button btnGenerateGraphic;
        private System.Windows.Forms.Label lblStatusExcel;
        private System.Windows.Forms.Button btnExcludeExcel;
    }
}

