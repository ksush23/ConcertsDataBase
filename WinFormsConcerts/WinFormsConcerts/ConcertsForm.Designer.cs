namespace WinFormsConcerts
{
    partial class ConcertsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.concertsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concertsDataSet = new WinFormsConcerts.ConcertsDataSet();
            this.artistsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.ArtistsTableAdapter();
            this.concertsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.ConcertsTableAdapter();
            this.ticketsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.TicketsTableAdapter();
            this.placesTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.PlacesTableAdapter();
            this.sectorsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.SectorsTableAdapter();
            this.seatsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.SeatsTableAdapter();
            this.tabPageSeats = new System.Windows.Forms.TabPage();
            this.tabPageSectors = new System.Windows.Forms.TabPage();
            this.tabPagePlaces = new System.Windows.Forms.TabPage();
            this.tabPageTickets = new System.Windows.Forms.TabPage();
            this.tabPageConcerts = new System.Windows.Forms.TabPage();
            this.tabPageArtists = new System.Windows.Forms.TabPage();
            this.saveAritistsButton = new System.Windows.Forms.Button();
            this.deleteArtistsButton = new System.Windows.Forms.Button();
            this.dataGridViewArtists = new System.Windows.Forms.DataGridView();
            this.tabControlConcerts = new System.Windows.Forms.TabControl();
            this.dataGridViewConcerts = new System.Windows.Forms.DataGridView();
            this.concertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concertTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketStateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPlaces = new System.Windows.Forms.DataGridView();
            this.dataGridViewSectors = new System.Windows.Forms.DataGridView();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSeats = new System.Windows.Forms.DataGridView();
            this.seatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatLinenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).BeginInit();
            this.tabPageSeats.SuspendLayout();
            this.tabPageSectors.SuspendLayout();
            this.tabPagePlaces.SuspendLayout();
            this.tabPageTickets.SuspendLayout();
            this.tabPageConcerts.SuspendLayout();
            this.tabPageArtists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).BeginInit();
            this.tabControlConcerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // concertsDataSetBindingSource
            // 
            this.concertsDataSetBindingSource.DataSource = this.concertsDataSet;
            this.concertsDataSetBindingSource.Position = 0;
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
            // concertsTableAdapter
            // 
            this.concertsTableAdapter.ClearBeforeFill = true;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // placesTableAdapter
            // 
            this.placesTableAdapter.ClearBeforeFill = true;
            // 
            // sectorsTableAdapter
            // 
            this.sectorsTableAdapter.ClearBeforeFill = true;
            // 
            // seatsTableAdapter
            // 
            this.seatsTableAdapter.ClearBeforeFill = true;
            // 
            // tabPageSeats
            // 
            this.tabPageSeats.Controls.Add(this.dataGridViewSeats);
            this.tabPageSeats.Location = new System.Drawing.Point(4, 25);
            this.tabPageSeats.Name = "tabPageSeats";
            this.tabPageSeats.Size = new System.Drawing.Size(784, 448);
            this.tabPageSeats.TabIndex = 5;
            this.tabPageSeats.Text = "Місця";
            this.tabPageSeats.UseVisualStyleBackColor = true;
            // 
            // tabPageSectors
            // 
            this.tabPageSectors.Controls.Add(this.dataGridViewSectors);
            this.tabPageSectors.Location = new System.Drawing.Point(4, 25);
            this.tabPageSectors.Name = "tabPageSectors";
            this.tabPageSectors.Size = new System.Drawing.Size(784, 448);
            this.tabPageSectors.TabIndex = 4;
            this.tabPageSectors.Text = "Сектори";
            this.tabPageSectors.UseVisualStyleBackColor = true;
            // 
            // tabPagePlaces
            // 
            this.tabPagePlaces.Controls.Add(this.dataGridViewPlaces);
            this.tabPagePlaces.Location = new System.Drawing.Point(4, 25);
            this.tabPagePlaces.Name = "tabPagePlaces";
            this.tabPagePlaces.Size = new System.Drawing.Size(784, 448);
            this.tabPagePlaces.TabIndex = 3;
            this.tabPagePlaces.Text = "Місця проведення";
            this.tabPagePlaces.UseVisualStyleBackColor = true;
            // 
            // tabPageTickets
            // 
            this.tabPageTickets.Controls.Add(this.dataGridViewTickets);
            this.tabPageTickets.Location = new System.Drawing.Point(4, 25);
            this.tabPageTickets.Name = "tabPageTickets";
            this.tabPageTickets.Size = new System.Drawing.Size(784, 414);
            this.tabPageTickets.TabIndex = 2;
            this.tabPageTickets.Text = "Білети";
            this.tabPageTickets.UseVisualStyleBackColor = true;
            // 
            // tabPageConcerts
            // 
            this.tabPageConcerts.Controls.Add(this.dataGridViewConcerts);
            this.tabPageConcerts.Location = new System.Drawing.Point(4, 25);
            this.tabPageConcerts.Name = "tabPageConcerts";
            this.tabPageConcerts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConcerts.Size = new System.Drawing.Size(784, 448);
            this.tabPageConcerts.TabIndex = 1;
            this.tabPageConcerts.Text = "Концерти";
            this.tabPageConcerts.UseVisualStyleBackColor = true;
            // 
            // tabPageArtists
            // 
            this.tabPageArtists.Controls.Add(this.dataGridViewArtists);
            this.tabPageArtists.Controls.Add(this.deleteArtistsButton);
            this.tabPageArtists.Controls.Add(this.saveAritistsButton);
            this.tabPageArtists.Location = new System.Drawing.Point(4, 25);
            this.tabPageArtists.Name = "tabPageArtists";
            this.tabPageArtists.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArtists.Size = new System.Drawing.Size(784, 448);
            this.tabPageArtists.TabIndex = 0;
            this.tabPageArtists.Text = "Виконавці";
            this.tabPageArtists.UseVisualStyleBackColor = true;
            this.tabPageArtists.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // saveAritistsButton
            // 
            this.saveAritistsButton.Location = new System.Drawing.Point(17, 3);
            this.saveAritistsButton.Name = "saveAritistsButton";
            this.saveAritistsButton.Size = new System.Drawing.Size(96, 37);
            this.saveAritistsButton.TabIndex = 1;
            this.saveAritistsButton.Text = "Зберегти";
            this.saveAritistsButton.UseVisualStyleBackColor = true;
            this.saveAritistsButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteArtistsButton
            // 
            this.deleteArtistsButton.Location = new System.Drawing.Point(132, 6);
            this.deleteArtistsButton.Name = "deleteArtistsButton";
            this.deleteArtistsButton.Size = new System.Drawing.Size(92, 33);
            this.deleteArtistsButton.TabIndex = 2;
            this.deleteArtistsButton.Text = "Видалити";
            this.deleteArtistsButton.UseVisualStyleBackColor = true;
            this.deleteArtistsButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridViewArtists
            // 
            this.dataGridViewArtists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtists.Location = new System.Drawing.Point(6, 46);
            this.dataGridViewArtists.Name = "dataGridViewArtists";
            this.dataGridViewArtists.RowTemplate.Height = 24;
            this.dataGridViewArtists.Size = new System.Drawing.Size(772, 402);
            this.dataGridViewArtists.TabIndex = 4;
            this.dataGridViewArtists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabControlConcerts
            // 
            this.tabControlConcerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlConcerts.Controls.Add(this.tabPageArtists);
            this.tabControlConcerts.Controls.Add(this.tabPageConcerts);
            this.tabControlConcerts.Controls.Add(this.tabPageTickets);
            this.tabControlConcerts.Controls.Add(this.tabPagePlaces);
            this.tabControlConcerts.Controls.Add(this.tabPageSectors);
            this.tabControlConcerts.Controls.Add(this.tabPageSeats);
            this.tabControlConcerts.Location = new System.Drawing.Point(12, 12);
            this.tabControlConcerts.Name = "tabControlConcerts";
            this.tabControlConcerts.SelectedIndex = 0;
            this.tabControlConcerts.Size = new System.Drawing.Size(792, 477);
            this.tabControlConcerts.TabIndex = 0;
            // 
            // dataGridViewConcerts
            // 
            this.dataGridViewConcerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConcerts.AutoGenerateColumns = false;
            this.dataGridViewConcerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConcerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.concertTimeDateDataGridViewTextBoxColumn});
            this.dataGridViewConcerts.DataSource = this.concertsBindingSource;
            this.dataGridViewConcerts.Location = new System.Drawing.Point(0, 7);
            this.dataGridViewConcerts.Name = "dataGridViewConcerts";
            this.dataGridViewConcerts.RowTemplate.Height = 24;
            this.dataGridViewConcerts.Size = new System.Drawing.Size(784, 438);
            this.dataGridViewConcerts.TabIndex = 0;
            // 
            // concertsBindingSource
            // 
            this.concertsBindingSource.DataMember = "Concerts";
            this.concertsBindingSource.DataSource = this.concertsDataSet;
            // 
            // concertTimeDateDataGridViewTextBoxColumn
            // 
            this.concertTimeDateDataGridViewTextBoxColumn.DataPropertyName = "Concert_TimeDate";
            this.concertTimeDateDataGridViewTextBoxColumn.HeaderText = "Дата і час";
            this.concertTimeDateDataGridViewTextBoxColumn.Name = "concertTimeDateDataGridViewTextBoxColumn";
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTickets.AutoGenerateColumns = false;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketStateIDDataGridViewTextBoxColumn,
            this.ticketPriceDataGridViewTextBoxColumn});
            this.dataGridViewTickets.DataSource = this.ticketsBindingSource;
            this.dataGridViewTickets.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(777, 387);
            this.dataGridViewTickets.TabIndex = 0;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.concertsDataSet;
            // 
            // ticketStateIDDataGridViewTextBoxColumn
            // 
            this.ticketStateIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_State_ID";
            this.ticketStateIDDataGridViewTextBoxColumn.HeaderText = "Стан квитка";
            this.ticketStateIDDataGridViewTextBoxColumn.Name = "ticketStateIDDataGridViewTextBoxColumn";
            // 
            // ticketPriceDataGridViewTextBoxColumn
            // 
            this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Price";
            this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataMember = "Places";
            this.placesBindingSource.DataSource = this.concertsDataSet;
            // 
            // placeAddressDataGridViewTextBoxColumn
            // 
            this.placeAddressDataGridViewTextBoxColumn.DataPropertyName = "Place_Address";
            this.placeAddressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.placeAddressDataGridViewTextBoxColumn.Name = "placeAddressDataGridViewTextBoxColumn";
            // 
            // placeNameDataGridViewTextBoxColumn
            // 
            this.placeNameDataGridViewTextBoxColumn.DataPropertyName = "Place_Name";
            this.placeNameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.placeNameDataGridViewTextBoxColumn.Name = "placeNameDataGridViewTextBoxColumn";
            // 
            // dataGridViewPlaces
            // 
            this.dataGridViewPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlaces.AutoGenerateColumns = false;
            this.dataGridViewPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeNameDataGridViewTextBoxColumn,
            this.placeAddressDataGridViewTextBoxColumn});
            this.dataGridViewPlaces.DataSource = this.placesBindingSource;
            this.dataGridViewPlaces.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewPlaces.Name = "dataGridViewPlaces";
            this.dataGridViewPlaces.RowTemplate.Height = 24;
            this.dataGridViewPlaces.Size = new System.Drawing.Size(768, 431);
            this.dataGridViewPlaces.TabIndex = 0;
            // 
            // dataGridViewSectors
            // 
            this.dataGridViewSectors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSectors.AutoGenerateColumns = false;
            this.dataGridViewSectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectorNameDataGridViewTextBoxColumn});
            this.dataGridViewSectors.DataSource = this.sectorsBindingSource;
            this.dataGridViewSectors.Location = new System.Drawing.Point(4, 49);
            this.dataGridViewSectors.Name = "dataGridViewSectors";
            this.dataGridViewSectors.RowTemplate.Height = 24;
            this.dataGridViewSectors.Size = new System.Drawing.Size(768, 386);
            this.dataGridViewSectors.TabIndex = 0;
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataMember = "Sectors";
            this.sectorsBindingSource.DataSource = this.concertsDataSet;
            // 
            // sectorNameDataGridViewTextBoxColumn
            // 
            this.sectorNameDataGridViewTextBoxColumn.DataPropertyName = "Sector_Name";
            this.sectorNameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.sectorNameDataGridViewTextBoxColumn.Name = "sectorNameDataGridViewTextBoxColumn";
            // 
            // dataGridViewSeats
            // 
            this.dataGridViewSeats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSeats.AutoGenerateColumns = false;
            this.dataGridViewSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seatLinenumberDataGridViewTextBoxColumn,
            this.seatNumberDataGridViewTextBoxColumn});
            this.dataGridViewSeats.DataSource = this.seatsBindingSource;
            this.dataGridViewSeats.Location = new System.Drawing.Point(3, 29);
            this.dataGridViewSeats.Name = "dataGridViewSeats";
            this.dataGridViewSeats.RowTemplate.Height = 24;
            this.dataGridViewSeats.Size = new System.Drawing.Size(769, 406);
            this.dataGridViewSeats.TabIndex = 0;
            // 
            // seatsBindingSource
            // 
            this.seatsBindingSource.DataMember = "Seats";
            this.seatsBindingSource.DataSource = this.concertsDataSet;
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
            // ConcertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.tabControlConcerts);
            this.Name = "ConcertsForm";
            this.Text = "Концерти";
            this.Load += new System.EventHandler(this.ConcertsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).EndInit();
            this.tabPageSeats.ResumeLayout(false);
            this.tabPageSectors.ResumeLayout(false);
            this.tabPagePlaces.ResumeLayout(false);
            this.tabPageTickets.ResumeLayout(false);
            this.tabPageConcerts.ResumeLayout(false);
            this.tabPageArtists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).EndInit();
            this.tabControlConcerts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource concertsDataSetBindingSource;
        private ConcertsDataSet concertsDataSet;
        private ConcertsDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private ConcertsDataSetTableAdapters.ConcertsTableAdapter concertsTableAdapter;
        private ConcertsDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private ConcertsDataSetTableAdapters.PlacesTableAdapter placesTableAdapter;
        private ConcertsDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
        private ConcertsDataSetTableAdapters.SeatsTableAdapter seatsTableAdapter;
        private System.Windows.Forms.TabPage tabPageSeats;
        private System.Windows.Forms.TabPage tabPageSectors;
        private System.Windows.Forms.TabPage tabPagePlaces;
        private System.Windows.Forms.BindingSource placesBindingSource;
        private System.Windows.Forms.TabPage tabPageTickets;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketStateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private System.Windows.Forms.TabPage tabPageConcerts;
        private System.Windows.Forms.DataGridView dataGridViewConcerts;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertTimeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource concertsBindingSource;
        private System.Windows.Forms.TabPage tabPageArtists;
        private System.Windows.Forms.DataGridView dataGridViewArtists;
        private System.Windows.Forms.Button deleteArtistsButton;
        private System.Windows.Forms.Button saveAritistsButton;
        private System.Windows.Forms.TabControl tabControlConcerts;
        private System.Windows.Forms.DataGridView dataGridViewSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatLinenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource seatsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSectors;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeAddressDataGridViewTextBoxColumn;
    }
}

