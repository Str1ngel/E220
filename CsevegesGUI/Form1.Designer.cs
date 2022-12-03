namespace CsevegesGUI
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
            this.kezedemenyezo_label = new System.Windows.Forms.Label();
            this.fogado_label = new System.Windows.Forms.Label();
            this.kezedemenyezo_comboBox = new System.Windows.Forms.ComboBox();
            this.fogado_comboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.csevegesek_label = new System.Windows.Forms.Label();
            this.csevegesek_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // kezedemenyezo_label
            // 
            this.kezedemenyezo_label.AutoSize = true;
            this.kezedemenyezo_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kezedemenyezo_label.Location = new System.Drawing.Point(47, 47);
            this.kezedemenyezo_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kezedemenyezo_label.Name = "kezedemenyezo_label";
            this.kezedemenyezo_label.Size = new System.Drawing.Size(154, 28);
            this.kezedemenyezo_label.TabIndex = 0;
            this.kezedemenyezo_label.Text = "Kezedeményező";
            // 
            // fogado_label
            // 
            this.fogado_label.AutoSize = true;
            this.fogado_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fogado_label.Location = new System.Drawing.Point(47, 88);
            this.fogado_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fogado_label.Name = "fogado_label";
            this.fogado_label.Size = new System.Drawing.Size(161, 28);
            this.fogado_label.TabIndex = 1;
            this.fogado_label.Text = "Fogadó (partner)";
            // 
            // kezedemenyezo_comboBox
            // 
            this.kezedemenyezo_comboBox.FormattingEnabled = true;
            this.kezedemenyezo_comboBox.Location = new System.Drawing.Point(231, 50);
            this.kezedemenyezo_comboBox.Name = "kezedemenyezo_comboBox";
            this.kezedemenyezo_comboBox.Size = new System.Drawing.Size(224, 29);
            this.kezedemenyezo_comboBox.TabIndex = 2;
            this.kezedemenyezo_comboBox.SelectedIndexChanged += new System.EventHandler(this.kezedemenyezo_comboBox_SelectedIndexChanged);
            // 
            // fogado_comboBox
            // 
            this.fogado_comboBox.FormattingEnabled = true;
            this.fogado_comboBox.Location = new System.Drawing.Point(231, 91);
            this.fogado_comboBox.Name = "fogado_comboBox";
            this.fogado_comboBox.Size = new System.Drawing.Size(224, 29);
            this.fogado_comboBox.TabIndex = 3;
            this.fogado_comboBox.SelectedIndexChanged += new System.EventHandler(this.fogado_comboBox_SelectedIndexChanged);
            // 
            // csevegesek_label
            // 
            this.csevegesek_label.AutoSize = true;
            this.csevegesek_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.csevegesek_label.Location = new System.Drawing.Point(34, 169);
            this.csevegesek_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.csevegesek_label.Name = "csevegesek_label";
            this.csevegesek_label.Size = new System.Drawing.Size(112, 28);
            this.csevegesek_label.TabIndex = 4;
            this.csevegesek_label.Text = "Csevegések";
            // 
            // csevegesek_listbox
            // 
            this.csevegesek_listbox.FormattingEnabled = true;
            this.csevegesek_listbox.ItemHeight = 21;
            this.csevegesek_listbox.Location = new System.Drawing.Point(34, 200);
            this.csevegesek_listbox.Name = "csevegesek_listbox";
            this.csevegesek_listbox.Size = new System.Drawing.Size(443, 382);
            this.csevegesek_listbox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 610);
            this.Controls.Add(this.csevegesek_listbox);
            this.Controls.Add(this.csevegesek_label);
            this.Controls.Add(this.fogado_comboBox);
            this.Controls.Add(this.kezedemenyezo_comboBox);
            this.Controls.Add(this.fogado_label);
            this.Controls.Add(this.kezedemenyezo_label);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Csevegés GUI";
            this.Load += new System.EventHandler(this.CsevegesGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kezedemenyezo_label;
        private Label fogado_label;
        private ComboBox kezedemenyezo_comboBox;
        private ComboBox fogado_comboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label csevegesek_label;
        private ListBox csevegesek_listbox;
    }
}