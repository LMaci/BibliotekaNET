using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaNET
{
    public partial class Form1 : Form
    {

        private BibliotekaEntities1 db = new BibliotekaEntities1();
        private Czytelnik aktualnyCzytelnik = new Czytelnik();
        private Ksiazka aktualnaKsiazka;
        private Autor aktualnyAutor;

        public Form1()
        {
            InitializeComponent();
            Odswiez();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet1.Ksiazka' table. You can move, or remove it, as needed.
            this.ksiazkaTableAdapter.Fill(this.bibliotekaDataSet1.Ksiazka);
            // TODO: This line of code loads data into the 'bibliotekaDataSet1.Czytelnik' table. You can move, or remove it, as needed.
            this.czytelnikTableAdapter.Fill(this.bibliotekaDataSet1.Czytelnik);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Wypozyczenie' table. You can move, or remove it, as needed.
            this.wypozyczenieTableAdapter.Fill(this.bibliotekaDataSet.Wypozyczenie);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Ksiazka' table. You can move, or remove it, as needed.
            this.ksiazkaTableAdapter.Fill(this.bibliotekaDataSet.Ksiazka);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Kategoria' table. You can move, or remove it, as needed.
            this.kategoriaTableAdapter.Fill(this.bibliotekaDataSet.Kategoria);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.Autor' table. You can move, or remove it, as needed.
            this.autorTableAdapter.Fill(this.bibliotekaDataSet.Autor);
            comboBox1.Text = null;
            comboBox2.Text = null;
            this.ksiazkaTableAdapter.FillByAutor(this.bibliotekaDataSet.Ksiazka, -1);
                this.wypozyczenieTableAdapter.FillByKsiazka(this.bibliotekaDataSet.Wypozyczenie, -1, -1);

        }

        public void Odswiez() // ODSWIEZ GRIDY
        {
            czytelnikBindingSource.DataSource = db.Czytelnik.ToArray();
            ksiazkaBindingSource.DataSource = db.Ksiazka.ToList();
            autorBindingSource.DataSource = db.Autor.ToList();
        }



        // -------------------------------------------------------------------------------
        // ----------------------------- C Z Y T E L N I K -------------------------------
        // -------------------------------------------------------------------------------
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) // INFO O CZYTELNIKU
        {

            aktualnyCzytelnik = czytelnikBindingSource.Current as Czytelnik;

            tbImie.Text = aktualnyCzytelnik.Imie;
            tbNazwisko.Text = aktualnyCzytelnik.Nazwisko;
            tbPesel.Text = aktualnyCzytelnik.PESEL;
            tbEmail.Text = aktualnyCzytelnik.Email;
            tbTelefon.Text = aktualnyCzytelnik.Telefon;

            try
            {
                this.ksiazkaTableAdapter.FillBy2(this.bibliotekaDataSet.Ksiazka, aktualnyCzytelnik.ID);
            }
            catch {}

                this.wypozyczenieTableAdapter.FillByKsiazka(this.bibliotekaDataSet.Wypozyczenie, int.Parse(listBox1.SelectedValue.ToString()), aktualnyCzytelnik.ID);
        }

        private void btAktualizuj_Click(object sender, EventArgs e) // AKTUALIZUJ CZYTELNIKA
        {
            if (!String.IsNullOrEmpty(tbImie.Text) && !String.IsNullOrEmpty(tbNazwisko.Text) && !String.IsNullOrEmpty(tbPesel.Text))
            {
                aktualnyCzytelnik.Imie = tbImie.Text;
                aktualnyCzytelnik.Nazwisko = tbNazwisko.Text;
                aktualnyCzytelnik.PESEL = tbPesel.Text;
                aktualnyCzytelnik.Email = tbEmail.Text;
                aktualnyCzytelnik.Telefon = tbTelefon.Text;

                db.SaveChanges();
                dataGridView1.Refresh();
            }
            else MessageBox.Show("Sprawdź poprawność danych");

        }

        private void btDodaj_Click(object sender, EventArgs e) // DODAJ CZYTELNIKA
        {
            if (!String.IsNullOrEmpty(tbImie.Text) && !String.IsNullOrEmpty(tbNazwisko.Text) && !String.IsNullOrEmpty(tbPesel.Text))
            {
                Czytelnik nowyCzytelnik = new Czytelnik();
                nowyCzytelnik.Imie = tbImie.Text;
                nowyCzytelnik.Nazwisko = tbNazwisko.Text;
                nowyCzytelnik.PESEL = tbPesel.Text;
                nowyCzytelnik.Email = tbEmail.Text;
                nowyCzytelnik.Telefon = tbTelefon.Text;
                db.Czytelnik.Add(nowyCzytelnik);

                db.SaveChanges();
                dataGridView1.Update();
                dataGridView1.Refresh();
                Odswiez();
            }
            else MessageBox.Show("Sprawdź poprawność danych");
        }

        private void button1_Click(object sender, EventArgs e) // USUN CZYTELNIKA
        {
            var usun = MessageBox.Show("Czy na pewno chcesz usunąć tego czytelnika?", "Potwierdź usunięcie", MessageBoxButtons.YesNo);

            if (usun == DialogResult.Yes)
            {
                try
                {
                    db.Czytelnik.Remove(aktualnyCzytelnik);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Niepoprawny wybór");
                }
                finally
                {
                    Odswiez();
                    aktualnyCzytelnik = null;
                    tbImie.Text = null;
                    tbNazwisko.Text = null;
                    tbPesel.Text = null;
                    tbEmail.Text = null;
                    tbTelefon.Text = null;
                }

            }
        }



        // -------------------------------------------------------------------------------
        // -------------------------------- K S I A Z K A  -------------------------------
        // -------------------------------------------------------------------------------
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) // WYSWIETL INFO O KSIAZCE
        {
            aktualnaKsiazka = ksiazkaBindingSource.Current as Ksiazka;

            aktualnyAutor = db.Autor.FirstOrDefault(x => x.ID == aktualnaKsiazka.Autor_ID);

            tbKSAutorImie.Text = aktualnyAutor.Imie;
            tbKSAutorNazwisko.Text = aktualnyAutor.Nazwisko;

            tbKSTytul.Text = aktualnaKsiazka.Tytul;
            comboBox2.SelectedIndex = (aktualnaKsiazka.Kategoria_ID) - 1;
            tbKSISBN.Text = aktualnaKsiazka.ISBN;
            tbKSOpis.Text = aktualnaKsiazka.Opis;
        }

        private void ksAktualizuj_Click(object sender, EventArgs e) // AKTUALIZUJ KSIAZKE
        {
            if (!String.IsNullOrEmpty(tbKSAutorImie.Text) && !String.IsNullOrEmpty(tbKSAutorNazwisko.Text) && !String.IsNullOrEmpty(tbKSTytul.Text) &&
                !String.IsNullOrEmpty(tbKSISBN.Text))
            {
                try
                {
                    aktualnyAutor = db.Autor.First(x => x.Imie == tbKSAutorImie.Text && x.Nazwisko == tbKSAutorNazwisko.Text);
                    aktualnyAutor.Imie = tbKSAutorImie.Text;
                    aktualnyAutor.Nazwisko = tbKSAutorNazwisko.Text;

                    aktualnaKsiazka.Autor_ID = aktualnyAutor.ID;

                    aktualnaKsiazka.Tytul = tbKSTytul.Text;
                    aktualnaKsiazka.Kategoria_ID = int.Parse(comboBox2.SelectedValue.ToString());
                    aktualnaKsiazka.ISBN = tbKSISBN.Text;
                    aktualnaKsiazka.Opis = tbKSOpis.Text;

                    db.SaveChanges();
                    dataGridView3.Refresh();
                }
                catch
                {
                    MessageBox.Show("Brak autora w bazie danych!");
                }
            }
        }

        private void ksDodaj_Click(object sender, EventArgs e) // DODAJ KSIAZKE
        {
            if (!String.IsNullOrEmpty(tbKSAutorImie.Text) && !String.IsNullOrEmpty(tbKSAutorNazwisko.Text) && !String.IsNullOrEmpty(tbKSTytul.Text) &&
                    !String.IsNullOrEmpty(tbKSISBN.Text))
            {
                try
                {
                    aktualnyAutor = db.Autor.First(x => x.Imie == tbKSAutorImie.Text && x.Nazwisko == tbKSAutorNazwisko.Text);
                    aktualnyAutor.Imie = tbKSAutorImie.Text;
                    aktualnyAutor.Nazwisko = tbKSAutorNazwisko.Text;

                    Ksiazka nowaKsiazka = new Ksiazka();
                    nowaKsiazka.Tytul = tbKSTytul.Text;
                    nowaKsiazka.Kategoria_ID = int.Parse(comboBox2.SelectedValue.ToString());
                    nowaKsiazka.ISBN = tbKSISBN.Text;
                    nowaKsiazka.Opis = tbKSOpis.Text;
                    nowaKsiazka.Autor_ID = aktualnyAutor.ID;

                    db.Ksiazka.Add(nowaKsiazka);

                    db.SaveChanges();
                    dataGridView3.Refresh();
                }
                catch
                {
                    var dodaj = MessageBox.Show("Brak autora w bazie danych! Dodać jako nowego?", "Brak autora!", MessageBoxButtons.YesNo);
                    if (dodaj == DialogResult.Yes)
                    {
                        Autor nowyAutor = new Autor();
                        nowyAutor.Imie = tbKSAutorImie.Text;
                        nowyAutor.Nazwisko = tbKSAutorNazwisko.Text;
                        db.Autor.Add(nowyAutor);

                        Ksiazka nowaKsiazka = new Ksiazka();
                        nowaKsiazka.Tytul = tbKSTytul.Text;
                        nowaKsiazka.Kategoria_ID = int.Parse(comboBox2.SelectedValue.ToString());
                        nowaKsiazka.ISBN = tbKSISBN.Text;
                        nowaKsiazka.Opis = tbKSOpis.Text;
                        nowaKsiazka.Autor_ID = nowyAutor.ID;

                        db.Ksiazka.Add(nowaKsiazka);

                        db.SaveChanges();
                        dataGridView3.Refresh();
                    }
                }
                finally { Odswiez(); CzyscPola(); }
            }
        }

        private void btKSUsun_Click(object sender, EventArgs e) // USUN KSIAZKE
        {
            var usun = MessageBox.Show("Czy na pewno chcesz usunąć książkę?", "Usuń książkę", MessageBoxButtons.YesNo);

            if (usun == DialogResult.Yes)
            {
                db.Ksiazka.Remove(aktualnaKsiazka);
                db.SaveChanges();
                Odswiez();

                CzyscPola();
            }
        }

        private void tbClear_Click(object sender, EventArgs e) // WYCZYSC POLA
        {
            CzyscPola();
        }

        public void CzyscPola()
        {
            aktualnaKsiazka = null;
            aktualnyAutor = null;
            tbKSAutorImie.Text = null;
            tbKSAutorNazwisko.Text = null;
            tbKSTytul.Text = null;
            comboBox2.Text = null;
            tbKSISBN.Text = null;
            tbKSOpis.Text = null;

            tbAUImie.Text = null;
            tbAUNazwisko.Text = null;
            tbAUTytul.Text = null;
            comboBox1.Text = null;
            tbAUISBN.Text = null;
            tbAUOpis.Text = null;
        }

        // -------------------------------------------------------------------------------
        // ---------------------------------- A U T O R ----------------------------------
        // -------------------------------------------------------------------------------
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) // WYSWIETL INFO O AUTORZE
        {
            aktualnyAutor = autorBindingSource.Current as Autor;
            tbAutorImie.Text = aktualnyAutor.Imie;
            tbAutorNazwisko.Text = aktualnyAutor.Nazwisko;

            this.ksiazkaTableAdapter.FillByAutor(this.bibliotekaDataSet.Ksiazka, aktualnyAutor.ID);
            Odswiez();

        }

        private void button3_Click(object sender, EventArgs e) // DODAJ AUTORA
        {
            Autor nowyAutor = new Autor();
            if (!String.IsNullOrEmpty(tbAutorImie.Text) && !String.IsNullOrEmpty(tbAutorNazwisko.Text))
            {
                nowyAutor.Imie = tbAutorImie.Text;
                nowyAutor.Nazwisko = tbAutorNazwisko.Text;
                db.Autor.Add(nowyAutor);
                db.SaveChanges();
                Odswiez();

                tbAutorImie.Text = null;
                tbAutorNazwisko.Text = null;
                Odswiez();
            }
            else MessageBox.Show("Uzupełnij brakujące dane!");
        }

        private void button2_Click(object sender, EventArgs e) // AKTUALIZUJ AUTORA
        {
            aktualnyAutor = autorBindingSource.Current as Autor;
            if (!String.IsNullOrEmpty(tbAutorImie.Text) && !String.IsNullOrEmpty(tbAutorNazwisko.Text))
            { 
                aktualnyAutor.Imie = tbAutorImie.Text;
                aktualnyAutor.Nazwisko = tbAutorNazwisko.Text;
                db.SaveChanges();
                Odswiez();
            }
            else MessageBox.Show("Uzupełnij brakujące dane!");
        }

        private void button4_Click(object sender, EventArgs e) // USUN AUTORA
        { 
            var usun = MessageBox.Show("Czy na pewno chcesz usunąć tego autora?", "Usuń autora", MessageBoxButtons.YesNo);
            if (usun == DialogResult.Yes)
            {
                aktualnyAutor = autorBindingSource.Current as Autor;
                var usunKsiazki = db.Ksiazka.Where(x => x.Autor_ID == aktualnyAutor.ID);
                db.Ksiazka.RemoveRange(usunKsiazki);
                db.SaveChanges();
                db.Autor.Remove(aktualnyAutor);
                db.SaveChanges();
                Odswiez();
                tbAutorImie.Text = null;
                tbAutorNazwisko.Text = null;
            }
        }



        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e) // FILTRUJ NA PODSTAWIE AUTORA
        {
            int index = dataGridView4.CurrentCell.RowIndex;
            int ksID = int.Parse(dataGridView4.Rows[index].Cells[3].Value.ToString());

            aktualnaKsiazka = db.Ksiazka.Single(x => x.ID == ksID);

            aktualnyAutor = db.Autor.FirstOrDefault(x => x.ID == aktualnaKsiazka.Autor_ID);

            tbAUImie.Text = aktualnyAutor.Imie;
            tbAUNazwisko.Text = aktualnyAutor.Nazwisko;

            tbAUTytul.Text = aktualnaKsiazka.Tytul;
            comboBox1.SelectedIndex = (aktualnaKsiazka.Kategoria_ID) - 1;
            tbAUISBN.Text = aktualnaKsiazka.ISBN;
            tbAUOpis.Text = aktualnaKsiazka.Opis;
        }

        private void button8_Click(object sender, EventArgs e) // DODAJ KSIAZKE
        {
            {
                if (!String.IsNullOrEmpty(tbAUImie.Text) && !String.IsNullOrEmpty(tbAUNazwisko.Text) && !String.IsNullOrEmpty(tbAUTytul.Text) &&
                        !String.IsNullOrEmpty(tbAUISBN.Text))
                {
                    try
                    {
                        aktualnyAutor = db.Autor.First(x => x.Imie == tbAUImie.Text && x.Nazwisko == tbAUNazwisko.Text);
                        aktualnyAutor.Imie = tbAUImie.Text;
                        aktualnyAutor.Nazwisko = tbAUNazwisko.Text;

                        Ksiazka nowaKsiazka = new Ksiazka();
                        nowaKsiazka.Tytul = tbAUTytul.Text;
                        nowaKsiazka.Kategoria_ID = int.Parse(comboBox2.SelectedValue.ToString());
                        nowaKsiazka.ISBN = tbAUISBN.Text;
                        nowaKsiazka.Opis = tbAUOpis.Text;
                        nowaKsiazka.Autor_ID = aktualnyAutor.ID;

                        db.Ksiazka.Add(nowaKsiazka);

                        db.SaveChanges();
                        dataGridView4.Refresh();
                        this.ksiazkaTableAdapter.FillByAutor(this.bibliotekaDataSet.Ksiazka, aktualnyAutor.ID);
                    }
                    catch
                    {
                        var dodaj = MessageBox.Show("Brak autora w bazie danych! Dodać jako nowego?", "Brak autora!", MessageBoxButtons.YesNo);
                        if (dodaj == DialogResult.Yes)
                        {
                            Autor nowyAutor = new Autor();
                            nowyAutor.Imie = tbAUImie.Text;
                            nowyAutor.Nazwisko = tbAUNazwisko.Text;
                            db.Autor.Add(nowyAutor);

                            Ksiazka nowaKsiazka1 = new Ksiazka();
                            nowaKsiazka1.Tytul = tbAUTytul.Text;
                            nowaKsiazka1.Kategoria_ID = int.Parse(comboBox2.SelectedValue.ToString());
                            nowaKsiazka1.ISBN = tbAUISBN.Text;
                            nowaKsiazka1.Opis = tbAUOpis.Text;
                            nowaKsiazka1.Autor_ID = nowyAutor.ID;

                            db.Ksiazka.Add(nowaKsiazka1);

                            db.SaveChanges();
                            dataGridView4.Refresh();
                            this.ksiazkaTableAdapter.FillByAutor(this.bibliotekaDataSet.Ksiazka, aktualnyAutor.ID);
                        }
                    }
                    finally { CzyscPola(); }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e) // USUN KSIAZKE
        {
            {
                var usun = MessageBox.Show("Czy na pewno chcesz usunąć książkę?", "Usuń książkę", MessageBoxButtons.YesNo);

                if (usun == DialogResult.Yes)
                {
                    db.Ksiazka.Remove(aktualnaKsiazka);
                    db.SaveChanges();

                    this.ksiazkaTableAdapter.FillByAutor(this.bibliotekaDataSet.Ksiazka, aktualnyAutor.ID);
                    CzyscPola();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAUImie.Text) && !String.IsNullOrEmpty(tbAUNazwisko.Text) && !String.IsNullOrEmpty(tbAUTytul.Text) &&
                    !String.IsNullOrEmpty(tbAUISBN.Text))
            {
                try
                {
                    aktualnyAutor = db.Autor.First(x => x.Imie == tbAUImie.Text && x.Nazwisko == tbAUNazwisko.Text);
                    aktualnyAutor.Imie = tbAUImie.Text;
                    aktualnyAutor.Nazwisko = tbAUNazwisko.Text;

                    aktualnaKsiazka.Autor_ID = aktualnyAutor.ID;

                    aktualnaKsiazka.Tytul = tbAUTytul.Text;
                    aktualnaKsiazka.Kategoria_ID = int.Parse(comboBox1.SelectedValue.ToString());
                    aktualnaKsiazka.ISBN = tbAUISBN.Text;
                    aktualnaKsiazka.Opis = tbAUOpis.Text;

                    db.SaveChanges();
                    dataGridView4.Refresh();
                    this.ksiazkaTableAdapter.FillByAutor(this.bibliotekaDataSet.Ksiazka, aktualnyAutor.ID);
                }
                catch
                {
                    MessageBox.Show("Brak autora w bazie danych!");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.wypozyczenieTableAdapter.FillByKsiazka(this.bibliotekaDataSet.Wypozyczenie, int.Parse(listBox1.SelectedValue.ToString()), aktualnyCzytelnik.ID);
            }
            catch {}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Wypozyczenie noweWypozyczenie = new Wypozyczenie();
            int iCz = dataGridView6.CurrentCell.RowIndex;
            int iKs = dataGridView7.CurrentCell.RowIndex; 

            noweWypozyczenie.Czytelnik_ID = int.Parse(dataGridView6.Rows[iCz].Cells[3].Value.ToString());
            noweWypozyczenie.Ksiazka_ID = int.Parse(dataGridView7.Rows[iKs].Cells[2].Value.ToString());
            noweWypozyczenie.Wydano = DateTime.Now;
            db.Wypozyczenie.Add(noweWypozyczenie);
            db.SaveChanges();
            lbImie.Text = null;
            lbNazwisko.Text = null;
            lbKsiazka.Text = null;
            MessageBox.Show("Wypożyczono książkę");

        }


        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iCz = dataGridView6.CurrentCell.RowIndex;
            
            lbImie.Text = dataGridView6.Rows[iCz].Cells[0].Value.ToString();
            lbNazwisko.Text = dataGridView6.Rows[iCz].Cells[1].Value.ToString();

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int iKs = dataGridView7.CurrentCell.RowIndex;
            lbKsiazka.Text = dataGridView7.Rows[iKs].Cells[0].Value.ToString();
        }

        private void dataGridView5_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            wypozyczenieBindingSource.EndEdit();
            db.SaveChanges();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int iOddaj = dataGridView5.CurrentCell.RowIndex;
            int id = int.Parse(dataGridView5.Rows[iOddaj].Cells[2].Value.ToString());
            Wypozyczenie oddaj;
            oddaj = db.Wypozyczenie.Single(x => x.ID == id);
            oddaj.Wydano = dtpOd.Value;
            oddaj.Zwrot = dtpDo.Value;

            db.SaveChanges();
                this.wypozyczenieTableAdapter.FillByKsiazka(this.bibliotekaDataSet.Wypozyczenie, int.Parse(listBox1.SelectedValue.ToString()), aktualnyCzytelnik.ID);

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iOddaj = dataGridView5.CurrentCell.RowIndex;
            dtpOd.Value = Convert.ToDateTime(dataGridView5.Rows[iOddaj].Cells[0].Value.ToString());
            try
            {
                dtpDo.Value = Convert.ToDateTime(dataGridView5.Rows[iOddaj].Cells[1].Value.ToString());
            }
            catch
            {
                dtpDo.Value = DateTime.Now;
            }
            

        }
    }
}
