using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DesktopLauncher.Utilities
{
    public static class XmlHelper
    {
        public static string basePath = Path.Combine(Application.StartupPath, "LayoutDatas");


        private static string CombinePath(string fileName)
        {
            return Path.Combine(basePath, $"{fileName}.xml");
        }
        public static bool SaveLayout(DataLayout dl)
        {
            dl.layoutDate = DateTime.Now;
            dl.layoutId = GetLayoutId();
            dl.basePath = CombinePath(dl.layoutName);
            FileStream fileStream = new FileStream(dl.basePath, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(dl.GetType());
            xmlSerializer.Serialize(fileStream, dl);
            fileStream.Close();
            return true;
        }


        public static int GetLayoutId()
        {
            return Directory.GetFiles(basePath).Length + 1;
        }

        public static DataLayout GetLayout(string fileName)
        {
            string path = Path.Combine(basePath);
            DataLayout dl = null;
            string[] file = Directory.GetFiles(path);
            string fn = file.Where(x => x.Contains($"{fileName}.xml")).FirstOrDefault();
            FileStream fileStream = new FileStream(fn, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataLayout));
            dl = (DataLayout)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
            return dl;
        }

        public static bool UpdateLayout(string fileName, DataLayout newLayout)
        {
            if (File.Exists(CombinePath(fileName)))
            {
                DeleteLayout(fileName);
                FileStream fileStream = new FileStream(CombinePath(newLayout.layoutName), FileMode.Create);
                XmlSerializer xmlSerializer = new XmlSerializer(newLayout.GetType());
                xmlSerializer.Serialize(fileStream, newLayout);
                fileStream.Close();
                return true;
            }
            return false;
        }



        public static bool DeleteLayout(string fileName)
        {
            File.Delete(CombinePath(fileName));
            return File.Exists(CombinePath(fileName));
        }








    }
}