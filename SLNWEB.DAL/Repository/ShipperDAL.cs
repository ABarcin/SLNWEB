using SLNWEB.Core;
using SLNWEB.DAL.Mapping;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Repository
{
    public class ShipperDAL : EntityRepository<Shipper, NorthwindEntities>, IShipperDAL
    {
        public List<ShipperVM> GetAllShipper()
        {
            return new ShipperMapping().ListShipperToShipperVM(this.GetAll()).ToList();
        }
    }
}
