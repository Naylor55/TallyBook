using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallyBook.PublicModel
{
    /// <summary>
    /// 结算单实体
    /// </summary>
    public class SettlementModel
    {
        /// <summary>
        /// 结算单编号
        /// </summary>
        
        public int Id; 
        /// <summary>
        /// 关联的消费项
        /// </summary>
        public List<int> SpendingIdList;      

        /// <summary>
        /// 结算日期
        /// </summary>
        public DateTime Date;
    }
}
