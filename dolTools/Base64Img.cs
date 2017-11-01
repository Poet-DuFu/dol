using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dolTools
{
    class Base64Img
    {


        internal static IEnumerable<string> base64imgs
        {
            get
            {
                var urls = new string[]
            {

"http://s1.sinaimg.cn/large/8d394da2gb7bf32066220",
"http://s3.sinaimg.cn/large/8d394da2gb7bf3239d052",
"http://s9.sinaimg.cn/large/8d394da2gb55078635d98",
"http://s3.sinaimg.cn/large/8d394da2gb55078a078e2",
"http://s8.sinaimg.cn/large/8d394da2gb5bf96aecfa7",
"http://s2.sinaimg.cn/large/8d394da2gb5bf96dca271",
"http://s2.sinaimg.cn/large/8d394da2gb4aaa89db2f1",
"http://s10.sinaimg.cn/large/8d394da2gb4aaa9298ec9",

            };


                foreach (var url in urls)
                {
                    WebClient wc = new WebClient();
                    var bs = wc.DownloadData(url);

                    yield return Convert.ToBase64String(bs);
                }
            }
        }


    }
}
