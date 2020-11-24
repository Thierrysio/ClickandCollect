using ClickandCollect.Modeles;
using ClickandCollect.Utilitaires;
using ClickandCollect.Vues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickandCollect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /// Remplissage du combobox1
            /// 
            this.RemplissageCbx();
        }
        private void RemplissageCbx()
        {
            comboBox1.Items.Clear();
            foreach (Ville uneVille in Ville.CollClassesVille)
            {
                comboBox1.Items.Add(uneVille.Id + "-" + uneVille.Nom);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ville param = this.GetObjetVille(Ville.CollClassesVille,comboBox1.Text.Split('-')[0]);
            textBox1.Text = param.Id.ToString();
            textBox2.Text = param.Nom;
            textBox3.Text = param.CodePostal.ToString();
            this.SetListeBox(param);
        }
        private void SetListeBox(Ville param)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("adresse", typeof(string));
            dt.Columns.Add("Ville", typeof(string));
            dt.Columns.Add("Code postal", typeof(int));
            dt.Columns.Add("Latitude", typeof(float));
            dt.Columns.Add("Longitude", typeof(float));

            foreach (Box uneBox in param.LesBox)
            {
                dt.Rows.Add(uneBox.Id, uneBox.Adresse, uneBox.LaVille.Nom, uneBox.LaVille.CodePostal,uneBox.GpsX,uneBox.GpsY);
            }

            dataGridView1.DataSource = dt;
        }
        private Ville GetObjetVille(List<Ville>param,string param2 )
        {
            Ville result = null;
            foreach(Ville uneVille in param)
            {
                if (uneVille.Id == Convert.ToInt32( param2))
                {
                    result = uneVille;
                    break;
                }
            }
            return result;
        }

        private Box GetObjetBox(List<Box> param, string param2)
        {
            Box result = null;
            foreach (Box uneBox in param)
            {
                if (uneBox.Id == Convert.ToInt32(param2))
                {
                    result = uneBox;
                    break;
                }
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "") return;
            new Ville(GestionCollection.GetNouvelIndex(Ville.CollClassesVille),textBox2.Text,Convert.ToInt32(textBox3.Text));
            this.RemplissageCbx();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ville param = this.GetObjetVille(Ville.CollClassesVille, textBox1.Text);
            if (textBox1.Text == "") return;
            param.Nom = textBox2.Text;
            param.CodePostal = Convert.ToInt32 (textBox3.Text);
            this.RemplissageCbx();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow ligne = dataGridView1.Rows[e.RowIndex];
            Ville param = this.GetObjetVille(Ville.CollClassesVille, textBox1.Text);
            Box laBox = this.GetObjetBox(param.LesBox, ligne.Cells[0].Value.ToString());

            Form Form2 = new Form2(laBox);
            Form2.ShowDialog();
        }
    }
}
