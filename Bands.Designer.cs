namespace WinFormsFinal
{
    partial class bandsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridBands = new System.Windows.Forms.DataGridView();
            this.dgBandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBandName = new System.Windows.Forms.TextBox();
            this.btnAddBand = new System.Windows.Forms.Button();
            this.lblBandName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblBandID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBands)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBands
            // 
            this.dataGridBands.AllowUserToAddRows = false;
            this.dataGridBands.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridBands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgBandID,
            this.dgBandName});
            this.dataGridBands.Location = new System.Drawing.Point(45, 44);
            this.dataGridBands.Name = "dataGridBands";
            this.dataGridBands.ReadOnly = true;
            this.dataGridBands.RowHeadersWidth = 51;
            this.dataGridBands.RowTemplate.Height = 30;
            this.dataGridBands.Size = new System.Drawing.Size(376, 376);
            this.dataGridBands.TabIndex = 18;
            this.dataGridBands.SelectionChanged += new System.EventHandler(this.dataGridBands_SelectionChanged);
            // 
            // dgBandID
            // 
            this.dgBandID.HeaderText = "ID";
            this.dgBandID.MinimumWidth = 6;
            this.dgBandID.Name = "dgBandID";
            this.dgBandID.ReadOnly = true;
            this.dgBandID.Width = 125;
            // 
            // dgBandName
            // 
            this.dgBandName.HeaderText = "Name";
            this.dgBandName.MinimumWidth = 6;
            this.dgBandName.Name = "dgBandName";
            this.dgBandName.ReadOnly = true;
            this.dgBandName.Width = 125;
            // 
            // txtBandName
            // 
            this.txtBandName.Location = new System.Drawing.Point(466, 120);
            this.txtBandName.Name = "txtBandName";
            this.txtBandName.Size = new System.Drawing.Size(296, 30);
            this.txtBandName.TabIndex = 17;
            // 
            // btnAddBand
            // 
            this.btnAddBand.Location = new System.Drawing.Point(466, 171);
            this.btnAddBand.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBand.Name = "btnAddBand";
            this.btnAddBand.Size = new System.Drawing.Size(143, 48);
            this.btnAddBand.TabIndex = 13;
            this.btnAddBand.Text = "Add Band";
            this.btnAddBand.UseVisualStyleBackColor = true;
            this.btnAddBand.Click += new System.EventHandler(this.btnAddBand_Click);
            // 
            // lblBandName
            // 
            this.lblBandName.AutoSize = true;
            this.lblBandName.Location = new System.Drawing.Point(476, 92);
            this.lblBandName.Name = "lblBandName";
            this.lblBandName.Size = new System.Drawing.Size(115, 25);
            this.lblBandName.TabIndex = 15;
            this.lblBandName.Text = "Band Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(638, 171);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 48);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblBandID
            // 
            this.lblBandID.AutoSize = true;
            this.lblBandID.Location = new System.Drawing.Point(633, 92);
            this.lblBandID.Name = "lblBandID";
            this.lblBandID.Size = new System.Drawing.Size(82, 25);
            this.lblBandID.TabIndex = 20;
            this.lblBandID.Text = "Band ID";
            this.lblBandID.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 435);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 48);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 521);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblBandID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridBands);
            this.Controls.Add(this.txtBandName);
            this.Controls.Add(this.btnAddBand);
            this.Controls.Add(this.lblBandName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "bandsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bands";
            this.Load += new System.EventHandler(this.Bands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBands;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBandName;
        private System.Windows.Forms.TextBox txtBandName;
        private System.Windows.Forms.Button btnAddBand;
        private System.Windows.Forms.Label lblBandName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblBandID;
        private System.Windows.Forms.Button btnDelete;
    }
}