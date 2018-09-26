using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bontana.Models;
using Bontana.Models;
namespace Bontana.Models
{
    public class ClsCheckRole
    {
         public static bool  CheckQuyen(int Module,int Role,int IdUser)
        {
            BontanaContext db = new BontanaContext();
            var listRight = db.TblRight.Where(p => p.IdUser == IdUser && p.IdModule == Module && p.Role ==Role).ToList();
            if (listRight.Count > 0)
            {
                
                 return true;
            }
            else
                return false;
        }
    }
 
}