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
            this.dataGridViewArtist = new System.Windows.Forms.DataGridView();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveConcertsButton = new System.Windows.Forms.Button();
            this.deleteConcertsButton = new System.Windows.Forms.Button();
            this.saveTicketsButton = new System.Windows.Forms.Button();
            this.deleteTicketsButton = new System.Windows.Forms.Button();
            this.savePlacesButton = new System.Windows.Forms.Button();
            this.deletePlacesButton = new System.Windows.Forms.Button();
            this.saveSectorsButton = new System.Windows.Forms.Button();
            this.deleteSectorsButton = new System.Windows.Forms.Button();
            this.saveSeatsButton = new System.Windows.Forms.Button();
            this.deleteSeatsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).BeginInit();
            this.tabPageSeats.SuspendLayout();
            this.tabPageSectors.SuspendLayout();
            this.tabPagePlaces.SuspendLayout();
            this.tabPageTickets.SuspendLayout();
            this.tabPageConcerts.SuspendLayout();
            this.tabPageArtists.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
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
            this.tabPageSeats.Controls.Add(this.deleteSeatsButton);
            this.tabPageSeats.Controls.Add(this.saveSeatsButton);
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
            this.tabPageSectors.Controls.Add(this.deleteSectorsButton);
            this.tabPageSectors.Controls.Add(this.saveSectorsButton);
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
            this.tabPagePlaces.Controls.Add(this.deletePlacesButton);
            this.tabPagePlaces.Controls.Add(this.savePlacesButton);
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
            this.tabPageTickets.Controls.Add(this.deleteTicketsButton);
            this.tabPageTickets.Controls.Add(this.saveTicketsButton);
            this.tabPageTickets.Controls.Add(this.dataGridViewTickets);
            this.tabPageTickets.Location = new System.Drawing.Point(4, 25);
            this.tabPageTickets.Name = "tabPageTickets";
            this.tabPageTickets.Size = new System.Drawing.Size(784, 448);
            this.tabPageTickets.TabIndex = 2;
            this.tabPageTickets.Text = "Білети";
            this.tabPageTickets.UseVisualStyleBackColor = true;
            // 
            // tabPageConcerts
            // 
            this.tabPageConcerts.Controls.Add(this.deleteConcertsButton);
            this.tabPageConcerts.Controls.Add(this.saveConcertsButton);
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
            this.tabPageArtists.Controls.Add(this.dataGridViewArtist);
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
            this.dataGridViewConcerts.Location = new System.Drawing.Point(3, 48);
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
            this.dataGridViewTickets.Location = new System.Drawing.Point(0, 46);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(777, 378);
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
            this.dataGridViewPlaces.Location = new System.Drawing.Point(4, 48);
            this.dataGridViewPlaces.Name = "dataGridViewPlaces";
            this.dataGridViewPlaces.RowTemplate.Height = 24;
            this.dataGridViewPlaces.Size = new System.Drawing.Size(768, 387);
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
            this.dataGridViewSeats.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewSeats.Name = "dataGridViewSeats";
            this.dataGridViewSeats.RowTemplate.Height = 24;
            this.dataGridViewSeats.Size = new System.Drawing.Size(769, 393);
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
            // dataGridViewArtist
            // 
            this.dataGridViewArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArtist.AutoGenerateColumns = false;
            this.dataGridViewArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistNameDataGridViewTextBoxColumn,
            this.artistGenreDataGridViewTextBoxColumn});
            this.dataGridViewArtist.DataSource = this.artistsBindingSource;
            this.dataGridViewArtist.Location = new System.Drawing.Point(4, 47);
            this.dataGridViewArtist.Name = "dataGridViewArtist";
            this.dataGridViewArtist.RowTemplate.Height = 24;
            this.dataGridViewArtist.Size = new System.Drawing.Size(768, 388);
            this.dataGridViewArtist.TabIndex = 3;
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "Artists";
            this.artistsBindingSource.DataSource = this.concertsDataSet;
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
            // saveConcertsButton
            // 
            this.saveConcertsButton.Location = new System.Drawing.Point(15, 6);
            this.saveConcertsButton.Name = "saveConcertsButton";
            this.saveConcertsButton.Size = new System.Drawing.Size(97, 36);
            this.saveConcertsButton.TabIndex = 1;
            this.saveConcertsButton.Text = "Зберегти";
            this.saveConcertsButton.UseVisualStyleBackColor = true;
            this.saveConcertsButton.Click += new System.EventHandler(this.saveConcertsButton_Click);
            // 
            // deleteConcertsButton
            // 
            this.deleteConcertsButton.Location = new System.Drawing.Point(130, 7);
            this.deleteConcertsButton.Name = "deleteConcertsButton";
            this.deleteConcertsButton.Size = new System.Drawing.Size(94, 35);
            this.deleteConcertsButton.TabIndex = 2;
            this.deleteConcertsButton.Text = "Видалити";
            this.deleteConcertsButton.UseVisualStyleBackColor = true;
            this.deleteConcertsButton.Click += new System.EventHandler(this.deleteConcertsButton_Click);
            // 
            // saveTicketsButton
            // 
            this.saveTicketsButton.Location = new System.Drawing.Point(20, 3);
            this.saveTicketsButton.Name = "saveTicketsButton";
            this.saveTicketsButton.Size = new System.Drawing.Size(86, 37);
            this.saveTicketsButton.TabIndex = 1;
            this.saveTicketsButton.Text = "Зберегти";
            this.saveTicketsButton.UseVisualStyleBackColor = true;
            this.saveTicketsButton.Click += new System.EventHandler(this.saveTicketsButton_Click);
            // 
            // deleteTicketsButton
            // 
            this.deleteTicketsButton.Location = new System.Drawing.Point(124, 3);
            this.deleteTicketsButton.Name = "deleteTicketsButton";
            this.deleteTicketsButton.Size = new System.Drawing.Size(89, 36);
            this.deleteTicketsButton.TabIndex = 2;
            this.deleteTicketsButton.Text = "Видалити";
            this.deleteTicketsButton.UseVisualStyleBackColor = true;
            this.deleteTicketsButton.Click += new System.EventHandler(this.deleteTicketsButton_Click);
            // 
            // savePlacesButton
            // 
            this.savePlacesButton.Location = new System.Drawing.Point(19, 3);
            this.savePlacesButton.Name = "savePlacesButton";
            this.savePlacesButton.Size = new System.Drawing.Size(101, 39);
            this.savePlacesButton.TabIndex = 1;
            this.savePlacesButton.Text = "Зберегти";
            this.savePlacesButton.UseVisualStyleBackColor = true;
            this.savePlacesButton.Click += new System.EventHandler(this.savePlacesButton_Click);
            // 
            // deletePlacesButton
            // 
            this.deletePlacesButton.Location = new System.Drawing.Point(137, 3);
            this.deletePlacesButton.Name = "deletePlacesButton";
            this.deletePlacesButton.Size = new System.Drawing.Size(96, 38);
            this.deletePlacesButton.TabIndex = 2;
            this.deletePlacesButton.Text = "Видалити";
            this.deletePlacesButton.UseVisualStyleBackColor = true;
            this.deletePlacesButton.Click += new System.EventHandler(this.deletePlacesButton_Click);
            // 
            // saveSectorsButton
            // 
            this.saveSectorsButton.Location = new System.Drawing.Point(20, 13);
            this.saveSectorsButton.Name = "saveSectorsButton";
            this.saveSectorsButton.Size = new System.Drawing.Size(86, 30);
            this.saveSectorsButton.TabIndex = 1;
            this.saveSectorsButton.Text = "Зберегти";
            this.saveSectorsButton.UseVisualStyleBackColor = true;
            this.saveSectorsButton.Click += new System.EventHandler(this.saveSectorsButton_Click);
            // 
            // deleteSectorsButton
            // 
            this.deleteSectorsButton.Location = new System.Drawing.Point(129, 13);
            this.deleteSectorsButton.Name = "deleteSectorsButton";
            this.deleteSectorsButton.Size = new System.Drawing.Size(85, 30);
            this.deleteSectorsButton.TabIndex = 2;
            this.deleteSectorsButton.Text = "Видалити";
            this.deleteSectorsButton.UseVisualStyleBackColor = true;
            this.deleteSectorsButton.Click += new System.EventHandler(this.deleteSectorsButton_Click);
            // 
            // saveSeatsButton
            // 
            this.saveSeatsButton.Location = new System.Drawing.Point(24, 3);
            this.saveSeatsButton.Name = "saveSeatsButton";
            this.saveSeatsButton.Size = new System.Drawing.Size(84, 33);
            this.saveSeatsButton.TabIndex = 1;
            this.saveSeatsButton.Text = "Зберегти";
            this.saveSeatsButton.UseVisualStyleBackColor = true;
            this.saveSeatsButton.Click += new System.EventHandler(this.saveSeatsButton_Click);
            // 
            // deleteSeatsButton
            // 
            this.deleteSeatsButton.Location = new System.Drawing.Point(124, 3);
            this.deleteSeatsButton.Name = "deleteSeatsButton";
            this.deleteSeatsButton.Size = new System.Drawing.Size(94, 32);
            this.deleteSeatsButton.TabIndex = 2;
            this.deleteSeatsButton.Text = "Видалити";
            this.deleteSeatsButton.UseVisualStyleBackColor = true;
            this.deleteSeatsButton.Click += new System.EventHandler(this.deleteSeatsButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private System.Windows.Forms.Button saveConcertsButton;
        private System.Windows.Forms.Button deleteConcertsButton;
        private System.Windows.Forms.Button deleteTicketsButton;
        private System.Windows.Forms.Button saveTicketsButton;
        private System.Windows.Forms.Button savePlacesButton;
        private System.Windows.Forms.Button deletePlacesButton;
        private System.Windows.Forms.Button deleteSectorsButton;
        private System.Windows.Forms.Button saveSectorsButton;
        private System.Windows.Forms.Button deleteSeatsButton;
        private System.Windows.Forms.Button saveSeatsButton;
    }
}

