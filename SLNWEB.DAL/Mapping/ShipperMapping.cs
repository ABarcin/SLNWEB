using SLNWEB.Core;
using SLNWEB.DAO.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNWEB.DAL.Mapping
{
    public class ShipperMapping
    {
        public ShipperVM ShipperToShipperVM(Shipper shipper)
        {
            return new ShipperVM()
            {
                ShipperID = shipper.ShipperID,
                CompanyName = shipper.CompanyName
            };
        }
        public Shipper ShipperVMToShipper(ShipperVM vm)
        {
            return new Shipper()
            {
                ShipperID = vm.ShipperID,
                CompanyName = vm.CompanyName
            };
        }
        public List<ShipperVM> ListShipperToShipperVM(List<Shipper> shippers)
        {
            List<ShipperVM> shipperVMs = new List<ShipperVM>();
            foreach (Shipper item in shippers)
            {
                shipperVMs.Add(ShipperToShipperVM(item));
            }
            return shipperVMs;
        }
        public List<Shipper> ListShipperVMToShipper(List<ShipperVM> vms)
        {
            List<Shipper> shippers = new List<Shipper>();
            foreach (ShipperVM item in vms)
            {
                shippers.Add(ShipperVMToShipper(item));
            }
            return shippers;
        }
    }
}
