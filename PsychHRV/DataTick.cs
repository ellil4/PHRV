using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using LibBinaryFile;

namespace PsychHRV
{
    public class DataTick//rebuild
    {
        String mPath;
        System.Timers.Timer mTimer;
        public List<StDataSector> mDataSource;
        long mReadTill = 0;
        int mDataSourceControlLength = 0;
        public TickerUIBehavoir mBehaviorInst;

        public DataTick(String path, int controlLength)
        {
            Thread.CurrentThread.IsBackground = true;
            mPath = path;
            mDataSourceControlLength = controlLength;
        }

        public void Start()
        {
            mTimer = new System.Timers.Timer();
            mDataSource = new List<StDataSector>();
            
            mBehaviorInst.mDataSource = mDataSource;

            //mReadTill = 0;

            mTimer.Interval = 1000;
            mTimer.AutoReset = true;
            mTimer.Elapsed += new ElapsedEventHandler(mTimer_Elapsed);
            mTimer.Start();
        }

        public void Stop()
        {
            mTimer.Stop();
        }

        /*private StHRV transformStr2St(List<String> rawStrArr)
        {
            StHRV retval = new StHRV();

            retval.Date = rawStrArr[0];
            retval.Time = rawStrArr[1];

            retval.VLF = Double.Parse(rawStrArr[2]);
            retval.LF = Double.Parse(rawStrArr[3]);
            retval.HF = Double.Parse(rawStrArr[4]);
            retval.L2HF = Double.Parse(rawStrArr[5]);

            return retval;
        }*/

        private void shortDataSource2ControlledSize()
        {
            int sizeDiff = mDataSource.Count - mDataSourceControlLength;
            if (sizeDiff > 0)
            {
                mDataSource.RemoveRange(0, sizeDiff);
            }
        }

        private void mTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Reader tf = new Reader(64);
            //long curLen = 0;

            
            tf.Open(mPath);

            List<byte[]> dataSpan = tf.ReadTillEnd(mReadTill);

            if(dataSpan.Count > 0)
            {
                for (int i = 0; i < dataSpan.Count; i++)
                {
                    StDataSector dataSector = new StDataSector();
                    dataSector.Time = tf.GetUInt64InBuf(0, dataSpan[i]);
                    dataSector.VLF = tf.GetDoubleInBuf(8, dataSpan[i]);
                    dataSector.LF = tf.GetDoubleInBuf(16, dataSpan[i]);
                    dataSector.HF = tf.GetDoubleInBuf(24, dataSpan[i]);
                    dataSector.L2HF = tf.GetDoubleInBuf(32, dataSpan[i]);
                    dataSector.RR1 = tf.GetDoubleInBuf(40, dataSpan[i]);
                    dataSector.RR2 = tf.GetDoubleInBuf(48, dataSpan[i]);
                    dataSector.RR3 = tf.GetDoubleInBuf(56, dataSpan[i]);

                    mDataSource.Add(dataSector);
                }
            }

            tf.Close();

            mReadTill += dataSpan.Count;

            mBehaviorInst.UpdateUserInterface();            
        }
    }
}
