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
    public partial class ClockControl : UserControl
    {
        const float PI = 3.141592654F;
        DateTime dateTime;

        float fRadius;
        float fCenterX;
        float fCenterY;
        float fCenterCircleRadius;

        float fHourLength;
        float fMinLength;
        float fSecLength;

        float fHourThickness;
        float fMinThickness;
        float fSecThickness;
        float fTicksThickness = 1;
        int rimThickness;
        int rimIndent;

        bool Draw5MinuteTicks { get; set; } = true;
        bool Draw1MinuteTicks { get; set; } = true;

        Color HourColor { get; set; } = Color.Black;
        Color MinuteColor { get; set; } = Color.Black;
        Color SecondColor { get; set; } = Color.Red;
        Color CenterColor { get; set; } = Color.Red;
        Color TicksColor { get; set; } = Color.Red;
        Color RimColor { get; set; } = Color.Black;

        public ClockControl()
        {
            InitializeComponent();
        }

        private void ClockControl_Load(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            ClockControl_Resize(sender, e);
        }

        private void ClockControl_Resize(object sender, EventArgs e)
        {
            Width = Height;
            fRadius = Height / 2;
            fCenterX = ClientSize.Width / 2;
            fCenterY = ClientSize.Height / 2;
            fHourLength = (float)Height / 2F / 2F;
            fMinLength = (float)Height / 2F / 1.4F;
            fSecLength = (float)Height / 2F / 1.15F;
            fHourThickness = (float)Height / 80;
            fMinThickness = (float)Height / 120;
            fSecThickness = (float)Height / 200;
            fCenterCircleRadius = Height / 50;
            rimThickness = (int)fCenterCircleRadius;
            rimIndent = 2 * (int)fCenterCircleRadius;
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            Refresh();
        }

        private void DrawLine(float fThickness, float fLength, Color color, float fRadians, Graphics graph)
        {
            graph.DrawLine(new Pen(color, fThickness), 
                fCenterX - (float)(fLength / 9 * Math.Sin(fRadians)),
                fCenterY + (float)(fLength / 9 * Math.Cos(fRadians)),
                fCenterX + (float)(fLength * Math.Sin(fRadians)),
                fCenterY - (float)(fLength * Math.Cos(fRadians)));
        }

        private void DrawPolygon(float fThickness, float fLength, Color color, float fRadians, Graphics graph)
        {
            PointF A = new PointF((float)(fCenterX + fThickness * 2 * Math.Sin(fRadians + PI / 2)), 
                (float)(fCenterY - fThickness * 2 * Math.Cos(fRadians + PI / 2)));
            PointF B = new PointF((float)(fCenterX + fThickness * 2 * Math.Sin(fRadians - PI / 2)),
                (float)(fCenterY - fThickness * 2 * Math.Cos(fRadians - PI / 2)));
            PointF C = new PointF((float)(fCenterX + fLength * Math.Sin(fRadians)),
                (float)(fCenterY -fLength * Math.Cos(fRadians)));
            PointF D = new PointF((float)(fCenterX -fThickness * 4 * Math.Sin(fRadians)),
                (float)(fCenterY + fThickness * 4 * Math.Cos(fRadians)));
            PointF[] points = { A, D, B, C };
            graph.FillPolygon(new SolidBrush(color), points);
        }

        public void Start()
        {
            timer1.Enabled = true;
            Refresh();
        }

        public void Stop()
        {
            timer1.Enabled = false;
        }

        private void ClockControl_Paint(object sender, PaintEventArgs e)
        {
            float fRadSec = (dateTime.Second) * 6 * PI / 180;
            float fRadMin = (dateTime.Minute) * 6 * PI / 180 + fRadSec / 60;
            float fRadHr = (dateTime.Hour % 12) * 30 * PI / 180 + fRadMin / 60 + fRadSec / 60;
            //float fRadHr = (dateTime.Hour % 12 + dateTime.Minute / 60F) * 30 * PI / 180;



            Bitmap bmp = new Bitmap(Width, Height);
            Graphics graph = Graphics.FromImage(bmp);
            
            
            DrawPolygon(fHourThickness, fHourLength, HourColor, fRadHr, graph);
            DrawPolygon(fMinThickness, fMinLength, MinuteColor, fRadMin, graph);
            //DrawLine(fHourThickness, fHourLength, HourColor, fRadHr, graph);
            //DrawLine(fMinThickness, fMinLength, MinuteColor, fRadMin, graph);
            DrawLine(fSecThickness, fSecLength, SecondColor, fRadSec, graph);

            for (int i = 0; i < 60; i++)
            {
                if (Draw5MinuteTicks == true && i % 5 == 0)
                // Draw 5 minute ticks
                {
                    graph.DrawLine(new Pen(TicksColor, 2 * fTicksThickness),
                      fCenterX + (float)((fRadius - rimIndent) * Math.Sin(i * 6 * PI / 180)),
                      fCenterY - (float)((fRadius - rimIndent) * Math.Cos(i * 6 * PI / 180)),
                      fCenterX + (float)((fRadius - 3 * rimIndent) * Math.Sin(i * 6 * PI / 180)),
                      fCenterY - (float)((fRadius - 3 * rimIndent) * Math.Cos(i * 6 * PI / 180)));
                }
                else if (Draw1MinuteTicks == true) // draw 1 minute ticks
                {
                    graph.DrawLine(new Pen(TicksColor, fTicksThickness),
                        fCenterX + (float)((fRadius - rimIndent) * Math.Sin(i * 6 * PI / 180)),
                        fCenterY - (float)((fRadius - rimIndent) * Math.Cos(i * 6 * PI / 180)),
                        fCenterX + (float)((fRadius - 2 * rimIndent) * Math.Sin(i * 6 * PI / 180)),
                        fCenterY - (float)((fRadius - 2 * rimIndent) * Math.Cos(i * 6 * PI / 180)));
                    //fCenterX + (float)(fRadius / 1.05F * Math.Sin(i * 6 * PI / 180)),
                    //fCenterY - (float)(fRadius / 1.05F * Math.Cos(i * 6 * PI / 180)),
                    //fCenterX + (float)(fRadius / 1.2F * Math.Sin(i * 6 * PI / 180)),
                    //fCenterY - (float)(fRadius / 1.2F * Math.Cos(i * 6 * PI / 180)));
                }
            }
            graph.DrawEllipse(new Pen(RimColor, rimThickness),
                rimIndent, rimIndent, Width - 2 * rimIndent, Height - 2 * rimIndent);
            graph.FillEllipse(new SolidBrush(CenterColor), fCenterX - fCenterCircleRadius / 2,
                fCenterY - fCenterCircleRadius / 2, fCenterCircleRadius, fCenterCircleRadius);
            

            e.Graphics.DrawImage(bmp, 0, 0);
        }

    }
}
