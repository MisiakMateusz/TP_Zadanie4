using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarstwaUslug;


namespace WarstwaUslug
{
    public class DataRepository
    {
        private static DataAdventureWorksDataContext dataContext = new DataAdventureWorksDataContext();
        /// <summary>
        /// Ustawianie oraz zwracanie wartości DataContext
        /// </summary>
        public static DataAdventureWorksDataContext DataContext
        {
            get => dataContext;
            set => dataContext = value;
        }

        /// <summary>
        /// Metoda wrzuca do bazy nowy Departament
        /// </summary>
        /// <param name="departament"></param>
        public static void CreateDepartament(Department departament)
        {
            dataContext.Department.InsertOnSubmit(departament);
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }

        /// <summary>
        /// Metoda zwraca wszystkie wartości z bazy i zapisuje je do List
        /// </summary>
        /// <returns></returns>
        public static List<Department> GetAllDepartament()
        {
            List<Department> departaments = (from departament in dataContext.Department
                                           select departament).ToList();

            return departaments;
        }
 


    }
}
