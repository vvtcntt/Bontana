using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bontana.Models;
using Bontana.Models;
namespace Bontana.Models
{

    public class clsManufactures
    {
        public static BontanaContext db = new BontanaContext();

        public static int idManu(int id)
        {
            var listConnect = db.TblConnectManuProduct.Where(p => p.IdCate == id).Select(p => p.IdManu).Take(1).ToList();
            int idManu = int.Parse(listConnect[0].Value.ToString());

            return idManu;
        }
    }
}