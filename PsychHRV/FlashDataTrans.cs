using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace PsychHRV
{
    class FlashDataTrans
    {
        public static String GenFlashFuncReq(String funcName, String args)
        {
            StringBuilder sb = new StringBuilder();
            XmlTextWriter xtw = new XmlTextWriter(new StringWriter(sb));

            xtw.WriteStartElement("invoke");
            xtw.WriteAttributeString("name", funcName);
            xtw.WriteAttributeString("returntype", "xml");

            xtw.WriteStartElement("arguments");
            xtw.WriteStartElement("string");
            xtw.WriteString(args);

            xtw.WriteEndElement();
            xtw.WriteEndElement();
            xtw.WriteEndElement();

            xtw.Flush();
            xtw.Close();

            return sb.ToString();
        }
    }
}
