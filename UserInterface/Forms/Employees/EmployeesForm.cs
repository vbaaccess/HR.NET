﻿using System;
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

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        private static EmployeesForm _instance = null;

        private static IList<EmployeeViewModel> testEmployees;

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

        public EmployeesForm()
        {
            InitializeComponent();
            testEmployees = GetFakeEmployees();
            PrepareEmployessData();
        }

        private void PrepareEmployessData()
        {
            BindingSourceEmployees.DataSource = new BindingList<EmployeeViewModel>(testEmployees);
        }

        private IList<EmployeeViewModel> GetFakeEmployees()
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
                   ,PESEL = "123456"
                   ,EmailAddress = "mailto:vba.msaccess@gmail.com"
                   ,IdentityCardNumber = "ABC123"
                   ,IssueDateIdentityCard = new DateTime(2012,9,1)
                   ,ExpirationDateIdentityCard = new DateTime(2022,9,1)
                   ,PassportNumber = "PSNR1234"
                   ,IssueDatePassport = new DateTime(2014,1,11)
                   ,ExpirationDatePassport = new DateTime(2024,1,11)
                   ,Status = new StatusModel("Wprowdzony")
                },
                new EmployeeModel()
                {
                    Id = 1
                   ,LastName = "Anna"
                   ,Firstname = "Swaczyn"
                   ,Code  = 2
                   ,Gender = new GenderModel("Kobieta")
                   ,DateBirth = new DateTime(1987,6,5)
                   ,PESEL = "234567"
                   ,EmailAddress = "http://vba.warszawa.pl/"
                   ,IdentityCardNumber = "XYC321"
                   ,IssueDateIdentityCard = new DateTime(2020,12,12)
                   ,ExpirationDateIdentityCard = new DateTime(2030,12,12)
                   ,PassportNumber = "PSNR2345"
                   ,IssueDatePassport = new DateTime(2018,5,26)
                   ,ExpirationDatePassport = new DateTime(2028,5,26)
                   ,Status = new StatusModel("Wprowdzony")
                }
            };

            IList<EmployeeViewModel> testEmployeesViewModel = new List<EmployeeViewModel>();
            //EmployeeViewModel  fakeEmployeesViewModel = new EmployeeViewModel();

            foreach (EmployeeModel fakeEmployeeModel in testEmployeesModel)
            {
                               // fakeEmployeesViewModel
                EmployeeViewModel fEVM = new EmployeeViewModel();
                fEVM.Id =  fakeEmployeeModel.Id;
                fEVM.LastName = fakeEmployeeModel.LastName;
                fEVM.Firstname = fakeEmployeeModel.Firstname;
                fEVM.Code = fakeEmployeeModel.Code.ToString();
                fEVM.Position = string.Empty;
                fEVM.Status = fakeEmployeeModel.Status.ToString();

                testEmployeesViewModel.Add(fEVM);

            }

            return testEmployeesViewModel;
        }

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
