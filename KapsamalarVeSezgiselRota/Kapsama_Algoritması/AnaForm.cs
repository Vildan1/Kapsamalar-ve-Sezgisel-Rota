using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapsamalarVeSezgiselRota
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        
        public DataGridView matris2 = new DataGridView();  

        public DataGridView matris3 = new DataGridView(); 

        public RichTextBox rtb = new RichTextBox(); 

        public int islem_sayisi = 0; 

        private void AnaForm_Load(object sender, EventArgs e)
        {
            
            btn_olustur.Enabled = false;
            matris1.Visible = false;
            btn_islem_basla.Enabled = false;
            btn_ilerle.Enabled = false;
            this.AcceptButton = btn_olustur;            
        }
        public void matris_olustur(int satir,int sutun,int x,int y,DataGridView matris)
        {
            for (int i = 0; i < sutun; i++)
            {
                matris.Columns.Add((i+1).ToString() + "", (i + 1).ToString() + ""); 
                matris.Columns[i].Width = 30; 
                matris.Columns[i].Resizable = DataGridViewTriState.False; 
            }
            matris.Columns.Add("agirlik", "Ağırlık"); 
            matris.Columns["agirlik"].ReadOnly = true; 
            matris.Columns["agirlik"].Width = 50; 
            matris.Columns["agirlik"].Resizable = DataGridViewTriState.False; 
            matris.TopLeftHeaderCell.Value = "y\\x"; 

            for (int j = 0; j < satir; j++)
            {
                string[] alfabe = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z" };
                matris.Rows.Add(); 
                matris.Rows[j].Height = 20; 
                matris.Rows[j].HeaderCell.Value =alfabe[j]; 
                matris.Rows[j].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight; 
            }
            matris.Rows.Add(); 

            matris.RowHeadersWidth = 50;  
            matris.SelectionMode = DataGridViewSelectionMode.CellSelect; 
            matris.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            matris.MultiSelect = false; 
            matris.AllowUserToDeleteRows = false; 
            matris.AllowUserToResizeRows = false; 
            matris.AllowUserToAddRows = false; 
            matris.Size = new Size((30*sutun)+102,(20*satir)+51); 
            matris.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10);
            matris.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10);
            matris.DefaultCellStyle.Font=new System.Drawing.Font("Times New Roman", 10);
            matris.Location = new Point(x, y+10);            
            matris.Visible = true;                        
            this.Controls.Add(matris);                   
            matris.Enabled = true;
            matris.ClearSelection();
        }

        public void ilk_deger_ata(DataGridView matris)
        {
            int satir = matris.Rows.Count - 1;
            int sutun = matris.Columns.Count - 1;

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    matris.Rows[i].Cells[j].Value = 0;
                    matris.Rows[i].Cells[j].ReadOnly = true;
                }
            }
        }

        public void degerleri_aktar(DataGridView m1, DataGridView m2)
        {
            int satir = m1.Rows.Count - 1;
            int sutun = m1.Columns.Count - 1;

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    m2.Rows[i].Cells[j].Value = m1.Rows[i].Cells[j].Value;
                    m2.Rows[i].Cells[j].ReadOnly = true;
                }
            }
        }

        public void sadece_sutun_agirlik_hesapla(DataGridView matris)
        {
            int satir = matris.Rows.Count - 1; 
            int sutun = matris.Columns.Count - 1; 
            int toplam = 0;
            int i = 0;
            int j = 0;


            for (i = 0; i < sutun; i++)
            {
                for (j = 0; j < satir; j++)
                {                  
                    if (Convert.ToInt32(matris.Rows[j].Cells[i].Value) == 1) 
                    {
                        toplam++;  
                        matris.Rows[j].Cells[i].Style = new DataGridViewCellStyle { BackColor = Color.MediumPurple, ForeColor = Color.White }; 
                    }
                }
                matris.Rows[satir].Cells[i].ReadOnly = true; 
                matris.Rows[satir].Cells[i].Style = new DataGridViewCellStyle { BackColor = Color.DarkOrange, ForeColor = Color.White }; 
                matris.Rows[satir].Cells[i].Value = toplam; 
                toplam = 0;
            }
        }

        public void agirliklari_temizle(DataGridView matris)
        {
            int satir = matris.Rows.Count - 1;

            for (int i = 0; i < satir; i++)
            {
                matris.Rows[i].Cells["agirlik"].Value = null;
                matris.Rows[i].Cells["agirlik"].Style = new DataGridViewCellStyle { BackColor = Color.White , ForeColor = Color.Black };
            }
        }

        public void sadece_agirligi_en_dusuk_sutunlarin_satir_agirligini_hesapla(DataGridView matris)
        {
            int satir = matris.Rows.Count - 1; 
            int sutun = matris.Columns.Count - 1; 

            int ek = Convert.ToInt32(matris.Rows[satir].Cells[0].Value); 

            int [] sutun_dizisi = new int[sutun]; 

            double toplam = 0; 

            for (int i = 0; i < sutun; i++)
            {
                sutun_dizisi[i] = Convert.ToInt32(matris.Rows[satir].Cells[i].Value); 
                if (Convert.ToInt32(matris.Rows[satir].Cells[i].Value) < ek )
                {
                    ek = Convert.ToInt32(matris.Rows[satir].Cells[i].Value);
                }
            }
            for (int i = 0; i < sutun; i++)
            {
                if(Convert.ToInt32(matris.Rows[satir].Cells[i].Value) == ek) 
                {
                    matris.Rows[satir].Cells[i].Style = new DataGridViewCellStyle { BackColor = Color.Green, ForeColor = Color.White };
                    for (int j = 0; j < satir; j++) 
                    {
                        if(Convert.ToInt32(matris.Rows[j].Cells[i].Value) == 1) 
                        {
                            for (int a = 0; a < sutun; a++)
                            {
                                if(Convert.ToInt32(matris.Rows[j].Cells[a].Value) == 1)
                                {
                                    toplam = toplam + (1 / Convert.ToDouble(sutun_dizisi[a])); 
                                }
                            }
                            matris.Rows[j].Cells["agirlik"].Value = satir * toplam; 
                            matris.Rows[j].Cells["agirlik"].Style = new DataGridViewCellStyle { BackColor = Color.Green, ForeColor = Color.White };
                            toplam = 0; 
                            
                        }
                    }
                }
            }           
        }

        public int mutlak_satir_sutun_bul_ve_sil(DataGridView matris)
        {
            int satir = matris.Rows.Count - 1; 
            int sutun = matris.Columns.Count - 1; 

            int mutlak_satir = 0;  
            int mutlak_sutun = 0;  

            int bulundu = 0;

            for (int i = 0; i < sutun; i++)
            {
                if (Convert.ToInt32(matris.Rows[satir].Cells[i].Value) == 1) 
                {
                    mutlak_sutun = i; 
                    bulundu++; 
                    break;
                }
            }
            if (bulundu == 0) 
            {
                return 0; 
            }

            for (int i = 0; i < satir; i++)
            {
                if (Convert.ToInt32(matris.Rows[i].Cells[mutlak_sutun].Value) == 1) 
                {
                    mutlak_satir = i; 
                    break; 
                }
            }
            DataGridViewRow satir_adi = matris.Rows[mutlak_satir]; 

            if (matris == matris2)
            {
                lbl_kapsamalar.Text += satir_adi.HeaderCell.Value + " "; 
                islem_sayisi++; 
                rtb.Text += "\n" + islem_sayisi + " => " + satir_adi.HeaderCell.Value + " Mutlak satir olarak bulundu ve " + satir_adi.HeaderCell.Value + " satiri ve ";
            }

            for (int i = 0; i < matris.Columns.Count-1; i++)
            {
                if (Convert.ToInt32(matris.Rows[mutlak_satir].Cells[i].Value) == 1)
                {
                    string silinecek_sutun_adi = matris.Columns[i].Name; 
                    if(matris == matris2)
                    {
                        rtb.Text += " " + silinecek_sutun_adi + " , ";
                    }
                    matris.Columns.Remove(silinecek_sutun_adi); 
                    i = i - 1; 
                }
            }

            rtb.Text += "Sutunlari silindi.";
            matris.Rows.RemoveAt(mutlak_satir); 

            return 1; 
        }
 
        public struct enKucuk
        {
            public double deger;
            public int sira;
        };

        public void rota_algoritmasi_ile_sil(DataGridView matris)
        {
            int satir_sayisi = matris.Rows.Count - 1;
            double[] agirlik_degerleri = new double[satir_sayisi];

            enKucuk en_kucuk; 
            en_kucuk.deger = 0;
            en_kucuk.sira = 0;

            for (int i = 0; i < satir_sayisi; i++)
            {
                if (Convert.ToDouble(matris.Rows[i].Cells["agirlik"].Value) > 0)
                {
                    en_kucuk.deger = Convert.ToDouble(matris.Rows[i].Cells["agirlik"].Value);
                    en_kucuk.sira = i;
                    break;
                }
            }

            for (int i = 0; i < satir_sayisi; i++)
            {
                if (Convert.ToDouble(matris.Rows[i].Cells["agirlik"].Value) > 0.0 && Convert.ToDouble(matris.Rows[i].Cells["agirlik"].Value) < en_kucuk.deger)
                {
                    en_kucuk.deger = Convert.ToDouble(matris.Rows[i].Cells["agirlik"].Value);
                    en_kucuk.sira = i;
                }
            }

            DataGridViewRow silinecek_satir = matris.Rows[en_kucuk.sira]; 
            if(matris == matris2)
            {
                islem_sayisi++;
                rtb.Text += "\n" + islem_sayisi + " => Rota algoritmasına gore " + silinecek_satir.HeaderCell.Value + " satiri en dusuk agirlik degerine sahip oldugu icin silindi.\n";
            }

            matris.Rows.Remove(silinecek_satir); 

        }

        public int satir_kapsamalarina_gore_sil(DataGridView matris)
        {
            int satir = matris.Rows.Count - 1; 
            int sutun = matris.Columns.Count - 1; 
            int ust_kapsar = 0;
            int alt_kapsar = 0;

       
            int i = 0;
            int j = 0;
            int k = 0;
            for (i = 0; i < satir; i++)
            {
                for (j = i + 1; j < satir; j++)
                {
                    for (k = 0; k < sutun; k++)
                    {
                        if (Convert.ToInt32(matris.Rows[i].Cells[k].Value) == 1 && Convert.ToInt32(matris.Rows[j].Cells[k].Value) == 0)
                        {
                            ust_kapsar++; 
                            if (alt_kapsar > 0)    
                                break; 

                        }
                        else if (Convert.ToInt32(matris.Rows[j].Cells[k].Value) == 1 && Convert.ToInt32(matris.Rows[i].Cells[k].Value) == 1)
                        {
                        }
                        else if (Convert.ToInt32(matris.Rows[j].Cells[k].Value) == 1 && Convert.ToInt32(matris.Rows[i].Cells[k].Value) == 0)
                        {
                            alt_kapsar++; 
                            if (ust_kapsar > 0) 
                                break;                    
                        }
                    }
                    if (ust_kapsar > 0 && alt_kapsar == 0 || ust_kapsar == 0 && alt_kapsar == 0)
                    {
                        DataGridViewRow silinecek_satir = matris.Rows[j]; 
                        DataGridViewRow kapsayan_satir = matris.Rows[i];

                        if(matris == matris2) 
                        {
                            islem_sayisi++; 
                            rtb.Text += "\n" + islem_sayisi + " => Satir kapsamalarina gore " + kapsayan_satir.HeaderCell.Value + " satiri " + silinecek_satir.HeaderCell.Value + "satirini kapsadi ve " + silinecek_satir.HeaderCell.Value + " satiri silindi. \n";
                        }

                        matris.Rows.Remove(silinecek_satir); 

                        return 1; 
                    }
                    else if (alt_kapsar > 0 && ust_kapsar == 0)
                    {
                        DataGridViewRow silinecek_satir = matris.Rows[i]; 
                        DataGridViewRow kapsayan_satir = matris.Rows[j];

                        if (matris == matris2) 
                        {
                            islem_sayisi++; 
                            rtb.Text += "\n" + islem_sayisi + " => Satir kapsamalarina gore " + kapsayan_satir.HeaderCell.Value + " satiri " + silinecek_satir.HeaderCell.Value + " satirini kapsadi ve " + silinecek_satir.HeaderCell.Value + " satiri silindi. \n";
                        }

                        matris.Rows.Remove(silinecek_satir); 

                        return 1; 
                    }
                    else 
                    {
                        alt_kapsar = 0;
                        ust_kapsar = 0;
                    }
                    alt_kapsar = 0;
                    ust_kapsar = 0;
                }
            }
            return 0; 
        }

        public int sutun_kapsamalarina_gore_sil(DataGridView matris)
        {
            int satir = matris.Rows.Count - 1; 
            int sutun = matris.Columns.Count - 1; 
            int sol_kapsar = 0;
            int sag_kapsar = 0;

            for (int i = 0; i < sutun; i++)
            {
                for (int j = i + 1; j < sutun; j++)
                {
                    for (int k = 0; k < satir; k++)
                    {
                        if (Convert.ToInt32(matris.Rows[k].Cells[i].Value) == 1 && Convert.ToInt32(matris.Rows[k].Cells[j].Value) == 0)
                        {
                            sol_kapsar++; 
                            if (sag_kapsar > 0 || sol_kapsar > 1) 
                                break;                            
                        }
                        else if (Convert.ToInt32(matris.Rows[k].Cells[i].Value) == 1 && Convert.ToInt32(matris.Rows[k].Cells[j].Value) == 1)
                        {
                        }
                        else if (Convert.ToInt32(matris.Rows[k].Cells[j].Value) == 1 && Convert.ToInt32(matris.Rows[k].Cells[i].Value) == 0)
                        {
                            sag_kapsar++;
                            if (sol_kapsar > 0 || sag_kapsar > 1) 
                                break; 
                        }
                    }
                    if (sol_kapsar == 1 && sag_kapsar == 0)
                    {
                        string kapsanan_sutun_adi = matris.Columns[j].Name; 
                        string kapsayan_sutun_adi = matris.Columns[i].Name; 

                        if (matris == matris2)  
                        {
                            islem_sayisi++; 
                            rtb.Text += "\n" + islem_sayisi + " => Sutun kapsamalarina gore " + kapsayan_sutun_adi + " sutunu " + kapsanan_sutun_adi + " sutununu kapsadi ve 1 fazla degere sahip oldugu icin kapsayan " + kapsayan_sutun_adi + " sutunu silindi.\n";
                        }

                        matris.Columns.Remove(kapsayan_sutun_adi); 
                        return 1; 
                    }
                    else if (sag_kapsar == 1 && sol_kapsar == 0)
                    {
                        string kapsanan_sutun_adi = matris.Columns[i].Name; 
                        string kapsayan_sutun_adi = matris.Columns[j].Name; 

                        if (matris == matris2) 
                        {
                            islem_sayisi++; 
                            rtb.Text += "\n" + islem_sayisi + " => Sutun kapsamalarina gore " + kapsayan_sutun_adi + " sutunu " + kapsanan_sutun_adi + " sutununu kapsadi ve 1 fazla degere sahip oldugu icin kapsayan " + kapsayan_sutun_adi + " sutunu silindi.\n";
                        }

                        matris.Columns.Remove(kapsayan_sutun_adi); 

                        return 1; 
                    }
                    else 
                    {
                        sag_kapsar = 0; 
                        sol_kapsar = 0; 
                    }
                    sag_kapsar = 0; 
                    sol_kapsar = 0; 
                }
            }
            return 0; 
        }

        public void degersiz_satir_varsa_sil(DataGridView matris)
        {
            int satir_sayisi = matris.Rows.Count - 1;
            int sutun_sayisi = matris.Columns.Count - 1;
            int bulunan_sifir_sayisi = 0;

            for (int i = 0; i < satir_sayisi; i++)
            {
               for (int j = 0; j < sutun_sayisi; j++)
               {
                  if (Convert.ToInt32(matris.Rows[i].Cells[j].Value) != 0) 
                  {
                      break; 
                  }
                  else
                  {
                      bulunan_sifir_sayisi++; 
                  }
               }
               if (bulunan_sifir_sayisi == sutun_sayisi)
               {
                   DataGridViewRow silinecek_satir = matris.Rows[i]; 
                   matris.Rows.Remove(silinecek_satir); 
                   satir_sayisi--; 
                   i = i - 1; 
                   bulunan_sifir_sayisi = 0; 
               }
               bulunan_sifir_sayisi = 0; 
            }
           
        }
        public void degersiz_sutun_varsa_sil(DataGridView matris)
        {
            int satir_sayisi = matris.Rows.Count - 1;
            int sutun_sayisi = matris.Columns.Count - 1;
            int bulunan_sifir_sayisi = 0;

            for (int i = 0; i < sutun_sayisi; i++)
            {
                for (int j = 0; j < satir_sayisi; j++)
                {
                    if (Convert.ToInt32(matris.Rows[j].Cells[i].Value) != 0)
                    {
                        break; 
                    }
                    else
                    {
                        bulunan_sifir_sayisi++; 
                    }
                }
                if (bulunan_sifir_sayisi == satir_sayisi)
                {
                    string silinecek_sutun_adi = matris.Columns[i].Name; 
                    matris.Columns.Remove(silinecek_sutun_adi); 
                    sutun_sayisi--; 
                    i = i - 1; 
                    bulunan_sifir_sayisi = 0; 
                }
                bulunan_sifir_sayisi = 0; 
            }
        }

        public int islem_yap(DataGridView matris)
        {
            if ((matris.Rows.Count-1) < 1 || (matris.Columns.Count-1) < 1) 
            {
               if(matris == matris2)
               {
                    rtb.Text += "\n\n İŞLEM SONLANDI \n\n";
                    btn_ilerle.Visible = false;           
                }
               return 0; 
            }
            else 
            {
                degersiz_satir_varsa_sil(matris);
                degersiz_sutun_varsa_sil(matris);

                if (mutlak_satir_sutun_bul_ve_sil(matris) == 0)
                {
                    if (matris == matris2) rtb.Text += "\nMutlak sutun bulunamadi ";
                    if (satir_kapsamalarina_gore_sil(matris) == 0)
                    {
                        if (matris == matris2) rtb.Text += " , Kapsanan satir bulunamadi ";
                        if (sutun_kapsamalarina_gore_sil(matris) == 0)
                        {
                            if (matris == matris2) rtb.Text += " , Kapsanan sutun bulunamadi ";
                            sadece_sutun_agirlik_hesapla(matris);
                            sadece_agirligi_en_dusuk_sutunlarin_satir_agirligini_hesapla(matris); 
                            rota_algoritmasi_ile_sil(matris); 
                            sadece_sutun_agirlik_hesapla(matris); 
                            agirliklari_temizle(matris);

                            return 1; 
                        }
                        else
                        {
                            return 1; 
                        }
                    }
                    else
                    {
                        return 1; 
                    }
                }
                else
                {
                    return 1;
                }
            }
        }
        int text_bosmu_kontrol = 0;
 
        private void txt_satir_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus = Convert.ToInt32(e.KeyChar);
            if (!(basilantus >= 48 && basilantus <= 57 || basilantus == 8) || basilantus == 32)
            {
                e.Handled = true;
            }
            else
            {
                text_bosmu_kontrol++;
            }
        }
        private void txt_sutun_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus = Convert.ToInt32(e.KeyChar);
            if (!(basilantus >= 48 && basilantus <= 57 || basilantus == 8) || basilantus == 32)
            {
                e.Handled = true;
            }
            else
            {
                text_bosmu_kontrol++;
            }
            if (text_bosmu_kontrol == 2)
            {
                btn_olustur.Enabled = true;
            }
        }

        private void Btn_tekrar_baslatma_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Program Tekrar Başlatılıyor ", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
        private void btn_olustur_Click(object sender, EventArgs e)
        {
            int satir = Convert.ToInt32(txt_satir.Text);
            int sutun = Convert.ToInt32(txt_sutun.Text);

            matris_olustur(satir, sutun, 20, 80, matris1); 

            ilk_deger_ata(matris1); 
   
            grb_baslangic.Enabled = false;                
            txt_satir.Enabled = false;                    
            txt_sutun.Enabled = false;                    
            btn_olustur.Enabled = false;                  
            btn_islem_basla.Enabled = true;              
        }

        private void btn_islem_basla_Click(object sender, EventArgs e)
        {
            sadece_sutun_agirlik_hesapla(matris1); 

            int satir = matris1.Rows.Count - 1;
            int sutun = matris1.Columns.Count - 1;
            int x = matris1.Width; 
            matris_olustur(satir, sutun, x + 40, 80, matris2); 
            degerleri_aktar(matris1, matris2); 
            sadece_sutun_agirlik_hesapla(matris2); 
            matris2.BackgroundColor = Color.DarkSlateGray;
   
            rtb.Size = new Size ( 550 , 350 ); 
            rtb.Top = (matris1.Height) + 100; 
            rtb.Left = 20; 
            rtb.Text += islem_sayisi.ToString() +" => Islemlere baslandi \n"; 
          
            rtb.Visible = true; 
            rtb.ReadOnly = true; 
            this.Controls.Add(rtb); 

            btn_islem_basla.Enabled = false; 
            btn_ilerle.Enabled = true;  

            matris_olustur(satir, sutun, x+x+60, 80, matris3);
            degerleri_aktar(matris1, matris3); 
            sadece_sutun_agirlik_hesapla(matris3); 
            matris3.BackgroundColor = Color.DarkSlateGray;
            matris3.ReadOnly = true;
            islem_yap(matris2); 
            sadece_sutun_agirlik_hesapla(matris2); 
        }

        private void btn_ilerle_Click(object sender, EventArgs e)
        {
            if (islem_yap(matris2) == 1) 
            {
                sadece_sutun_agirlik_hesapla(matris2);
                islem_yap(matris1);
                sadece_sutun_agirlik_hesapla(matris1);
            }
        }
                
        private void matris1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            Int32 selectedCellCount = matris1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                for (int i = 0;i < selectedCellCount; i++)
                {
                    if (Convert.ToInt32(matris1.SelectedCells[i].Value) == 0)
                    {
                        matris1.SelectedCells[i].Value = 1;
                    }
                    else
                    {
                        matris1.SelectedCells[i].Value = 0;
                    }
                }
            }
        }
    }
}
