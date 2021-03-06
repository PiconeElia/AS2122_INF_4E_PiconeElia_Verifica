namespace AS2122_INF_4E_PiconeElia_Verifica
{
    public partial class GestioneForm : Form
    {
        //creazione dizionario
        Dictionary<string, Articolo> articoli;
        public GestioneForm()
        {
            InitializeComponent();
            articoli = new Dictionary<string, Articolo>();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new Articolo(txtCodice.Text, txtDescrizione.Text, cmbUnitaDiMisura.Text, Convert.ToDouble(txtPrezzo.Text));
            if (articoli.ContainsKey(a.Codice))
                articoli[a.Codice] = a;
            else articoli.Add(a.Codice, a);

            lblArticoli.Text = $"Articoli({articoli.Count})";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lstVisualizza.Items.Clear();
            switch (cmbScelta.Text)
            {
                case "Visualizza articoli":
                    foreach (KeyValuePair<string, Articolo> kvp in articoli)
                    {
                        lstVisualizza.Items.Add(kvp.Value.Visualizzati());
                    }
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

