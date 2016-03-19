using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
namespace SmartShoppingDat
{
    public class FileCom
    {
        public static void ExportBatteryInfo( Client entity)
        {
            string Path = "@E:\\Test";
            var sb = new StringBuilder();
            sb.AppendLine(@"ClientsId, Username, First Name, Last Name, Adress, Phone");
            sb.AppendLine(entity.ToString());
            var fileFullName = string.Format(@"{0}\test.csv", Path);

            File.WriteAllText(fileFullName, sb.ToString());
 

        }

        public static string ReadCommand()
        {
            string text = File.ReadAllText(@"E:\Test\cmd.txt");
            return text;
        }

        public static string ReeadEntry()
        {
            string text = File.ReadAllText(@"E:\Test\UnivData.txt");
            return text;
        }



    }
}
