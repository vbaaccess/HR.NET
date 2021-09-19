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
        public static IList<EmployeeViewModel> MapEmpoyeeModellToEmployeeViewModel
            (IList<EmployeeModel> employeeModelToMap)
        {
            // mozna uzyc biblioteki do mapowania obiektow 

            IList<EmployeeViewModel> MappedEmployeesViewModel = new List<EmployeeViewModel>();

            foreach (EmployeeModel pomEmployeeModel in employeeModelToMap)
            {
                // mappedRecordEmployeesViewModel
                EmployeeViewModel mrEmployee = new EmployeeViewModel();
                mrEmployee.Id = pomEmployeeModel.Id;
                mrEmployee.LastName = pomEmployeeModel.LastName;
                mrEmployee.Firstname = pomEmployeeModel.Firstname;
                mrEmployee.Code = pomEmployeeModel.Code.ToString();
                mrEmployee.Position = string.Empty;
                mrEmployee.Status = pomEmployeeModel.Status.ToString();

                MappedEmployeesViewModel.Add(mrEmployee);

            }

            return MappedEmployeesViewModel;

        }
    }
}
