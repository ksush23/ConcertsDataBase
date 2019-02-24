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
    public partial class FormTickets : Form
    {
        public FormTickets()
        {
            InitializeComponent();
        }

        private void buttonFindTickets_Click(object sender, EventArgs e)
        {
            find_tickets();
        }

        private void find_tickets()
        {
            string findArtist = "%" + textBoxArtist.Text + "%";
            string findPlace = "%" + textBoxPlace.Text + "%";

            if (textBoxArtist.Text != "")
            {
                if (textBoxPlace.Text != "")
                    ticketsByCategoryTableAdapter.FillByArtistPlace(dsConcerts.TicketsByCategory, findArtist, findPlace);
                else
                    ticketsByCategoryTableAdapter.FillByArtist(dsConcerts.TicketsByCategory, findArtist);
            }

            else if (textBoxPlace.Text != "")
                ticketsByCategoryTableAdapter.FillByPlace(dsConcerts.TicketsByCategory, findPlace);

            else
                ticketsByCategoryTableAdapter.FillByAll(dsConcerts.TicketsByCategory);
        }
    }
    
}
