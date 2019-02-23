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
            this.artistsByCategoryTableAdapter = new ConcertsData.DSConcertsTableAdapters.ArtistsByCategoryTableAdapter();
            this.dsConcerts = new ConcertsData.DSConcerts();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.labelArtistGenre = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataGridViewArtistsCategory = new System.Windows.Forms.DataGridView();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_Place_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistsByGenreTableAdapter = new ConcertsData.DSConcertsTableAdapters.ArtistsByGenreTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.concertsDataSet = new WinFormsConcerts.ConcertsDataSet();
            this.artistsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.ArtistsTableAdapter();
            this.comboBoxGenres = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistsCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // artistsByCategoryTableAdapter
            // 
            this.artistsByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // dsConcerts
            // 
            this.dsConcerts.DataSetName = "DSConcerts";
            this.dsConcerts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "ArtistsByCategory";
            this.bindingSource.DataSource = this.dsConcerts;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(252, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoSize = true;
            this.labelArtistName.Location = new System.Drawing.Point(73, 42);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(48, 17);
            this.labelArtistName.TabIndex = 3;
            this.labelArtistName.Text = "Назва";
            this.labelArtistName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelArtistGenre
            // 
            this.labelArtistGenre.AutoSize = true;
            this.labelArtistGenre.Location = new System.Drawing.Point(73, 79);
            this.labelArtistGenre.Name = "labelArtistGenre";
            this.labelArtistGenre.Size = new System.Drawing.Size(45, 17);
            this.labelArtistGenre.TabIndex = 4;
            this.labelArtistGenre.Text = "Жанр";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(542, 68);
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
            this.concertTimeDateDataGridViewTextBoxColumn,
            this.Artist_ID,
            this.Concert_ID,
            this.Concert_Artist_ID,
            this.Concert_Place_ID});
            this.dataGridViewArtistsCategory.DataSource = this.bindingSource;
            this.dataGridViewArtistsCategory.Location = new System.Drawing.Point(33, 132);
            this.dataGridViewArtistsCategory.Name = "dataGridViewArtistsCategory";
            this.dataGridViewArtistsCategory.RowTemplate.Height = 24;
            this.dataGridViewArtistsCategory.Size = new System.Drawing.Size(642, 284);
            this.dataGridViewArtistsCategory.TabIndex = 6;
            this.dataGridViewArtistsCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtistsCategory_CellContentClick);
            this.dataGridViewArtistsCategory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtistCategory_CellContentClick);
            this.dataGridViewArtistsCategory.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewArtistsCategory_DefaultValuesNeeded);
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
            this.Concert_Place_ID.HeaderText = "Місце проведення";
            this.Concert_Place_ID.Name = "Concert_Place_ID";
            this.Concert_Place_ID.ReadOnly = true;
            // 
            // artistsByGenreTableAdapter
            // 
            this.artistsByGenreTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Artists";
            this.bindingSource1.DataSource = this.dsConcerts;
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
            // comboBoxGenres
            // 
            this.comboBoxGenres.FormattingEnabled = true;
            this.comboBoxGenres.Items.AddRange(new object[] {
            "Pop",
            "Rock",
            "Rap",
            "Народна музика"});
            this.comboBoxGenres.Location = new System.Drawing.Point(252, 79);
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(180, 24);
            this.comboBoxGenres.TabIndex = 7;
            // 
            // ArtistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 450);
            this.Controls.Add(this.comboBoxGenres);
            this.Controls.Add(this.dataGridViewArtistsCategory);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelArtistGenre);
            this.Controls.Add(this.labelArtistName);
            this.Controls.Add(this.textBoxName);
            this.Name = "ArtistsForm";
            this.Text = "ArtistsForm";
            this.Load += new System.EventHandler(this.ArtistsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistsCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConcertsData.DSConcertsTableAdapters.ArtistsByCategoryTableAdapter artistsByCategoryTableAdapter;
        private ConcertsData.DSConcerts dsConcerts;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.Label labelArtistGenre;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridViewArtistsCategory;
        private ConcertsData.DSConcertsTableAdapters.ArtistsByGenreTableAdapter artistsByGenreTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ConcertsDataSet concertsDataSet;
        private ConcertsDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertTimeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_Place_ID;
        private System.Windows.Forms.ComboBox comboBoxGenres;
    }
}