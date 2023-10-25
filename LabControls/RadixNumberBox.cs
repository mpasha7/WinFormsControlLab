using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabControls
{
    public partial class RadixNumberBox : TextBox
    {
        private NumberSystem numberSystem = NumberSystem.Dec;
        /// <summary>
        /// Задает систему счисления, в которой RadixNumberBox.Text отображает значение свойства Value.
        /// </summary>
        public NumberSystem NumberSystem 
        { 
            get => numberSystem; 
            set
            {
                if (numberSystem != value)
                {
                    numberSystem = value;
                    int radix = (int)numberSystem;
                    Text = radix <= 10 ? Value.ToStringWithRadix(radix) : Value.ToString("x");
                }
            }
        }

        private int value = 0;
        /// <summary>
        /// Задает целочисленное значение строки RadixNumberBox.Text.
        /// </summary>
        public int Value
        {
            get => this.value;
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    ValueChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// Возникает, когда изменяется значение свойства RadixNumberBox.Value.
        /// </summary>
        public event EventHandler? ValueChanged;
       
        public RadixNumberBox()
        {
            InitializeComponent();
            Text = "0";
        }

        public RadixNumberBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            Text = "0";
        }

        /// <summary>
        /// Вызывается при изменении свойства RadixNumberBox.Text. 
        /// Ограничивает вводимое значение не более 255.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnTextChanged(EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                Text = "0";
                return;
            }
            int radix = (int)NumberSystem;
            if (Convert.ToInt32(Text, radix) > 255)
            {
                Text = radix <= 10 ? 255.ToStringWithRadix(radix) : 255.ToString("x");
            }
            Value = Convert.ToInt32(Text, radix);
            base.OnTextChanged(e);
        }

        /// <summary>
        /// Вызывается при нажатии любой клавиши, когда фокус ввода на объекте RadixNumberBox.
        /// Запускает проверку корректности нажатой клавиши.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(KeyCheck(number) || number == (char)Keys.Back || number == (char)Keys.Delete))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        /// <summary>
        /// Проверяет корректность нажатой клавиши.
        /// Зависит от текущей системы счисления.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool KeyCheck(char number)
        {
            int radix = (int)NumberSystem;
            if(radix == 16)
            {
                return Char.IsDigit(number) || "abcdef".Contains(number);
            }
            else
            {
                return Char.IsDigit(number) && Convert.ToInt32(number.ToString()) < radix;
            }
        }

    }
}
