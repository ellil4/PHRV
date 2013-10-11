using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Timers;
using System.Diagnostics;

namespace PsychHRV
{
    public partial class FlashPanel : Form
    {
        Stopwatch mWatch;

        public FlashPanel()
        {
            InitializeComponent();
            amFlashCtrl.Movie = AppDomain.CurrentDomain.BaseDirectory + "test.swf";
            amSendBackTextLabel.Text = "waiting for data";
            mWatch = new Stopwatch();
        }

        private void amSendBtn_Click(object sender, EventArgs e)
        {
            String Text2Send = amTextBox.Text;
            int Int2Send = 0;
            try
            {
                int.TryParse(Text2Send, out Int2Send);
                amFlashCtrl.CallFunction(FlashDataTrans.GenFlashFuncReq("SetAnimation2Frame", Text2Send));
                amTextBox.Clear();
            }
            catch
            {
                MessageBox.Show("input a number");
            }

        }

        private void amFlashCtrl_FlashCall(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FlashCallEvent e)
        {
            XmlDocument xd = new XmlDocument();
            xd.LoadXml(e.request);
            XmlNodeList xnl = xd.GetElementsByTagName("arguments");
            amSendBackTextLabel.Text = "收到：" + xnl[0].FirstChild.InnerText;
        }

        private void amBtnTotalFrame_Click(object sender, EventArgs e)
        {
            try
            {
                amFlashCtrl.CallFunction(FlashDataTrans.GenFlashFuncReq("GetInformation", "GetTotalFrameCount"));
            }
            catch(Exception err)
            {
                MessageBox.Show("Problem");
            }
        }

        private void amBtnCurFrm_Click(object sender, EventArgs e)
        {
            try
            {
                amFlashCtrl.CallFunction(FlashDataTrans.GenFlashFuncReq("GetInformation", "GetCurrentFrameIndex"));
            }
            catch (Exception err)
            {
                MessageBox.Show("Problem");
            }
        }

        private System.Timers.Timer mT;
        private int mCurPlayFrame = 1;

        private void amBtnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                mCurPlayFrame = 1;

                int interv = Int32.Parse(amTbSpd.Text);
                mT = new System.Timers.Timer();
                mT.Interval = interv;
                mT.AutoReset = true;
                mT.Elapsed += new ElapsedEventHandler(t_Elapsed);
                mT.Enabled = true;
                mWatch.Reset();
                mWatch.Start();

                amBtnPlay.Enabled = false;
                amTbSpd.Text = "";
            }
            catch
            {
                MessageBox.Show("Problem");
            }
        }

        private void goToFrame(int frameIdx)
        {
            amFlashCtrl.CallFunction(FlashDataTrans.GenFlashFuncReq("SetAnimation2Frame", frameIdx.ToString()));
        }

        private void setPlayFinishedUI()
        {
            amBtnPlay.Enabled = true;
            amLabelEffi.Text = "Spent Dure: " + mWatch.ElapsedMilliseconds.ToString();
            mWatch.Stop();
            mWatch.Reset();
        }

        private delegate void timedele1Para(int index);
        private delegate void timedele0Para();

        void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (mCurPlayFrame == 450)
            {
                mT.AutoReset = false;
                mT.Enabled = false;
                Invoke(new timedele0Para(setPlayFinishedUI));
            }
            
            Invoke(new timedele1Para(goToFrame), new object[] { mCurPlayFrame });
            
            mCurPlayFrame++;
        }
    }
}
