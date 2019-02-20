using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallyBook.PublicModel
{
    /// <summary>
    /// 消费实体
    /// </summary>
    public class SpendingModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id;

        /// <summary>
        /// 项目
        /// </summary>
        public string Project;

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal Summoney;

        /// <summary>
        /// 付款人
        /// </summary>
        public PersonEnum Payer;

        /// <summary>
        /// 受益人
        /// </summary>
        public List<PersonEnum> Beneficiary;
    }
}
