using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class MonAn_BUS
    {
        public static List<MonAn_DTO> LoadMonAn()
        {
            return MonAn_DAO.LoadMonAn();
        }

        public static int layIDMonAn(string tenMonAn)
        {
            return MonAn_DAO.layIDMonAn(tenMonAn);
        }

        public static List<MonAn_DTO> TimMonAn(string tenMonAn)
        {
            return MonAn_DAO.TimMonAn(tenMonAn);
        }

        public static bool ThemMonAn(MonAn_DTO monAn)
        {
            return MonAn_DAO.ThemMonAn(monAn);
        }

        public static bool SuaMonAn(MonAn_DTO monAn)
        {
            return MonAn_DAO.SuaMonAn(monAn);
        }

        public static bool XoaMonAn(MonAn_DTO monAn)
        {
            return MonAn_DAO.XoaMonAn(monAn);
        }

        public static bool XoaToanBoMonAn()
        {
            return MonAn_DAO.XoaToanBoMonAn();
        }

    }
}
