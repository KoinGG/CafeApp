using CafeApp.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp.Sourses
{
    public class DbContextProvider
    {
        private static CafeAppContext _context;

        public static CafeAppContext GetContext()
        {
            return _context ??= new CafeAppContext();
        }
    }
}
