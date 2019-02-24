namespace WinFormsConcerts
{
    partial class FormTickets
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
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.buttonFindTickets = new System.Windows.Forms.Button();
            this.dsConcerts = new ConcertsData.DSConcerts();
            this.ticketsByCategoryTableAdapter = new ConcertsData.DSConcertsTableAdapters.TicketsByCategoryTableAdapter();
            this.bindingSourceTicketsByCategory = new System.Windows.Forms.BindingSource(this.components);
            this.concertsDataSet = new WinFormsConcerts.ConcertsDataSet();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatLinenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTicketsByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(295, 41);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(191, 22);
            this.textBoxArtist.TabIndex = 0;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(295, 88);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(191, 22);
            this.textBoxPlace.TabIndex = 3;
            // 
            // buttonFindTickets
            // 
            this.buttonFindTickets.Location = new System.Drawing.Point(571, 53);
            this.buttonFindTickets.Name = "buttonFindTickets";
            this.buttonFindTickets.Size = new System.Drawing.Size(80, 52);
            this.buttonFindTickets.TabIndex = 4;
            this.buttonFindTickets.Text = "Пошук";
            this.buttonFindTickets.UseVisualStyleBackColor = true;
            this.buttonFindTickets.Click += new System.EventHandler(this.buttonFindTickets_Click);
            // 
            // dsConcerts
            // 
            this.dsConcerts.DataSetName = "DSConcerts";
            this.dsConcerts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsByCategoryTableAdapter
            // 
            this.ticketsByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceTicketsByCategory
            // 
            this.bindingSourceTicketsByCategory.DataMember = "TicketsByCategory";
            this.bindingSourceTicketsByCategory.DataSource = this.dsConcerts;
            // 
            // concertsDataSet
            // 
            this.concertsDataSet.DataSetName = "ConcertsDataSet";
            this.concertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AutoGenerateColumns = false;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.seatLinenumberDataGridViewTextBoxColumn,
            this.seatNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewTickets.DataSource = this.bindingSourceTicketsByCategory;
            this.dataGridViewTickets.Location = new System.Drawing.Point(25, 128);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(713, 314);
            this.dataGridViewTickets.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Виконавець";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Місце проведення";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Artist_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Виконавець";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Place_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Місце проведення";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // seatLinenumberDataGridViewTextBoxColumn
            // 
            this.seatLinenumberDataGridViewTextBoxColumn.DataPropertyName = "Seat_Line_number";
            this.seatLinenumberDataGridViewTextBoxColumn.HeaderText = "Номер ряду";
            this.seatLinenumberDataGridViewTextBoxColumn.Name = "seatLinenumberDataGridViewTextBoxColumn";
            // 
            // seatNumberDataGridViewTextBoxColumn
            // 
            this.seatNumberDataGridViewTextBoxColumn.DataPropertyName = "Seat_Number";
            this.seatNumberDataGridViewTextBoxColumn.HeaderText = "Номер сидіння";
            this.seatNumberDataGridViewTextBoxColumn.Name = "seatNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Стан";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTickets);
            this.Controls.Add(this.buttonFindTickets);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.textBoxArtist);
            this.Name = "FormTickets";
            this.Text = "FormTickets";
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTicketsByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Button buttonFindTickets;
        private ConcertsData.DSConcerts dsConcerts;
        private ConcertsData.DSConcertsTableAdapters.TicketsByCategoryTableAdapter ticketsByCategoryTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceTicketsByCategory;
        private ConcertsDataSet concertsDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatLinenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}