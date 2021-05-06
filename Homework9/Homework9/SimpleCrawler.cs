using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework9
{
    class SimpleCrawler
    {//建立一个哈希表，储存url和是否被爬取过的bool值，被爬过是true
        public Hashtable urls = new Hashtable();
        private int count = 0; //爬取的次数
        private   string StartUrl { get; set; }

      


        public  string HostFilter ;
        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        //主机过滤规则
       // public string HostFilter { get; set; }
        //文件过滤规则
        public string FileFilter = "((.html?|.aspx|.jsp|.php)$|^[^.]+$)";
        //
        public void Enter(string startUrl)
        {
            Match match = Regex.Match(startUrl, urlParseRegex);
            string host = match.Groups["host"].Value;
            HostFilter = "^" + host + "$";
            this.StartUrl = startUrl;
            urls.Add(startUrl, false);//加入初始页面
                                              //开启新线程
            new Thread(Crawl).Start();

        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {//如果被爬取过，跳出
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                //如果没有要爬的或者爬url的次数超过10次就不爬了
                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
               
                    Parse(html,current);//解析,并加入新的链接
                
              
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;

                string html = webClient.DownloadString(url);
                string fileName = count.ToString();//把序号转换成string
                File.WriteAllText(fileName, html, Encoding.UTF8);
                ClassUrl classUrl = new ClassUrl
                {
                    url = url
                };
                if (html.Length == 0)
                {
                    Form1.listfalse.Add(classUrl);


                }
                else { Form1.listtrue.Add(classUrl); }
                    

                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html,string pageUrl)
        {//在html中找到未爬过的网站就加入到数组中
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
              
                if (strRef.Length == 0) continue;
                if (strRef.StartsWith("javascript:")) continue;
                strRef = FixUrl(strRef, pageUrl);
                //if (strRef.StartsWith("http"))
                //{
                //    if (!strRef.StartsWith(StartUrl)) continue;
                //    if (urls[strRef] == null) urls[strRef] = false;
                //}else { strRef = StartUrl + strRef;
                //    if (urls[strRef] == null) urls[strRef] = false; }
                //解析出host和file两个部分，进行过滤
                
                Match linkUrlMatch = Regex.Match(strRef, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if ( Regex.IsMatch(file, FileFilter)
                  && (urls[strRef] == null)&&Regex.IsMatch(host, HostFilter))
                {
                    urls[strRef] = false;
                }
            }
        }

        static public  string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            { //完整路径
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            //非上述开头的相对路径
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
