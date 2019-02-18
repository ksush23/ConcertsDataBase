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
            this.dataGridViewArtistCategory = new System.Windows.Forms.DataGridView();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.labelArtistGenre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistCategory)).BeginInit();
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
            // 
            // dataGridViewArtistCategory
            // 
            this.dataGridViewArtistCategory.AutoGenerateColumns = false;
            this.dataGridViewArtistCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtistCategory.DataSource = this.bindingSource;
            this.dataGridViewArtistCategory.Location = new System.Drawing.Point(30, 148);
            this.dataGridViewArtistCategory.Name = "dataGridViewArtistCategory";
            this.dataGridViewArtistCategory.RowTemplate.Height = 24;
            this.dataGridViewArtistCategory.Size = new System.Drawing.Size(720, 269);
            this.dataGridViewArtistCategory.TabIndex = 0;
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
            // ArtistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelArtistGenre);
            this.Controls.Add(this.labelArtistName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.dataGridViewArtistCategory);
            this.Name = "ArtistsForm";
            this.Text = "ArtistsForm";
            this.Load += new System.EventHandler(this.ArtistsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConcertsData.DSConcertsTableAdapters.ArtistsByCategoryTableAdapter artistsByCategoryTableAdapter;
        private ConcertsData.DSConcerts dsConcerts;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridView dataGridViewArtistCategory;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.Label labelArtistGenre;
    }
}