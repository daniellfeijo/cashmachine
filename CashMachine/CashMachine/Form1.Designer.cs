namespace CashMachine
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
            this.AccountCombo = new System.Windows.Forms.ComboBox();
            this.ClientText = new System.Windows.Forms.TextBox();
            this.NumberText = new System.Windows.Forms.TextBox();
            this.BalanceText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AccountCombo
            // 
            this.AccountCombo.FormattingEnabled = true;
            this.AccountCombo.Location = new System.Drawing.Point(210, 98);
            this.AccountCombo.Name = "AccountCombo";
            this.AccountCombo.Size = new System.Drawing.Size(121, 21);
            this.AccountCombo.TabIndex = 0;
            this.AccountCombo.SelectedIndexChanged += new System.EventHandler(this.AccountCombo_SelectedIndexChanged);
            // 
            // ClientText
            // 
            this.ClientText.Location = new System.Drawing.Point(210, 146);
            this.ClientText.Name = "ClientText";
            this.ClientText.Size = new System.Drawing.Size(100, 20);
            this.ClientText.TabIndex = 1;
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(210, 185);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(100, 20);
            this.NumberText.TabIndex = 2;
            // 
            // BalanceText
            // 
            this.BalanceText.Location = new System.Drawing.Point(210, 235);
            this.BalanceText.Name = "BalanceText";
            this.BalanceText.Size = new System.Drawing.Size(100, 20);
            this.BalanceText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 485);
            this.Controls.Add(this.BalanceText);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.ClientText);
            this.Controls.Add(this.AccountCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AccountCombo;
        private System.Windows.Forms.TextBox ClientText;
        private System.Windows.Forms.TextBox NumberText;
        private System.Windows.Forms.TextBox BalanceText;
    }
}

