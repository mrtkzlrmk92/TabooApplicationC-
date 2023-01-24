using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kelime = new string[21];
        string[,] yasak = new string[21, 3];
        Random rnd = new Random();
        int sayac = 0;
        int dogru = 0;
        int yanlıs = 0;
        int pas = 0;
        int aPuan = 0;
        int bPuan = 0;
        bool grup = true;
        bool basla = true;
        private void button1_Click(object sender, EventArgs e)
        {  
            
            if (basla == false)
            {
                timer1.Stop();
                button1.Text = "devam Et";
                basla = true;
            }
            else
            {
                timer1.Start();
                button1.Text = "durdur";
                basla = false;
            }
          
        

            kelime[0] = "HECE";
            kelime[1] = "KÜSMEK";
            kelime[2] = "AVİZE";
            kelime[3] = "KOORDİNAT";
            kelime[4] = "TERİM";
            kelime[5] = "SOYUT";
            kelime[6] = "BASKÜL";
            kelime[7] = "HALÜSİNASYON";
            kelime[8] = "ARMAĞAN";
            kelime[9] = "ANTİKA";
            kelime[10] = "ADEM ELMASI";

            kelime[11] = "SATRANÇ";
            kelime[12] = "PARAŞÜT";
            kelime[13] = "TİYATRO";
            kelime[14] = "DOST";
            kelime[15] = "ANAHTAR";
            kelime[16] = "KEDİ";
            kelime[17] = "BONKÖR";
            kelime[18] = "FİDAN";
            kelime[19] = "PRATİK";
            kelime[20] = "Mesai";



            yasak[0, 0] = "Kelime";
            yasak[0, 1] = "Harf";
            yasak[0, 2] = "Ses";

            yasak[1, 0] = "Darılmak";
            yasak[1, 1] = "Kızmak";
            yasak[1, 2] = "Tartışmak";

            yasak[2, 0] = "Lamba";
            yasak[2, 1] = "Kristal";
            yasak[2, 2] = "Tavan";

            yasak[3, 0] = "Yer";
            yasak[3, 1] = "Enlem";
            yasak[3, 2] = "Boylam";

            yasak[4, 0] = "Kelime";
            yasak[4, 1] = "Anlam";
            yasak[4, 2] = "Fatih";

            yasak[5, 0] = "Duyu";
            yasak[5, 1] = "Algılamak";
            yasak[5, 2] = "Görünmeyen";

            yasak[6, 0] = "Tartı";
            yasak[6, 1] = "Kilo";
            yasak[6, 2] = "Ağır";

            yasak[7, 0] = "Hayal";
            yasak[7, 1] = "Gerçek";
            yasak[7, 2] = "Görmek";

            yasak[8, 0] = "Hediye";
            yasak[8, 1] = "Vermek";
            yasak[8, 2] = "Almak";

            yasak[9, 0] = "Zengin";
            yasak[9, 1] = "Eski";
            yasak[9, 2] = "Tablo";

            yasak[10, 0] = "Erkek";
            yasak[10, 1] = "Gırtlak";
            yasak[10, 2] = "Çıkıntı";

            yasak[11, 0] = "Şah-Mat";
            yasak[11, 1] = "Vezir";
            yasak[11, 2] = "Piyon";

            yasak[12, 0] = "Uçak";
            yasak[12, 1] = "Atlamak";
            yasak[12, 2] = "Uçmak";

            yasak[13, 0] = "Oyuncu";
            yasak[13, 1] = "Sahne";
            yasak[13, 2] = "Perde";

            yasak[14, 0] = "Güven";
            yasak[14, 1] = "Samimi";
            yasak[14, 2] = "Dürüst";

            yasak[15, 0] = "Kilit";
            yasak[15, 1] = "Metal";
            yasak[15, 2] = "Kasa";

            yasak[16, 0] = "Pati";
            yasak[16, 1] = "Fare";
            yasak[16, 2] = "Tüy";

            yasak[17, 0] = "Eli Açık";
            yasak[17, 1] = "Cömert";
            yasak[17, 2] = "Para";

            yasak[18, 0] = "Ağaç";
            yasak[18, 1] = "Büyümek";
            yasak[18, 2] = "Küçük";

            yasak[19, 0] = "Kolay";
            yasak[19, 1] = "Zeka";
            yasak[19, 2] = "Çabuk";

            yasak[20, 0] = "saat";
            yasak[20, 1] = "iş";
            yasak[20, 2] = "Fazla";

            if (grup == true)
            {
                label9.Text = "A Grubu";
            }
            else
            {
                label9.Text = "B Grubu";
            }
            getir();
            
     



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 1;
            progressBar1.Value = sayac;
            label1.Text = sayac.ToString();

            if (sayac == 100)
            {
                timer1.Stop();
                basla = true;

                if (grup == true)
                {
                    aPuan += dogru - yanlıs;
                    MessageBox.Show("Süreniz doldu Doğru sayınız " + dogru + " yanlış sayınız " + yanlıs,"A Grubu");
                    MessageBox.Show("B grubuna geçilecektir" ,"Grunp Değişimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    grup = false;
                }
                else
                {
                    bPuan += dogru - yanlıs;
                    MessageBox.Show("Süreniz doldu Doğru sayınız " + dogru + " yanlış sayınız " + yanlıs, "B Grubu");
                    MessageBox.Show("A grubuna geçilecektir", "Grup Değişimi",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    grup = true;
                }
                dogru = 0;
                yanlıs = 0;
                label6.Text = dogru.ToString();
                label8.Text = yanlıs.ToString();
                button1.Text = "Devam Et";
                sayac = 0;
            
                
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {

            dogru++;
            label6.Text = dogru.ToString();
            getir();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yanlıs++;
            label8.Text = yanlıs.ToString();

            getir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getir();
        }
         void getir()
        {
            listBox1.Items.Clear();
            int no = rnd.Next(0, kelime.Length);
            textBox1.Text = kelime[no];
            for (int i = 0; i < 3; i++)
            {
                listBox1.Items.Add(yasak[no, i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (aPuan > bPuan)
            {
                MessageBox.Show($"kazanan A  grup puanı {aPuan} kaybeden b grup puanı {bPuan}", "Kazanan A Grubu");
                
            }
            else
            {
                MessageBox.Show($"kazanan B  grup puanı {bPuan} kaybeden A grup puanı {aPuan}", "Kazanan B Grubu");
            }
        }
           
    }
}
