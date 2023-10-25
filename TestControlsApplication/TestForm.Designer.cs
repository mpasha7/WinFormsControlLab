namespace TestControlsApplication
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clockControl1 = new LabControls.ClockControl();
            this.watchControl1 = new LabControls.WatchControl(this.components);
            this.SuspendLayout();
            // 
            // clockControl1
            // 
            this.clockControl1.Location = new System.Drawing.Point(370, 36);
            this.clockControl1.Name = "clockControl1";
            this.clockControl1.Size = new System.Drawing.Size(293, 293);
            this.clockControl1.TabIndex = 0;
            // 
            // watchControl1
            // 
            this.watchControl1.BackColor = System.Drawing.Color.Black;
            this.watchControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.watchControl1.ForeColor = System.Drawing.Color.Green;
            this.watchControl1.Location = new System.Drawing.Point(27, 87);
            this.watchControl1.Name = "watchControl1";
            this.watchControl1.Size = new System.Drawing.Size(311, 148);
            this.watchControl1.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 472);
            this.Controls.Add(this.watchControl1);
            this.Controls.Add(this.clockControl1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LabControls.ClockControl clockControl1;
        private LabControls.WatchControl watchControl1;
    }
}