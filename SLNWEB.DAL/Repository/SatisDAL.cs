using SLNWEB.Core;
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
    public class SatisDAL : ISatisDAL
    {
        public int AddSatis(SatisYapVM satisVM)
        {
            int donenDeger = 0;
            using (TransactionScope scope = new TransactionScope())
            {
                ProductDAL productDAL = new ProductDAL();
                try
                {
                    int value = new OrderDAL().AddOrder(satisVM.OrderVM);
                    if (value > 0)
                    {
                        int orderID = new OrderDAL().GetAll().OrderByDescending(x => x.OrderID).First().OrderID;
                        satisVM.OrderDetailVM.OrderID = orderID;
                        satisVM.OrderDetailVM.UnitPrice = productDAL.GetAll(x => x.ProductID == satisVM.OrderDetailVM.ProductID).SingleOrDefault().UnitPrice;
                        if (productDAL.GetAll(x => x.ProductID == satisVM.OrderDetailVM.ProductID).SingleOrDefault().UnitsInStock > satisVM.OrderDetailVM.Quantity)
                        {
                            int deger = new OrderDetailDAL().AddOrderDetail(satisVM.OrderDetailVM);
                            if (deger > 0)
                            {
                                Product p = productDAL.GetAll(x => x.ProductID == satisVM.OrderDetailVM.ProductID).SingleOrDefault();
                                p.UnitsInStock = (short?)(p.UnitsInStock - satisVM.OrderDetailVM.Quantity);
                                donenDeger = productDAL.Update(p);
                                if (donenDeger > 0)
                                {
                                    scope.Complete();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }

            }
            return donenDeger;
        }

    }
}
