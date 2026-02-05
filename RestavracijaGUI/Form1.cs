using RestavracijaLib; //lastna knjižica
using RestavracijaLib.RestavracijaLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestavracijaGUI
{
    public partial class Form1 : Form
    {
        private List<Izdelek> meni = new List<Izdelek>();
        private Narocilo narocilo = new Narocilo();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
                comboBoxMiza.Items.Add(i);

            comboBoxMiza.SelectedIndex = 0;

            meni.Add(new Hrana("Pica Klasika", 8.50m, "gluten, mleko"));
            meni.Add(new Hrana("Pica Margerita", 8.50m, "gluten, mleko"));
            meni.Add(new Hrana("Hamburger", 7.20m, "gluten"));
            meni.Add(new Hrana("Solata", 5.00m, "—"));
            meni.Add(new Pijaca("Voda", 1.50m, 0.5));
            meni.Add(new Pijaca("Sok", 2.20m, 0.33));
            meni.Add(new Pijaca("Kava", 1.80m, 0.2));

            OsveziMeni();
            OsveziNarocilo();
        }

        private void OsveziMeni()
        {
            listBoxMeni.Items.Clear();
            foreach (var i in meni)
                listBoxMeni.Items.Add(i);
        }

        private void OsveziNarocilo()
        {
            listBoxNarocilo.Items.Clear();
            foreach (var p in narocilo.Postavke)
                listBoxNarocilo.Items.Add(p);

            decimal skupaj = narocilo.Skupaj();
            decimal zDDV = narocilo.ZnesekZDDV();

            labelSkupaj.Text = "Skupaj: " + skupaj.ToString("0.00") + " €";
            labelZDDV.Text = "Z DDV: " + zDDV.ToString("0.00") + " €";
            labelRacun.Text = "Naročilo #" + narocilo.Stevilka;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (listBoxMeni.SelectedItem == null) return;

            Izdelek izbran = (Izdelek)listBoxMeni.SelectedItem;
            narocilo.DodajIzdelek(izbran);

            OsveziNarocilo();
        }

        private void buttonOdstrani_Click(object sender, EventArgs e)
        {
            if (listBoxNarocilo.SelectedItem == null) return;

            PostavkaNarocila izbrana = (PostavkaNarocila)listBoxNarocilo.SelectedItem;
            narocilo.Postavke.Remove(izbrana);

            OsveziNarocilo();
        }

        private void buttonNovoNarocilo_Click(object sender, EventArgs e)
        {
            narocilo = new Narocilo();
            OsveziNarocilo();
        }

        private void buttonZakljuciRacun_Click(object sender, EventArgs e)
        {
            Racun r = new Racun();
            foreach (var p in narocilo.Postavke)
                r.Postavke.Add(p);

            MessageBox.Show
            (
                "Račun #" + r.StevilkaRacuna +
                Environment.NewLine +
                "Skupaj: " + r.Skupaj().ToString("0.00") + " €" +
                Environment.NewLine +
                "Z DDV: " + r.ZnesekZDDV().ToString("0.00") + " €",
                "Račun"
            );

            ICenik cenik = r;   // r je Racun
            decimal znesek = cenik.KoncnaCena();
        }
    }
}
