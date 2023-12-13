namespace WinFormsFinal
{
    partial class mainForm
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
            this.btnRead = new System.Windows.Forms.Button();
            this.dataGridRecords = new System.Windows.Forms.DataGridView();
            this.tblBandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAlbumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBands = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(587, 480);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(206, 48);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dataGridRecords
            // 
            this.dataGridRecords.AllowUserToAddRows = false;
            this.dataGridRecords.AllowUserToDeleteRows = false;
            this.dataGridRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblBandID,
            this.tblBandName,
            this.tblAlbumID,
            this.tblAlbumName,
            this.tblReleaseYear});
            this.dataGridRecords.Location = new System.Drawing.Point(28, 25);
            this.dataGridRecords.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridRecords.Name = "dataGridRecords";
            this.dataGridRecords.ReadOnly = true;
            this.dataGridRecords.RowHeadersWidth = 50;
            this.dataGridRecords.RowTemplate.Height = 30;
            this.dataGridRecords.Size = new System.Drawing.Size(765, 435);
            this.dataGridRecords.TabIndex = 1;
            // 
            // tblBandID
            // 
            this.tblBandID.HeaderText = "Band ID";
            this.tblBandID.MinimumWidth = 6;
            this.tblBandID.Name = "tblBandID";
            this.tblBandID.ReadOnly = true;
            this.tblBandID.Width = 125;
            // 
            // tblBandName
            // 
            this.tblBandName.HeaderText = "Band Name";
            this.tblBandName.MinimumWidth = 6;
            this.tblBandName.Name = "tblBandName";
            this.tblBandName.ReadOnly = true;
            this.tblBandName.Width = 125;
            // 
            // tblAlbumID
            // 
            this.tblAlbumID.HeaderText = "Album ID";
            this.tblAlbumID.MinimumWidth = 6;
            this.tblAlbumID.Name = "tblAlbumID";
            this.tblAlbumID.ReadOnly = true;
            this.tblAlbumID.Width = 125;
            // 
            // tblAlbumName
            // 
            this.tblAlbumName.HeaderText = "Album Name";
            this.tblAlbumName.MinimumWidth = 6;
            this.tblAlbumName.Name = "tblAlbumName";
            this.tblAlbumName.ReadOnly = true;
            this.tblAlbumName.Width = 125;
            // 
            // tblReleaseYear
            // 
            this.tblReleaseYear.HeaderText = "Release Year";
            this.tblReleaseYear.MinimumWidth = 6;
            this.tblReleaseYear.Name = "tblReleaseYear";
            this.tblReleaseYear.ReadOnly = true;
            this.tblReleaseYear.Width = 125;
            // 
            // btnBands
            // 
            this.btnBands.Location = new System.Drawing.Point(28, 480);
            this.btnBands.Name = "btnBands";
            this.btnBands.Size = new System.Drawing.Size(206, 48);
            this.btnBands.TabIndex = 14;
            this.btnBands.Text = "Bands";
            this.btnBands.UseVisualStyleBackColor = true;
            this.btnBands.Click += new System.EventHandler(this.btnBands_Click);
            // 
            // btnAlbums
            // 
            this.btnAlbums.Location = new System.Drawing.Point(306, 480);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(206, 48);
            this.btnAlbums.TabIndex = 15;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.UseVisualStyleBackColor = true;
            this.btnAlbums.Click += new System.EventHandler(this.btnAlbums_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 553);
            this.Controls.Add(this.btnAlbums);
            this.Controls.Add(this.btnBands);
            this.Controls.Add(this.dataGridRecords);
            this.Controls.Add(this.btnRead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record Company";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView dataGridRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblBandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblBandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblAlbumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblAlbumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblReleaseYear;
        private System.Windows.Forms.Button btnBands;
        private System.Windows.Forms.Button btnAlbums;
    }
}

