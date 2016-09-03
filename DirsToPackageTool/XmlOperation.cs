using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DirsToPackageTool
{
    public class XmlOperation
    {
        private static string GetConfigFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "PackageConfig.xml";

        }
        private static XElement getFileEle()
        {
            XElement xe = null;
            try
            {
                xe = XElement.Load(GetConfigFilePath());
            }
            catch (System.IO.FileNotFoundException)
            {
                xe = null;
            }
            return xe;
        }
        public static bool GetXmlIntoSetEntity()
        {
            XElement xe = getFileEle();
            if (xe == null)
            {
                return false;
            }
            IEnumerable<XElement> eles = from ele in xe.Element("set").Elements("path")
                                         select ele;
            if (eles == null)
            {
                return false;
            }
            foreach (XElement eleItem in eles)
            {
                switch (eleItem.Attribute("type").Value)
                {
                    case "zgwtest":
                        SetEntity.TestExpPath = eleItem.Element("export").Value;
                        SetEntity.TestTarPath = eleItem.Element("target").Value;
                        SetEntity.TestBinPath = eleItem.Element("bin").Value;
                        break;
                    case "zgwformal":
                        SetEntity.FormalExpPath = eleItem.Element("export").Value;
                        SetEntity.FormalTarPath = eleItem.Element("target").Value;
                        SetEntity.FormalBinPath = eleItem.Element("bin").Value;
                        break;
                    case "application":
                        int locX = Int32.Parse(eleItem.Element("point").Attribute("x").Value);
                        int locY = Int32.Parse(eleItem.Element("point").Attribute("y").Value);
                        SetEntity.Point = new Point(locX, locY);
                        break;
                    case "export":
                        SetEntity.ExportPath = eleItem.Element("value").Value;
                        break;

                }
            }
            return true;

        }
        public static bool SetXmlIntoSetEntity(bool saveLoc)
        {
            XElement xe = getFileEle();
            if (xe == null)
            {
                return false;
            }

            IEnumerable<XElement> eles = from ele in xe.Element("set").Elements("path")
                                         select ele;
            if (eles == null)
            {
                return false;
            }
            foreach (XElement eleItem in eles)
            {
                switch (eleItem.Attribute("type").Value)
                {
                    case "zgwtest":
                        eleItem.Element("export").Value = SetEntity.TestExpPath;
                        eleItem.Element("target").Value = SetEntity.TestTarPath;
                        eleItem.Element("bin").Value = SetEntity.TestBinPath;
                        break;
                    case "zgwformal":
                        eleItem.Element("export").Value = SetEntity.FormalExpPath;
                        eleItem.Element("target").Value = SetEntity.FormalTarPath;
                        eleItem.Element("bin").Value = SetEntity.FormalBinPath;
                        break;
                    case "application":
                        if (saveLoc)
                        {
                            eleItem.Element("point").Attribute("x").Value = SetEntity.Point.X.ToString();
                            eleItem.Element("point").Attribute("y").Value = SetEntity.Point.Y.ToString();
                        }                        
                        break;
                }
            }
            xe.Save(GetConfigFilePath());
            return true;
        }
    }
}
