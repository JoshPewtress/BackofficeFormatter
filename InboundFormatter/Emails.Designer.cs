namespace InboundFormatter
{
    partial class Emails
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
            this.requestGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.damageRadioButton = new System.Windows.Forms.RadioButton();
            this.lostRadioButton = new System.Windows.Forms.RadioButton();
            this.requestOtherRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelRadioButton = new System.Windows.Forms.RadioButton();
            this.requestOtherTextBox = new System.Windows.Forms.TextBox();
            this.actionGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.actionOtherRadioButton = new System.Windows.Forms.RadioButton();
            this.resourceRadioButton = new System.Windows.Forms.RadioButton();
            this.refundRadioButton = new System.Windows.Forms.RadioButton();
            this.actionOtherTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.resultsDataGrid = new System.Windows.Forms.DataGridView();
            this.submitLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.storeNumberTextBox = new System.Windows.Forms.TextBox();
            this.requestGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.actionGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).BeginInit();
            this.submitLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(700, 153);
            this.inputTextBox.TabIndex = 0;
            // 
            // requestGroup
            // 
            this.requestGroup.Controls.Add(this.tableLayoutPanel1);
            this.requestGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestGroup.Location = new System.Drawing.Point(0, 153);
            this.requestGroup.Name = "requestGroup";
            this.requestGroup.Size = new System.Drawing.Size(700, 69);
            this.requestGroup.TabIndex = 1;
            this.requestGroup.TabStop = false;
            this.requestGroup.Text = "Request Reason";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.damageRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lostRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.requestOtherRadioButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelRadioButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 50);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // damageRadioButton
            // 
            this.damageRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.damageRadioButton.AutoSize = true;
            this.damageRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.damageRadioButton.Checked = true;
            this.damageRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.damageRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.damageRadioButton.FlatAppearance.BorderSize = 2;
            this.damageRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.damageRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.damageRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageRadioButton.Location = new System.Drawing.Point(3, 3);
            this.damageRadioButton.Name = "damageRadioButton";
            this.damageRadioButton.Size = new System.Drawing.Size(167, 44);
            this.damageRadioButton.TabIndex = 0;
            this.damageRadioButton.TabStop = true;
            this.damageRadioButton.Text = "Damaged";
            this.damageRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.damageRadioButton.UseVisualStyleBackColor = true;
            // 
            // lostRadioButton
            // 
            this.lostRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.lostRadioButton.AutoSize = true;
            this.lostRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lostRadioButton.FlatAppearance.BorderSize = 2;
            this.lostRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.lostRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lostRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostRadioButton.Location = new System.Drawing.Point(176, 3);
            this.lostRadioButton.Name = "lostRadioButton";
            this.lostRadioButton.Size = new System.Drawing.Size(167, 44);
            this.lostRadioButton.TabIndex = 1;
            this.lostRadioButton.TabStop = true;
            this.lostRadioButton.Text = "Lost In-Transit";
            this.lostRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lostRadioButton.UseVisualStyleBackColor = true;
            // 
            // requestOtherRadioButton
            // 
            this.requestOtherRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.requestOtherRadioButton.AutoSize = true;
            this.requestOtherRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestOtherRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestOtherRadioButton.FlatAppearance.BorderSize = 2;
            this.requestOtherRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.requestOtherRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestOtherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestOtherRadioButton.Location = new System.Drawing.Point(522, 3);
            this.requestOtherRadioButton.Name = "requestOtherRadioButton";
            this.requestOtherRadioButton.Size = new System.Drawing.Size(169, 44);
            this.requestOtherRadioButton.TabIndex = 3;
            this.requestOtherRadioButton.TabStop = true;
            this.requestOtherRadioButton.Text = "Other";
            this.requestOtherRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.requestOtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // cancelRadioButton
            // 
            this.cancelRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.cancelRadioButton.AutoSize = true;
            this.cancelRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelRadioButton.FlatAppearance.BorderSize = 2;
            this.cancelRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.cancelRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelRadioButton.Location = new System.Drawing.Point(349, 3);
            this.cancelRadioButton.Name = "cancelRadioButton";
            this.cancelRadioButton.Size = new System.Drawing.Size(167, 44);
            this.cancelRadioButton.TabIndex = 2;
            this.cancelRadioButton.TabStop = true;
            this.cancelRadioButton.Text = "Customer Cancel";
            this.cancelRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelRadioButton.UseVisualStyleBackColor = true;
            // 
            // requestOtherTextBox
            // 
            this.requestOtherTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestOtherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestOtherTextBox.Location = new System.Drawing.Point(0, 222);
            this.requestOtherTextBox.Name = "requestOtherTextBox";
            this.requestOtherTextBox.Size = new System.Drawing.Size(700, 22);
            this.requestOtherTextBox.TabIndex = 3;
            this.requestOtherTextBox.Enter += new System.EventHandler(this.RemovePlaceholder);
            this.requestOtherTextBox.Leave += new System.EventHandler(this.AddPlaceholder);
            // 
            // actionGroup
            // 
            this.actionGroup.Controls.Add(this.tableLayoutPanel2);
            this.actionGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionGroup.Location = new System.Drawing.Point(0, 244);
            this.actionGroup.Name = "actionGroup";
            this.actionGroup.Size = new System.Drawing.Size(700, 69);
            this.actionGroup.TabIndex = 4;
            this.actionGroup.TabStop = false;
            this.actionGroup.Text = "Action Needed";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.actionOtherRadioButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.resourceRadioButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.refundRadioButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 50);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // actionOtherRadioButton
            // 
            this.actionOtherRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.actionOtherRadioButton.AutoSize = true;
            this.actionOtherRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionOtherRadioButton.FlatAppearance.BorderSize = 2;
            this.actionOtherRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.actionOtherRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionOtherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionOtherRadioButton.Location = new System.Drawing.Point(465, 3);
            this.actionOtherRadioButton.Name = "actionOtherRadioButton";
            this.actionOtherRadioButton.Size = new System.Drawing.Size(226, 44);
            this.actionOtherRadioButton.TabIndex = 2;
            this.actionOtherRadioButton.TabStop = true;
            this.actionOtherRadioButton.Text = "Other";
            this.actionOtherRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actionOtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // resourceRadioButton
            // 
            this.resourceRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.resourceRadioButton.AutoSize = true;
            this.resourceRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceRadioButton.FlatAppearance.BorderSize = 2;
            this.resourceRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.resourceRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resourceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceRadioButton.Location = new System.Drawing.Point(234, 3);
            this.resourceRadioButton.Name = "resourceRadioButton";
            this.resourceRadioButton.Size = new System.Drawing.Size(225, 44);
            this.resourceRadioButton.TabIndex = 1;
            this.resourceRadioButton.TabStop = true;
            this.resourceRadioButton.Text = "Resource";
            this.resourceRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resourceRadioButton.UseVisualStyleBackColor = true;
            // 
            // refundRadioButton
            // 
            this.refundRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.refundRadioButton.AutoSize = true;
            this.refundRadioButton.Checked = true;
            this.refundRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refundRadioButton.FlatAppearance.BorderSize = 2;
            this.refundRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.refundRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refundRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundRadioButton.Location = new System.Drawing.Point(3, 3);
            this.refundRadioButton.Name = "refundRadioButton";
            this.refundRadioButton.Size = new System.Drawing.Size(225, 44);
            this.refundRadioButton.TabIndex = 0;
            this.refundRadioButton.TabStop = true;
            this.refundRadioButton.Text = "Refund";
            this.refundRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refundRadioButton.UseVisualStyleBackColor = true;
            // 
            // actionOtherTextBox
            // 
            this.actionOtherTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionOtherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionOtherTextBox.Location = new System.Drawing.Point(0, 313);
            this.actionOtherTextBox.Name = "actionOtherTextBox";
            this.actionOtherTextBox.Size = new System.Drawing.Size(700, 22);
            this.actionOtherTextBox.TabIndex = 6;
            this.actionOtherTextBox.Enter += new System.EventHandler(this.RemovePlaceholder);
            this.actionOtherTextBox.Leave += new System.EventHandler(this.AddPlaceholder);
            // 
            // submitButton
            // 
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButton.FlatAppearance.BorderSize = 2;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(108, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(589, 32);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resultsDataGrid
            // 
            this.resultsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.resultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultsDataGrid.Location = new System.Drawing.Point(0, 371);
            this.resultsDataGrid.MinimumSize = new System.Drawing.Size(650, 0);
            this.resultsDataGrid.Name = "resultsDataGrid";
            this.resultsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.resultsDataGrid.Size = new System.Drawing.Size(700, 144);
            this.resultsDataGrid.TabIndex = 11;
            this.resultsDataGrid.TabStop = false;
            // 
            // submitLayoutPanel
            // 
            this.submitLayoutPanel.ColumnCount = 2;
            this.submitLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.submitLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.submitLayoutPanel.Controls.Add(this.submitButton, 1, 0);
            this.submitLayoutPanel.Controls.Add(this.storeNumberTextBox, 0, 0);
            this.submitLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.submitLayoutPanel.Location = new System.Drawing.Point(0, 335);
            this.submitLayoutPanel.Name = "submitLayoutPanel";
            this.submitLayoutPanel.RowCount = 1;
            this.submitLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.submitLayoutPanel.Size = new System.Drawing.Size(700, 38);
            this.submitLayoutPanel.TabIndex = 12;
            // 
            // storeNumberTextBox
            // 
            this.storeNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeNumberTextBox.Location = new System.Drawing.Point(3, 3);
            this.storeNumberTextBox.Multiline = true;
            this.storeNumberTextBox.Name = "storeNumberTextBox";
            this.storeNumberTextBox.Size = new System.Drawing.Size(99, 32);
            this.storeNumberTextBox.TabIndex = 7;
            this.storeNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.storeNumberTextBox.Enter += new System.EventHandler(this.RemovePlaceholder);
            this.storeNumberTextBox.Leave += new System.EventHandler(this.AddPlaceholder);
            // 
            // Emails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(700, 515);
            this.Controls.Add(this.submitLayoutPanel);
            this.Controls.Add(this.resultsDataGrid);
            this.Controls.Add(this.actionOtherTextBox);
            this.Controls.Add(this.actionGroup);
            this.Controls.Add(this.requestOtherTextBox);
            this.Controls.Add(this.requestGroup);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Emails";
            this.Text = "Emails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.requestGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.actionGroup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGrid)).EndInit();
            this.submitLayoutPanel.ResumeLayout(false);
            this.submitLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.GroupBox requestGroup;
        private System.Windows.Forms.TextBox requestOtherTextBox;
        private System.Windows.Forms.RadioButton requestOtherRadioButton;
        private System.Windows.Forms.RadioButton cancelRadioButton;
        private System.Windows.Forms.RadioButton lostRadioButton;
        private System.Windows.Forms.RadioButton damageRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox actionGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton refundRadioButton;
        private System.Windows.Forms.RadioButton actionOtherRadioButton;
        private System.Windows.Forms.RadioButton resourceRadioButton;
        private System.Windows.Forms.TextBox actionOtherTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView resultsDataGrid;
        private System.Windows.Forms.TableLayoutPanel submitLayoutPanel;
        private System.Windows.Forms.TextBox storeNumberTextBox;
    }
}