using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
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
