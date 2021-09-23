using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;

namespace SystemHR.DataAccessLayer
{
    public interface IDataConnection
    {
        IEnumerable<EmployeeModel> GetEmployees();
        EmployeeModel GetEmployee(int id);
        EmployeeModel CreateEmployee(EmployeeModel eModel);
        EmployeeModel ModifyEmployee(EmployeeModel eModel);
        void RemoveEmployee(EmployeeModel employeesId);

    }
}
