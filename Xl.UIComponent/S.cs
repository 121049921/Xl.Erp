using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.UIComponent
{
    public class EidtModelEventArgs<T>: EventArgs
    {
        public T  EditEntity {get;set;}
    }
}
