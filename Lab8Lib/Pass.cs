using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Lib
{
    public class Pass
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Place { get; set; }
        public string Prop { get; set; }
        public string PassNum { get; set; }
        public string PassSer { get; set; }
        public bool HasMarried { get; set; }
        public override string ToString()
        {
            return string.Format("{0}|Страна:{1}|Город:{2}|Место выдачи:{3}||Место прописки:{4}|{6}{5}, {7}", Name,Country,Region,Place,Prop,PassNum,PassSer,HasMarried ? ":Женат(Замужем)" : "Не женат(Не замужем)");
        }
    }
}
