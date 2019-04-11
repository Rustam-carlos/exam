using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLesson
{
    public interface ISender
    {
        void SendMessage(string to, string text);
    }
}
