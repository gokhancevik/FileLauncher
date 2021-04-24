using System;
using System.Collections.Generic;

namespace DesktopLauncher
{
    [Serializable]
    public class DataLayout
    {
        public DataLayout()
        {
            this.filePathList = new List<string>();
        }
        public int layoutId { get; set; } = 1;
        public string layoutName { get; set; }
        public DateTime layoutDate { get; set; }

        public string basePath { get; set; }
        public bool isDefault { get; set; }
        public List<string> filePathList { get; set; }
    }
}