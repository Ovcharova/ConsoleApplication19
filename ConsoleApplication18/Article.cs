using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    public class Article
    {
        public int Index;
        public string Name;
        public string Text;
        public string Comment;
        public DateTime TimeComment;

        public override string ToString()
        {
            String format = "[MM/dd hh:mm]";
            StringBuilder stringBilder = new StringBuilder();
            stringBilder.AppendFormat("{0} ", Index)
                .AppendFormat("{0} ", Name)
                .AppendFormat("{0} ", Text)
                .AppendFormat("{0} ", Comment)
                .AppendFormat("{0} ", TimeComment.ToString(format));
            return stringBilder.ToString();
        }


    }
}
