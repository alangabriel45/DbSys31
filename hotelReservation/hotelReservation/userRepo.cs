using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotelReservation.AppData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotelReservation
{

    public class UserRepo
    {
        private hotelReserveEntities db;

        public UserRepo()
        {
            db = new hotelReserveEntities();
        }
    }   
}
