namespace InboundFormatter
{
    partial class Selector
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
            if (disposing && ( components != null ))
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
            this.emailButton = new System.Windows.Forms.Button();
            this.crossdockButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailButton
            // 
            this.emailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailButton.Location = new System.Drawing.Point(12, 12);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(198, 93);
            this.emailButton.TabIndex = 0;
            this.emailButton.Text = "Emails";
            this.emailButton.UseVisualStyleBackColor = true;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // crossdockButton
            // 
            this.crossdockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossdockButton.Location = new System.Drawing.Point(216, 12);
            this.crossdockButton.Name = "crossdockButton";
            this.crossdockButton.Size = new System.Drawing.Size(198, 93);
            this.crossdockButton.TabIndex = 1;
            this.crossdockButton.Text = "Crossdocks";
            this.crossdockButton.UseVisualStyleBackColor = true;
            this.crossdockButton.Click += new System.EventHandler(this.crossdockButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Created by - Josh Pewtress";
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crossdockButton);
            this.Controls.Add(this.emailButton);
            this.Name = "Selector";
            this.Text = "Backoffice Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button crossdockButton;
        private System.Windows.Forms.Label label1;
    }
}