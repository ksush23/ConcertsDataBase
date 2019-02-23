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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearchTicket_Click(object sender, EventArgs e)
        {

        }

        private void find_tickets()
        {
            string findArtist = "%" + textBoxArtist.Text + "%";
            string findPlace = "%" + textBoxPlace.Text + "%";
            int priceFrom = Convert.ToInt32(textBoxPriceFrom.Text);
            int priceTo = Convert.ToInt32(textBoxPriceTo.Text);

            if (textBoxPriceFrom.Text == "")
                priceFrom = 0;
            if (textBoxPriceTo.Text == "")
                priceTo = 10000000;

            if (textBoxArtist.Text != "")
            {
                if (textBoxPlace.Text != "" && textBoxPriceFrom.Text != "" || textBoxPriceTo.Text != "")
                {
                    ticketsByCategoryTableAdapter.FillByArtistPlacePrice(dsConcerts.TicketsByCategory, findArtist, findPlace, priceFrom, priceTo);
                }

                else if (textBoxPlace.Text != "")
                {
                    ticketsByCategoryTableAdapter.FillByArtistPlace(dsConcerts.TicketsByCategory, findArtist, findPlace);
                }
                else if (textBoxPriceFrom.Text != "" || textBoxPriceTo.Text != "")
                {
                    ticketsByCategoryTableAdapter.FillByArtistPrice(dsConcerts.TicketsByCategory, findArtist, priceFrom, priceTo);
                }
                else if (textBoxPlace.Text == "")
                {
                    ticketsByCategoryTableAdapter.FillByArtist(dsConcerts.TicketsByCategory, findArtist);
                }
            }

            else if (textBoxPlace.Text != "")
            {
                if (textBoxPriceFrom.Text != "" || textBoxPriceTo.Text != "")
                {
                    ticketsByCategoryTableAdapter.FillByPlacePrice(dsConcerts.TicketsByCategory, findPlace, priceFrom, priceTo);
                }

                ticketsByCategoryTableAdapter.FillByPlace(dsConcerts.TicketsByCategory, findPlace);
            }

            else if (textBoxPriceFrom.Text != "" || textBoxPriceTo.Text != "")
            {
                ticketsByCategoryTableAdapter.FillByPrice(dsConcerts.TicketsByCategory, priceFrom, priceTo);
            }

        }
    }
}
