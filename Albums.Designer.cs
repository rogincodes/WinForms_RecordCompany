namespace WinFormsFinal
{
    partial class albumsForm
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
            this.dataGridAlbums = new System.Windows.Forms.DataGridView();
            this.dgAlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAlbumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgABandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBandID = new System.Windows.Forms.Label();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.txtBandID = new System.Windows.Forms.TextBox();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAlbumID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAlbums
            // 
            this.dataGridAlbums.AllowUserToAddRows = false;
            this.dataGridAlbums.AllowUserToDeleteRows = false;
            this.dataGridAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgAlbumID,
            this.dgAlbumName,
            this.dgReleaseYear,
            this.dgABandID});
            this.dataGridAlbums.Location = new System.Drawing.Point(31, 36);
            this.dataGridAlbums.Name = "dataGridAlbums";
            this.dataGridAlbums.ReadOnly = true;
            this.dataGridAlbums.RowHeadersWidth = 51;
            this.dataGridAlbums.RowTemplate.Height = 30;
            this.dataGridAlbums.Size = new System.Drawing.Size(636, 337);
            this.dataGridAlbums.TabIndex = 27;
            this.dataGridAlbums.SelectionChanged += new System.EventHandler(this.dataGridAlbums_SelectionChanged);
            // 
            // dgAlbumID
            // 
            this.dgAlbumID.HeaderText = "ID";
            this.dgAlbumID.MinimumWidth = 6;
            this.dgAlbumID.Name = "dgAlbumID";
            this.dgAlbumID.ReadOnly = true;
            this.dgAlbumID.Width = 125;
            // 
            // dgAlbumName
            // 
            this.dgAlbumName.HeaderText = "Name";
            this.dgAlbumName.MinimumWidth = 6;
            this.dgAlbumName.Name = "dgAlbumName";
            this.dgAlbumName.ReadOnly = true;
            this.dgAlbumName.Width = 125;
            // 
            // dgReleaseYear
            // 
            this.dgReleaseYear.HeaderText = "Release Year";
            this.dgReleaseYear.MinimumWidth = 6;
            this.dgReleaseYear.Name = "dgReleaseYear";
            this.dgReleaseYear.ReadOnly = true;
            this.dgReleaseYear.Width = 125;
            // 
            // dgABandID
            // 
            this.dgABandID.HeaderText = "Band ID";
            this.dgABandID.MinimumWidth = 6;
            this.dgABandID.Name = "dgABandID";
            this.dgABandID.ReadOnly = true;
            this.dgABandID.Width = 125;
            // 
            // lblBandID
            // 
            this.lblBandID.AutoSize = true;
            this.lblBandID.Location = new System.Drawing.Point(725, 207);
            this.lblBandID.Name = "lblBandID";
            this.lblBandID.Size = new System.Drawing.Size(82, 25);
            this.lblBandID.TabIndex = 24;
            this.lblBandID.Text = "Band ID";
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Location = new System.Drawing.Point(723, 139);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(129, 25);
            this.lblReleaseYear.TabIndex = 19;
            this.lblReleaseYear.Text = "Release Year";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(713, 100);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(296, 30);
            this.txtAlbumName.TabIndex = 17;
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Location = new System.Drawing.Point(723, 72);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(125, 25);
            this.lblAlbumName.TabIndex = 15;
            this.lblAlbumName.Text = "Album Name";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(713, 167);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(296, 30);
            this.txtReleaseYear.TabIndex = 21;
            // 
            // txtBandID
            // 
            this.txtBandID.Location = new System.Drawing.Point(715, 235);
            this.txtBandID.Name = "txtBandID";
            this.txtBandID.Size = new System.Drawing.Size(296, 30);
            this.txtBandID.TabIndex = 26;
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(715, 289);
            this.btnAddAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(133, 48);
            this.btnAddAlbum.TabIndex = 22;
            this.btnAddAlbum.Text = "Add Album";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(876, 289);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 48);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAlbumID
            // 
            this.lblAlbumID.AutoSize = true;
            this.lblAlbumID.Location = new System.Drawing.Point(871, 72);
            this.lblAlbumID.Name = "lblAlbumID";
            this.lblAlbumID.Size = new System.Drawing.Size(92, 25);
            this.lblAlbumID.TabIndex = 29;
            this.lblAlbumID.Text = "Album ID";
            this.lblAlbumID.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(534, 388);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 48);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // albumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 481);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblAlbumID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridAlbums);
            this.Controls.Add(this.txtBandID);
            this.Controls.Add(this.lblBandID);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.lblReleaseYear);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.lblAlbumName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "albumsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albums";
            this.Load += new System.EventHandler(this.albumsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlbums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAlbums;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAlbumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAlbumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgReleaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgABandID;
        private System.Windows.Forms.Label lblBandID;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.TextBox txtBandID;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblAlbumID;
        private System.Windows.Forms.Button btnDelete;
    }
}