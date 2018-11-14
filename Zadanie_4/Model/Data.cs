using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarstwaUslug;

namespace Zadanie_4.Model
{
    class Data
    {
        public IEnumerable<Department> Departament
        {
            get
            {
                List<Department> departaments = DataRepository.GetAllDepartament();
                return departaments;
            }
        }

    }
}
