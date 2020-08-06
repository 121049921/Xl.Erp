using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Model
{
    public class Organization : BaseEntity
    {
        [DisplayName("父Id")]
        public int ParentId { get; set; }
    }
}
