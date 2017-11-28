using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Models
{
   public class LogInfoModel
    {
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public DateTime Date { get; set; }
        public string HttpRequestMethod { get; set; }
        public int HttpStatusCode { get; set; }
        public string Path { get; set; }
        public int Size { get; set; }
    }
}
