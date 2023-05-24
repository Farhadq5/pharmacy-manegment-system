using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int UserId { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Position { get; set; }

    }
}
