using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsConcerts
{
    public partial class ConcertsForm : Form
    {
        public ConcertsForm()
        {
            InitializeComponent();
            artistsTableAdapter.Fill(concertsDataSet.Artists);
            concertsTableAdapter.Fill(concertsDataSet.Concerts);
            ticketsTableAdapter.Fill(concertsDataSet.Tickets);
            placesTableAdapter.Fill(concertsDataSet.Places);
            sectorsTableAdapter.Fill(concertsDataSet.Sectors);
            seatsTableAdapter.Fill(concertsDataSet.Seats);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ConcertsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concertsDataSet.Seats". При необходимости она может быть перемещена или удалена.
            this.seatsTableAdapter.Fill(this.concertsDataSet.Seats);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concertsDataSet.Sectors". При необходимости она может быть перемещена или удалена.
            this.sectorsTableAdapter.Fill(this.concertsDataSet.Sectors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concertsDataSet.Places". При необходимости она может быть перемещена или удалена.
            this.placesTableAdapter.Fill(this.concertsDataSet.Places);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concertsDataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.concertsDataSet.Tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concertsDataSet.Concerts". При необходимости она может быть перемещена или удалена.
            this.concertsTableAdapter.Fill(this.concertsDataSet.Concerts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concertsDataSet.Artists". При необходимости она может быть перемещена или удалена.
            this.artistsTableAdapter.Fill(this.concertsDataSet.Artists);

        }

        private void artistsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ticketsTableAdapter.Update(concertsDataSet.Tickets);
            concertsTableAdapter.Update(concertsDataSet.Concerts);
            artistsTableAdapter.Update(concertsDataSet.Artists);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewArtist.CurrentRow.Cells["Artist_ID"].Value;
                global::System.Nullable<int> concerts_artist_count = (int)qtAdapter.SQ_Count_Concert_Artist_ID(id);

                if (concerts_artist_count == 0)
                    artistsBindingSource.RemoveCurrent();
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити виконавця, на якого є посилання?", "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        artistsBindingSource.RemoveCurrent();
                        for (int i = 0; i < dataGridViewConcerts.RowCount - 1; i++)
                        {
                            if (id == (int)dataGridViewConcerts.Rows[i].Cells["Concert_Artist_ID"].Value)
                            {
                                concertsBindingSource.RemoveAt(i);
                                for (int j = 0; j < dataGridViewTickets.RowCount - 1; j++)
                                {
                                    if (id == (int)dataGridViewTickets.Rows[j].Cells["Ticket_Concert_ID"].Value)
                                        ticketsBindingSource.RemoveAt(j);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення виконавця!");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveConcertsButton_Click(object sender, EventArgs e)
        {
            concertsTableAdapter.Update(concertsDataSet.Concerts);
        }

        private void deleteConcertsButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewConcerts.CurrentRow.Cells["Concert_ID"].Value;
                global::System.Nullable<int> tickets_concerts_count = (int)qtAdapter.SQ_Count_Ticket_Concert_ID(id);

                if (tickets_concerts_count == 0)
                    concertsBindingSource.RemoveCurrent();
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити концерт, на який є посилання?", "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        concertsBindingSource.RemoveCurrent();
                        for (int i = 0; i < dataGridViewTickets.RowCount - 1; i++)
                        {
                            if (id == (int)dataGridViewTickets.Rows[i].Cells["Ticket_Concert_ID"].Value)
                                ticketsBindingSource.RemoveAt(i);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення місця проведення!");
            }
        }

        private void saveTicketsButton_Click(object sender, EventArgs e)
        {
            ticketsTableAdapter.Update(concertsDataSet.Tickets);
        }

        private void deleteTicketsButton_Click(object sender, EventArgs e)
        {
            ticketsBindingSource.RemoveCurrent();
        }

        private void savePlacesButton_Click(object sender, EventArgs e)
        {
            ticketsTableAdapter.Update(concertsDataSet.Tickets);
            sectorsTableAdapter.Update(concertsDataSet.Sectors);
            seatsTableAdapter.Update(concertsDataSet.Seats);
            placesTableAdapter.Update(concertsDataSet.Places);
        }

        private void deletePlacesButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewPlaces.CurrentRow.Cells["Place_ID"].Value;
                global::System.Nullable<int> concerts_places_count = (int)qtAdapter.SQ_Concerts_Places_ID_Count(id);
                global::System.Nullable<int> sectors_places_count = (int)qtAdapter.SQ_Count_Sector_Place_ID(id);

                if (concerts_places_count == 0 && sectors_places_count == 0)
                    placesBindingSource.RemoveCurrent();
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити місце проведення, на яке є посилання?", "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        placesBindingSource.RemoveCurrent();

                        if (concerts_places_count == 0)
                            for (int i = 0; i < dataGridViewConcerts.RowCount - 1; i++)
                            {
                                if (id == (int)dataGridViewConcerts.Rows[i].Cells["Concert_Place_ID"].Value)
                                {
                                    concertsBindingSource.RemoveAt(i);
                                    for (int j = 0; j < dataGridViewTickets.RowCount - 1; j++)
                                    {
                                        if (id == (int)dataGridViewTickets.Rows[j].Cells["Ticket_Concert_ID"].Value)
                                            ticketsBindingSource.RemoveAt(j);
                                    }
                                }
                            }

                        if (sectors_places_count == 0)
                            for (int i = 0; i < dataGridViewSectors.RowCount - 1; i++)
                            {
                                if (id == (int)dataGridViewSectors.Rows[i].Cells["Sector_Place_ID"].Value)
                                {
                                    sectorsBindingSource.RemoveAt(i);
                                    for (int j = 0; j < dataGridViewSeats.RowCount - 1; j++)
                                    {
                                        if (id == (int)dataGridViewSeats.Rows[j].Cells["Seat_Sector_ID"].Value)
                                            seatsBindingSource.RemoveAt(j);
                                    }
                                }
                            }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення місця проведення!");
            }
            
        }

        private void saveSectorsButton_Click(object sender, EventArgs e)
        {
            ticketsTableAdapter.Update(concertsDataSet.Tickets);
            seatsTableAdapter.Update(concertsDataSet.Seats);
            sectorsTableAdapter.Update(concertsDataSet.Sectors);
        }

        private void deleteSectorsButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewSectors.CurrentRow.Cells["Sectors_ID"].Value;
                global::System.Nullable<int> seats_sectors_count = (int)qtAdapter.SQ_Count_Seat_Sector_ID(id);

                if (seats_sectors_count == 0)
                    sectorsBindingSource.RemoveCurrent();
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити сектор, на який є посилання?", "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        sectorsBindingSource.RemoveCurrent();
                        for (int i = 0; i < dataGridViewSeats.RowCount - 1; i++)
                        {
                            if (id == (int)dataGridViewSeats.Rows[i].Cells["Seat_Sector_ID"].Value)
                            {
                                seatsBindingSource.RemoveAt(i);
                                for (int j = 0; j < dataGridViewTickets.RowCount - 1; j++)
                                {
                                    if (id == (int)dataGridViewTickets.Rows[j].Cells["Ticket_Concert_ID"].Value)
                                        ticketsBindingSource.RemoveAt(j);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення сектора!");
            }
        }

        private void saveSeatsButton_Click(object sender, EventArgs e)
        {
            ticketsTableAdapter.Update(concertsDataSet.Tickets);
            seatsTableAdapter.Update(concertsDataSet.Seats);
        }

        private void deleteSeatsButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewSeats.CurrentRow.Cells["Seats_ID"].Value;
                global::System.Nullable<int> tickets_seats_count = (int)qtAdapter.SQ_Count_Ticket_Seat_ID(id);

                if (tickets_seats_count == 0)
                    seatsBindingSource.RemoveCurrent();
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити місце, на яке є посилання?", "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        seatsBindingSource.RemoveCurrent();
                        for (int i = 0; i < dataGridViewTickets.RowCount - 1; i++)
                        {
                            if (id == (int)dataGridViewTickets.Rows[i].Cells["Ticket_Seat_ID"].Value)
                                ticketsBindingSource.RemoveAt(i);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення місця!");
            }
        }

        private void concertsDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewConcerts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewArtist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewArtist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridViewArtist.CurrentRow.Cells["Artist_ID"].Value;
                string name = (string)dataGridViewArtist.CurrentRow.Cells["artistNameDataGridViewTextBoxColumn"].Value;

                ArtistsForm concertsDialog = new ArtistsForm(id, name);
                concertsDialog.ShowDialog(this);

                concertsDialog.Dispose();
            }
            catch
            {
                MessageBox.Show("Помилка переходу до списку виконавців", "Перехід до списку виконавців");
            }
        }

        private void dataGridViewArtistCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridViewArtist.CurrentRow.Cells["Artist_ID"].Value;
                string name = (string)dataGridViewArtist.CurrentRow.Cells["artistNameDataGridViewTextBoxColumn"].Value;

                ArtistsForm concertsDialog = new ArtistsForm(id, name);
                concertsDialog.ShowDialog(this);

                concertsDialog.Dispose();
            }
            catch
            {
                //MessageBox.Show("Помилка переходу до списку виконавців", "Перехід до списку виконавців");
            }
        }

        private void tabControlConcerts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonSearchForTickets_Click(object sender, EventArgs e)
        {
            FormTickets formTickets = new FormTickets();
            formTickets.ShowDialog(this);
            formTickets.Dispose();
        }

        private void buttonSearchForTickets_Click_1(object sender, EventArgs e)
        {
            FormTickets formTickets = new FormTickets();
            formTickets.ShowDialog(this);
            formTickets.Dispose();
        }

        private void buttonSearchForTickets_Click_2(object sender, EventArgs e)
        {
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormTickets formTickets = new FormTickets();
            formTickets.ShowDialog(this);
            formTickets.Dispose();
        }

        private void dataGridViewArtist_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некоректні дані");
        }

        private void dataGridViewConcerts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некоректні дані");
        }

        private void dataGridViewTickets_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некоректні дані");
        }

        private void dataGridViewPlaces_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некоректні дані");
        }

        private void dataGridViewSectors_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некоректні дані");
        }

        private void dataGridViewSeats_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некоректні дані");
        }
    }
}
