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
            // ArtistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewArtistCategory);
            this.Name = "ArtistsForm";
            this.Text = "ArtistsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ConcertsData.DSConcertsTableAdapters.ArtistsByCategoryTableAdapter artistsByCategoryTableAdapter;
        private ConcertsData.DSConcerts dsConcerts;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridView dataGridViewArtistCategory;
    }
}