using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            BtnA.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnA.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                            break;
                    case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            BtnB.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "Cuma")
                        {
                            BtnC.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnC.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        
                    case 4:
                        if (textBox1.Text == "Diyarbakır")
                        {
                            BtnD.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnD.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "Eski")
                        {
                            BtnE.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnE.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "Ferman")
                        {
                            BtnF.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnF.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "Güneş")
                        {
                            BtnG.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnG.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Bursa")
                        {
                            BtnH.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnH.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    case 9:
                        if (textBox1.Text == "Bursa")
                        {
                            BtnI.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnI.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    case 10:
                        if (textBox1.Text == "Bursa")
                        {
                            Btnİİ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            Btnİİ.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    case 11:
                        if (textBox1.Text == "Bursa")
                        {
                            BtnJ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnJ.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    case 12:
                        if (textBox1.Text == "Bursa")
                        {
                            BtnK.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            BtnK.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki Soru";
            soruNo++;
            this.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richtextbox1.Text = "Ülkemizin Güney Kısmındaki Kıyı Bölgesi?";
                BtnA.BackColor = Color.Yellow;
                button25.Text = "A";
            }

            if (soruNo == 2)
            {
                richtextbox1.Text = "Yeşilliği ile ünlü Marmara İlimiz ?";
                BtnB.BackColor = Color.Yellow;
                button25.Text = "B";
            }

            if (soruNo == 3)
            {
                richtextbox1.Text = "Müslümanlanların kutsal günü ?";
                BtnC.BackColor = Color.Yellow;
                button25.Text = "C";
            }
            if (soruNo == 4)
            {
                richtextbox1.Text = "Karpuzu ile ünlü ilimiz ?";
                BtnD.BackColor = Color.Green;
                button25.Text = "D";
            }
            if (soruNo == 5)
            {
                richtextbox1.Text = "Yeni kelimesinin zıt anlamlısı = ?";
                BtnE.BackColor = Color.Green;
                button25.Text = "E";
            }
            if (soruNo == 6)
            {
                richtextbox1.Text = "Padişah Fermanın Yazılı Haline ne denir ?";
                BtnF.BackColor = Color.Green;
                button25.Text = "F";
            }
            if (soruNo == 7)
            {
                richtextbox1.Text = "Dünyanın Isı Kaynağı ?";
                BtnG.BackColor = Color.Green;
                button25.Text = "G";
            }
            if (soruNo == 8)
            {
                richtextbox1.Text = "Öğrencilerin kötü karne getirince baktığı eşya ?";
                BtnH.BackColor = Color.Green;
                button25.Text = "H";
            }
            if (soruNo == 9)
            {
                richtextbox1.Text = "Gülüyle Ünlü İlimiz ?";
                BtnI.BackColor = Color.Yellow;
                button25.Text = "I";
            }
            if (soruNo == 10)
            {
                richtextbox1.Text = "Mersin'in diğer adı ?";
                Btnİİ.BackColor = Color.Yellow;
                button25.Text = "İ";
            }
            if (soruNo == 11)
            {
                richtextbox1.Text = "Askeri bir Topluluk?";
                BtnJ.BackColor = Color.Yellow;
                button25.Text = "J";
            }
            if (soruNo == 12)
            {
                richtextbox1.Text = "Malatyanın Meşhur Meyvesi ?";
                BtnK.BackColor = Color.Yellow;
                button25.Text = "K";
            }
            if (soruNo == 13)
            {
                richtextbox1.Text = "Her yıl bahar aylarında düzenlenen çiçek festivali?";
                BtnL.BackColor = Color.Yellow;
                button25.Text = "L";
            }
            if (soruNo == 14)
            {
                richtextbox1.Text = "Yılın Üçüncü Ayı Nedir ?";
                BtnM.BackColor = Color.Yellow;
                button25.Text = "M";
            }
            if (soruNo == 15)
            {
                richtextbox1.Text = "Üflemeli Müzik Aleti ?";
                BtnN.BackColor = Color.Yellow;
                button25.Text = "N";
            }
            if (soruNo == 16)
            {
                richtextbox1.Text = "Halk Şairi ?";
                BtnO.BackColor = Color.Yellow;
                button25.Text = "O";
            }
            if (soruNo == 17)
            {
                richtextbox1.Text = "Çocukların Pek sevmediği Pirinç Havuç gibi Sebzelerle Yapılan Yemek ?";
                BtnP.BackColor = Color.Yellow;
                button25.Text = "P";
            }
            if (soruNo == 18)
            {
                richtextbox1.Text = "11 Ayın Sultanı ?";
                BtnR.BackColor = Color.Yellow;
                button25.Text = "R";
            }
            if (soruNo == 19)
            {
                richtextbox1.Text = "İngilizcede Yılan Ne Demek ?";
                BtnS.BackColor = Color.Yellow;
                button25.Text = "S";
            }
            if (soruNo == 20)
            {
                richtextbox1.Text = "Türkiyeni Megastarı ?";
                BtnT.BackColor = Color.Yellow;
                button25.Text = "T";
            }
            if (soruNo == 21)
            {
                richtextbox1.Text = "Ümit Kelimesinin Eş Anlamlısı ?";
                BtnU.BackColor = Color.Yellow;
                button25.Text = "U";
            }
            if (soruNo == 22)
            {
                richtextbox1.Text = "Kahvaltası ile ünlü ilimiz ?";
                BtnV.BackColor = Color.Yellow;
                button25.Text = "V";
            }
            if (soruNo == 23)
            {
                richtextbox1.Text = "Şimşek Kelimesinin Eş anlamlısı ?";
                BtnY.BackColor = Color.Yellow;
                button25.Text = "Y";
            }
            if (soruNo == 24)
            {
                richtextbox1.Text = "Ege Bölgesininde Yağı Çıkartılan Kahvaltı Meyvesi ?";
                BtnZ.BackColor = Color.Yellow;
                button25.Text = "Z";
            }

        }
    }
}
