namespace WinFormsConcerts
{
    partial class ArtistsForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataGridViewArtistsCategory = new System.Windows.Forms.DataGridView();
            this.concertsDataSet = new WinFormsConcerts.ConcertsDataSet();
            this.artistsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.ArtistsTableAdapter();
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsConcerts = new ConcertsData.DSConcerts();
            this.artistsByCategoryTableAdapter = new ConcertsData.DSConcertsTableAdapters.ArtistsByCategoryTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_Place_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistsCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(534, 51);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(100, 45);
            this.buttonFind.TabIndex = 5;
            this.buttonFind.Text = "Пошук";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // dataGridViewArtistsCategory
            // 
            this.dataGridViewArtistsCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArtistsCategory.AutoGenerateColumns = false;
            this.dataGridViewArtistsCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtistsCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistNameDataGridViewTextBoxColumn,
            this.artistGenreDataGridViewTextBoxColumn,
            this.Place_Name,
            this.concertTimeDateDataGridViewTextBoxColumn,
            this.Artist_ID,
            this.Concert_ID,
            this.Concert_Artist_ID,
            this.Concert_Place_ID});
            this.dataGridViewArtistsCategory.DataSource = this.bindingSource;
            this.dataGridViewArtistsCategory.Location = new System.Drawing.Point(33, 120);
            this.dataGridViewArtistsCategory.Name = "dataGridViewArtistsCategory";
            this.dataGridViewArtistsCategory.RowTemplate.Height = 24;
            this.dataGridViewArtistsCategory.Size = new System.Drawing.Size(601, 309);
            this.dataGridViewArtistsCategory.TabIndex = 6;
            this.dataGridViewArtistsCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtistsCategory_CellContentClick);
            this.dataGridViewArtistsCategory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtistCategory_CellContentClick);
            this.dataGridViewArtistsCategory.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewArtistsCategory_DefaultValuesNeeded);
            // 
            // concertsDataSet
            // 
            this.concertsDataSet.DataSetName = "ConcertsDataSet";
            this.concertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(45, 65);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(128, 17);
            this.labelPlace.TabIndex = 7;
            this.labelPlace.Text = "Місце проведення";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(227, 60);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(154, 22);
            this.textBoxPlace.TabIndex = 8;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "ArtistsByCategory";
            this.bindingSource.DataSource = this.dsConcerts;
            // 
            // dsConcerts
            // 
            this.dsConcerts.DataSetName = "DSConcerts";
            this.dsConcerts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artistsByCategoryTableAdapter
            // 
            this.artistsByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Artists";
            this.bindingSource1.DataSource = this.dsConcerts;
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "Artist_Name";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "Виконавець";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            this.artistNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artistGenreDataGridViewTextBoxColumn
            // 
            this.artistGenreDataGridViewTextBoxColumn.DataPropertyName = "Artist_Genre";
            this.artistGenreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.artistGenreDataGridViewTextBoxColumn.Name = "artistGenreDataGridViewTextBoxColumn";
            this.artistGenreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Place_Name
            // 
            this.Place_Name.DataPropertyName = "Place_Name";
            this.Place_Name.HeaderText = "Місце проведення";
            this.Place_Name.Name = "Place_Name";
            // 
            // concertTimeDateDataGridViewTextBoxColumn
            // 
            this.concertTimeDateDataGridViewTextBoxColumn.DataPropertyName = "Concert_TimeDate";
            this.concertTimeDateDataGridViewTextBoxColumn.HeaderText = "Дата і час";
            this.concertTimeDateDataGridViewTextBoxColumn.Name = "concertTimeDateDataGridViewTextBoxColumn";
            this.concertTimeDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Artist_ID
            // 
            this.Artist_ID.DataPropertyName = "Artist_ID";
            this.Artist_ID.HeaderText = "Artist_ID";
            this.Artist_ID.Name = "Artist_ID";
            this.Artist_ID.ReadOnly = true;
            this.Artist_ID.Visible = false;
            // 
            // Concert_ID
            // 
            this.Concert_ID.DataPropertyName = "Concert_ID";
            this.Concert_ID.HeaderText = "Concert_ID";
            this.Concert_ID.Name = "Concert_ID";
            this.Concert_ID.ReadOnly = true;
            this.Concert_ID.Visible = false;
            // 
            // Concert_Artist_ID
            // 
            this.Concert_Artist_ID.DataPropertyName = "Concert_Artist_ID";
            this.Concert_Artist_ID.HeaderText = "Concert_Artist_ID";
            this.Concert_Artist_ID.Name = "Concert_Artist_ID";
            this.Concert_Artist_ID.ReadOnly = true;
            this.Concert_Artist_ID.Visible = false;
            // 
            // Concert_Place_ID
            // 
            this.Concert_Place_ID.DataPropertyName = "Concert_Place_ID";
            this.Concert_Place_ID.HeaderText = "Concert_Place_ID";
            this.Concert_Place_ID.Name = "Concert_Place_ID";
            this.Concert_Place_ID.Visible = false;
            // 
            // ArtistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.dataGridViewArtistsCategory);
            this.Controls.Add(this.buttonFind);
            this.Name = "ArtistsForm";
            this.Text = "ArtistsForm";
            this.Load += new System.EventHandler(this.ArtistsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistsCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConcertsData.DSConcertsTableAdapters.ArtistsByCategoryTableAdapter artistsByCategoryTableAdapter;
        private ConcertsData.DSConcerts dsConcerts;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridViewArtistsCategory;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ConcertsDataSet concertsDataSet;
        private ConcertsDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertTimeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_Place_ID;
    }
}