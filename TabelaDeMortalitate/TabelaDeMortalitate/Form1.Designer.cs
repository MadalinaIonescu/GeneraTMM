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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.lblStatusExcel = new System.Windows.Forms.Label();
            this.btnExcludeExcel = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnInputINS = new System.Windows.Forms.Button();
            this.btnGenerateTable = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnGenerateGraphic = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.title.Location = new System.Drawing.Point(636, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(343, 80);
            this.title.TabIndex = 0;
            this.title.Text = "GeneraTMM";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(682, 13);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(423, 25);
            this.description.TabIndex = 1;
            this.description.Text = "Aplicatie pentru generarea tabelei de mortalitate";
            // 
            // lblStatusExcel
            // 
            this.lblStatusExcel.AutoSize = true;
            this.lblStatusExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusExcel.Location = new System.Drawing.Point(78, 12);
            this.lblStatusExcel.Name = "lblStatusExcel";
            this.lblStatusExcel.Size = new System.Drawing.Size(177, 24);
            this.lblStatusExcel.TabIndex = 6;
            this.lblStatusExcel.Text = "Niciun fisier incarcat";
            // 
            // btnExcludeExcel
            // 
            this.btnExcludeExcel.BackColor = System.Drawing.Color.Red;
            this.btnExcludeExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcludeExcel.FlatAppearance.BorderSize = 0;
            this.btnExcludeExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcludeExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcludeExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcludeExcel.Location = new System.Drawing.Point(0, 0);
            this.btnExcludeExcel.Name = "btnExcludeExcel";
            this.btnExcludeExcel.Size = new System.Drawing.Size(40, 43);
            this.btnExcludeExcel.TabIndex = 7;
            this.btnExcludeExcel.Text = "X";
            this.btnExcludeExcel.UseVisualStyleBackColor = false;
            this.btnExcludeExcel.Visible = false;
            this.btnExcludeExcel.Click += new System.EventHandler(this.btnExcludeExcel_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnInputINS);
            this.panelButtons.Controls.Add(this.btnGenerateTable);
            this.panelButtons.Controls.Add(this.logo);
            this.panelButtons.Controls.Add(this.btnInsert);
            this.panelButtons.Controls.Add(this.btnGenerateGraphic);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(200, 761);
            this.panelButtons.TabIndex = 8;
            // 
            // btnInputINS
            // 
            this.btnInputINS.BackColor = System.Drawing.Color.Transparent;
            this.btnInputINS.FlatAppearance.BorderSize = 0;
            this.btnInputINS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputINS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnInputINS.ForeColor = System.Drawing.Color.White;
            this.btnInputINS.Image = ((System.Drawing.Image)(resources.GetObject("btnInputINS.Image")));
            this.btnInputINS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInputINS.Location = new System.Drawing.Point(0, 169);
            this.btnInputINS.Name = "btnInputINS";
            this.btnInputINS.Size = new System.Drawing.Size(200, 76);
            this.btnInputINS.TabIndex = 6;
            this.btnInputINS.Text = "Creeaza Excel";
            this.btnInputINS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInputINS.UseVisualStyleBackColor = false;
            this.btnInputINS.Click += new System.EventHandler(this.btnInputINS_Click);
            // 
            // btnGenerateTable
            // 
            this.btnGenerateTable.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateTable.FlatAppearance.BorderSize = 0;
            this.btnGenerateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTable.ForeColor = System.Drawing.Color.White;
            this.btnGenerateTable.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateTable.Image")));
            this.btnGenerateTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerateTable.Location = new System.Drawing.Point(0, 428);
            this.btnGenerateTable.Name = "btnGenerateTable";
            this.btnGenerateTable.Size = new System.Drawing.Size(200, 76);
            this.btnGenerateTable.TabIndex = 4;
            this.btnGenerateTable.Text = "Generare tabela";
            this.btnGenerateTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateTable.UseVisualStyleBackColor = false;
            this.btnGenerateTable.Click += new System.EventHandler(this.btnGenerateTable_Click);
            this.btnGenerateTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGenerateTable_MouseDown);
            // 
            // logo
            // 
            this.logo.Image = global::TabelaDeMortalitate.Properties.Resources.icon;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(163, 125);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsert.Location = new System.Drawing.Point(0, 299);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 76);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Inserare Excel-date";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnGenerateGraphic
            // 
            this.btnGenerateGraphic.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateGraphic.FlatAppearance.BorderSize = 0;
            this.btnGenerateGraphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnGenerateGraphic.ForeColor = System.Drawing.Color.White;
            this.btnGenerateGraphic.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateGraphic.Image")));
            this.btnGenerateGraphic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerateGraphic.Location = new System.Drawing.Point(0, 544);
            this.btnGenerateGraphic.Name = "btnGenerateGraphic";
            this.btnGenerateGraphic.Size = new System.Drawing.Size(200, 76);
            this.btnGenerateGraphic.TabIndex = 5;
            this.btnGenerateGraphic.Text = "Generare grafice";
            this.btnGenerateGraphic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateGraphic.UseVisualStyleBackColor = false;
            this.btnGenerateGraphic.Click += new System.EventHandler(this.btnGenerateGraphic_Click);
            this.btnGenerateGraphic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGenerateGraphic_MouseDown);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblStatusExcel);
            this.panelBottom.Controls.Add(this.btnExcludeExcel);
            this.panelBottom.Controls.Add(this.description);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(200, 718);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1286, 43);
            this.panelBottom.TabIndex = 9;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.progressBar);
            this.mainPanel.Location = new System.Drawing.Point(200, 59);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1286, 656);
            this.mainPanel.TabIndex = 10;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(195, 269);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(832, 96);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1486, 761);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "TMGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnGenerateTable;
        private System.Windows.Forms.Button btnGenerateGraphic;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnInputINS;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ProgressBar progressBar;
        internal System.Windows.Forms.Button btnInsert;
        internal System.Windows.Forms.Label lblStatusExcel;
        internal System.Windows.Forms.Button btnExcludeExcel;
    }
}

