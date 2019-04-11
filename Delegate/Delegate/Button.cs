using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    
    public class Button
    {
        public event Action<OurButtonEventArgs> ClickEvent;
        public int Width { get; set; }
        public int Heigt { get; set; }
        public string Text { get; set; }

      
        public void Click()
        {
            // изменяем р-р и цвет если надо
            //if (clickButtonDelegate!=null)
            //clickButtonDelegate(new OurButtonEventArgs());
            ClickEvent?.Invoke(new OurButtonEventArgs());
        }
    }
}
