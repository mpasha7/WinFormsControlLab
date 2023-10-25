using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class ColorSelector : UserControl
    {
        public ColorSelector()
        {
            InitializeComponent();
            radixBoxR.ValueChanged += RadixBox_ValueChanged;
            radixBoxG.ValueChanged += RadixBox_ValueChanged;
            radixBoxB.ValueChanged += RadixBox_ValueChanged;
            RadixBox_ValueChanged(radixBoxR, new EventArgs());
        }

        /// <summary>
        /// Вызывается при срабатывании события ValueChanged какого-либо дочернего RadixNumberBox.
        /// Корректирует свойство lblColor.BackColor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadixBox_ValueChanged(object? sender, EventArgs e)
        {
            lblColor.BackColor = Color.FromArgb(radixBoxR.Value, radixBoxG.Value, radixBoxB.Value);
        }

        /// <summary>
        /// Вызывается при срабатывании события CheckedChanged какого-либо дочернего RadioButton.
        /// Изменяет свойство NumberSystem всех дочерних RadixNumberBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            switch (radioButton.Text)
            {
                case "Bin":
                    radixBoxR.NumberSystem = NumberSystem.Bin;
                    radixBoxG.NumberSystem = NumberSystem.Bin;
                    radixBoxB.NumberSystem = NumberSystem.Bin;
                    break;
                case "Oct":
                    radixBoxR.NumberSystem = NumberSystem.Oct;
                    radixBoxG.NumberSystem = NumberSystem.Oct;
                    radixBoxB.NumberSystem = NumberSystem.Oct;
                    break;
                case "Dec":
                    radixBoxR.NumberSystem = NumberSystem.Dec;
                    radixBoxG.NumberSystem = NumberSystem.Dec;
                    radixBoxB.NumberSystem = NumberSystem.Dec;
                    break;
                case "Hex":
                    radixBoxR.NumberSystem = NumberSystem.Hex;
                    radixBoxG.NumberSystem = NumberSystem.Hex;
                    radixBoxB.NumberSystem = NumberSystem.Hex;
                    break;
                default:
                    break;
            }
        }
    }
}
