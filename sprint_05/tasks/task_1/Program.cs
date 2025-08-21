/* task 1
1. Create interface IDeveloper with property Tool, methods Create() and Destroy

2. Create two classes Programmer (with field language) and Builder (with field tool), which implement this interface.

Create method should print "Programmer created" to the console for the Programmer class and "Builder created" for the Builder class.

Destroy method should print "Programmer destroyed" to the console for the Programmer class and "Builder destroyed" for the Builder class.

3. Create default implementation of interface IComparable<IDeveloper> in IDeveloper interface. Compare IDevelopers by Tool property.

4. Create class TeamWork with static void function SortTeamMembers that takes an array of IDeveloper and sorts this array.
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task_1
{
    public class TeamWork
    {
        public static void SortTeamMembers(IDeveloper[] ideveloper)
        {
            Array.Sort(ideveloper);
        }
    }

}