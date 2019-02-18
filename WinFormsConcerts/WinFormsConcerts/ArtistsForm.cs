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
    public partial class ArtistsForm : Form
    {
        int id_cat;
        string name_cat;
        public ArtistsForm()
        {
            InitializeComponent();
        }

        public ArtistsForm(int cat_id, string cat_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", cat_name);

            id_cat = cat_id;
            name_cat = cat_name;
            find_Artists();
        }

        private void find_Artists()
        {
            string findName = "%" + textBoxName.Text + "%";
            if (textBoxGenre.Text != "")
            {
                string findGenre = "%" + textBoxGenre.Text + "%";

                artistsByCategoryTableAdapter.FillByArtistGenre(dsConcerts.ArtistsByCategory, id_cat, findGenre);
            }
        }

        private void ArtistsForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
