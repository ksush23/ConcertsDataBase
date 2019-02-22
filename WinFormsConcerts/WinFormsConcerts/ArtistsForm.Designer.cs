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
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.labelArtistGenre = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataGridViewArtistsCategory = new System.Windows.Forms.DataGridView();
            this.ArtistByGenre = new System.Windows.Forms.Label();
            this.comboBoxArtistByGenre = new System.Windows.Forms.ComboBox();
            this.artistsByGenreTableAdapter = new ConcertsData.DSConcertsTableAdapters.ArtistsByGenreTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.concertsDataSet = new WinFormsConcerts.ConcertsDataSet();
            this.artistsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.ArtistsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concertTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_Place_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistsCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(252, 89);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.ShortcutsEnabled = false;
            this.textBoxGenre.Size = new System.Drawing.Size(180, 22);
            this.textBoxGenre.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(252, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoSize = true;
            this.labelArtistName.Location = new System.Drawing.Point(70, 42);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(48, 17);
            this.labelArtistName.TabIndex = 3;
            this.labelArtistName.Text = "Назва";
            this.labelArtistName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelArtistGenre
            // 
            this.labelArtistGenre.AutoSize = true;
            this.labelArtistGenre.Location = new System.Drawing.Point(73, 89);
            this.labelArtistGenre.Name = "labelArtistGenre";
            this.labelArtistGenre.Size = new System.Drawing.Size(45, 17);
            this.labelArtistGenre.TabIndex = 4;
            this.labelArtistGenre.Text = "Жанр";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(541, 51);
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
            this.Artist_ID,
            this.concertTimeDateDataGridViewTextBoxColumn,
            this.Concert_ID,
            this.Concert_Artist_ID,
            this.Concert_Place_ID});
            this.dataGridViewArtistsCategory.DataSource = this.bindingSource;
            this.dataGridViewArtistsCategory.Location = new System.Drawing.Point(-1, 132);
            this.dataGridViewArtistsCategory.Name = "dataGridViewArtistsCategory";
            this.dataGridViewArtistsCategory.RowTemplate.Height = 24;
            this.dataGridViewArtistsCategory.Size = new System.Drawing.Size(642, 286);
            this.dataGridViewArtistsCategory.TabIndex = 6;
            this.dataGridViewArtistsCategory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtistCategory_CellContentClick);
            // 
            // ArtistByGenre
            // 
            this.ArtistByGenre.AutoSize = true;
            this.ArtistByGenre.Location = new System.Drawing.Point(783, 65);
            this.ArtistByGenre.Name = "ArtistByGenre";
            this.ArtistByGenre.Size = new System.Drawing.Size(159, 17);
            this.ArtistByGenre.TabIndex = 7;
            this.ArtistByGenre.Text = "Виконавець за жанром";
            // 
            // comboBoxArtistByGenre
            // 
            this.comboBoxArtistByGenre.FormattingEnabled = true;
            this.comboBoxArtistByGenre.Location = new System.Drawing.Point(1009, 65);
            this.comboBoxArtistByGenre.Name = "comboBoxArtistByGenre";
            this.comboBoxArtistByGenre.Size = new System.Drawing.Size(121, 24);
            this.comboBoxArtistByGenre.TabIndex = 8;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistIDDataGridViewTextBoxColumn,
            this.artistNameDataGridViewTextBoxColumn1,
            this.artistGenreDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(733, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 264);
            this.dataGridView1.TabIndex = 9;
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "Artist_ID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "Artist_ID";
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            // 
            // artistNameDataGridViewTextBoxColumn1
            // 
            this.artistNameDataGridViewTextBoxColumn1.DataPropertyName = "Artist_Name";
            this.artistNameDataGridViewTextBoxColumn1.HeaderText = "Artist_Name";
            this.artistNameDataGridViewTextBoxColumn1.Name = "artistNameDataGridViewTextBoxColumn1";
            // 
            // artistGenreDataGridViewTextBoxColumn1
            // 
            this.artistGenreDataGridViewTextBoxColumn1.DataPropertyName = "Artist_Genre";
            this.artistGenreDataGridViewTextBoxColumn1.HeaderText = "Artist_Genre";
            this.artistGenreDataGridViewTextBoxColumn1.Name = "artistGenreDataGridViewTextBoxColumn1";
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "Artist_Name";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "Виконавець";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            // 
            // artistGenreDataGridViewTextBoxColumn
            // 
            this.artistGenreDataGridViewTextBoxColumn.DataPropertyName = "Artist_Genre";
            this.artistGenreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.artistGenreDataGridViewTextBoxColumn.Name = "artistGenreDataGridViewTextBoxColumn";
            // 
            // Artist_ID
            // 
            this.Artist_ID.DataPropertyName = "Artist_ID";
            this.Artist_ID.HeaderText = "Artist_ID";
            this.Artist_ID.Name = "Artist_ID";
            // 
            // concertTimeDateDataGridViewTextBoxColumn
            // 
            this.concertTimeDateDataGridViewTextBoxColumn.DataPropertyName = "Concert_TimeDate";
            this.concertTimeDateDataGridViewTextBoxColumn.HeaderText = "Дата і час";
            this.concertTimeDateDataGridViewTextBoxColumn.Name = "concertTimeDateDataGridViewTextBoxColumn";
            // 
            // Concert_ID
            // 
            this.Concert_ID.DataPropertyName = "Concert_ID";
            this.Concert_ID.HeaderText = "Concert_ID";
            this.Concert_ID.Name = "Concert_ID";
            this.Concert_ID.Visible = false;
            // 
            // Concert_Artist_ID
            // 
            this.Concert_Artist_ID.DataPropertyName = "Concert_Artist_ID";
            this.Concert_Artist_ID.HeaderText = "Concert_Artist_ID";
            this.Concert_Artist_ID.Name = "Concert_Artist_ID";
            this.Concert_Artist_ID.Visible = false;
            // 
            // Concert_Place_ID
            // 
            this.Concert_Place_ID.DataPropertyName = "Concert_Place_ID";
            this.Concert_Place_ID.HeaderText = "Місце проведення";
            this.Concert_Place_ID.Name = "Concert_Place_ID";
            // 
            // ArtistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxArtistByGenre);
            this.Controls.Add(this.ArtistByGenre);
            this.Controls.Add(this.dataGridViewArtistsCategory);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelArtistGenre);
            this.Controls.Add(this.labelArtistName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxGenre);
            this.Name = "ArtistsForm";
            this.Text = "ArtistsForm";
            this.Load += new System.EventHandler(this.ArtistsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistsCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConcertsData.DSConcertsTableAdapters.ArtistsByCategoryTableAdapter artistsByCategoryTableAdapter;
        private ConcertsData.DSConcerts dsConcerts;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.Label labelArtistGenre;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridViewArtistsCategory;
        private System.Windows.Forms.Label ArtistByGenre;
        private System.Windows.Forms.ComboBox comboBoxArtistByGenre;
        private ConcertsData.DSConcertsTableAdapters.ArtistsByGenreTableAdapter artistsByGenreTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ConcertsDataSet concertsDataSet;
        private ConcertsDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertTimeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_Place_ID;
    }
}