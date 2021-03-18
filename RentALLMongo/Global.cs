using RentALL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentALLMongo
{
    public static class Global
    {
        private static User activeUser;

        public static User ActiveUser
        {
            get { return activeUser; }
            set { activeUser = value; }
        }

    }
}
