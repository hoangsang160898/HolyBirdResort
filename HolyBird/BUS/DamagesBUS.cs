using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DamagesBUS
    {
        public static List<DamagesDTO> LoadDamages(string magiaodich)
        {
            List<DamagesDTO> result = DamagesDAO.LoadDamages(magiaodich);
            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}
