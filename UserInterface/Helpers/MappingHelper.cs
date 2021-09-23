using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.ViewModel;

namespace SystemHR.UserInterface.Helpers
{
    public class MappingHelper
    {
        public static IList<EmployeeViewModel> MapEmpoyeeModelToEmployeeViewModel
            (IEnumerable<EmployeeModel> employeesModelToMap)
        {
            // mozna uzyc biblioteki do mapowania obiektow 

            IList<EmployeeViewModel> employeesViewModelToReturn = new List<EmployeeViewModel>();

            foreach (EmployeeModel werEmployeeModel in employeesModelToMap)
            {
                // mappedRecordEmployeesViewModel
                EmployeeViewModel employeeViewModelToBeAdded = new EmployeeViewModel();
                employeeViewModelToBeAdded.Id = werEmployeeModel.Id;
                employeeViewModelToBeAdded.LastName = werEmployeeModel.LastName;
                employeeViewModelToBeAdded.Firstname = werEmployeeModel.Firstname;
                employeeViewModelToBeAdded.Code = werEmployeeModel.Code.ToString();
                employeeViewModelToBeAdded.Position = string.Empty;
                employeeViewModelToBeAdded.Status = werEmployeeModel.Status.ToString();

                employeesViewModelToReturn.Add(employeeViewModelToBeAdded);

            }

            return employeesViewModelToReturn;

        }
        
        // metoda przeciazeniowa 
        public static EmployeeViewModel MapEmpoyeeModelToEmployeeViewModel (EmployeeModel employeeModelToMap)
        {
            // mozna uzyc biblioteki do mapowania obiektow 
                // mappedRecordEmployeesViewModel
                EmployeeViewModel employeeViewModelToReturn = new EmployeeViewModel();
                employeeViewModelToReturn.Id = employeeModelToMap.Id;
                employeeViewModelToReturn.LastName = employeeModelToMap.LastName;
                employeeViewModelToReturn.Firstname = employeeModelToMap.Firstname;
                employeeViewModelToReturn.Code = employeeModelToMap.Code.ToString();
                employeeViewModelToReturn.Position = string.Empty;
                employeeViewModelToReturn.Status = employeeModelToMap.Status.ToString();

            return employeeViewModelToReturn;

        }

    }
}
