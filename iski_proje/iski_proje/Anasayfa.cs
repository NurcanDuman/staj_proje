using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.IO;

namespace iski_proje
{
    public partial class Anasayfa : DevExpress.XtraEditors.XtraForm
    {
        MySqlConnection con = new MySqlConnection("SERVER = 127.0.0.1;Uid=root;pwd=123; Port=3306;database=cesme;SSL Mode=None;");
        MySqlCommand command = new MySqlCommand();
        public Anasayfa()
        {
            InitializeComponent();
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            string command = "SELECT cesme.id,cesme.ad,cesme.lat,cesme.lon,cesme.bilgi_aciklama,cesme.mimarin_adi,stil.stil,cesme.mimari_tip_id,cesme.yaptiran,cesme.hazne_sayisi," +
                "hazne_yapi_malzeme.hazne_yapi_malzeme,hazne_cati_tipi.cati_tip,hazne_cati_malzeme.hazne_cati_malzeme,fiziki_durum.durum,cesme.sebeke_suyu,cesme.kaynak_suyu,cesme.kaynak_suyu_membagi," +
                "cephe_orgu_malzeme.cephe_orgu_malzeme,cati_kaplama_malzeme.cati_kaplama_malzeme,cati_ortusu.ortu,bulundugu_alan.alan,konum.konum,cesme.cephe_sayisi,cesme.alinlik,cesme.silme," +
                "masrapalik.masrapalik,cesme.lule_sayisi,cesme.yalak_durumu,cesme.testilik,cesme.tugra,cesme.tugra_kime_ait," +
                "cesme.kemer,kemer_tip.tip,cesme.musluk,cesme.musluk_sayi,cesme.ayna_tasi,cesme.ayna_tasi_sayisi,ayna_tas_malzeme.ayna_tas_malzeme,cesme.cesmecik,cesme.cesmecik_sayi," +
                "cesme.kitabe_sayi,kitabe_malzeme.kitabe_malzeme,cesme.kitabe_tercume,cesme.diger_bilgiler,cesme.resim,sacak_ozellik.ozellik,yalak_malzeme.yalak_malzeme " +

                "FROM cesme LEFT JOIN stil on cesme.stil_id = stil.stil_id " +
                "LEFT JOIN ayna_tas_malzeme on cesme.ayna_tasi_malzeme_id = ayna_tas_malzeme.ayna_tas_malzeme_id " +
                "LEFT JOIN bulundugu_alan on cesme.bulundugu_alan_id = bulundugu_alan.bulundugu_alan_id " +
                "LEFT JOIN cati_kaplama_malzeme on cesme.cati_kaplama_id = cati_kaplama_malzeme.cati_kaplama_id " +
                "LEFT JOIN cati_ortusu on cesme.cati_ortu_id = cati_ortusu.cati_ortu_id " +
                "LEFT JOIN cephe_orgu_malzeme on cesme.cephe_orgu_malzeme_id = cephe_orgu_malzeme.cephe_orgu_malzeme_id " +
                "LEFT JOIN fiziki_durum on cesme.cesmenin_durumu_id = fiziki_durum.fiziki_durum_id " +
                "LEFT JOIN hazne_cati_malzeme on cesme.hazne_cati_malzeme_id = hazne_cati_malzeme.hazne_cati_malzeme_id " +
                "LEFT JOIN hazne_cati_tipi on cesme.hazne_cati_tipi_id = hazne_cati_tipi.hazne_cati_tip_id " +
                "LEFT JOIN hazne_yapi_malzeme on cesme.hazne_yapim_malzeme_id = hazne_yapi_malzeme.hazne_yapi_malzeme_id " +
                "LEFT JOIN kemer_tip on cesme.kemer_tip_id=kemer_tip.kemer_tip_id " +
                "LEFT JOIN kitabe_malzeme on cesme.kitabe_malzeme_id = kitabe_malzeme.kitabe_malzeme_id " +
                "LEFT JOIN konum on cesme.konumu_id = konum.konum_id " +
                "LEFT JOIN masrapalik on cesme.masrapalik_id = masrapalik.masrapalik_id " +
                "LEFT JOIN mimari_tipi on cesme.mimari_tip_id = mimari_tipi.mimari_tip_id " +
                "LEFT JOIN sacak_durum on cesme.sacak_durum_id = sacak_durum.sacak_durum_id " +
                "LEFT JOIN sacak_ozellik on cesme.sacak_ozellik_id = sacak_ozellik.sacak_ozellik_id " +
                "LEFT JOIN yalak_malzeme on cesme.yalak_malzeme_id = yalak_malzeme.yalak_malzeme_id";
                
            DataTable dt = new DataTable();
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            con.Close();
        }
        public void Ekle(string sorgu)
        {
            con.Open();
            command.Connection = con;
            command.CommandText = sorgu;

            command.Parameters.AddWithValue("@lat", txtLat.Text);
            command.Parameters.AddWithValue("@lon", txtLon.Text);
            command.Parameters.AddWithValue("@ad", txtCesmeAd.Text);
            command.Parameters.AddWithValue("@bilgi_aciklama", txtAciklama.Text);
            command.Parameters.AddWithValue("@mimarin_adi", txtMimarAd.Text);
            if (cmbStil.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@stil_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@stil_id", cmbStil.SelectedIndex);
            }

            if (cmbMimariTip.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@mimari_tip_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@mimari_tip_id", cmbMimariTip.SelectedIndex);
            }

            command.Parameters.AddWithValue("@yaptiran", txtYaptiran.Text);
            command.Parameters.AddWithValue("@hazne_sayisi", numericHazneSayisi.Text);

            if (cmbHazneYapiM.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@hazne_yapim_malzeme_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@hazne_yapim_malzeme_id", cmbHazneYapiM.SelectedIndex);
            }

            if (cmbHazneCatiTip.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@hazne_cati_tipi_id", null);
            }

            else
            {
                command.Parameters.AddWithValue("@hazne_cati_tipi_id", cmbHazneCatiTip.SelectedIndex);
            }

            if (cmbHazneCatiM.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@hazne_cati_malzeme_id", null);
            }

            else
            {
                command.Parameters.AddWithValue("@hazne_cati_malzeme_id", cmbHazneCatiM.SelectedIndex);
            }

            if (cmbFizikiDurum.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@cesmenin_durumu_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@cesmenin_durumu_id", cmbFizikiDurum.SelectedIndex);
            }
            command.Parameters.AddWithValue("@sebeke_suyu", cmbSebekeSuyu.SelectedIndex.ToString());
            command.Parameters.AddWithValue("@kaynak_suyu", cmbKaynakSuyu.SelectedIndex.ToString());
            command.Parameters.AddWithValue("@kaynak_suyu_membagi", txtKaynakMembagi.Text);

            if (cmbCepheOrguM.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@cephe_orgu_malzeme_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@cephe_orgu_malzeme_id", cmbCepheOrguM.SelectedIndex);
            }

            if (cmbCatiKaplama.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@cati_kaplama_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@cati_kaplama_id", cmbCatiKaplama.SelectedIndex);
            }

            if (cmbCatiOrtu.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@cati_ortu_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@cati_ortu_id", cmbCatiOrtu.SelectedIndex);
            }

            if (cmbSacakDurum.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@sacak_durum_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@sacak_durum_id", cmbSacakDurum.SelectedIndex);
            }

            if (cmbSacakOzellik.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@sacak_ozellik_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@sacak_ozellik_id", cmbSacakOzellik.SelectedIndex);
            }

            if (cmbBulunduguAlan.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@bulundugu_alan_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@bulundugu_alan_id", cmbBulunduguAlan.SelectedIndex);
            }

            if (cmbKonum.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@konumu_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@konumu_id", cmbKonum.SelectedIndex);
            }
            command.Parameters.AddWithValue("@cephe_sayisi", numericCephe.Text);
            command.Parameters.AddWithValue("@alinlik", cmbAlinlik.SelectedIndex.ToString());
            command.Parameters.AddWithValue("@silme", cmbSilme.SelectedIndex.ToString());

            if (cmbMasrapa.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@masrapalik_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@masrapalik_id", cmbMasrapa.SelectedIndex);
            }
            command.Parameters.AddWithValue("@lule_sayisi", numericLule.Text);
            command.Parameters.AddWithValue("@yalak_durumu", cmbYalakDurum.SelectedIndex.ToString());

            if (cmbYalakM.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@yalak_malzeme_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@yalak_malzeme_id", cmbYalakM.SelectedIndex);
            }
            command.Parameters.AddWithValue("@testilik", cmbTestilik.SelectedIndex.ToString());
            command.Parameters.AddWithValue("@tugra", cmbTugra.SelectedIndex.ToString());
            command.Parameters.AddWithValue("@tugra_kime_ait", txtTugraSahibi.Text);
            command.Parameters.AddWithValue("@kemer", cmbKemer.SelectedIndex.ToString());

            if (cmbKemerTip.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@kemer_tip_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@kemer_tip_id", cmbKemerTip.SelectedIndex);
            }
            command.Parameters.AddWithValue("@musluk", cmbMusluk.SelectedIndex.ToString());
            command.Parameters.AddWithValue("@musluk_sayi", numericMusluk.Text);
            command.Parameters.AddWithValue("@ayna_tasi", cmbAynaTasi.SelectedIndex.ToString());
            command.Parameters.AddWithValue("@ayna_tasi_sayisi", numericAynaTasi.Text);

            if (cmbAynaTasM.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@ayna_tasi_malzeme_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@ayna_tasi_malzeme_id", cmbAynaTasM.SelectedIndex);
            }
            command.Parameters.AddWithValue("@cesmecik", cmbCesmecik.SelectedIndex.ToString());
            command.Parameters.AddWithValue("@cesmecik_sayi", numericCesmecik.Text);
            command.Parameters.AddWithValue("@kitabe_sayi", numericKitabe.Text);

            if (cmbKitabeM.SelectedIndex == -1)
            {
                command.Parameters.AddWithValue("@kitabe_malzeme_id", null);
            }
            else
            {
                command.Parameters.AddWithValue("@kitabe_malzeme_id", cmbKitabeM.SelectedIndex);
            }
            con.Close();
            command.Parameters.AddWithValue("@kitabe_tercume", txtKitabeT.Text);
            command.Parameters.AddWithValue("@diger_bilgiler", txtDigerB.Text);
            command.Parameters.AddWithValue("@resim", Path.GetFileName(pb));

            command.ExecuteNonQuery();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Ekle("insert into cesme(lat, lon, ad, bilgi_aciklama, mimarin_adi, stil_id, mimari_tip_id, yaptiran, hazne_sayisi, hazne_yapim_malzeme_id, hazne_cati_tipi_id, hazne_cati_malzeme_id, " +
                        "cesmenin_durumu_id, sebeke_suyu, kaynak_suyu, kaynak_suyu_membagi, cephe_orgu_malzeme_id, cati_kaplama_id, cati_ortu_id, sacak_durum_id, sacak_ozellik_id, bulundugu_alan_id, " +
                        "konumu_id, cephe_sayisi, alinlik, silme, masrapalik_id, lule_sayisi, yalak_durumu, yalak_malzeme_id, testilik, tugra, tugra_kime_ait, kemer, kemer_tip_id, musluk, musluk_sayi, " +
                        "ayna_tasi, ayna_tasi_sayisi, ayna_tasi_malzeme_id, cesmecik, cesmecik_sayi, kitabe_sayi, kitabe_malzeme_id, kitabe_tercume, diger_bilgiler, resim)" +

                        "values(@lat, @lon, @ad, @bilgi_aciklama, @mimarin_adi, @stil_id, @mimari_tip_id, @yaptiran, @hazne_sayisi, @hazne_yapim_malzeme_id, @hazne_cati_tipi_id, @hazne_cati_malzeme_id, " +
                        "@cesmenin_durumu_id, @sebeke_suyu, kaynak_suyu, @kaynak_suyu_membagi, @cephe_orgu_malzeme_id, @cati_kaplama_id, @cati_ortu_id, @sacak_durum_id, @sacak_ozellik_id, @bulundugu_alan_id, " +
                        "@konumu_id, @cephe_sayisi, @alinlik, @silme, @masrapalik_id, @lule_sayisi, @yalak_durumu, @yalak_malzeme_id, @testilik, @tugra, @tugra_kime_ait, @kemer, @kemer_tip_id, @musluk, @musluk_sayi, " +
                        "@ayna_tasi, @ayna_tasi_sayisi, @ayna_tasi_malzeme_id, @cesmecik, @cesmecik_sayi, @kitabe_sayi, @kitabe_malzeme_id, @kitabe_tercume, @diger_bilgiler, @resim)");

                MessageBox.Show("Çeşme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Guncelle()
        {
            DialogResult onay = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (onay == DialogResult.Yes)
            {
                con.Open();
                string id = gridView1.GetFocusedRowCellValue("id").ToString();
                MySqlCommand cmd = new MySqlCommand("update cesme set lat='" + txtLat.Text + "',lon='" + txtLon.Text + "',ad='" + txtCesmeAd.Text + "',bilgi_aciklama='" + txtAciklama.Text +
                    "',mimarin_adi='" + txtMimarAd.Text + "',stil_id='" + cmbStil.Text + "',yaptiran='" + txtYaptiran.Text + "',hazne_sayisi='" + numericHazneSayisi.Text + "',mimari_tip_id='" + cmbMimariTip +
                    "',hazne_yapim_malzeme_id='" + cmbHazneYapiM.Text + "',hazne_cati_tipi_id='" + cmbHazneCatiTip.Text + "',hazne_cati_malzeme_id='" + cmbHazneCatiM.Text +
                    "',cesmenin_durumu_id='" + cmbFizikiDurum.Text + "',sebeke_suyu='" + cmbSebekeSuyu.SelectedIndex.ToString() + "',kaynak_suyu='" + cmbKaynakSuyu.SelectedIndex +
                    "',kaynak_suyu_membagi='" + txtKaynakMembagi.Text + "',cephe_orgu_malzeme_id='" + cmbCepheOrguM.Text + "',cati_kaplama_id='" + cmbCatiKaplama.Text +
                    "',cati_ortu_id='" + cmbCatiOrtu.Text + "',sacak_durum_id='" + cmbSacakDurum.Text + "',sacak_ozellik_id='" + cmbSacakOzellik + "',sacak_ozellik_id='" + cmbSacakOzellik.Text +
                    "',bulundugu_alan_id='" + cmbBulunduguAlan.Text +
                    "',konumu_id='" + cmbKonum.Text + "',cephe_sayisi='" + numericCephe.Text + "',alinlik='" + cmbAlinlik.SelectedIndex.ToString() + "',silme='" + cmbSilme.SelectedIndex.ToString() +
                    "',masrapalik_id='" + cmbMasrapa.Text + "',lule_sayisi='" + numericLule.Text + "',yalak_durumu='" + cmbYalakDurum.SelectedIndex.ToString() + "',yalak_malzeme_id='" + cmbYalakM.Text +
                    "',testilik='" + cmbTestilik.SelectedIndex.ToString() + "',tugra='" + cmbTugra.SelectedIndex.ToString() + "',tugra_kime_ait='" + txtTugraSahibi.Text +
                    "',kemer='" + cmbKemer.SelectedIndex.ToString() + "',kemer_tip_id='" + cmbKemerTip.Text + "',musluk='" + cmbMusluk.SelectedIndex.ToString() +
                    "',musluk_sayi='" + numericMusluk.Text + "',ayna_tasi='" + cmbAynaTasi.SelectedIndex.ToString() + "',ayna_tasi_sayisi='" + numericAynaTasi.Text + "',ayna_tasi_malzeme_id='" + cmbAynaTasM.Text +
                    "',cesmecik='" + cmbCesmecik.SelectedIndex.ToString() + "',cesmecik_sayi='" + numericCesmecik.Text + "',kitabe_sayi='" + numericKitabe.Text + "',kitabe_malzeme_id='" + cmbKitabeM.Text +
                    "',kitabe_tercume='" + txtKitabeT.Text + "',diger_bilgiler='" + txtDigerB.Text + "',resim='" + Path.GetFileName(pb) + "' where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Listele();
            }
            else
            {
                MessageBox.Show("Güncelleme işleminiz iptal edildi");
            }
        }
        
        public string pb;
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*jpg;*png;*nef | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyaYolu = dosya.FileName;
            pb = "C:\\Users\\nurca\\source\\repos\\iski_proje\\iski_proje\\Resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyaYolu, pb);
            pictureBox1.ImageLocation = pb;
        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
            Listele();
            Temizle();
        }
        private void Sil()
        {
            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (onay == DialogResult.Yes)
            {
                con.Open();
                string id = gridView1.GetFocusedRowCellValue("id").ToString();
                MySqlCommand cmd = new MySqlCommand("delete from cesme where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Silme işlemi gerçekleştirildi");
            }
            else
            {
                MessageBox.Show("Silme işleminiz iptal edildi");
            }
        }
        
        private void Temizle()
        {
            txtLat.Text = " ";
            txtLon.Text = " ";
            txtCesmeAd.Text = " ";
            txtMimarAd.Text = " ";
            cmbStil.Text = " ";
            cmbMimariTip.Text = " ";
            txtYaptiran.Text = " ";
            numericHazneSayisi.Text = "0";
            cmbHazneYapiM.Text = " ";
            cmbHazneCatiTip.Text = " ";
            cmbHazneCatiM.Text = " ";
            cmbFizikiDurum.Text = " ";
            cmbSebekeSuyu.Text = " ";
            cmbKaynakSuyu.Text = " ";
            txtKaynakMembagi.Text = " ";
            cmbCepheOrguM.Text = " ";
            cmbCatiKaplama.Text = " ";
            cmbCatiOrtu.Text = " ";
            cmbSacakDurum.Text = " ";
            cmbSacakOzellik.Text = " ";
            cmbBulunduguAlan.Text = " ";
            cmbKonum.Text = " ";
            numericCephe.Text = "0";
            cmbAlinlik.Text = " ";
            cmbSilme.Text = " ";
            cmbMasrapa.Text = " ";
            numericLule.Text ="0";
            cmbYalakDurum.Text = " ";
            cmbTugra.Text = " ";
            cmbTestilik.Text = " ";
            cmbKemer.Text = " ";
            cmbKemerTip.Text = " ";
            cmbMusluk.Text = " ";
            numericMusluk.Text = "0";
            cmbAynaTasi.Text = " ";
            numericAynaTasi.Text = " ";
            cmbAynaTasM.Text = " ";
            cmbCesmecik.Text = " ";
            numericCesmecik.Text = "0";
            numericKitabe.Text = "0";
            cmbKitabeM.Text = " ";
            txtKitabeT.Text = " ";
            txtDigerB.Text = " ";
            txtAciklama.Text = " ";
            pictureBox1.ImageLocation = " ";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
            Temizle();
            Listele();
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtLat.Text = gridView1.GetFocusedRowCellValue("lat").ToString();
            txtLon.Text = gridView1.GetFocusedRowCellValue("lon").ToString();
            txtCesmeAd.Text = gridView1.GetFocusedRowCellValue("ad").ToString();
            txtMimarAd.Text = gridView1.GetFocusedRowCellValue("mimarin_adi").ToString();
            cmbStil.Text = gridView1.GetFocusedRowCellValue("stil").ToString();
            cmbMimariTip.Text = gridView1.GetFocusedRowCellValue("mimari_tip_id").ToString();
            txtYaptiran.Text = gridView1.GetFocusedRowCellValue("yaptiran").ToString();
            numericHazneSayisi.Text = gridView1.GetFocusedRowCellValue("hazne_sayisi").ToString();
            cmbHazneYapiM.Text = gridView1.GetFocusedRowCellValue("hazne_yapi_malzeme").ToString();
            cmbHazneCatiTip.Text = gridView1.GetFocusedRowCellValue("cati_tip").ToString();
            cmbHazneCatiM.Text = gridView1.GetFocusedRowCellValue("hazne_cati_malzeme").ToString();
            cmbFizikiDurum.Text = gridView1.GetFocusedRowCellValue("durum").ToString();
            
            if (gridView1.GetFocusedRowCellValue("sebeke_suyu").ToString() == "True") cmbSebekeSuyu.Text = "Var";
            
            else cmbSebekeSuyu.Text = "Yok";

            if (gridView1.GetFocusedRowCellValue("kaynak_suyu").ToString() == "True") cmbKaynakSuyu.Text = "Var";
            
            else cmbKaynakSuyu.Text = "Yok";

            txtKaynakMembagi.Text = gridView1.GetFocusedRowCellValue("kaynak_suyu_membagi").ToString();
            cmbCepheOrguM.Text = gridView1.GetFocusedRowCellValue("cephe_orgu_malzeme").ToString();
            cmbCatiKaplama.Text = gridView1.GetFocusedRowCellValue("cati_kaplama_malzeme").ToString();
            cmbCatiOrtu.Text = gridView1.GetFocusedRowCellValue("ortu").ToString();
            cmbSacakDurum.Text = gridView1.GetFocusedRowCellValue("durum").ToString();
            cmbSacakOzellik.Text = gridView1.GetFocusedRowCellValue("ozellik").ToString();
            cmbBulunduguAlan.Text = gridView1.GetFocusedRowCellValue("alan").ToString();
            cmbKonum.Text = gridView1.GetFocusedRowCellValue("konum").ToString();
            numericCephe.Text = gridView1.GetFocusedRowCellValue("cephe_sayisi").ToString();
            
            if (gridView1.GetFocusedRowCellValue("alinlik").ToString() == "True") cmbAlinlik.Text = "Var";
            
            else cmbAlinlik.Text = "Yok";

            if (gridView1.GetFocusedRowCellValue("silme").ToString() == "True") cmbSilme.Text = "Var";
            
            else cmbSilme.Text = "Yok";

            cmbMasrapa.Text = gridView1.GetFocusedRowCellValue("masrapalik").ToString();
            numericLule.Text = gridView1.GetFocusedRowCellValue("lule_sayisi").ToString();

            if (gridView1.GetFocusedRowCellValue("yalak_durumu").ToString() == "True") cmbYalakDurum.Text = "Var";
            
            else cmbYalakDurum.Text = "Yok";

            cmbYalakM.Text = gridView1.GetFocusedRowCellValue("yalak_malzeme").ToString();
            if (gridView1.GetFocusedRowCellValue("tugra").ToString().ToString() == "True")
            {
                cmbTugra.Text = "Var";
            }
            else
            {
                cmbTugra.Text = "Yok";
            }

            if (gridView1.GetFocusedRowCellValue("testilik").ToString() == "True")
            {
                cmbTestilik.Text = "Var";
            }
            else
            {
                cmbTestilik.Text = "Yok";
            }

            txtTugraSahibi.Text = gridView1.GetFocusedRowCellValue("tugra_kime_ait").ToString();

            if (gridView1.GetFocusedRowCellValue("kemer").ToString() == "True")
            {
                cmbKemer.Text = "Var";
            }
            else
            {
                cmbKemer.Text = "Yok";
            }

            cmbKemerTip.Text = gridView1.GetFocusedRowCellValue("tip").ToString();
            
            if (gridView1.GetFocusedRowCellValue("musluk").ToString() == "True")
            {
                cmbMusluk.Text = "Var";
            }
            else
            {
                cmbMusluk.Text = "Yok";
            }

            numericMusluk.Text = gridView1.GetFocusedRowCellValue("musluk_sayi").ToString();

            if (gridView1.GetFocusedRowCellValue("ayna_tasi").ToString() == "True")
            {
                cmbAynaTasi.Text = "Var";
            }
            else
            {
                cmbAynaTasi.Text = "Yok";
            }

            numericAynaTasi.Text = gridView1.GetFocusedRowCellValue("ayna_tasi_sayisi").ToString();
            cmbAynaTasM.Text = gridView1.GetFocusedRowCellValue("ayna_tas_malzeme").ToString();

            if (gridView1.GetFocusedRowCellValue("cesmecik").ToString() == "True")
            {
                cmbCesmecik.Text = "Var";
            }
            else
            {
                cmbCesmecik.Text = "Yok";
            }

            numericCesmecik.Text = gridView1.GetFocusedRowCellValue("cesmecik_sayi").ToString();
            numericKitabe.Text = gridView1.GetFocusedRowCellValue("kitabe_sayi").ToString();
            cmbKitabeM.Text = gridView1.GetFocusedRowCellValue("kitabe_malzeme").ToString();
            txtKitabeT.Text = gridView1.GetFocusedRowCellValue("kitabe_tercume").ToString();
            txtDigerB.Text = gridView1.GetFocusedRowCellValue("diger_bilgiler").ToString();
            txtAciklama.Text = gridView1.GetFocusedRowCellValue("bilgi_aciklama").ToString();
            pb = "C:\\Users\\nurca\\source\\repos\\iski_proje\\iski_proje\\Resimler\\" + gridView1.GetFocusedRowCellValue("resim").ToString();
            pictureBox1.ImageLocation = pb;
        }

        private void cmbTugra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTugra.SelectedIndex == 1)
            {
                txtTugraSahibi.Visible = true;
                label38.Visible = true;
            }

            else
            {
                txtTugraSahibi.Visible = false;
                label38.Visible = false;
            }
        }

        private void cmbYalakDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYalakDurum.SelectedIndex == 1)
            {
                cmbYalakM.Visible = true;
                label41.Visible = true;
            }

            else
            {
                cmbYalakM.Visible = false;
                label41.Visible = false;
            }
        }

        private void cmbKemer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKemer.SelectedIndex == 1)
            {
                cmbKemerTip.Visible = true;
                label36.Visible = true;
            }

            else
            {
                cmbKemerTip.Visible = false;
                label36.Visible = false;
            }
        }

        private void cmbMusluk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusluk.SelectedIndex == 1)
            {
                numericMusluk.Visible = true;
                label34.Visible = true;
            }

            else
            {
                numericMusluk.Visible = false;
                label34.Visible = false;
            }
        }

        private void cmbAynaTasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAynaTasi.SelectedIndex == 1)
            {
                numericAynaTasi.Visible = true;
                cmbAynaTasM.Visible = true;
                label23.Visible = true;
                label32.Visible = true;
            }

            else
            {
                numericAynaTasi.Visible = false;
                cmbAynaTasM.Visible = false;
                label23.Visible = false;
                label32.Visible = false;
            }
        }

        private void cmbCesmecik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCesmecik.SelectedIndex == 1)
            {
                numericCesmecik.Visible = true;
                label21.Visible = true;
            }

            else
            {
                numericCesmecik.Visible = false;
                label21.Visible = false;
            }
        }

        private void cmbKaynakSuyu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKaynakSuyu.SelectedIndex == 1)
            {
                txtKaynakMembagi.Visible = true;
                label16.Visible = true;
            }

            else
            {
                txtKaynakMembagi.Visible = false;
                label16.Visible = false;
            }
        }

    }
}