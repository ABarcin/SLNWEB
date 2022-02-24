using SLNWEB.DAO.VM;
using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SLNWEB.DAL.Repository
{
    public class SatisDAL:ISatisDAL
    {
        public int AddSatis(SatisVM satisVM)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    int value=new OrderDAL().AddOrder(satisVM.Order);
                    if (value>0)
                    {
                       int orderID= new OrderDAL().GetAll().OrderByDescending(x => x.OrderID).First().OrderID;
                       
                    }
                }
                catch (Exception ex)
                {

                }

            }


            return 0;
        }

    }
}
