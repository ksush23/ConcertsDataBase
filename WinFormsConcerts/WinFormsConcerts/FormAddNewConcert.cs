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
    public partial class FormAddNewConcert : Form
    {
        int id_concert;
        string time_concert;

        public FormAddNewConcert()
        {
            InitializeComponent();
        }

        public FormAddNewConcert(int concert_id, string concert_time)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", concert_time);

            notConcertsTableAdapter.Fill(dsConcerts.NotConcerts, concert_id);

            id_concert = concert_id;
            time_concert = concert_time;
        }

        private void FormAddNewConcert_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddConcert_Click(object sender, EventArgs e)
        {
            try
            {
                int concert_id = (int)(bindingSource.Current as DataRowView)["Concert_ID"];
                notConcertsTableAdapter.
            }
        }
    }
}
