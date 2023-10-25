using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class WatchControl : UserControl
    {
        Font? bigFont;
        Font? middleFont;
        Font? smallFont;
        CultureInfo culture = new CultureInfo("en-US");

        public WatchControl()
        {
            InitializeComponent();
        }

        public WatchControl(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void WatchControl_Load(object sender, EventArgs e)
        {
            LoadFonts();
            lblTime.Font = bigFont;
            lblSeconds.Font = middleFont;
            lblDate.Font = smallFont;
            lblDayOfWeek.Font = smallFont;
            //lblSeconds.Location = new Point(lblTime.Location.X + lblTime.Width, 
            //    lblTime.Location.Y + lblTime.Height - lblSeconds.Height);
            timer1.Start();
        }

        private void LoadFonts()
        {
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile(@"C:/Users/Паша/source/repos/WinFormsControlLab/LabControls/Fonts/DigitFont.ttf");
            bigFont = new Font(fonts.Families[0], 72);
            middleFont = new Font(fonts.Families[0], 35);
            smallFont = new Font(fonts.Families[0], 25);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm", culture);
            lblSeconds.Text = DateTime.Now.ToString(":ss", culture);
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy", culture);
            lblDayOfWeek.Text = DateTime.Now.ToString("ddd", culture);
        }
    }
}
