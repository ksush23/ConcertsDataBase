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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.textBoxPriceTo = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.dsConcerts = new ConcertsData.DSConcerts();
            this.ticketsByCategoryTableAdapter = new ConcertsData.DSConcertsTableAdapters.TicketsByCategoryTableAdapter();
            this.bindingSourceTicketsByCategory = new System.Windows.Forms.BindingSource(this.components);
            this.concertsDataSet = new WinFormsConcerts.ConcertsDataSet();
            this.dataGridViewTicketsByCategory = new System.Windows.Forms.DataGridView();
            this.Ticket_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket_State_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket_Seat_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket_Concert_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearchTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTicketsByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketsByCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виконавець";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цінова категорія";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Від";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "До";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Місце проведення";
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(282, 31);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(100, 22);
            this.textBoxArtist.TabIndex = 5;
            // 
            // textBoxPriceFrom
            // 
            this.textBoxPriceFrom.Location = new System.Drawing.Point(282, 64);
            this.textBoxPriceFrom.Name = "textBoxPriceFrom";
            this.textBoxPriceFrom.Size = new System.Drawing.Size(100, 22);
            this.textBoxPriceFrom.TabIndex = 6;
            // 
            // textBoxPriceTo
            // 
            this.textBoxPriceTo.Location = new System.Drawing.Point(282, 93);
            this.textBoxPriceTo.Name = "textBoxPriceTo";
            this.textBoxPriceTo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPriceTo.TabIndex = 7;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(282, 138);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlace.TabIndex = 8;
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
            // dataGridViewTicketsByCategory
            // 
            this.dataGridViewTicketsByCategory.AutoGenerateColumns = false;
            this.dataGridViewTicketsByCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicketsByCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket_ID,
            this.Ticket_State_ID,
            this.Ticket_Seat_ID,
            this.Ticket_Concert_ID,
            this.artistNameDataGridViewTextBoxColumn,
            this.artistGenreDataGridViewTextBoxColumn,
            this.placeNameDataGridViewTextBoxColumn,
            this.ticketPriceDataGridViewTextBoxColumn});
            this.dataGridViewTicketsByCategory.DataSource = this.bindingSourceTicketsByCategory;
            this.dataGridViewTicketsByCategory.Location = new System.Drawing.Point(25, 180);
            this.dataGridViewTicketsByCategory.Name = "dataGridViewTicketsByCategory";
            this.dataGridViewTicketsByCategory.RowTemplate.Height = 24;
            this.dataGridViewTicketsByCategory.Size = new System.Drawing.Size(711, 276);
            this.dataGridViewTicketsByCategory.TabIndex = 9;
            this.dataGridViewTicketsByCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ticket_ID
            // 
            this.Ticket_ID.DataPropertyName = "Ticket_ID";
            this.Ticket_ID.HeaderText = "Ticket_ID";
            this.Ticket_ID.Name = "Ticket_ID";
            this.Ticket_ID.ReadOnly = true;
            this.Ticket_ID.Visible = false;
            // 
            // Ticket_State_ID
            // 
            this.Ticket_State_ID.DataPropertyName = "Ticket_State_ID";
            this.Ticket_State_ID.HeaderText = "Ticket_State_ID";
            this.Ticket_State_ID.Name = "Ticket_State_ID";
            this.Ticket_State_ID.ReadOnly = true;
            this.Ticket_State_ID.Visible = false;
            // 
            // Ticket_Seat_ID
            // 
            this.Ticket_Seat_ID.DataPropertyName = "Ticket_Seat_ID";
            this.Ticket_Seat_ID.HeaderText = "Ticket_Seat_ID";
            this.Ticket_Seat_ID.Name = "Ticket_Seat_ID";
            this.Ticket_Seat_ID.ReadOnly = true;
            this.Ticket_Seat_ID.Visible = false;
            // 
            // Ticket_Concert_ID
            // 
            this.Ticket_Concert_ID.DataPropertyName = "Ticket_Concert_ID";
            this.Ticket_Concert_ID.HeaderText = "Ticket_Concert_ID";
            this.Ticket_Concert_ID.Name = "Ticket_Concert_ID";
            this.Ticket_Concert_ID.ReadOnly = true;
            this.Ticket_Concert_ID.Visible = false;
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
            // placeNameDataGridViewTextBoxColumn
            // 
            this.placeNameDataGridViewTextBoxColumn.DataPropertyName = "Place_Name";
            this.placeNameDataGridViewTextBoxColumn.HeaderText = "Місце проведення";
            this.placeNameDataGridViewTextBoxColumn.Name = "placeNameDataGridViewTextBoxColumn";
            this.placeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketPriceDataGridViewTextBoxColumn
            // 
            this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Price";
            this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
            this.ticketPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonSearchTicket
            // 
            this.buttonSearchTicket.Location = new System.Drawing.Point(498, 64);
            this.buttonSearchTicket.Name = "buttonSearchTicket";
            this.buttonSearchTicket.Size = new System.Drawing.Size(166, 58);
            this.buttonSearchTicket.TabIndex = 10;
            this.buttonSearchTicket.Text = "Пошук";
            this.buttonSearchTicket.UseVisualStyleBackColor = true;
            this.buttonSearchTicket.Click += new System.EventHandler(this.buttonSearchTicket_Click);
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 468);
            this.Controls.Add(this.buttonSearchTicket);
            this.Controls.Add(this.dataGridViewTicketsByCategory);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.textBoxPriceTo);
            this.Controls.Add(this.textBoxPriceFrom);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTickets";
            this.Text = "FormTickets";
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTicketsByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketsByCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.TextBox textBoxPriceFrom;
        private System.Windows.Forms.TextBox textBoxPriceTo;
        private System.Windows.Forms.TextBox textBoxPlace;
        private ConcertsData.DSConcerts dsConcerts;
        private ConcertsData.DSConcertsTableAdapters.TicketsByCategoryTableAdapter ticketsByCategoryTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceTicketsByCategory;
        private ConcertsDataSet concertsDataSet;
        private System.Windows.Forms.DataGridView dataGridViewTicketsByCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_State_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_Seat_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_Concert_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSearchTicket;
    }
}