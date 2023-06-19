using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelgeArsivYönetimSistemi.FORMS
{
    public partial class PERSONEL : Form
    {
        public PERSONEL()
        {
            InitializeComponent();
            LoadTheme();    
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = THEMECOLOR.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = THEMECOLOR.SecondaryColor;
                }
            }

        }
    }
}
