using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Studentski_sistem___Filip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unosUniverziteta_Click(object sender, EventArgs e)
        {
            Unos_univerziteta uu = new Unos_univerziteta();
            if (uu.ShowDialog() == DialogResult.OK) {
                SqlConnection con = new SqlConnection(Konekcija.cnn);
                SqlCommand command = con.CreateCommand();
                command.CommandText = "Insert INTO Univerzitet(Ime_uni, Mesto) VALUES(@ime, @mesto)";
                command.Parameters.AddWithValue("@ime", uu.ime);
                command.Parameters.AddWithValue("@mesto", uu.mesto);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        private void unosProfesora_Click(object sender, EventArgs e)
        {
            Unos_profesora up = new Unos_profesora();
            if (up.ShowDialog() == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(Konekcija.cnn);
                SqlCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO Profesor (Sifra_prof, Ime, Prezime, Godiste) VALUES (@sifra, @ime, @prezime, @godiste)";
                command.Parameters.AddWithValue("@sifra", up.sifra);
                command.Parameters.AddWithValue("@ime", up.ime);
                command.Parameters.AddWithValue("@prezime", up.prezime);
                command.Parameters.AddWithValue("@godiste", up.godiste);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }

        }

        private void unosPredmeta_Click(object sender, EventArgs e)
        {
            Unos_predmeta upred = new Unos_predmeta();
            if (upred.ShowDialog() == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(Konekcija.cnn);
                SqlCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO Predmet (Sifra_pred, Sifra_prof, Fond_casova, Br_ECTS_bodova, Naziv, Nacin_polaganja, Br_semestra ) VALUES (@sifra_pred, @sifra_prof, @fond_casova, @br_ects_bodova, @naziv, @nacin_pol, @br_sem)";
                command.Parameters.AddWithValue("@sifra_pred", upred.sifPredmeta);
                command.Parameters.AddWithValue("@sifra_prof", upred.sifProfesora);
                command.Parameters.AddWithValue("@fond_casova", upred.fond);
                command.Parameters.AddWithValue("@br_ects_bodova", upred.brPoena);
                command.Parameters.AddWithValue("@naziv", upred.naziv);
                command.Parameters.AddWithValue("@nacin_pol", upred.nacinPolaganja);
                command.Parameters.AddWithValue("@br_sem", upred.brSemestara);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }

        }

        private void unosAsistenta_Click(object sender, EventArgs e)
        {
            Unos_asistenta uasistenta = new Unos_asistenta();
            if (uasistenta.ShowDialog() == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(Konekcija.cnn);
                SqlCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO Asistent (Sifra_Asist, Sifra_Prof, Ime, Prezime, Godiste) VALUES (@sifra_asis, @sifra_prof, @ime, @prezime, @godiste)";
                command.Parameters.AddWithValue("@sifra_asis", uasistenta.sifAsistenta);
                command.Parameters.AddWithValue("@sifra_prof", uasistenta.sifProfesora);
                command.Parameters.AddWithValue("@ime", uasistenta.ime);
                command.Parameters.AddWithValue("@prezime", uasistenta.prezime);
                command.Parameters.AddWithValue("@godiste", uasistenta.godiste);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        private void unosFakulteta_Click(object sender, EventArgs e)
        {
            Unos_fakulteta uFakulteta = new Unos_fakulteta();
            if (uFakulteta.ShowDialog() == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(Konekcija.cnn);
                SqlCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO Fakultet (Ime_fak, Ime_uni, Ulica, Telefon, E_mail, Status,Sifra_pred ) VALUES (@ime_fak, @ime_uni, @ulica, @telefon, @e_mail, @status,@spred)";
                command.Parameters.AddWithValue("@ime_fak", uFakulteta.imef);
                command.Parameters.AddWithValue("@Ime_uni", uFakulteta.IKF);
                command.Parameters.AddWithValue("@ulica", uFakulteta.ul);
                command.Parameters.AddWithValue("@telefon", uFakulteta.tel);
                command.Parameters.AddWithValue("@e_mail", uFakulteta.em);
                command.Parameters.AddWithValue("@status", uFakulteta.st);
                command.Parameters.AddWithValue("@spred", uFakulteta.sp);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        private void prikazUniverzitet_Click(object sender, EventArgs e)
        {
            Prikaz_univerziteta p_un = new Prikaz_univerziteta();
            p_un.ShowDialog();
        }

        private void prikazProfesora_Click(object sender, EventArgs e)
        {
            Prikaz_profesora p_pr = new Prikaz_profesora();
            p_pr.ShowDialog();
        }

        private void prikazPredmeta_Click(object sender, EventArgs e)
        {
            Prikaz_predmeta p_pred = new Prikaz_predmeta();
            p_pred.ShowDialog();
        }

        private void prikazAsistenta_Click(object sender, EventArgs e)
        {
            Prikaz_asistenta p_ast = new Prikaz_asistenta();
            p_ast.ShowDialog();
        }

        private void prikazFakulteta_Click(object sender, EventArgs e)
        {
            Prikaz_fakulteta p_fak = new Prikaz_fakulteta();
            p_fak.ShowDialog();
        }

        private void prikazProfesorovogAsistenta_Click(object sender, EventArgs e)
        {
            Prikazi_profesorovog_asistenta p_pro_asis = new Prikazi_profesorovog_asistenta();
            p_pro_asis.ShowDialog();
        }

        private void obrisiUniverzitet_Click(object sender, EventArgs e)
        {
            Obrisi_univerzitet ou = new Obrisi_univerzitet();
            if (ou.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(Konekcija.cnn);
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Fakultet SET Ime_uni=0 WHERE Ime_uni=@if", con);

                        cmd.Parameters.AddWithValue("@if", ou.IDU);
                        cmd.ExecuteNonQuery();

                        SqlCommand command = new SqlCommand("DELETE FROM " + " Univerzitet WHERE Ime_uni=@if ", con);

                        {
                            command.Parameters.AddWithValue("@if", ou.Naziv_uni);
                            command.ExecuteNonQuery();
                        }

                        con.Close();
                    }
                }

                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Doslo je do greske!: {0}", ex.Message));
                }
            }
        }

        private void obrisiProfesor_Click(object sender, EventArgs e)
        {
            Obrisi_profesora op = new Obrisi_profesora();
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(Konekcija.cnn);
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE Asistent SET Sifra_Prof=0 WHERE Sifra_Prof=@id", con);

                        cmd.Parameters.AddWithValue("@id", op.IDP);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("UPDATE Predmet SET Sifra_Prof=0 WHERE Sifra_Prof=@id", con);

                        cmd.Parameters.AddWithValue("@id", op.IDP);
                        cmd.ExecuteNonQuery();

                        SqlCommand command = new SqlCommand("DELETE FROM " + " Profesor WHERE Sifra_Prof=@id", con);

                        {
                            command.Parameters.AddWithValue("@id", op.IDP);
                            command.ExecuteNonQuery();
                        }

                        con.Close();
                    }
                }

                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Doslo je do greske!: {0}", ex.Message));
                }

            }
       }

        private void obrisiPredmet_Click(object sender, EventArgs e)
        {
            Obrisi_predmet o_pr = new Obrisi_predmet();
            if (o_pr.ShowDialog() == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(Konekcija.cnn);
                {

                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Fakultet SET Ime_fak=0 WHERE Sifra_pred=@na ", con);

                    cmd.Parameters.AddWithValue("@na", o_pr.OBP);
                    cmd.ExecuteNonQuery();

                    SqlCommand command = new SqlCommand("DELETE FROM " + " Predmet WHERE Naziv=@na or Nacin_polaganja=@np or Br_semestra=@bs", con);

                    {
                        command.Parameters.AddWithValue("@na", o_pr.Naziv_pred);
                        command.Parameters.AddWithValue("@np", o_pr.Nacin_pol);
                        command.Parameters.AddWithValue("@bs", o_pr.Broj_sem);

                        command.ExecuteNonQuery();
                    }

                    con.Close();

                }
            }
        }

        private void obrisiAsistent_Click(object sender, EventArgs e)
        {
            Obrisi_asistenta o_as = new Obrisi_asistenta();
            if (o_as.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(Konekcija.cnn);
                    {
                        con.Open();

                        SqlCommand command = new SqlCommand("DELETE FROM " + " Asistent WHERE Ime=@ia or Godiste=@god", con);

                        {
                            command.Parameters.AddWithValue("@ia", o_as.Ime_asist);
                            command.Parameters.AddWithValue("@god", o_as.Godiste);

                            command.ExecuteNonQuery();
                        }

                        con.Close();
                    }
                }

                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Doslo je do greske!: {0}", ex.Message));
                }
            }
        }

        private void obrisiFakultet_Click(object sender, EventArgs e)
        {
            Obrisi_fakultet o_fak = new Obrisi_fakultet();
            if (o_fak.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    SqlConnection con = new SqlConnection(Konekcija.cnn);
                    {
                        con.Open();

                        SqlCommand command = new SqlCommand("DELETE FROM " + " Fakultet WHERE Ime_fak=@if and Ime_fak=@id ", con);

                        {
                            command.Parameters.AddWithValue("@if", o_fak.Ime_fakulteta);
                            command.Parameters.AddWithValue("@id", o_fak.IK);

                            command.ExecuteNonQuery();
                        }

                        con.Close();
                    }
                }

                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Doslo je do greske!: {0}", ex.Message));
                }

            }
        }

        private void izmeniUniverzitet_Click(object sender, EventArgs e)
        {
            Izmeni_univerzitet izm_uni = new Izmeni_univerzitet();
            if (izm_uni.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(Konekcija.cnn);
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Fakultet SET Ime_uni=0 WHERE Ime_uni=@if", con);

                        cmd.Parameters.AddWithValue("@if", izm_uni.staro);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("UPDATE Univerzitet  SET Ime_uni = @iu, Mesto= @me WHERE Ime_uni=@staro", con);
                        cmd.Parameters.AddWithValue("@staro", izm_uni.staro);
                        cmd.Parameters.AddWithValue("@iu", izm_uni.Naziv);
                        cmd.Parameters.AddWithValue("@me", izm_uni.Mesto);

                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("UPDATE Fakultet SET Ime_uni=@novo WHERE Ime_uni=@iu", con);

                        cmd.Parameters.AddWithValue("@novo", izm_uni.Naziv);
                        cmd.Parameters.AddWithValue("@iu", "0");
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }

                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Doslo je do greske!: {0}", ex.Message));
                }
            }
        }

        private void izmeniProfesora_Click(object sender, EventArgs e)
        {
            Izmeni_profesora izm_prof = new Izmeni_profesora();
            if (izm_prof.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(Konekcija.cnn);
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE Profesor SET  Ime=@ip, Prezime=@pr, Godiste=@god where Prezime=@pr", con);
                        cmd.Parameters.AddWithValue("@ip", izm_prof.Naziv);
                        cmd.Parameters.AddWithValue("@pr", izm_prof.Prezime);
                        cmd.Parameters.AddWithValue("@god", izm_prof.Godiste);
                        
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Doslo je do greske!: {0}", ex.Message));
                }
            }
        }

        private void izmeniPredmet_Click(object sender, EventArgs e)
        {
            Izmeni_predmet izm_pred = new Izmeni_predmet();
            if (izm_pred.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(Konekcija.cnn);
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE Predmet SET Sifra_prof = @sprf, Fond_casova= @fond, Br_ECTS_bodova = @br_ects, Naziv = @naziv, Br_semestra = @br_sem, Nacin_polaganja = @na_pol WHERE Sifra_pred=@sp", con);

                        cmd.Parameters.AddWithValue("@sprf", izm_pred.Sifra_profesora);
                        cmd.Parameters.AddWithValue("@fond", izm_pred.Fond);
                        cmd.Parameters.AddWithValue("@br_ects", izm_pred.Broj_poena);
                        cmd.Parameters.AddWithValue("@naziv", izm_pred.Naziv);
                        cmd.Parameters.AddWithValue("@br_sem", izm_pred.Broj_semestra);
                        cmd.Parameters.AddWithValue("@na_pol", izm_pred.Nacin_polaganja);
                        cmd.Parameters.AddWithValue("@sp", izm_pred.Sifra_predmeta);

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Doslo je do greske!: {0}", ex.Message));
                }
            }
        }

        private void izmeniAsistent_Click(object sender, EventArgs e)
        {
            Izmeni_asistenta izm_ast = new Izmeni_asistenta();
            if (izm_ast.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(Konekcija.cnn);
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE Asistent SET Sifra_Prof = @sp, Prezime = @prez, Godiste = @god, Ime = @ime WHERE Sifra_Asist=@sa", con);

                        cmd.Parameters.AddWithValue("@sp", izm_ast.Sifra_profesora);
                        cmd.Parameters.AddWithValue("@prez", izm_ast.Prezime);
                        cmd.Parameters.AddWithValue("@god", izm_ast.Godiste);
                        cmd.Parameters.AddWithValue("@ime", izm_ast.Naziv);
                        cmd.Parameters.AddWithValue("@sa", izm_ast.Sifra_asistenta);

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Doslo je do greske!: {0}", ex.Message));
                }
            }
        }

        private void izmeniFakultet_Click(object sender, EventArgs e)
        {
            Izmeni_fakultet izm_fak = new Izmeni_fakultet();
            if (izm_fak.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SqlConnection con = new SqlConnection(Konekcija.cnn);
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE Fakultet SET Ime_fak=@if, Ime_uni= @iu, Ulica = @ulica, Telefon = @tel, Status = @status, E_mail = @mejl WHERE Ime_fak=@ifs", con);

                        cmd.Parameters.AddWithValue("@iu", izm_fak.Ime_uni);
                        cmd.Parameters.AddWithValue("@ulica", izm_fak.Ulica);
                        cmd.Parameters.AddWithValue("@tel", izm_fak.Telefon);
                        cmd.Parameters.AddWithValue("@status", izm_fak.Status);
                        cmd.Parameters.AddWithValue("@mejl", izm_fak.mejl);
                        cmd.Parameters.AddWithValue("@if", izm_fak.Ime_fak);
                        cmd.Parameters.AddWithValue("@ifs", izm_fak.staro);

                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Doslo je do greske!: {0}", ex.Message));
                }

            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

    }
}