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
        public static void ExportInfo( Client entity)
        {
            string info="";
            string Path = "C:\\Test";
            var fileFullName = string.Format(@"{0}\DataExchange.csv", Path);
            info = Convert.ToString(entity.ClientId) +"," + entity.Username + "," + entity.FirstName + "," + entity.LastName + "," + entity.Adress + "," + entity.Phone;

            File.WriteAllText(fileFullName, info);
        }

        public static string ReadCommand()
        {
            string text = File.ReadAllText("C:\\Test\\cmd.txt");
            return text;
        }

        public static void maskcommand()
        {
            string fileFullName = "C:\\Test\\UnivData.txt";
            string info = "0";
            File.WriteAllText(fileFullName, info);
        }


        public static string ReadEntry()
        {
            string text = File.ReadAllText("C:\\Test\\UnivData.txt");
            return text;
        }



    }
}
