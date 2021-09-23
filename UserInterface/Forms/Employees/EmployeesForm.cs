using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.DataAccessLayer.ViewModel;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : BaseForm
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
            
            IEnumerable<EmployeeModel> employees = GlobalConfig.Connection.GetEmployees();
            testEmployees = MappingHelper.MapEmpoyeeModelToEmployeeViewModel(employees);

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

        #endregion

        #region Events

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm frm = new EmployeeAddForm();
            frm.ReloadEmployees += (s, ea) =>
             {
                 //MessageBox.Show("ReloadEmployees Invoke");

                 // odczytuje dane zdarzenia
                 EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;
                 if (eventArgs!=null)
                 {
                     EmployeeViewModel employee 
                        = MappingHelper.MapEmpoyeeModelToEmployeeViewModel(eventArgs.Employee);
                     BindingSourceEmployees.Add(employee);

                     dgvEmployees.ClearSelection();
                     dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                 };
             };
            frm.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            int employeesId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);
            int selectedRowIndex = dgvEmployees.CurrentRow.Index;

            EmployeeEditForm frm = new EmployeeEditForm(employeesId);

            frm.ReloadEmployees += (s, ea) =>
            {
                //MessageBox.Show("ReloadEmployees Invoke");

                // odczytuje dane zdarzenia
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;
                if (eventArgs != null)
                {
                    EmployeeViewModel employee
                       = MappingHelper.MapEmpoyeeModelToEmployeeViewModel(eventArgs.Employee);

                    BindingSourceEmployees[selectedRowIndex] = employee;

                    //BindingSourceEmployees.Add(employee);

                    //dgvEmployees.ClearSelection();
                    //dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                };
            };

            frm.ShowDialog();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);
            int selectedRowIndex = dgvEmployees.CurrentRow.Index;

            // TO DO - ultimately deleting from the database 
            // RemoveEmployee(employeesId);

            EmployeeViewModel employee = testEmployees.Where(x => x.Id == employeeId).FirstOrDefault();
            if (employee != null)
            {
                BindingSourceEmployees.Remove(employee);
                if (dgvEmployees.Rows.Count>1)
                {
                    dgvEmployees.ClearSelection();
                    dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            //TO DO
        }
        #endregion

    }
}
