using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    class Petya : User
    {
        public Petya()
        {
            User.Name = "Петя";
            AddLoginDate(2022, 03, 31);
            AddLoginDate(2022, 04, 13);
            AddLoginDate(2022, 04, 16);
            AddLoginDate(2022, 04, 15);
            AddLoginDate(2022, 04, 19);
            AddLoginDate(2022, 04, 17);
            SortDate();
        }
        
        
    
    
    
    
    
    
    
    }
}
