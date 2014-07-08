namespace PW_4
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
            this.text_log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.text_n = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_log
            // 
            this.text_log.Location = new System.Drawing.Point(15, 90);
            this.text_log.Multiline = true;
            this.text_log.Name = "text_log";
            this.text_log.ReadOnly = true;
            this.text_log.Size = new System.Drawing.Size(260, 227);
            this.text_log.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj N:";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(15, 54);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(151, 23);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // text_n
            // 
            this.text_n.Location = new System.Drawing.Point(15, 28);
            this.text_n.Name = "text_n";
            this.text_n.Size = new System.Drawing.Size(151, 20);
            this.text_n.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 329);
            this.Controls.Add(this.text_n);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox text_n;
    }
}

