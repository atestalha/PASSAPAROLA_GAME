using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSAPAROLA_GAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int soruno = 0, dgrcvp = 0, ynlscvp = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                switch(soruno)
                {
                    case 1:
                        if(textBox1.Text=="akdeniz")
                        {
                            yuvarlak_Buton1.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text=dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton1.BackColor=Color.Red;
                            ynlscvp++;
                            lblYanlis.Text=ynlscvp.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            yuvarlak_Buton2.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton2.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "ceyhan")
                        {
                            yuvarlak_Buton3.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton3.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            yuvarlak_Buton4.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton4.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "edirne")
                        {
                            yuvarlak_Buton5.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton5.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "fransa")
                        {
                            yuvarlak_Buton6.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton6.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "ganimet")
                        {
                            yuvarlak_Buton7.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton7.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "hatay")
                        {
                            yuvarlak_Buton8.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton8.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ığdır")
                        {
                            yuvarlak_Buton9.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton9.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "imdat")
                        {
                            yuvarlak_Buton10.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton10.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            yuvarlak_Buton11.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton11.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "konya")
                        {
                            yuvarlak_Buton12.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton12.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "leylek")
                        {
                            yuvarlak_Buton13.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton13.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "meyve")
                        {
                            yuvarlak_Buton14.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton14.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "nevşehir")
                        {
                            yuvarlak_Buton15.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton15.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "osman")
                        {
                            yuvarlak_Buton16.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton16.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "papatya")
                        {
                            yuvarlak_Buton17.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton17.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "reyyan")
                        {
                            yuvarlak_Buton18.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton18.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "samsun")
                        {
                            yuvarlak_Buton19.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton19.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "telefon")
                        {
                            yuvarlak_Buton20.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton20.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "uzak")
                        {
                            yuvarlak_Buton21.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton21.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            yuvarlak_Buton22.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton22.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yeni")
                        {
                            yuvarlak_Buton23.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton23.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zarar")
                        {
                            yuvarlak_Buton24.BackColor = Color.Yellow;
                            dgrcvp++;
                            lblDogru.Text = dgrcvp.ToString();
                        }
                        else
                        {
                            yuvarlak_Buton24.BackColor = Color.Red;
                            ynlscvp++;
                            lblYanlis.Text = ynlscvp.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SONRAKİ";
            soruno++;
            this.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "ÜLKEMİZİN GÜNEYİNDEKİ DENİZİN ADI";
                yuvarlak_Buton1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "MARMARA BÖLGESİNDEKİ YEŞİLLİĞİYLE ÜNLÜ OLAN ŞEHRİMİZ";
                yuvarlak_Buton2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "ADANADA BİR NEHİR İSMİ";
                yuvarlak_Buton3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "KARPUZUYLA ÜNLÜ OLAN ŞEHRİMİZ";
                yuvarlak_Buton4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "SELİMİYE CAMİİ HANGİ ŞEHİRDE";
                yuvarlak_Buton5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "EYFEL KULESİ HANGİ ÜLKEDE";
                yuvarlak_Buton6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "SAVAŞLARDA ELDE EDİLEN MADDİ ŞEY";
                yuvarlak_Buton7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "BABANIN KIZ KARDEŞİ";
                yuvarlak_Buton8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "TÜRKİYE'DE GÜNEŞİN EN ERKEN DOĞDUĞU İL";
                yuvarlak_Buton9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "ZOR DURUMDA KALDIĞIMIZDA NE DİYE BAĞIRIRIZ";
                yuvarlak_Buton10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "POLİS,ASKER, ?";
                yuvarlak_Buton11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "SELÇUKLUNUN BAŞKENTİ";
                yuvarlak_Buton12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "BİR TÜR KUŞ TÜRÜ";
                yuvarlak_Buton13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "AĞAÇLARDA YETİŞEN VE YEDİĞİMİZ DOĞAL ÜRÜNÜN ADI";
                yuvarlak_Buton14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "KAPADOKYA HANGİ ŞEHRİMİZDE";
                yuvarlak_Buton15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "OSMANLININ KURUCUSUNUN İSMİ";
                yuvarlak_Buton16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "BİR ÇİÇEK TÜRÜ";
                yuvarlak_Buton17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "CENNETTEKİ KAPILARIN BİRİNİN ADI";
                yuvarlak_Buton18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "KARADENİZ BÇLGESİNDEKİ ŞEHRİMİZ";
                yuvarlak_Buton19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "YAYGIN OLARAK KULLANILAN İLETİŞİM ARACI";
                yuvarlak_Buton20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "YAKIN KELİMESİNİN ZITTI";
                yuvarlak_Buton21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "TÜRKİYEDEKİ EN BÜYÜK GÖLÜN İSMİ";
                yuvarlak_Buton22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "ESKİ KELİMESİNŞN ZITTI";
                yuvarlak_Buton23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "YARAR KELİMESİNİN ZITTI";
                yuvarlak_Buton24.BackColor = Color.Yellow;
            }

        }
       
    }
}
