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
            artistsBindingSource.RemoveCurrent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
