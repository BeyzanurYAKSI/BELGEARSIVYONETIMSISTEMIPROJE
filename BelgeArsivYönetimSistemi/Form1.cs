using BelgeArsivYönetimSistemi.DOMAİN;
using BelgeArsivYönetimSistemi.FORMS;
using BelgeArsivYönetimSistemi.SERVİCE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace BelgeArsivYönetimSistemi
{
    public partial class Form1 : Form
    {
        //Fields 
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form ActiveForm;

        //Constructor 
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(THEMECOLOR.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(THEMECOLOR.ColorList.Count);

            }
            tempIndex = index;
            string color = THEMECOLOR.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = THEMECOLOR.ChangeColorBrightness(color, -0.3);
                    THEMECOLOR.PrimaryColor = color;
                    THEMECOLOR.SecondaryColor = THEMECOLOR.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActivateButton(btnSender);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KULLANICI_EKLEME kullaniciFrm = new KULLANICI_EKLEME();
            (new kullanıcıService()).kullanıcıKaydet(gkullanıcıad:kullaniciFrm.kAdTxt.Text,gkullanıcıSifre: kullaniciFrm.sifreTxt.Text,gkullanıcıEmail:kullaniciFrm.emailTxt.Text ,gkullanıcıTelefon:kullaniciFrm.telefonTxt.Text,gkullanıcıDepartman:kullaniciFrm.departmanTxt.Text,gkullanıcıTc:kullaniciFrm. tcTxt.Text);
            kullanıcılarıGöster();
        }
        void kullanıcılarıGöster()
        {
            KULLANICI_EKLEME kullaniciFrm = new KULLANICI_EKLEME();
            kullaniciFrm.listBox1.Items.Clear();
            //listBox1.Items.Clear();
            foreach( Kullanıcı k in (new kullanıcıService()).kullanıcılarıGetir())
            {
                kullaniciFrm.listBox1.Items.Add(k);  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            kullanıcılarıGöster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KULLANICI_EKLEME kullaniciFrm=new KULLANICI_EKLEME();
            kullaniciFrm.listBox1.Items.Clear();
            (new kullanıcıService()).kullanıcıSil(((Kullanıcı)kullaniciFrm.listBox1.SelectedItem).Id);
            kullanıcılarıGöster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EVRAK_KAYIT evraklarFrm = new EVRAK_KAYIT();
            (new evrakService()).evrakKaydet(gEvrakAd:evraklarFrm.eAdTxt.Text,gEvrakKategori:evraklarFrm.KategoriTxt.Text,gEvrakDetay:evraklarFrm.DetayTxt.Text,gEvrakTarih:evraklarFrm.KTarihTxt.Text,gEvrakKAlanAd:evraklarFrm.KAlanAdTxt.Text,gEvrakDolapNo:evraklarFrm.DolapNoTxt.Text,gEvrakRafNo:evraklarFrm.RafNoTxt.Text );
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PERSONEL personelFrm = new PERSONEL();
            (new personelService()).personelKaydet(gPersonelAd:personelFrm.pAdTxt.Text,gPersonelSifre:personelFrm.pSifreTxt.Text,gPersonelEmail:personelFrm.pEmailTxt.Text,gPersonelTelefon:personelFrm.pTelefonTxt.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EMANET emanetFrm = new EMANET();
            (new emanetService()).emanetKaydet(gEmanetAd:emanetFrm.eeAdTxt.Text,gEmanetATarih:emanetFrm.eaTarihTxt.Text,gEmanetTTarih:emanetFrm.etTarihTxt.Text,gEmanetTAAd:emanetFrm.etAAdTxt.Text,gEmanetTATelefon:emanetFrm.etATelTxt.Text,gEmanetVKisiId:emanetFrm.evKisiIdTxt.Text);
        }
        void emanetleriListele()
        {
            EMANET EmanetFrm = new EMANET();
            EmanetFrm.listBox2.Items.Clear(); 
            foreach(Emanet e in (new emanetService()).emanetleriListele())
            {
              EmanetFrm.listBox2.Items.Add(e);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            emanetleriListele();
        }
        void evraklarıtrhListele()
        {
            EVRAK_KAYIT evraklarFrm=new EVRAK_KAYIT();
            evraklarFrm.listBox3.Items.Clear();
            foreach(Evrak evrak in (new evrakService()).evraklarıtrhListele())
            {
                evraklarFrm.listBox3.Items.Add(evrak);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            evraklarıtrhListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKullanıcıEkleme_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.KULLANICI_EKLEME(), sender);
           
        }

        private void btnEvrakKayıt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.EVRAK_KAYIT(), sender);
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.PERSONEL(), sender);
        }

        private void btnEmanet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.EMANET(), sender);
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            Reset();

        }
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "ANASAYFA";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
