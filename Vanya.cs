using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    class Vanya : User
    {
        public Vanya()
        {
            User.Name = "Ваня";
            AddLoginDate(2022, 04, 12);
            AddLoginDate(2022, 04, 15);
            AddLoginDate(2022, 04, 13);
            AddLoginDate(2022, 04, 17);
            AddLoginDate(2022, 04, 19);
            AddLoginDate(2022, 04, 16);
            SortDate();
        }
        
        
    
    
    
    
    
    
    
    }
}
