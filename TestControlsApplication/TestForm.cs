using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestControlsApplication
{
    public partial class TestForm : Form
    {
        //public Font? font;

        public TestForm()
        {
            InitializeComponent();
            clockControl1.Start();
        }

        //private void LoadFont()
        //{
        //    PrivateFontCollection fonts = new PrivateFontCollection();
        //    fonts.AddFontFile("DigitFont.ttf");
        //    font = new Font(fonts.Families[0], 20);
        //}
    }
}
