using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationView.VariableSeesion
{
    public static class LoginInfo
    {
        public static string IdAccount;
        public static string IdUser;
        public static string IdRole;
        public static string IdBusiness;
        public static string UserName;
        public static string Role;
        public static string Access;
        public static Boolean ischange = false;
        public static Boolean changesession = false;
        public static string Pass;
        public static Int32 pagesize = 2;
        public static Decimal pageamount = 0;
        public static Decimal page = 0;
        public static Int32 pageactual = 1;
        public static Int32 skipamount = 1;
        public static Boolean isSearch = false;
    }
}
