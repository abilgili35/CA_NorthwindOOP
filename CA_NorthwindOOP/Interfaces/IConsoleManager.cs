using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindOOP.Interfaces
{
    public interface IConsoleManager
    {
        public void RunConsoleManager();
        public void GetConsoleMenu();
        public int SelectConsoleMenu();
    }
}
