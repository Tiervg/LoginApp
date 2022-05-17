using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    class Misha : User
    {
        public Misha()
        {
            User.Name = "Миша";
            AddLoginDate(2022, 04, 9);
            AddLoginDate(2022, 04, 10);
            AddLoginDate(2022, 04, 17);
            AddLoginDate(2022, 04, 19);
            AddLoginDate(2022, 04, 16);
            AddLoginDate(2022, 04, 15);
            SortDate();
        }
        
        
    
    
    
    
    
    
    
    }
}
