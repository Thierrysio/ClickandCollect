using ClickandCollect.Modeles;
using ClickandCollect.Utilitaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickandCollect.Vues
{
    public partial class Form2 : Form
    {
        public Form2(Box param)
        {
            InitializeComponent();
            int x = param.Id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.SetListeBox();
        }
        private void SetListeBox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("adresse", typeof(string));
            dt.Columns.Add("Ville", typeof(string));
            dt.Columns.Add("Code postal", typeof(int));
            dt.Columns.Add("Latitude", typeof(float));
            dt.Columns.Add("Longitude", typeof(float));

            foreach (Box uneBox in Box.collClasseBox)
            {
                dt.Rows.Add(uneBox.Id, uneBox.Adresse, uneBox.LaVille.Nom, uneBox.LaVille.CodePostal, uneBox.GpsX, uneBox.GpsY);
            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ligne = dataGridView1.Rows[e.RowIndex];
            Box laBox = GestionCollection.GetObjet<Box>(Box.collClasseBox, ligne.Cells[0].Value.ToString());

            textBox1.Text = laBox.Id.ToString();
            textBox2.Text = laBox.Adresse;
            comboBox1.Text = laBox.LaVille.Nom;
            textBox3.Text = laBox.LaVille.CodePostal.ToString();
            textBox4.Text = laBox.GpsX.ToString();
            textBox5.Text = laBox.GpsY.ToString();
            comboBox2.Text = "";
        }
    }
}
