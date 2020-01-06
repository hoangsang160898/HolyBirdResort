using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ActivityBUS
    {
        public static List<ActivityDTO> LoadActivities()
        {
            List<ActivityDTO> result = ActivityDAO.LoadActivities();
            if (result == null)
                return null;
            return result;
        }
        public static void AcceptRoom(string madoan)
        {
            ActivityDAO.AcceptRoom(madoan);
        }
        public static void CancelRoom(string magiaodich)
        {
            ActivityDAO.CancelRoom(magiaodich);
        }
    }
}
