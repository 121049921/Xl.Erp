using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Model
{

    public interface AggregateRoot<Key>
    {
        [DisplayName("Id")]
        Key Id { get; set; }
    }
    public class AggregateRoot : AggregateRoot<int>
    {
        [DisplayName("Id")]
        public int Id { get; set; }
    }
    public class BaseEntity : AggregateRoot
    {
        
        [Required("编码必填")]
        [DisplayName("编码")]
        public string Code { get; set; }
       
        [DisplayName("创建时间")]
        public DateTime CreateTime { get; set; }
        [DisplayName("创建人Id")]
        public int CreateUserId { get; set; }
        [DisplayName("创建人")]
        public string CreateUserName { get; set; }

        [DisplayName("修改时间")]
        public DateTime UpdateTime { get; set; }

        [DisplayName("修改人Id")]
        public int UpdateUserId { get; set; }

        [DisplayName("修改人")]
        public string UpdateUserName { get; set; }

        [DisplayName("备注")]
        public string Remark { get; set; }

        [DisplayName("排序")]
        public int Sort { get; set; }
        [DisplayName("是否启用")]
        public bool IsEabled { get; set; }
    }
}
