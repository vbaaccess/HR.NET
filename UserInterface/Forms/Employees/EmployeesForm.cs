using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.DataAccessLayer.ViewModel;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {

        #region Fields
        private static EmployeesForm _instance = null;
        private static IList<EmployeeViewModel> testEmployees;
        #endregion

        #region Propertes
        public static EmployeesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeesForm();
                }

                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                    return true;

                return false;
            }

        }

        #endregion

        #region Constructior
        public EmployeesForm()
        {
            InitializeComponent();
            testEmployees = GetTestEmployees();
            PrepareEmployessData();
        }
        #endregion

        #region Private Metods

        private void PrepareEmployessData()
        {
            //sort data by column Code
            //var testEmployeesSorted = testEmployees.OrderBy(x => x.Code).AsEnumerable();  //Linq
            var testEmployeesSorted = testEmployees.OrderBy(x => x.Code).ToList();          //Linq
            BindingSourceEmployees.DataSource = new BindingList<EmployeeViewModel>(testEmployees);
            dgvEmployees.DataSource = BindingSourceEmployees;
        }

        private IList<EmployeeViewModel> GetTestEmployees()
        {
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
                },
                new EmployeeModel()
                {
                    Id = 1
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
            };

            return MappingHelper.MapEmpoyeeModellToEmployeeViewModel(testEmployeesModel);
        }
        #endregion

        #region Private Metods

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        #endregion

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm frm = new EmployeeAddForm();
            frm.ShowDialog();
        }
    }
}
