using System;
using System.Collections.Generic;
using System.Text;

namespace Backup_Net_Core_
{
    class Variables
    {
        public Variables() { }

        DateTime dt = new DateTime();
        public static string filepath;
        public static string destination;
        public static string BackupFolderName = "Backup " + DateTime.Now.ToString();
    }
}
