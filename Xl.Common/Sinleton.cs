using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Common
{
    public class Sinleton<T> where T : class, new()
    {
        private static object objLoker = new object();


        private static T instanc;
        public static T Instanc
        {
            get
            {
                if (instanc == null)
                {

                    lock (objLoker)
                    {
                        instanc = new T();
                    }
                }
                return instanc;
            }
        }
    }
}
