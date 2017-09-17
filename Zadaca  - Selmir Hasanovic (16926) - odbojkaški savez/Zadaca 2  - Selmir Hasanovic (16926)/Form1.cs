using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Oracle.ManagedDataAccess.Client;
using System.Net;
using System.Xml;
using System.Threading;
using System.Resources;
using Zadaca_2___Selmir_Hasanovic__16926_.Properties;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    public partial class GlavnaForma : Form
    {
        List<Klub> _klubovi = new List<Klub>();
        List<Klub> _kluboviULigi = new List<Klub>();
        public GlavnaForma()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("klubovi.dat"))
                {
                    FileStream fs = new FileStream("klubovi.dat", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    if (new FileInfo("klubovi.dat").Length != 0)
                    {
                        _klubovi = (List<Klub>)bf.Deserialize(fs);
                        foreach (Klub k in _klubovi)
                        {
                            PrikazRegistriranihKlubova.Items.Add(k);
                        }
                    }
                    fs.Close();
                }
                else 
                {
                    FileStream fs = new FileStream("klubovi.dat", FileMode.CreateNew);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DodajNoviIzuzetak(ex.Message, DateTime.Now);
            }
        }
        private void DodajKlubULigu_Click(object sender, EventArgs e)
        {
            try
            {
                Klub k = PrikazRegistriranihKlubova.SelectedItem as Klub;
                if(MuškaLiga.Checked && k.Prefiks == "ŽOK")
                {
                    throw (new DupliranjeException("Nije moguće u mušku ligu dodati klub sa prefiksom 'ŽOK'."));
                }
                if(ŽenskaLiga.Checked && k.Prefiks == "MOK")
                {
                    throw (new DupliranjeException("Nije moguće u žensku ligu dodati klub sa prefiksom 'MOK'."));
                }
                foreach (Klub kl in _kluboviULigi)
                    if (kl.Naziv == k.Naziv)
                    {
                        throw(new DupliranjeException("Klub već dodan u ligu."));
                    }
                if (k.Prefiks == "")
                {
                    return;
                }
                _kluboviULigi.Add(k);
                MessageBox.Show("Klub uspješno dodan.", "Dodavanje uspješno", MessageBoxButtons.OK);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Pogrešan odabir.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(DupliranjeException d)
            {
                MessageBox.Show(d.Message, "Izuzetak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PremijerLiga_CheckedChanged(object sender, EventArgs e)
        {
            DržavaIliEntitet.Text = "Država:";
            NazivDržave.Visible = true;
            RS.Visible = false;
            FBiH.Visible = false;
            RS.Checked = false;
            FBiH.Checked = false;
        }

        private void EntitetskaLiga_CheckedChanged(object sender, EventArgs e)
        {
            DržavaIliEntitet.Text = "Entitet:";
            NazivDržave.Visible = false;
            RS.Visible = true;
            FBiH.Visible = true;
            FBiH.Checked = true;
        }

        private void Registracija_Click(object sender, EventArgs e)
        {
            try
            {
                if (Naziv.Text == "" || Mjesto.Text == "" || Telefon.Text == "" || Adresa.Text == "")
                {
                    throw (new DupliranjeException("Niste popunili sva polja."));
                }
                Klub k = new Klub(
                    PrefiksBOK.Checked,
                    PrefiksHOK.Checked,
                    PrefiksMOK.Checked,
                    PrefiksOK.Checked,
                    PrefiksSOK.Checked,
                    PrefiksŽOK.Checked,
                    Naziv.Text,
                    Mjesto.Text,
                    Telefon.Text,
                    Adresa.Text
                );
                foreach (Klub kl in _klubovi)
                    if (kl.Naziv == k.Naziv && kl.Prefiks == k.Prefiks)
                    {
                        MessageBox.Show("Već postoji klub sa istim nazivom.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                _klubovi.Add(k);
                MessageBox.Show("Klub je uspješno registrovan.", "Registracija uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrikazRegistriranihKlubova.Items.Add(k);
                Naziv.Text = "";
                Mjesto.Text = "";
                Telefon.Text = "";
                Adresa.Text = "";
            }
            catch (DupliranjeException d)
            {
                MessageBox.Show(d.Message, "Greška pri registraciji kluba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PronađiKlub_Click(object sender, EventArgs e)
        {
            foreach (Klub kl in _klubovi)
            {
                if (kl.Naziv == PretragaNazivKluba.Text)
                {
                    PretragaAdresa.Text = kl.Adresa;
                    PretragaMjesto.Text = kl.Mjesto;
                    PretragaTelefon.Text = kl.Telefon;
                    PretragaNaziv.Text = kl.Naziv;
                    PretragaPrefiks.Text = kl.Prefiks;
                    return;
                }
            }
            MessageBox.Show("Klub nije pronađen.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BrisanjeKluba_Click(object sender, EventArgs e)
        {
            foreach (Klub kl in _klubovi)
            {
                if (kl.Naziv == PretragaNazivKluba.Text)
                {
                    _klubovi.Remove(kl);
                    Izbrišiklub(kl);
                    MessageBox.Show("Klub uspješno obrisan.", "Brisanje uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Klub nije pronađen.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public bool Izbrišiklub(Klub klub)
        {
            try
            {
                using (OracleConnection oc = GetConnection())
                using (OracleCommand cmd = oc.CreateCommand())
                {
                    oc.Open();

                    string sqlDelete = "Delete from Klubovi Where naziv = :naziv";
                    cmd.CommandText = sqlDelete;

                    cmd.Parameters.Add(new OracleParameter("naziv", klub.Naziv));
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        Klub _klub;
        bool _klubPronadjen;
        private void PronalazakŽeljenogKluba_Click(object sender, EventArgs e)
        {
            _klubPronadjen = false;
            foreach (Klub kl in _klubovi)
            {
                if (kl.Naziv == UnosTekstaZaPretragu.Text)
                {
                    _klub = kl;
                    _klubovi.Remove(kl);
                    MessageBox.Show("Klub pronađen. Ispod možete izvršiti željene promjene.", "Pretraživanje uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _klubPronadjen = true;
                    return;
                }
            }
            _klubPronadjen = false;
            MessageBox.Show("Klub nije pronađen.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PotvrdaIzmjene_Click(object sender, EventArgs e)
        {
            if (_klubPronadjen == true)
            {
                if (PrOK.Checked) _klub.Prefiks = "OK";
                else if (PrMOK.Checked) _klub.Prefiks = "MOK";
                else if (PrŽOK.Checked) _klub.Prefiks = "ŽOK";
                else if (PrBOK.Checked) _klub.Prefiks = "BOK";
                else if (PrSOK.Checked) _klub.Prefiks = "SOK";
                else if (PrHOK.Checked) _klub.Prefiks = "HOK";
                if (IzmjenaNaziv.Text != "") _klub.Naziv = IzmjenaNaziv.Text;
                if (IzmjenaMjesto.Text != "") _klub.Mjesto = IzmjenaMjesto.Text;
                if (IzmjenaAdresa.Text != "") _klub.Adresa = IzmjenaAdresa.Text;
                if (IzmjenaTelefon.Text != "") _klub.Telefon = IzmjenaTelefon.Text;
                UpdateKlub(_klub);
                MessageBox.Show("Podaci o klubu uspješno izmijenjeni.", "Izmjena uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _klubPronadjen = false;
                _klubovi.Add(_klub);
            }
            else
            {
                MessageBox.Show("Nije pronađen klub za izmjenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PrBOK.Checked = false;
            PrOK.Checked = false;
            PrMOK.Checked = false;
            PrŽOK.Checked = false;
            PrSOK.Checked = false;
            PrHOK.Checked = false;
            IzmjenaAdresa.Text = "";
            IzmjenaMjesto.Text = "";
            IzmjenaNaziv.Text = "";
            IzmjenaTelefon.Text = "";
            UnosTekstaZaPretragu.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.osbih.ba/");
        }
        List<Liga> _lige = new List<Liga>();
        private void OrganizujLigu_Click(object sender, EventArgs e)
        {
            Liga l;
            if (FBiH.Checked == false && RS.Checked == false)
            {
                try
                {
                    if (NazivDržave.Text != "")
                    {
                        l = new PremLiga(
                            MuškaLiga.Checked,
                            AktivnaLiga.Checked,
                            NazivDržave.Text,
                            _kluboviULigi
                        );
                    }
                    else
                        throw (new DupliranjeException());
                }
                catch (DupliranjeException)
                {
                    MessageBox.Show("Greška pri kreiranju lige. Morate unijeti naziv države.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Greška pri kreiranju lige. Niste ispravno unijeli klubove.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                try
                {
                    l = new EntLiga(
                        MuškaLiga.Checked,
                        AktivnaLiga.Checked,
                        FBiH.Checked,
                        _kluboviULigi
                    );
                }
                catch (Exception)
                {
                    MessageBox.Show("Greška pri kreiranju lige. Niste ispravno unijeli klubove.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            _lige.Add(l);
            if (MessageBox.Show("Liga je uspješno dodata. Da li želite organizovati sezonu?", "Organizacija sezone", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                NazivDržave.Text = "";
                foreach(Klub k in _klubovi)
                    PrikazRegistriranihKlubova.Items.Add(k);
                return;
            }
            GeneriranjeRasporeda _os = new GeneriranjeRasporeda(l, _kluboviULigi);
            _os.ShowDialog();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacija je kreirana 2015. godine. Kreator: Selmir Hasanović", "O aplikaciji", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void restartujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrirajKlubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistracijaKluba.Show();
        }

        private void evidentirajLiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizacijaLige.Show();
        }

        private void pretražiKluboveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaBrisanje.Show();
        }

        private void izmijeniKlubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromjenaPodatakaOKlubu.Show();
        }

        private void snimiPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("klubovi.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, _klubovi);
                fs.Close();
                MessageBox.Show("Uspješno snimljeno u binarnu datoteku.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DodajNoviIzuzetak(ex.Message, DateTime.Now);
            }
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Klub>));
                FileStream fs = new FileStream("klubovi.xml", FileMode.Create);
                xs.Serialize(fs, _klubovi.ToList<Klub>());
                fs.Close();
                MessageBox.Show("Uspješno snimljeno u XML datoteku.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DodajNoviIzuzetak(ex.Message, DateTime.Now);
            }
        }

        private void restartujToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void zatvoriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacija je kreirana 2015. godine. Kreator: Selmir Hasanović.");
        }

        private void webStranicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.osbih.ba/");
        }
        public bool dozvoliPrikaz;
        private void button1_Click(object sender, EventArgs e)
        {
            DodatniPodaciOLigi dodatniPodaci = new DodatniPodaciOLigi(_kluboviULigi, out dozvoliPrikaz);
            if (dozvoliPrikaz)
            {
                dodatniPodaci.Show();
            }
        }
        BindingList<Klub> Klubovi = new BindingList<Klub>();
        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("klubovi.xml", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(Klubovi.GetType());
                Klubovi = serializer.Deserialize(fs) as BindingList<Klub>;
                fs.Close();
                PrikazKlubova _pk = new PrikazKlubova(Klubovi);
                _pk.ShowDialog();
            }
        }
        public bool KreirajTabeluKlubova()
        {
            try
            {
                using (OracleConnection oc = GetConnection())
                {
                    using (OracleCommand cmd = oc.CreateCommand())
                    {
                        oc.Open();
                        cmd.CommandText = "CREATE TABLE Klubovi(mjesto varchar[50], prefiks varchar(50), naziv varchar(50) PRIMARY KEY, adresa varchar[50], telefon varchar[50])";
                        int result = cmd.ExecuteNonQuery();
                        return true;
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        private void upišiKluboveUBazuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreirajTabeluKlubova();
            try
            {
                using (OracleConnection oc = GetConnection())
                    using (OracleCommand cmd = oc.CreateCommand())
                    {
                        oc.Open();
                        foreach(Klub k in _klubovi) {
                            string sqlInsert = "insert into Employee (mjesto, prefiks, naziv, adresa, telefon)";
                            sqlInsert += "values (:k.mjesto, :k.prefiks, :k.naziv, :k.adresa, :k.telefon)";
                            cmd.CommandText = sqlInsert;
                            cmd.ExecuteNonQuery();
                        }
                    }
            }
            catch (Exception)
            {
            }
        }

        public bool UpdateKlub(Klub klub)
        {
            try
            {
                using (OracleConnection oc = GetConnection())
                using (OracleCommand cmd = oc.CreateCommand())
                {
                    oc.Open();

                    string sqlUpdate = "Update Klubovi set mjesto =:mjesto, adresa=:adresa, prefiks=:prefiks, telefon=:telefon"
                                     + " where naziv=:naiv ";
                    cmd.CommandText = sqlUpdate;
                    cmd.Parameters.Add(new OracleParameter("mjesto", klub.Mjesto));
                    cmd.Parameters.Add(new OracleParameter("adresa", klub.Adresa));
                    cmd.Parameters.Add(new OracleParameter("prefiks", klub.Prefiks));
                    cmd.Parameters.Add(new OracleParameter("telefon", klub.Telefon));
                    cmd.Parameters.Add(new OracleParameter("naziv", klub.Naziv));

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void pregledKlubovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           BindingList<Klub> Klubovi = UčitajKlubove();
           PrikazKlubova _pk = new PrikazKlubova(Klubovi);
           _pk.ShowDialog();
        }
        public BindingList<Klub> UčitajKlubove()
        {
            BindingList<Klub> klubovi = new BindingList<Klub>();
            try
            {
                using (OracleConnection oc = GetConnection())
                using (OracleCommand cmd = oc.CreateCommand())
                {
                    oc.Open();

                    string sqlSelect = "SELECT * FROM Klubovi";
                    cmd.CommandText = sqlSelect;

                    OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            klubovi.Add(new Klub(false, true, false, false, false, false, reader["naziv"].ToString(),
                                reader["mjesto"].ToString(), reader["telefon"].ToString(), reader["adresa"].ToString()
                                ));
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return klubovi;
        }
        string host = "80.65.65.66",
        serviceName = "etflab.db.lab.etf.unsa.ba",
        userID = "SH16926",
        password = "b34o8mRs";
        public OracleConnection GetConnection()
        {
            try
            {
                OracleConnection dbConnection = new OracleConnection();
                dbConnection.ConnectionString = string.Format(
                    @"Data Source=
                        (DESCRIPTION =
                                (ADDRESS = (PROTOCOL = TCP)(HOST = {0})(PORT = 1521))
                                (CONNECT_DATA =
                                    (SERVER = DEDICATED)
                                    (SERVICE_NAME = {1})
                                )
                 );
            User Id= {2}; Password= {3}; Persist Security Info=True;",
                    host, serviceName, userID, password);
                return dbConnection;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool DodajNoviIzuzetak(string tekstIzuzetka, DateTime vrijemeDešavanja)
        {
            try
            {
                using (OracleConnection oc = GetConnection())
                using (OracleCommand cmd = oc.CreateCommand())
                {
                    oc.Open();
                    string sqlInsert = "insert into Izuzeci (ID, tekst, datum, vrijemeDešavanja)";
                    sqlInsert += "values (:ID, :tekstIzuzetka, :vrijemeDešavanja)";
                    cmd.CommandText = sqlInsert;

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void KreirajTabeluIzuzetaka()
        {
            try
            {
                using (OracleConnection oc = GetConnection())
                {
                    using (OracleCommand cmd = oc.CreateCommand())
                    {
                        oc.Open();
                        cmd.CommandText = "CREATE TABLE Izuzeci(ID int PRIMARY KEY, tekst varchar(50), vrijemeDešavanja DATE)";
                        int result = cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE SEQUENCE SequenceTest_Sequence START WITH 1 INCREMENT BY 1";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE OR REPLACE TRIGGER trigger_name BEFORE INSERT ON Izuzeci FOR EACH ROW BEGIN :new.ID := SequenceTest_Sequence.nextval;END;";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void startIStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Niti n = new Niti();
            n.ShowDialog();
        }
        private void Parsiraj()
        {
            List<string> prognoze = new List<string>();
            XmlTextReader reader = new XmlTextReader("VremenskaPrognoza.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Text:
                        if(new[] {"Mainly sunny", "Fog", "Variable cloudiness", "Rain", "Snow"}.Contains(reader.Value.Split(',')[0].Trim()))
                            prognoze.Add(reader.Value.Split(',')[0].Trim());
                        break;
                }
            }
            Prognoza pr = new Prognoza(prognoze);
            pr.ShowDialog();
        }
        private void sarajevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dokxml = dajIzvorniKod("http://rss.theweathernetwork.com/weather/bkxx0004");
            MessageBox.Show(dokxml);
            File.WriteAllText("VremenskaPrognoza.xml", dokxml);
            Thread t = new Thread(() => Parsiraj());
            t.Start();
        }
        String dajIzvorniKod(String url)
        {
            try
            {
                WebClient client = new WebClient();
                Byte[] source = client.DownloadData(url);
                String s = System.Text.Encoding.Default.GetString(source);
                return s;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return e.Message;
            }
        }
        static int brojac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (brojac == 0)
            {
                pictureBox1.Image = (Image)Image.FromFile(Application.StartupPath + "/Image1.png");
                brojac++;
            }

            else if (brojac == 1)
            {
                pictureBox1.Image = (Image)Image.FromFile(Application.StartupPath + "/Image2.png");
                brojac++;
            }

            else if (brojac == 2)
            {
                pictureBox1.Image = (Image)Image.FromFile(Application.StartupPath + "/Image3.png");
                brojac++;
            }

            else if (brojac == 3)
            {
                pictureBox1.Image = (Image)Image.FromFile(Application.StartupPath + "/Image5.png");
                brojac++;
            }

            else if (brojac == 4)
            {
                pictureBox1.Image = (Image)Image.FromFile(Application.StartupPath + "/Image6.png");
                brojac++;
                brojac = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Izvještaj izv = new Izvještaj(_klubovi);
            izv.ShowDialog();
        }
    }
}
