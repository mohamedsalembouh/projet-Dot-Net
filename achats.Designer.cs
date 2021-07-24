
namespace projet_dot_net
{
    partial class achats
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
            this.label1 = new System.Windows.Forms.Label();
            this.box_achat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quant_achat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Medapresmodification = new System.Windows.Forms.DataGridView();
            this.stock = new System.Windows.Forms.Label();
            this.quant_stocke = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Medapresmodification)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "achats des Medicaments";
            // 
            // box_achat
            // 
            this.box_achat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.box_achat.FormattingEnabled = true;
            this.box_achat.Location = new System.Drawing.Point(2, 62);
            this.box_achat.Name = "box_achat";
            this.box_achat.Size = new System.Drawing.Size(144, 25);
            this.box_achat.TabIndex = 1;
            this.box_achat.Text = "Select Medicament";
            this.box_achat.SelectedIndexChanged += new System.EventHandler(this.box_achat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choisir une quantité";
            // 
            // quant_achat
            // 
            this.quant_achat.Location = new System.Drawing.Point(2, 192);
            this.quant_achat.Name = "quant_achat";
            this.quant_achat.Size = new System.Drawing.Size(127, 23);
            this.quant_achat.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(12, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Acheter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Medapresmodification
            // 
            this.Medapresmodification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Medapresmodification.Location = new System.Drawing.Point(221, 12);
            this.Medapresmodification.Name = "Medapresmodification";
            this.Medapresmodification.RowTemplate.Height = 25;
            this.Medapresmodification.Size = new System.Drawing.Size(577, 438);
            this.Medapresmodification.TabIndex = 5;
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(24, 101);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(0, 15);
            this.stock.TabIndex = 6;
            // 
            // quant_stocke
            // 
            this.quant_stocke.AutoSize = true;
            this.quant_stocke.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quant_stocke.Location = new System.Drawing.Point(2, 116);
            this.quant_stocke.Name = "quant_stocke";
            this.quant_stocke.Size = new System.Drawing.Size(136, 20);
            this.quant_stocke.TabIndex = 7;
            this.quant_stocke.Text = "quantite stocke est";
            this.quant_stocke.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // achats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.quant_stocke);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.Medapresmodification);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quant_achat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_achat);
            this.Controls.Add(this.label1);
            this.Name = "achats";
            this.Text = "achats";
            this.Load += new System.EventHandler(this.achats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Medapresmodification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_achat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quant_achat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Medapresmodification;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label quant_stocke;
        private System.Windows.Forms.Button button2;
    }
}