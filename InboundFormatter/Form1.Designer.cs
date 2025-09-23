namespace InboundFormatter
{
    partial class InboundFormatter
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.crossdockButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(854, 158);
            this.inputTextBox.TabIndex = 1;
            // 
            // processButton
            // 
            this.processButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.processButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(3, 3);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(421, 39);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Process Email";
            this.processButton.UseVisualStyleBackColor = false;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            this.processButton.Enter += new System.EventHandler(this.Button_HoverEnter);
            this.processButton.Leave += new System.EventHandler(this.Button_HoverLeave);
            this.processButton.MouseEnter += new System.EventHandler(this.Button_HoverEnter);
            this.processButton.MouseLeave += new System.EventHandler(this.Button_HoverLeave);
            // 
            // resultsGrid
            // 
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGrid.Location = new System.Drawing.Point(0, 203);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.Size = new System.Drawing.Size(854, 396);
            this.resultsGrid.TabIndex = 2;
            this.resultsGrid.TabStop = false;
            // 
            // crossdockButton
            // 
            this.crossdockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crossdockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crossdockButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossdockButton.Location = new System.Drawing.Point(430, 3);
            this.crossdockButton.Name = "crossdockButton";
            this.crossdockButton.Size = new System.Drawing.Size(421, 39);
            this.crossdockButton.TabIndex = 3;
            this.crossdockButton.Text = "Process Crossdock";
            this.crossdockButton.UseVisualStyleBackColor = true;
            this.crossdockButton.Click += new System.EventHandler(this.crossdockButton_Click);
            this.crossdockButton.Enter += new System.EventHandler(this.Button_HoverEnter);
            this.crossdockButton.Leave += new System.EventHandler(this.Button_HoverLeave);
            this.crossdockButton.MouseEnter += new System.EventHandler(this.Button_HoverEnter);
            this.crossdockButton.MouseLeave += new System.EventHandler(this.Button_HoverLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.crossdockButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.processButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InboundFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 599);
            this.Controls.Add(this.resultsGrid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.inputTextBox);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "InboundFormatter";
            this.Text = "Inbound Formatter";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.DataGridView resultsGrid;
        private System.Windows.Forms.Button crossdockButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

