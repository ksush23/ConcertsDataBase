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
            this.deleteSeatsButton = new System.Windows.Forms.Button();
            this.saveSeatsButton = new System.Windows.Forms.Button();
            this.dataGridViewSeats = new System.Windows.Forms.DataGridView();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageSectors = new System.Windows.Forms.TabPage();
            this.deleteSectorsButton = new System.Windows.Forms.Button();
            this.saveSectorsButton = new System.Windows.Forms.Button();
            this.dataGridViewSectors = new System.Windows.Forms.DataGridView();
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPagePlaces = new System.Windows.Forms.TabPage();
            this.deletePlacesButton = new System.Windows.Forms.Button();
            this.savePlacesButton = new System.Windows.Forms.Button();
            this.dataGridViewPlaces = new System.Windows.Forms.DataGridView();
            this.placeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageTickets = new System.Windows.Forms.TabPage();
            this.deleteTicketsButton = new System.Windows.Forms.Button();
            this.saveTicketsButton = new System.Windows.Forms.Button();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.bindingSourceTicketStates = new System.Windows.Forms.BindingSource(this.components);
            this.dsConcerts = new ConcertsData.DSConcerts();
            this.concertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageConcerts = new System.Windows.Forms.TabPage();
            this.deleteConcertsButton = new System.Windows.Forms.Button();
            this.saveConcertsButton = new System.Windows.Forms.Button();
            this.dataGridViewConcerts = new System.Windows.Forms.DataGridView();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageArtists = new System.Windows.Forms.TabPage();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewArtist = new System.Windows.Forms.DataGridView();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteArtistsButton = new System.Windows.Forms.Button();
            this.saveAritistsButton = new System.Windows.Forms.Button();
            this.tabControlConcerts = new System.Windows.Forms.TabControl();
            this.qtAdapter = new ConcertsData.DSConcertsTableAdapters.QTAdapter();
            this.fKConcertArtistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKConcertArtistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ticket_StatesTableAdapter = new ConcertsData.DSConcertsTableAdapters.Ticket_StatesTableAdapter();
            this.concertTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_Artist_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_Place_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concert_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBoxConcertArtistID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ComboBoxConcertPlaceID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector_Place_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBoxSectorPlaceID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.seatLinenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat_Sector_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBoxSeatSectorID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ComboBoxTicketSeatID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket_State = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ticket_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket_State_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket_Seat_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket_Concert_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).BeginInit();
            this.tabPageSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).BeginInit();
            this.tabPageSectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            this.tabPagePlaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).BeginInit();
            this.tabPageTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTicketStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            this.tabPageConcerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            this.tabPageArtists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).BeginInit();
            this.tabControlConcerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKConcertArtistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKConcertArtistBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // concertsDataSetBindingSource
            // 
            this.concertsDataSetBindingSource.DataSource = this.concertsDataSet;
            this.concertsDataSetBindingSource.Position = 0;
            this.concertsDataSetBindingSource.CurrentChanged += new System.EventHandler(this.concertsDataSetBindingSource_CurrentChanged);
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
            this.tabPageSeats.Size = new System.Drawing.Size(1957, 448);
            this.tabPageSeats.TabIndex = 5;
            this.tabPageSeats.Text = "Місця";
            this.tabPageSeats.UseVisualStyleBackColor = true;
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
            // dataGridViewSeats
            // 
            this.dataGridViewSeats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSeats.AutoGenerateColumns = false;
            this.dataGridViewSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seatLinenumberDataGridViewTextBoxColumn,
            this.Seat_ID,
            this.Seat_Sector_ID,
            this.seatNumberDataGridViewTextBoxColumn,
            this.ComboBoxSeatSectorID});
            this.dataGridViewSeats.DataSource = this.seatsBindingSource;
            this.dataGridViewSeats.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewSeats.Name = "dataGridViewSeats";
            this.dataGridViewSeats.RowTemplate.Height = 24;
            this.dataGridViewSeats.Size = new System.Drawing.Size(1305, 393);
            this.dataGridViewSeats.TabIndex = 0;
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataMember = "Sectors";
            this.sectorsBindingSource.DataSource = this.concertsDataSet;
            // 
            // seatsBindingSource
            // 
            this.seatsBindingSource.DataMember = "Seats";
            this.seatsBindingSource.DataSource = this.concertsDataSet;
            // 
            // tabPageSectors
            // 
            this.tabPageSectors.Controls.Add(this.deleteSectorsButton);
            this.tabPageSectors.Controls.Add(this.saveSectorsButton);
            this.tabPageSectors.Controls.Add(this.dataGridViewSectors);
            this.tabPageSectors.Location = new System.Drawing.Point(4, 25);
            this.tabPageSectors.Name = "tabPageSectors";
            this.tabPageSectors.Size = new System.Drawing.Size(1957, 448);
            this.tabPageSectors.TabIndex = 4;
            this.tabPageSectors.Text = "Сектори";
            this.tabPageSectors.UseVisualStyleBackColor = true;
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
            // dataGridViewSectors
            // 
            this.dataGridViewSectors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSectors.AutoGenerateColumns = false;
            this.dataGridViewSectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectorNameDataGridViewTextBoxColumn,
            this.Sector_ID,
            this.Sector_Place_ID,
            this.ComboBoxSectorPlaceID});
            this.dataGridViewSectors.DataSource = this.sectorsBindingSource;
            this.dataGridViewSectors.Location = new System.Drawing.Point(4, 49);
            this.dataGridViewSectors.Name = "dataGridViewSectors";
            this.dataGridViewSectors.RowTemplate.Height = 24;
            this.dataGridViewSectors.Size = new System.Drawing.Size(1941, 386);
            this.dataGridViewSectors.TabIndex = 0;
            this.dataGridViewSectors.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewSectors_DataError);
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataMember = "Places";
            this.placesBindingSource.DataSource = this.concertsDataSet;
            // 
            // tabPagePlaces
            // 
            this.tabPagePlaces.Controls.Add(this.deletePlacesButton);
            this.tabPagePlaces.Controls.Add(this.savePlacesButton);
            this.tabPagePlaces.Controls.Add(this.dataGridViewPlaces);
            this.tabPagePlaces.Location = new System.Drawing.Point(4, 25);
            this.tabPagePlaces.Name = "tabPagePlaces";
            this.tabPagePlaces.Size = new System.Drawing.Size(1957, 448);
            this.tabPagePlaces.TabIndex = 3;
            this.tabPagePlaces.Text = "Місця проведення";
            this.tabPagePlaces.UseVisualStyleBackColor = true;
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
            // dataGridViewPlaces
            // 
            this.dataGridViewPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlaces.AutoGenerateColumns = false;
            this.dataGridViewPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeNameDataGridViewTextBoxColumn,
            this.placeAddressDataGridViewTextBoxColumn,
            this.Place_ID});
            this.dataGridViewPlaces.DataSource = this.placesBindingSource;
            this.dataGridViewPlaces.Location = new System.Drawing.Point(3, 47);
            this.dataGridViewPlaces.Name = "dataGridViewPlaces";
            this.dataGridViewPlaces.RowTemplate.Height = 24;
            this.dataGridViewPlaces.Size = new System.Drawing.Size(1305, 388);
            this.dataGridViewPlaces.TabIndex = 0;
            this.dataGridViewPlaces.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewPlaces_DataError);
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
            // Place_ID
            // 
            this.Place_ID.DataPropertyName = "Place_ID";
            this.Place_ID.HeaderText = "Place_ID";
            this.Place_ID.Name = "Place_ID";
            this.Place_ID.Visible = false;
            // 
            // tabPageTickets
            // 
            this.tabPageTickets.Controls.Add(this.deleteTicketsButton);
            this.tabPageTickets.Controls.Add(this.saveTicketsButton);
            this.tabPageTickets.Controls.Add(this.dataGridViewTickets);
            this.tabPageTickets.Location = new System.Drawing.Point(4, 25);
            this.tabPageTickets.Name = "tabPageTickets";
            this.tabPageTickets.Size = new System.Drawing.Size(1957, 448);
            this.tabPageTickets.TabIndex = 2;
            this.tabPageTickets.Text = "Білети";
            this.tabPageTickets.UseVisualStyleBackColor = true;
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
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTickets.AutoGenerateColumns = false;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComboBoxTicketSeatID,
            this.ticketPriceDataGridViewTextBoxColumn,
            this.Ticket_State,
            this.Ticket_ID,
            this.Ticket_State_ID,
            this.Ticket_Seat_ID,
            this.Ticket_Concert_ID});
            this.dataGridViewTickets.DataSource = this.ticketsBindingSource;
            this.dataGridViewTickets.Location = new System.Drawing.Point(0, 46);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(1950, 378);
            this.dataGridViewTickets.TabIndex = 0;
            this.dataGridViewTickets.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewTickets_DataError);
            // 
            // bindingSourceTicketStates
            // 
            this.bindingSourceTicketStates.DataMember = "Ticket_States";
            this.bindingSourceTicketStates.DataSource = this.dsConcerts;
            // 
            // dsConcerts
            // 
            this.dsConcerts.DataSetName = "DSConcerts";
            this.dsConcerts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // concertsBindingSource
            // 
            this.concertsBindingSource.DataMember = "Concerts";
            this.concertsBindingSource.DataSource = this.concertsDataSet;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.concertsDataSet;
            // 
            // tabPageConcerts
            // 
            this.tabPageConcerts.Controls.Add(this.deleteConcertsButton);
            this.tabPageConcerts.Controls.Add(this.saveConcertsButton);
            this.tabPageConcerts.Controls.Add(this.dataGridViewConcerts);
            this.tabPageConcerts.Location = new System.Drawing.Point(4, 25);
            this.tabPageConcerts.Name = "tabPageConcerts";
            this.tabPageConcerts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConcerts.Size = new System.Drawing.Size(1957, 448);
            this.tabPageConcerts.TabIndex = 1;
            this.tabPageConcerts.Text = "Концерти";
            this.tabPageConcerts.UseVisualStyleBackColor = true;
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
            // dataGridViewConcerts
            // 
            this.dataGridViewConcerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConcerts.AutoGenerateColumns = false;
            this.dataGridViewConcerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConcerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.concertTimeDateDataGridViewTextBoxColumn,
            this.Concert_Artist_ID,
            this.Concert_Place_ID,
            this.Concert_ID,
            this.ComboBoxConcertArtistID,
            this.ComboBoxConcertPlaceID});
            this.dataGridViewConcerts.DataSource = this.concertsBindingSource;
            this.dataGridViewConcerts.Location = new System.Drawing.Point(3, 48);
            this.dataGridViewConcerts.Name = "dataGridViewConcerts";
            this.dataGridViewConcerts.RowTemplate.Height = 24;
            this.dataGridViewConcerts.Size = new System.Drawing.Size(1957, 438);
            this.dataGridViewConcerts.TabIndex = 0;
            this.dataGridViewConcerts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConcerts_CellContentClick);
            this.dataGridViewConcerts.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewConcerts_DataError);
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataMember = "Artists";
            this.artistsBindingSource.DataSource = this.concertsDataSet;
            // 
            // tabPageArtists
            // 
            this.tabPageArtists.Controls.Add(this.buttonSearch);
            this.tabPageArtists.Controls.Add(this.dataGridViewArtist);
            this.tabPageArtists.Controls.Add(this.deleteArtistsButton);
            this.tabPageArtists.Controls.Add(this.saveAritistsButton);
            this.tabPageArtists.Location = new System.Drawing.Point(4, 25);
            this.tabPageArtists.Name = "tabPageArtists";
            this.tabPageArtists.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArtists.Size = new System.Drawing.Size(1957, 448);
            this.tabPageArtists.TabIndex = 0;
            this.tabPageArtists.Text = "Виконавці";
            this.tabPageArtists.UseVisualStyleBackColor = true;
            this.tabPageArtists.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(243, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 32);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.artistGenreDataGridViewTextBoxColumn,
            this.Artist_ID});
            this.dataGridViewArtist.DataSource = this.artistsBindingSource;
            this.dataGridViewArtist.Location = new System.Drawing.Point(6, 47);
            this.dataGridViewArtist.Name = "dataGridViewArtist";
            this.dataGridViewArtist.RowTemplate.Height = 24;
            this.dataGridViewArtist.Size = new System.Drawing.Size(1306, 388);
            this.dataGridViewArtist.TabIndex = 3;
            this.dataGridViewArtist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtist_CellContentClick);
            this.dataGridViewArtist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtistCategory_CellDoubleClick);
            this.dataGridViewArtist.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewArtist_DataError);
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
            // Artist_ID
            // 
            this.Artist_ID.DataPropertyName = "Artist_ID";
            this.Artist_ID.HeaderText = "Artist_ID";
            this.Artist_ID.Name = "Artist_ID";
            this.Artist_ID.Visible = false;
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
            this.tabControlConcerts.Size = new System.Drawing.Size(1965, 477);
            this.tabControlConcerts.TabIndex = 0;
            this.tabControlConcerts.SelectedIndexChanged += new System.EventHandler(this.tabControlConcerts_SelectedIndexChanged);
            // 
            // fKConcertArtistBindingSource
            // 
            this.fKConcertArtistBindingSource.DataMember = "FK_Concert_Artist";
            this.fKConcertArtistBindingSource.DataSource = this.artistsBindingSource;
            // 
            // fKConcertArtistBindingSource1
            // 
            this.fKConcertArtistBindingSource1.DataMember = "FK_Concert_Artist";
            this.fKConcertArtistBindingSource1.DataSource = this.artistsBindingSource;
            // 
            // ticket_StatesTableAdapter
            // 
            this.ticket_StatesTableAdapter.ClearBeforeFill = true;
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
            this.Concert_Artist_ID.HeaderText = "Concert_Artist_ID";
            this.Concert_Artist_ID.Name = "Concert_Artist_ID";
            this.Concert_Artist_ID.Visible = false;
            // 
            // Concert_Place_ID
            // 
            this.Concert_Place_ID.DataPropertyName = "Concert_Place_ID";
            this.Concert_Place_ID.HeaderText = "Concert_Place_ID";
            this.Concert_Place_ID.Name = "Concert_Place_ID";
            this.Concert_Place_ID.Visible = false;
            // 
            // Concert_ID
            // 
            this.Concert_ID.DataPropertyName = "Concert_ID";
            this.Concert_ID.HeaderText = "Concert_ID";
            this.Concert_ID.Name = "Concert_ID";
            this.Concert_ID.Visible = false;
            // 
            // ComboBoxConcertArtistID
            // 
            this.ComboBoxConcertArtistID.DataPropertyName = "Concert_Artist_ID";
            this.ComboBoxConcertArtistID.DataSource = this.artistsBindingSource;
            this.ComboBoxConcertArtistID.DisplayMember = "Artist_Name";
            this.ComboBoxConcertArtistID.HeaderText = "Виконавець";
            this.ComboBoxConcertArtistID.Name = "ComboBoxConcertArtistID";
            this.ComboBoxConcertArtistID.ValueMember = "Artist_ID";
            // 
            // ComboBoxConcertPlaceID
            // 
            this.ComboBoxConcertPlaceID.DataPropertyName = "Concert_Place_ID";
            this.ComboBoxConcertPlaceID.DataSource = this.placesBindingSource;
            this.ComboBoxConcertPlaceID.DisplayMember = "Place_Name";
            this.ComboBoxConcertPlaceID.HeaderText = "Місце проведення";
            this.ComboBoxConcertPlaceID.Name = "ComboBoxConcertPlaceID";
            this.ComboBoxConcertPlaceID.ValueMember = "Place_ID";
            // 
            // sectorNameDataGridViewTextBoxColumn
            // 
            this.sectorNameDataGridViewTextBoxColumn.DataPropertyName = "Sector_Name";
            this.sectorNameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.sectorNameDataGridViewTextBoxColumn.Name = "sectorNameDataGridViewTextBoxColumn";
            // 
            // Sector_ID
            // 
            this.Sector_ID.DataPropertyName = "Sector_ID";
            this.Sector_ID.HeaderText = "Sector_ID";
            this.Sector_ID.Name = "Sector_ID";
            this.Sector_ID.Visible = false;
            // 
            // Sector_Place_ID
            // 
            this.Sector_Place_ID.DataPropertyName = "Sector_Place_ID";
            this.Sector_Place_ID.HeaderText = "Sector_Place_ID";
            this.Sector_Place_ID.Name = "Sector_Place_ID";
            this.Sector_Place_ID.Visible = false;
            // 
            // ComboBoxSectorPlaceID
            // 
            this.ComboBoxSectorPlaceID.DataPropertyName = "Sector_Place_ID";
            this.ComboBoxSectorPlaceID.DataSource = this.placesBindingSource;
            this.ComboBoxSectorPlaceID.DisplayMember = "Place_Name";
            this.ComboBoxSectorPlaceID.HeaderText = "Місце проведення";
            this.ComboBoxSectorPlaceID.Name = "ComboBoxSectorPlaceID";
            this.ComboBoxSectorPlaceID.ValueMember = "Place_ID";
            // 
            // seatLinenumberDataGridViewTextBoxColumn
            // 
            this.seatLinenumberDataGridViewTextBoxColumn.DataPropertyName = "Seat_Line_number";
            this.seatLinenumberDataGridViewTextBoxColumn.HeaderText = "Номер ряду";
            this.seatLinenumberDataGridViewTextBoxColumn.Name = "seatLinenumberDataGridViewTextBoxColumn";
            // 
            // Seat_ID
            // 
            this.Seat_ID.DataPropertyName = "Seat_ID";
            this.Seat_ID.HeaderText = "Seat_ID";
            this.Seat_ID.Name = "Seat_ID";
            this.Seat_ID.Visible = false;
            // 
            // Seat_Sector_ID
            // 
            this.Seat_Sector_ID.DataPropertyName = "Seat_Sector_ID";
            this.Seat_Sector_ID.HeaderText = "Seat_Sector_ID";
            this.Seat_Sector_ID.Name = "Seat_Sector_ID";
            this.Seat_Sector_ID.Visible = false;
            // 
            // seatNumberDataGridViewTextBoxColumn
            // 
            this.seatNumberDataGridViewTextBoxColumn.DataPropertyName = "Seat_Number";
            this.seatNumberDataGridViewTextBoxColumn.HeaderText = "Номер сидіння";
            this.seatNumberDataGridViewTextBoxColumn.Name = "seatNumberDataGridViewTextBoxColumn";
            // 
            // ComboBoxSeatSectorID
            // 
            this.ComboBoxSeatSectorID.DataPropertyName = "Seat_Sector_ID";
            this.ComboBoxSeatSectorID.DataSource = this.sectorsBindingSource;
            this.ComboBoxSeatSectorID.DisplayMember = "Sector_Name";
            this.ComboBoxSeatSectorID.HeaderText = "Сектор";
            this.ComboBoxSeatSectorID.Name = "ComboBoxSeatSectorID";
            this.ComboBoxSeatSectorID.ValueMember = "Sector_ID";
            // 
            // ComboBoxTicketSeatID
            // 
            this.ComboBoxTicketSeatID.DataPropertyName = "Ticket_Seat_ID";
            this.ComboBoxTicketSeatID.DataSource = this.seatsBindingSource;
            this.ComboBoxTicketSeatID.DisplayMember = "Seat_Number";
            this.ComboBoxTicketSeatID.HeaderText = "Місце";
            this.ComboBoxTicketSeatID.Name = "ComboBoxTicketSeatID";
            this.ComboBoxTicketSeatID.ValueMember = "Seat_ID";
            // 
            // ticketPriceDataGridViewTextBoxColumn
            // 
            this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Price";
            this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
            // 
            // Ticket_State
            // 
            this.Ticket_State.DataPropertyName = "Ticket_State_ID";
            this.Ticket_State.DataSource = this.bindingSourceTicketStates;
            this.Ticket_State.DisplayMember = "Name";
            this.Ticket_State.HeaderText = "Стан квитка";
            this.Ticket_State.Name = "Ticket_State";
            this.Ticket_State.ValueMember = "State_ID";
            this.Ticket_State.Visible = false;
            // 
            // Ticket_ID
            // 
            this.Ticket_ID.DataPropertyName = "Ticket_ID";
            this.Ticket_ID.HeaderText = "Ticket_ID";
            this.Ticket_ID.Name = "Ticket_ID";
            this.Ticket_ID.Visible = false;
            // 
            // Ticket_State_ID
            // 
            this.Ticket_State_ID.DataPropertyName = "Ticket_State_ID";
            this.Ticket_State_ID.HeaderText = "Ticket_State_ID";
            this.Ticket_State_ID.Name = "Ticket_State_ID";
            this.Ticket_State_ID.Visible = false;
            // 
            // Ticket_Seat_ID
            // 
            this.Ticket_Seat_ID.DataPropertyName = "Ticket_Seat_ID";
            this.Ticket_Seat_ID.HeaderText = "Ticket_Seat_ID";
            this.Ticket_Seat_ID.Name = "Ticket_Seat_ID";
            this.Ticket_Seat_ID.Visible = false;
            // 
            // Ticket_Concert_ID
            // 
            this.Ticket_Concert_ID.DataPropertyName = "Ticket_Concert_ID";
            this.Ticket_Concert_ID.HeaderText = "Ticket_Concert_ID";
            this.Ticket_Concert_ID.Name = "Ticket_Concert_ID";
            this.Ticket_Concert_ID.Visible = false;
            // 
            // ConcertsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1336, 484);
            this.Controls.Add(this.tabControlConcerts);
            this.Name = "ConcertsForm";
            this.Text = "Концерти";
            this.Load += new System.EventHandler(this.ConcertsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsDataSet)).EndInit();
            this.tabPageSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).EndInit();
            this.tabPageSectors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            this.tabPagePlaces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).EndInit();
            this.tabPageTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTicketStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concertsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            this.tabPageConcerts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            this.tabPageArtists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).EndInit();
            this.tabControlConcerts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKConcertArtistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKConcertArtistBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private System.Windows.Forms.TabPage tabPageConcerts;
        private System.Windows.Forms.DataGridView dataGridViewConcerts;
        private System.Windows.Forms.BindingSource concertsBindingSource;
        private System.Windows.Forms.TabPage tabPageArtists;
        private System.Windows.Forms.Button deleteArtistsButton;
        private System.Windows.Forms.Button saveAritistsButton;
        private System.Windows.Forms.TabControl tabControlConcerts;
        private System.Windows.Forms.DataGridView dataGridViewSeats;
        private System.Windows.Forms.BindingSource seatsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSectors;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewPlaces;
        private System.Windows.Forms.DataGridView dataGridViewArtist;
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
        private ConcertsData.DSConcertsTableAdapters.QTAdapter qtAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist_ID;
        private System.Windows.Forms.BindingSource fKConcertArtistBindingSource;
        private System.Windows.Forms.BindingSource fKConcertArtistBindingSource1;
        private System.Windows.Forms.BindingSource bindingSourceTicketStates;
        private ConcertsData.DSConcerts dsConcerts;
        private ConcertsData.DSConcertsTableAdapters.Ticket_StatesTableAdapter ticket_StatesTableAdapter;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatLinenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat_Sector_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBoxSeatSectorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector_Place_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBoxSectorPlaceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn concertTimeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_Artist_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_Place_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concert_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBoxConcertArtistID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBoxConcertPlaceID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboBoxTicketSeatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ticket_State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_State_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_Seat_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_Concert_ID;
    }
}

