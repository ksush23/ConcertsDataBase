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
            string findPlace = "%" + textBoxPlace.Text + "%";


            if (textBoxPlace.Text != "")
            {
                artistsByCategoryTableAdapter.FillByPlace(dsConcerts.ArtistsByCategory, id_cat, findPlace);
            }
            else
            {
                artistsByCategoryTableAdapter.FillByData(dsConcerts.ArtistsByCategory, id_cat);
            }
        }

        private void ArtistsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "concertsDataSet.Artists". При необходимости она может быть перемещена или удалена.
            this.artistsTableAdapter.Fill(this.concertsDataSet.Artists);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            find_Artists();
        }

        private void dataGridViewArtistCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int id = 0;

            try
            {
                id = (int)dataGridViewArtistsCategory.CurrentRow.Cells["Artist_ID"].Value;
                artistsByGenreTableAdapter.FillGenre(dsConcerts.ArtistsByGenre, id);
            }
            catch
            {
                MessageBox.Show("Помилка", "Помилка");
            }*/
        }

        private void dataGridViewArtistsCategory_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                e.Row.Cells["Artist_ID"].Value = id_cat;
                e.Row.Cells["artistNameDataGridViewTextBoxColumn"].Value = name_cat;
            }
            catch
            {

            }
        }

        private void buttonDeleteArtistForm_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAddConcert_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewArtistsCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
