namespace LabControls
{
    partial class ColorSelector
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radixBoxR = new LabControls.RadixNumberBox(this.components);
            this.lblR = new System.Windows.Forms.Label();
            this.radixBoxG = new LabControls.RadixNumberBox(this.components);
            this.lblG = new System.Windows.Forms.Label();
            this.radixBoxB = new LabControls.RadixNumberBox(this.components);
            this.lblB = new System.Windows.Forms.Label();
            this.rbtnBin = new System.Windows.Forms.RadioButton();
            this.rbtnDec = new System.Windows.Forms.RadioButton();
            this.rbtnOct = new System.Windows.Forms.RadioButton();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.lblColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radixBoxR
            // 
            this.radixBoxR.Location = new System.Drawing.Point(53, 20);
            this.radixBoxR.Name = "radixBoxR";
            this.radixBoxR.NumberSystem = LabControls.NumberSystem.Dec;
            this.radixBoxR.Size = new System.Drawing.Size(100, 23);
            this.radixBoxR.TabIndex = 0;
            this.radixBoxR.Text = "0";
            this.radixBoxR.Value = 0;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(23, 25);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(17, 15);
            this.lblR.TabIndex = 1;
            this.lblR.Text = "R:";
            // 
            // radixBoxG
            // 
            this.radixBoxG.Location = new System.Drawing.Point(53, 49);
            this.radixBoxG.Name = "radixBoxG";
            this.radixBoxG.NumberSystem = LabControls.NumberSystem.Dec;
            this.radixBoxG.Size = new System.Drawing.Size(100, 23);
            this.radixBoxG.TabIndex = 1;
            this.radixBoxG.Text = "0";
            this.radixBoxG.Value = 0;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(23, 54);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(18, 15);
            this.lblG.TabIndex = 1;
            this.lblG.Text = "G:";
            // 
            // radixBoxB
            // 
            this.radixBoxB.Location = new System.Drawing.Point(53, 78);
            this.radixBoxB.Name = "radixBoxB";
            this.radixBoxB.NumberSystem = LabControls.NumberSystem.Dec;
            this.radixBoxB.Size = new System.Drawing.Size(100, 23);
            this.radixBoxB.TabIndex = 2;
            this.radixBoxB.Text = "0";
            this.radixBoxB.Value = 0;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(23, 83);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 15);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B:";
            // 
            // rbtnBin
            // 
            this.rbtnBin.AutoSize = true;
            this.rbtnBin.Location = new System.Drawing.Point(53, 107);
            this.rbtnBin.Name = "rbtnBin";
            this.rbtnBin.Size = new System.Drawing.Size(42, 19);
            this.rbtnBin.TabIndex = 3;
            this.rbtnBin.Text = "Bin";
            this.rbtnBin.UseVisualStyleBackColor = true;
            this.rbtnBin.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnDec
            // 
            this.rbtnDec.AutoSize = true;
            this.rbtnDec.Checked = true;
            this.rbtnDec.Location = new System.Drawing.Point(53, 132);
            this.rbtnDec.Name = "rbtnDec";
            this.rbtnDec.Size = new System.Drawing.Size(45, 19);
            this.rbtnDec.TabIndex = 5;
            this.rbtnDec.TabStop = true;
            this.rbtnDec.Text = "Dec";
            this.rbtnDec.UseVisualStyleBackColor = true;
            this.rbtnDec.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnOct
            // 
            this.rbtnOct.AutoSize = true;
            this.rbtnOct.Location = new System.Drawing.Point(101, 107);
            this.rbtnOct.Name = "rbtnOct";
            this.rbtnOct.Size = new System.Drawing.Size(44, 19);
            this.rbtnOct.TabIndex = 4;
            this.rbtnOct.Text = "Oct";
            this.rbtnOct.UseVisualStyleBackColor = true;
            this.rbtnOct.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Location = new System.Drawing.Point(101, 132);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(46, 19);
            this.rbtnHex.TabIndex = 6;
            this.rbtnHex.Text = "Hex";
            this.rbtnHex.UseVisualStyleBackColor = true;
            this.rbtnHex.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor.Location = new System.Drawing.Point(169, 20);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(130, 130);
            this.lblColor.TabIndex = 7;
            // 
            // ColorSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.rbtnHex);
            this.Controls.Add(this.rbtnDec);
            this.Controls.Add(this.rbtnOct);
            this.Controls.Add(this.rbtnBin);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.radixBoxB);
            this.Controls.Add(this.radixBoxG);
            this.Controls.Add(this.radixBoxR);
            this.Name = "ColorSelector";
            this.Size = new System.Drawing.Size(314, 164);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadixNumberBox radixBoxR;
        private Label lblR;
        private RadixNumberBox radixBoxG;
        private Label lblG;
        private RadixNumberBox radixBoxB;
        private Label lblB;
        private RadioButton rbtnBin;
        private RadioButton rbtnDec;
        private RadioButton rbtnOct;
        private RadioButton rbtnHex;
        private Label lblColor;
    }
}
