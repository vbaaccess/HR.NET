using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;

namespace SystemHR.DataAccessLayer
{
    public class SqlConnector : IDataConnection
    {
        #region Fields
        IList<EmployeeModel> testEmployeesModel = new List<EmployeeModel>()
            {
                    new EmployeeModel()
                {
                    Id = 1
                   ,LastName = "Pawel"
                   ,Firstname = "Duda"
                   ,Code  = 1
                   ,Gender = new GenderModel("Mężczyzna")
                   ,DateBirth = new DateTime(1978,1,1)
                   ,PESEL = "78010102177"
                   ,EmailAddress = "mailto:vba.msaccess@gmail.com"
                   ,IdentityCardNumber = "ABC123"
                   ,IssueDateIdentityCard = new DateTime(2012,9,1)
                   ,ExpirationDateIdentityCard = new DateTime(2022,9,1)
                   ,PassportNumber = "PSNR1234"
                   ,IssueDatePassport = new DateTime(2014,1,11)
                   ,ExpirationDatePassport = new DateTime(2024,1,11)
                   ,Status = new StatusModel("Wprowadzony")
                }
                ,   new EmployeeModel()
                    {
                        Id = 2
                       ,LastName = "Anna"
                       ,Firstname = "Swaczyn"
                       ,Code  = 2
                       ,Gender = new GenderModel("Kobieta")
                       ,DateBirth = new DateTime(1987,6,5)
                       ,PESEL = "87060510647"
                       ,EmailAddress = "http://vba.warszawa.pl/"
                       ,IdentityCardNumber = "XYC321"
                       ,IssueDateIdentityCard = new DateTime(2020,12,12)
                       ,ExpirationDateIdentityCard = new DateTime(2030,12,12)
                       ,PassportNumber = "PSNR2345"
                       ,IssueDatePassport = new DateTime(2018,5,26)
                       ,ExpirationDatePassport = new DateTime(2028,5,26)
                       ,Status = new StatusModel("Wprowadzony")
                    }
                ,   new EmployeeModel()
                    {
                        Id = 3
                       ,LastName = "Tadeusz"
                       ,Firstname = "Tedy"
                       ,Code  = 3
                       ,Gender = new GenderModel("Mężczyzna")
                       ,DateBirth = new DateTime(1977,12,14)
                       ,PESEL = "77121491231"
                       ,EmailAddress = "http://vba.warszawa.pl/"
                       ,IdentityCardNumber = "ABB112233"
                       ,IssueDateIdentityCard = new DateTime(2018,09,15)
                       ,ExpirationDateIdentityCard = new DateTime(2028,09,15)
                       ,PassportNumber = "P.NR.0007"
                       ,IssueDatePassport = new DateTime(2019,4,17)
                       ,ExpirationDatePassport = new DateTime(2024,4,17)
                       ,Status = new StatusModel("Wprowadzony")
                    }
            };
        #endregion

        #region Public Metods
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return testEmployeesModel;
        }

        public EmployeeModel GetEmployee(int id)
        {
            return testEmployeesModel.Single(x=>x.Id == id);
        }
        #endregion

        #region TO DO
        public EmployeeModel ModifyEmployee(EmployeeModel eModel)
        {
            return eModel;  //TO DO
        }

        public EmployeeModel CreateEmployee(EmployeeModel eModel)
        {
            return eModel;  //TO DO
        }

        public void RemoveEmployee(EmployeeModel employeesId)
        {
            //TO DO 
        }
        #endregion

    }
}
