using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLibrairieMVVM.Helpers
{
    public class Utils
    {
        public static string[] GetListBook()
        {
            string _rep = ConfigurationManager.AppSettings["repfileExterne"];

            var _listFic = Directory.GetFiles(_rep, "*.jpg", SearchOption.TopDirectoryOnly);

            return _listFic;
        }


    }
}
