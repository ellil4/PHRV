using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PsychHRV
{
    public abstract class TickerUIBehavoir
    {
        public List<StDataSector> mDataSource;
        abstract public void UpdateUserInterface();
    }
}
