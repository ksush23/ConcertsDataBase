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
            this.tabControlConcerts = new System.Windows.Forms.TabControl();
            this.tabPageArtists = new System.Windows.Forms.TabPage();
            this.tabPageConcerts = new System.Windows.Forms.TabPage();
            this.tabPageTickets = new System.Windows.Forms.TabPage();
            this.tabPagePlaces = new System.Windows.Forms.TabPage();
            this.tabPageSectors = new System.Windows.Forms.TabPage();
            this.tabPageSeats = new System.Windows.Forms.TabPage();
            this.dataGridViewArtists = new System.Windows.Forms.DataGridView();
            this.concertsDataSet = new WinFormsConcerts.ConcertsDataSet();
            this.concertsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.ArtistsTableAdapter();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewConcerts = new System.Windows.Forms.DataGridView();
            this.concertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concertsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.ConcertsTableAdapter();
            this.concertTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_Place_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.TicketsTableAdapter();
            this.ticketStateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketConcertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketSeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPlaces = new System.Windows.Forms.DataGridView();
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placesTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.PlacesTableAdapter();
            this.placeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSectors = new System.Windows.Forms.DataGridView();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectorsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.SectorsTableAdapter();
            this.sectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorPlaceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSeats = new System.Windows.Forms.DataGridView();
            this.seatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatsTableAdapter = new WinFormsConcerts.ConcertsDataSetTableAdapters.SeatsTableAdapter();
            this.seatLinenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatSectorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlConcerts.SuspendLayout();
            this.tabPageArtists.SuspendLayout();
            this.tabPageConcerts.SuspendLayout();
            this.tabPageTickets.SuspendLayout();
            this.tabPagePlaces.SuspendLayout();
            this.tabPageSectors.SuspendLayout();
            this.tabPageSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tabControlConcerts.Size = new System.Drawing.Size(792, 443);
            this.tabControlConcerts.TabIndex = 0;
            // 
            // tabPageArtists
            // 
            this.tabPageArtists.Controls.Add(this.dataGridViewArtists);
            this.tabPageArtists.Location = new System.Drawing.Point(4, 25);
            this.tabPageArtists.Name = "tabPageArtists";
            this.tabPageArtists.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArtists.Size = new System.Drawing.Size(784, 414);
            this.tabPageArtists.TabIndex = 0;
            this.tabPageArtists.Text = "Виконавці";
            this.tabPageArtists.UseVisualStyleBackColor = true;
            this.tabPageArtists.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPageConcerts
            // 
            this.tabPageConcerts.Controls.Add(this.dataGridViewConcerts);
            this.tabPageConcerts.Location = new System.Drawing.Point(4, 25);
            this.tabPageConcerts.Name = "tabPageConcerts";
            this.tabPageConcerts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConcerts.Size = new System.Drawing.Size(784, 414);
            this.tabPageConcerts.TabIndex = 1;
            this.tabPageConcerts.Text = "Концерти";
            this.tabPageConcerts.UseVisualStyleBackColor = true;
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
            // tabPagePlaces
            // 
            this.tabPagePlaces.Controls.Add(this.dataGridViewPlaces);
            this.tabPagePlaces.Location = new System.Drawing.Point(4, 25);
            this.tabPagePlaces.Name = "tabPagePlaces";
            this.tabPagePlaces.Size = new System.Drawing.Size(784, 414);
            this.tabPagePlaces.TabIndex = 3;
            this.tabPagePlaces.Text = "Місця проведення";
            this.tabPagePlaces.UseVisualStyleBackColor = true;
            // 
            // tabPageSectors
            // 
            this.tabPageSectors.Controls.Add(this.dataGridViewSectors);
            this.tabPageSectors.Location = new System.Drawing.Point(4, 25);
            this.tabPageSectors.Name = "tabPageSectors";
            this.tabPageSectors.Size = new System.Drawing.Size(784, 414);
            this.tabPageSectors.TabIndex = 4;
            this.tabPageSectors.Text = "Сектори";
            this.tabPageSectors.UseVisualStyleBackColor = true;
            // 
            // tabPageSeats
            // 
            this.tabPageSeats.Controls.Add(this.dataGridViewSeats);
            this.tabPageSeats.Location = new System.Drawing.Point(4, 25);
            this.tabPageSeats.Name = "tabPageSeats";
            this.tabPageSeats.Size = new System.Drawing.Size(784, 414);
            this.tabPageSeats.TabIndex = 5;
            this.tabPageSeats.Text = "Місця";
            this.tabPageSeats.UseVisualStyleBackColor = true;
            // 
            // dataGridViewArtists
            // 
            this.dataGridViewArtists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArtists.AutoGenerateColumns = false;
            this.dataGridViewArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistNameDataGridViewTextBoxColumn,
            this.artistGenreDataGridViewTextBoxColumn});
            this.dataGridViewArtists.DataSource = this.artistsBindingSource;
            this.dataGridViewArtists.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewArtists.Name = "dataGridViewArtists";
            this.dataGridViewArtists.RowTemplate.Height = 24;
            this.dataGridViewArtists.Size = new System.Drawing.Size(769, 398);
            this.dataGridViewArtists.TabIndex = 0;
            // 
            // concertsDataSet
            // 
            this.concertsDataSet.DataSetName = "ConcertsDataSet";
            this.concertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // concertsDataSetBindingSource
            // 
            this.concertsDataSetBindingSource.DataSource = this.concertsDataSet;
            this.concertsDataSetBindingSource.Position = 0;
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "Artists";
            this.artistsBindingSource.DataSource = this.concertsDataSetBindingSource;
            // 
            // artistsTableAdapter
            // 
            this.artistsTableAdapter.ClearBeforeFill = true;
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "Artist_Name";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            // 
            // artistGenreDataGridViewTextBoxColumn
            // 
            this.artistGenreDataGridViewTextBoxColumn.DataPropertyName = "Artist_Genre";
            this.artistGenreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.artistGenreDataGridViewTextBoxColumn.Name = "artistGenreDataGridViewTextBoxColumn";
            // 
            // dataGridViewConcerts
            // 
            this.dataGridViewConcerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConcerts.AutoGenerateColumns = false;
            this.dataGridViewConcerts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewConcerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConcerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.concertTimeDateDataGridViewTextBoxColumn,
            this.Concert_Artist_ID,
            this.Concert_Place_ID});
            this.dataGridViewConcerts.DataSource = this.concertsBindingSource;
            this.dataGridViewConcerts.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewConcerts.Name = "dataGridViewConcerts";
            this.dataGridViewConcerts.RowTemplate.Height = 24;
            this.dataGridViewConcerts.Size = new System.Drawing.Size(775, 408);
            this.dataGridViewConcerts.TabIndex = 0;
            // 
            // concertsBindingSource
            // 
            this.concertsBindingSource.DataMember = "Concerts";
            this.concertsBindingSource.DataSource = this.concertsDataSet;
            // 
            // concertsTableAdapter
            // 
            this.concertsTableAdapter.ClearBeforeFill = true;
            // 
            // concertTimeDateDataGridViewTextBoxColumn
            // 
            this.concertTimeDateDataGridViewTextBoxColumn.DataPropertyName = "Concert_TimeDate";
            this.concertTimeDateDataGridViewTextBoxColumn.HeaderText = "Дата і час";
            this.concertTimeDateDataGridViewTextBoxColumn.Name = "concertTimeDateDataGridViewTextBoxColumn";
            // 
            // Concert_Artist_ID
            // 
            this.Concert_Artist_ID.DataPropertyName = "Concert_Artist_ID";
            this.Concert_Artist_ID.HeaderText = "Виконавець";
            this.Concert_Artist_ID.Name = "Concert_Artist_ID";
            // 
            // Concert_Place_ID
            // 
            this.Concert_Place_ID.DataPropertyName = "Concert_Place_ID";
            this.Concert_Place_ID.HeaderText = "Місце проведення";
            this.Concert_Place_ID.Name = "Concert_Place_ID";
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
            this.ticketConcertIDDataGridViewTextBoxColumn,
            this.ticketSeatIDDataGridViewTextBoxColumn,
            this.ticketPriceDataGridViewTextBoxColumn});
            this.dataGridViewTickets.DataSource = this.ticketsBindingSource;
            this.dataGridViewTickets.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(756, 382);
            this.dataGridViewTickets.TabIndex = 0;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.concertsDataSetBindingSource;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // ticketStateIDDataGridViewTextBoxColumn
            // 
            this.ticketStateIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_State_ID";
            this.ticketStateIDDataGridViewTextBoxColumn.HeaderText = "Стан";
            this.ticketStateIDDataGridViewTextBoxColumn.Name = "ticketStateIDDataGridViewTextBoxColumn";
            // 
            // ticketConcertIDDataGridViewTextBoxColumn
            // 
            this.ticketConcertIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Concert_ID";
            this.ticketConcertIDDataGridViewTextBoxColumn.HeaderText = "Концерт";
            this.ticketConcertIDDataGridViewTextBoxColumn.Name = "ticketConcertIDDataGridViewTextBoxColumn";
            // 
            // ticketSeatIDDataGridViewTextBoxColumn
            // 
            this.ticketSeatIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Seat_ID";
            this.ticketSeatIDDataGridViewTextBoxColumn.HeaderText = "Місце";
            this.ticketSeatIDDataGridViewTextBoxColumn.Name = "ticketSeatIDDataGridViewTextBoxColumn";
            // 
            // ticketPriceDataGridViewTextBoxColumn
            // 
            this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Price";
            this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
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
            this.dataGridViewPlaces.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPlaces.Name = "dataGridViewPlaces";
            this.dataGridViewPlaces.RowTemplate.Height = 24;
            this.dataGridViewPlaces.Size = new System.Drawing.Size(769, 398);
            this.dataGridViewPlaces.TabIndex = 0;
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataMember = "Places";
            this.placesBindingSource.DataSource = this.concertsDataSetBindingSource;
            // 
            // placesTableAdapter
            // 
            this.placesTableAdapter.ClearBeforeFill = true;
            // 
            // placeNameDataGridViewTextBoxColumn
            // 
            this.placeNameDataGridViewTextBoxColumn.DataPropertyName = "Place_Name";
            this.placeNameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.placeNameDataGridViewTextBoxColumn.Name = "placeNameDataGridViewTextBoxColumn";
            // 
            // placeAddressDataGridViewTextBoxColumn
            // 
            this.placeAddressDataGridViewTextBoxColumn.DataPropertyName = "Place_Address";
            this.placeAddressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.placeAddressDataGridViewTextBoxColumn.Name = "placeAddressDataGridViewTextBoxColumn";
            // 
            // dataGridViewSectors
            // 
            this.dataGridViewSectors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSectors.AutoGenerateColumns = false;
            this.dataGridViewSectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectorNameDataGridViewTextBoxColumn,
            this.sectorPlaceIDDataGridViewTextBoxColumn});
            this.dataGridViewSectors.DataSource = this.sectorsBindingSource;
            this.dataGridViewSectors.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewSectors.Name = "dataGridViewSectors";
            this.dataGridViewSectors.RowTemplate.Height = 24;
            this.dataGridViewSectors.Size = new System.Drawing.Size(777, 397);
            this.dataGridViewSectors.TabIndex = 0;
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataMember = "Sectors";
            this.sectorsBindingSource.DataSource = this.concertsDataSetBindingSource;
            // 
            // sectorsTableAdapter
            // 
            this.sectorsTableAdapter.ClearBeforeFill = true;
            // 
            // sectorNameDataGridViewTextBoxColumn
            // 
            this.sectorNameDataGridViewTextBoxColumn.DataPropertyName = "Sector_Name";
            this.sectorNameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.sectorNameDataGridViewTextBoxColumn.Name = "sectorNameDataGridViewTextBoxColumn";
            // 
            // sectorPlaceIDDataGridViewTextBoxColumn
            // 
            this.sectorPlaceIDDataGridViewTextBoxColumn.DataPropertyName = "Sector_Place_ID";
            this.sectorPlaceIDDataGridViewTextBoxColumn.HeaderText = "Місце проведення";
            this.sectorPlaceIDDataGridViewTextBoxColumn.Name = "sectorPlaceIDDataGridViewTextBoxColumn";
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
            this.seatNumberDataGridViewTextBoxColumn,
            this.seatSectorIDDataGridViewTextBoxColumn});
            this.dataGridViewSeats.DataSource = this.seatsBindingSource;
            this.dataGridViewSeats.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewSeats.Name = "dataGridViewSeats";
            this.dataGridViewSeats.RowTemplate.Height = 24;
            this.dataGridViewSeats.Size = new System.Drawing.Size(768, 397);
            this.dataGridViewSeats.TabIndex = 0;
            // 
            // seatsBindingSource
            // 
            this.seatsBindingSource.DataMember = "Seats";
            this.seatsBindingSource.DataSource = this.concertsDataSetBindingSource;
            // 
            // seatsTableAdapter
            // 
            this.seatsTableAdapter.ClearBeforeFill = true;
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
            // seatSectorIDDataGridViewTextBoxColumn
            // 
            this.seatSectorIDDataGridViewTextBoxColumn.DataPropertyName = "Seat_Sector_ID";
            this.seatSectorIDDataGridViewTextBoxColumn.HeaderText = "Сектор";
            this.seatSectorIDDataGridViewTextBoxColumn.Name = "seatSectorIDDataGridViewTextBoxColumn";
            // 
            // ConcertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlConcerts);
            this.Name = "ConcertsForm";
            this.Text = "Концерти";
            this.Load += new System.EventHandler(this.ConcertsForm_Load);
            this.tabControlConcerts.ResumeLayout(false);
            this.tabPageArtists.ResumeLayout(false);
            this.tabPageConcerts.ResumeLayout(false);
            this.tabPageTickets.ResumeLayout(false);
            this.tabPagePlaces.ResumeLayout(false);
            this.tabPageSectors.ResumeLayout(false);
            this.tabPageSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConcerts;
        private System.Windows.Forms.TabPage tabPageArtists;
        private System.Windows.Forms.TabPage tabPageConcerts;
        private System.Windows.Forms.TabPage tabPageTickets;
        private System.Windows.Forms.TabPage tabPagePlaces;
        private System.Windows.Forms.TabPage tabPageSectors;
        private System.Windows.Forms.TabPage tabPageSeats;
        private System.Windows.Forms.DataGridView dataGridViewArtists;
        private System.Windows.Forms.BindingSource concertsDataSetBindingSource;
        private ConcertsDataSet concertsDataSet;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private ConcertsDataSetTableAdapters.ArtistsTableAdapter artistsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewConcerts;
        private System.Windows.Forms.BindingSource concertsBindingSource;
        private ConcertsDataSetTableAdapters.ConcertsTableAdapter concertsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertTimeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_Place_ID;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private ConcertsDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketStateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketConcertIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketSeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewPlaces;
        private System.Windows.Forms.BindingSource placesBindingSource;
        private ConcertsDataSetTableAdapters.PlacesTableAdapter placesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewSectors;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private ConcertsDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorPlaceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewSeats;
        private System.Windows.Forms.BindingSource seatsBindingSource;
        private ConcertsDataSetTableAdapters.SeatsTableAdapter seatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatLinenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatSectorIDDataGridViewTextBoxColumn;
    }
}

