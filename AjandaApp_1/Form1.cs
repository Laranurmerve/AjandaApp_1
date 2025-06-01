using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using System.Collections.Generic;

namespace AjandaApp_1
{
    public partial class Form1 : Form
    {
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNotlar_Click(object sender, EventArgs e)
        {

        }

        private string connectionString = ConfigurationManager.ConnectionStrings["AjandaDB"].ConnectionString;

        private List<int> _aramaSonucIndeksleri = new List<int>();
        private int _gecerliAramaIndeksi = -1;
        private DateTime? _sonArananTarih = null;

        public Form1()
        {
            InitializeComponent();
            NotlariYukle();
            lstNotlar.DrawItem += lstNotlar_DrawItem;
            txtAçıklama.TextChanged += txtAçıklama_TextChanged;
        }

        private void AramaDurumunuSifirla()
        {
            _sonArananTarih = null;
            _aramaSonucIndeksleri.Clear();
            _gecerliAramaIndeksi = -1;
        }

        private void NotlariYukle()
        {
            lstNotlar.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Baslik, Tarih FROM Notlar ORDER BY Tarih DESC", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string baslik = reader["Baslik"].ToString();
                        DateTime tarih = Convert.ToDateTime(reader["Tarih"]);
                        lstNotlar.Items.Add($"[{tarih:dd.MM.yyyy}] {baslik}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Notlar yüklenirken hata oluştu: " + ex.Message);
                }
            }
            AramaDurumunuSifirla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBaşlık.Text))
            {
                MessageBox.Show("Başlık boş olamaz!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sorgu = "INSERT INTO Notlar (Baslik, Açıklama, Tarih) VALUES (@baslik, @aciklama, @tarih)";
                    using (SqlCommand komut = new SqlCommand(sorgu, connection))
                    {
                        komut.Parameters.AddWithValue("@baslik", txtBaşlık.Text);
                        komut.Parameters.AddWithValue("@aciklama", txtAçıklama.Text);
                        komut.Parameters.AddWithValue("@tarih", dtpTarih.Value.Date);

                        int etkilenenSatir = komut.ExecuteNonQuery();

                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Not başarıyla kaydedildi!");
                            NotlariYukle();
                            Temizle();
                        }
                    }
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    MessageBox.Show("Bu başlık zaten kayıtlı!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void lstNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotlar.SelectedItem == null) return;

            string selectedTitle = lstNotlar.SelectedItem.ToString();
            int indexOfKapanis = selectedTitle.IndexOf("] ");
            if (indexOfKapanis == -1) return;

            string baslik = selectedTitle.Substring(indexOfKapanis + 2);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Baslik, Açıklama, Tarih FROM Notlar WHERE Baslik = @baslik", connection);
                    command.Parameters.AddWithValue("@baslik", baslik);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtBaşlık.Text = reader["Baslik"].ToString();
                            txtAçıklama.Text = reader["Açıklama"].ToString();
                            dtpTarih.Value = Convert.ToDateTime(reader["Tarih"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void Temizle()
        {
            txtBaşlık.Clear();
            txtAçıklama.Clear();
            dtpTarih.Value = DateTime.Now;
            lstNotlar.ClearSelected();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (lstNotlar.SelectedItem == null)
            {
                MessageBox.Show("Silinecek not seçiniz!");
                return;
            }

            if (MessageBox.Show("Seçili notu silmek istediğinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string selectedTitle = lstNotlar.SelectedItem.ToString();
                int indexOfKapanis = selectedTitle.IndexOf("] ");
                if (indexOfKapanis == -1)
                {
                    MessageBox.Show("Seçilen notun başlığı çözülemedi.");
                    return;
                }

                string baslik = selectedTitle.Substring(indexOfKapanis + 2);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM Notlar WHERE Baslik = @baslik", connection);
                        command.Parameters.AddWithValue("@baslik", baslik);

                        int etkilenenSatir = command.ExecuteNonQuery();

                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Not silindi!");
                            NotlariYukle();
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Silinecek not bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme işlemi sırasında hata: " + ex.Message);
                    }
                }
            }
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }

        private bool isFirstCharCapitalized = false;

        private void txtAçıklama_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAçıklama.Text))
            {
                isFirstCharCapitalized = false;
                return;
            }

            if (!isFirstCharCapitalized)
            {
                txtAçıklama.Text = char.ToUpper(txtAçıklama.Text[0]) + txtAçıklama.Text.Substring(1);
                txtAçıklama.SelectionStart = txtAçıklama.Text.Length;
                isFirstCharCapitalized = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstNotlar.SelectedItem == null)
            {
                MessageBox.Show("Güncellenecek notu listeden seçmelisin!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBaşlık.Text))
            {
                MessageBox.Show("Başlık boş olamaz!");
                return;
            }

            string selectedItem = lstNotlar.SelectedItem.ToString();
            int indexOfKapanis = selectedItem.IndexOf("] ");
            if (indexOfKapanis == -1)
            {
                MessageBox.Show("Seçilen notun başlığı çözülemedi.");
                return;
            }

            string eskiBaslik = selectedItem.Substring(indexOfKapanis + 2);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(
                        "UPDATE Notlar SET Baslik = @yeniBaslik, Açıklama = @aciklama, Tarih = @tarih WHERE Baslik = @eskiBaslik",
                        connection);

                    command.Parameters.AddWithValue("@yeniBaslik", txtBaşlık.Text);
                    command.Parameters.AddWithValue("@aciklama", txtAçıklama.Text);
                    command.Parameters.AddWithValue("@tarih", dtpTarih.Value.Date);
                    command.Parameters.AddWithValue("@eskiBaslik", eskiBaslik);

                    int etkilenenSatir = command.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Not başarıyla güncellendi!");
                        NotlariYukle();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız oldu. Not bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DateTime secilenTarih = dtpAramaTarihi.Value.Date;

            if (_sonArananTarih == null || _sonArananTarih.Value != secilenTarih)
            {
                _aramaSonucIndeksleri.Clear();
                _gecerliAramaIndeksi = -1;
                _sonArananTarih = secilenTarih;

                for (int i = 0; i < lstNotlar.Items.Count; i++)
                {
                    string itemText = lstNotlar.Items[i].ToString();
                    int basIndex = itemText.IndexOf('[') + 1;
                    int sonIndex = itemText.IndexOf(']');

                    if (basIndex > 0 && sonIndex > basIndex)
                    {
                        string tarihStr = itemText.Substring(basIndex, sonIndex - basIndex);
                        if (DateTime.TryParseExact(tarihStr, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime notTarihi))
                        {
                            if (notTarihi.Date == secilenTarih)
                            {
                                _aramaSonucIndeksleri.Add(i);
                            }
                        }
                    }
                }
            }

            if (_aramaSonucIndeksleri.Count > 0)
            {
                _gecerliAramaIndeksi++;
                if (_gecerliAramaIndeksi >= _aramaSonucIndeksleri.Count)
                {
                    _gecerliAramaIndeksi = 0;
                }
                lstNotlar.SelectedIndex = _aramaSonucIndeksleri[_gecerliAramaIndeksi];

                if (lstNotlar.Items.Count > 0 && _gecerliAramaIndeksi < lstNotlar.Items.Count)
                {
                    int itemsPerScreen = lstNotlar.ClientSize.Height / lstNotlar.ItemHeight;
                    lstNotlar.TopIndex = Math.Max(0, _aramaSonucIndeksleri[_gecerliAramaIndeksi] - (itemsPerScreen / 2));
                }
            }
            else
            {
                if (_gecerliAramaIndeksi == -1 && (_aramaSonucIndeksleri.Count == 0))
                {
                    MessageBox.Show("Bu tarihe ait not bulunamadı.", "Arama Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                lstNotlar.ClearSelected();
            }
        }

        private void lstNotlar_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lstNotlar.Items.Count)
                return;

            e.DrawBackground();

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color textColor = isSelected ? Color.White : Color.Black;
            Font textFont = new Font("Segoe UI", 10, FontStyle.Bold);

            string text = lstNotlar.Items[e.Index].ToString();
            string displayText = "• " + text;

            using (SolidBrush brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(displayText, textFont, brush, e.Bounds.Left + 5, e.Bounds.Top + 2);
            }
            textFont.Dispose();
            e.DrawFocusRectangle();
        }

        private void txtBaşlık_TextChanged(object sender, EventArgs e)
        {

        }
    }
}