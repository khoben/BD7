using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD7
{   
    // проверяет, есть ли доступ у данной роли к конкретному действию
    public static class CheckAccess
    {

        public static bool ChangeClient(AccessRoles role)
        {
            // только директор и сотрудник отдела по работе с клиентами может
            // менять информацию о клиентах
            if (role == AccessRoles.Director || role == AccessRoles.Manager)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
