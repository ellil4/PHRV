using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;


namespace PsychHRV
{
    public class TUIBV1 : TickerUIBehavoir
    {
        Form1 mForm;
        public TUIBV1(Form1 form)
        {
            mForm = form;
        }

        public void interfaceCoreJob()
        {
            Series serVLF = new Series("VLF");
            serVLF.ChartType = SeriesChartType.Line;
            serVLF.BorderWidth = 1;
            serVLF.ShadowOffset = 1;
            serVLF.IsVisibleInLegend = false;
            serVLF.Color = Color.FromArgb(19, 142, 13);

            Series serLF = new Series("LF");
            serLF.ChartType = SeriesChartType.Line;
            serLF.BorderWidth = 1;
            serLF.ShadowOffset = 1;
            serLF.IsVisibleInLegend = false;
            serLF.Color = Color.FromArgb(0, 0, 255);

            Series serHF = new Series("HF");
            serHF.ChartType = SeriesChartType.Line;
            serHF.BorderWidth = 1;
            serHF.ShadowOffset = 1;
            serHF.IsVisibleInLegend = false;
            serHF.Color = Color.FromArgb(255, 0, 0);

            Series serL2H = new Series("L2H");
            serL2H.ChartType = SeriesChartType.Line;
            serL2H.BorderWidth = 1;
            serL2H.ShadowOffset = 1;
            serL2H.IsVisibleInLegend = false;
            serL2H.Color = Color.FromArgb(255, 0, 128);

            for (int i = 0; i < mDataSource.Count; i++)
            {
                serVLF.Points.AddY(mDataSource[i].VLF);
                serLF.Points.AddY(mDataSource[i].LF);
                serHF.Points.AddY(mDataSource[i].HF);
                serL2H.Points.AddY(mDataSource[i].L2HF);
            }

            mForm.amChartLF.Series.Clear();
            mForm.amChartLF.Series.Add(serLF);

            mForm.amChartHF.Series.Clear();
            mForm.amChartHF.Series.Add(serHF);

            mForm.amChartVLF.Series.Clear();
            mForm.amChartVLF.Series.Add(serVLF);

            mForm.amChartL2H.Series.Clear();
            mForm.amChartL2H.Series.Add(serL2H);

            mForm.label5.Text = mDataSource[mDataSource.Count - 1].VLF + "," +
                mDataSource[mDataSource.Count - 1].LF + "," + mDataSource[mDataSource.Count - 1].HF + ","
                  + mDataSource[mDataSource.Count - 1].L2HF;
        }

        delegate void invokeDele();

        public override void UpdateUserInterface()
        {
            invokeDele dele = new invokeDele(interfaceCoreJob);
            if(!mForm.IsDisposed)
                mForm.Invoke(dele);
        }
    }
}
