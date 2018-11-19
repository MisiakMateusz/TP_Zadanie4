using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarstwaUslug;
using Zadanie_4.Model;
using Zadanie_4.ViewModel;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows;

namespace Zadanie_4.ViewModel
{
    class MainViewModel : BindableBase
    {
        private ObservableCollection<Department> departament;
        
        private Department obecnyDepartament;
        private Data dataLayer;

        private short newDepartamentID;
        /// <summary>
        /// Pobiera z pola tekstowego wartość DepartamentID
        /// </summary>
        public short NewDepartamentID
        {
            get => newDepartamentID;
            set
            {
                newDepartamentID = value;
                RaisePropertyChanged();
            }
        }

        private string newName;
        /// <summary>
        /// Pobiera z pola tekstowego nazwę departament działu(Departamentu)
        /// </summary>
        public string NewName
        {
            get => newName;
            set
            {
                newName = value;
                RaisePropertyChanged();
            }
        }

        private string newGroupName;
        /// <summary>
        /// Pobiera z pola tekstowego nazwę grupy działu(Departamentu)
        /// </summary>
        public string NewGroupName
        {
            get => newGroupName;
            set
            {
                newGroupName = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Właściwość zwraca kolekcje Departament lub ustawia
        /// </summary>
        public ObservableCollection<Department> Departament
        {
            get => departament;
            set
            {
                departament = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Metoda zwraca aktualnie używany obiekt
        /// </summary>
        public Department ObecnyDepartament
        {
            get => obecnyDepartament;
            set
            {
                obecnyDepartament = value;
                RaisePropertyChanged();
                              
            }
        }

        /// <summary>
        /// Ustawianie oraz zwracanie wartości Data
        /// </summary>
        public Data Data
        {
            
            get => dataLayer;
            set
            {
                dataLayer = value;
                Departament = new ObservableCollection<Department>(value.Departament);
              
            }
        }
     
        //Delegaty
        public DelegateCommand AddDepartament { get; private set; }
        public DelegateCommand GetAllDepartament { get; private set; }
        public DelegateCommand DeleteDepartment { get; private set; }


        /// <summary>
        /// Konstruktor bezparametrowy MainViewModel
        /// </summary>
        public MainViewModel()
        {

            dataLayer = new Data();
            AddDepartament = new DelegateCommand(AddDepartaments);
            departament = new ObservableCollection<Department>();
            DeleteDepartment = new DelegateCommand(DeleteDepartments);
            GetAllDepartament = new DelegateCommand(() => Data = new Data());
           
        }

        /// <summary>
        /// Metoda usuwa obiekt z listy oraz z bazy danych
        /// </summary>
        private void DeleteDepartments()
        {
            Task.Run(() => DataRepository.DeleteDepartment(obecnyDepartament.DepartmentID));
            departament.Remove(obecnyDepartament);
        }

        /// <summary>
        /// Metoda Przekazuje uworzony departament do DataRepository
        /// </summary>
        private void AddDepartaments()
        {
            if (newName.Length <= 50 && newGroupName.Length <= 50)
            {
                Department dp = new Department()
                {

                    DepartmentID = newDepartamentID,
                    GroupName = newGroupName,
                    Name = newName,
                    ModifiedDate = DateTime.Now
                };
                departament.Add(dp);
                Task.Run(() => { DataRepository.CreateDepartament(dp); });
            }
            else MessageBox.Show("Podane dane nie mogą zostać przekazane do bazy danych", "Błąd");
        }


    }
}
