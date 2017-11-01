using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolTools
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            serializer.MaxJsonLength = int.MaxValue;
            var str = serializer.Serialize(Base64Img.base64imgs);
            File.WriteAllText(@"..\..\NanbanTrade.json", str);
        }
    }
}
