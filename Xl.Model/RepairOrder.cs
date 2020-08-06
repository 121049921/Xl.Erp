using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Model
{
    public class RepairOrder : BaseEntity
    {
        [DisplayName("客户名")]
        [Required("不能为空!")]
        [MaxLength(15, "长度不能大于50")]
        public string CustomName { get; set; }
        [DisplayName("性别")]
        public Gender Gender { get; set; }
        [Required("不能为空!")]
        [DisplayName("联系手机")]
        public string Phone { get; set; }
        [DisplayName("联系手机2")]
        public string OtherPhone { get; set; }
        [DisplayName("微信")]
        public string Wx { get; set; }

        [DisplayName("省")]
        public string Province { get; set; }

        [DisplayName("市")]
        public string City { get; set; }
        [DisplayName("描述")]
        public string Description { get; set; }

        [DisplayName("地址")]
        public string Adress { get; set; }

        [DisplayName("品牌")]
        public string Brand { get; set; }

        [DisplayName("家电类型")]
        public HomeElectronicsType HomeElectronicsType { get; set; }

        [DisplayName("上门服务费")]
        public decimal DoorToDoorAmount { get; set; }
        [DisplayName("维修师傅")]
        public string MaintenanceMaster { get; set; }

        [DisplayName("维修是否成功")]
        public bool IsMaintenanceSuccessed { get; set; }

        [DisplayName("维修费用")]
        public decimal MaintenanceAmount { get; set; }

        [DisplayName("预约时间")]
        public DateTime AppointmentDateTime { get; set; }
        [DisplayName("上门时间")]
        public DateTime VisitingDateTime { get; set; }


        [DisplayName("是否投诉")]
        public bool IsComplaints { get; set; }


    }

    /// <summary>
    /// 性别
    /// </summary>
    public enum Gender
    {
        Men = 1,
        Women = 2,
    }

    /// <summary>
    /// 家电类型
    /// </summary>
    public enum HomeElectronicsType
    {
        [Description("电冰箱")]
        Fridges = 1,
        [Description("电冰箱")]
        WashingMachine = 2,

        [Description("电视机")]
        Television = 3,
        [Description("壁挂炉")]
        WallHangingFurnace = 4,
    }
}
