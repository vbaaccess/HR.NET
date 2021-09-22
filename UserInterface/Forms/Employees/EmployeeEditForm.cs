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
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeEditForm : BaseAddEditForm
    {
        #region Fields
        private EmployeeModel employee;
        public EventHandler ReloadEmployees;
        #endregion

        #region Constructor
        public EmployeeEditForm(int employeeId)
        {
            InitializeComponent();
            employee = GetTestEmployees(employeeId);
            InitializeDate();
            PrepareEmplyeeDate(employee);
            ValidateControls();
        }
        #endregion

        #region Private Metods
        private void PrepareEmplyeeDate(EmployeeModel employee)
        {
            txtLastName.Text = employee.LastName;
            txtFirstName.Text = employee.Firstname;
            cbGender.Text = employee.Gender != null ? employee.Gender.Value : null;
            dtpDateBirth.Value = employee.DateBirth.Value; //DateTimePickerValueChanged
            txtPesel.Text = employee.PESEL;
            txtPhoneNumber.Text = employee.PhoneNumber;
            txtEmailAddress.Text = employee.EmailAddress;
            txtIdentityCardNumber.Text = employee.IdentityCardNumber;
            dtpIssueDateIdentityCard.Value = employee.IssueDateIdentityCard.Value;
            txtPassportNumber.Text = employee.PassportNumber;
            dtpIssueDatePassport.Value = employee.IssueDatePassport.Value;
            dtpExpirationDatePassport.Value = employee.ExpirationDatePassport.Value;

            lblEmployee.Text = $"{employee.Firstname} {employee.LastName} ({employee.Code.ToString().PadLeft(4,'0')} - {employee.Status})";
        }

        private EmployeeModel GetTestEmployees(int employeeId)
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

            EmployeeModel testEmployeeModel = testEmployeesModel.Where(x => x.Id == employeeId).FirstOrDefault();
            return testEmployeeModel;
        }

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
                epLastName.SetError(txtLastName, "Pole Nazwisko jest wymagane.");
            else
                epLastName.Clear();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                epFirstName.SetError(txtFirstName, "Pole Imie jest wymagane.");
            else
                epFirstName.Clear();
        }

        private void InitializeDate()
        {
            IList<GenderModel> genders = new List<GenderModel>()
            {
                new GenderModel("Kobieta")
              , new GenderModel("Mężczyzna")
              , new GenderModel(string.Empty)
            };

            BindingSourceGender.DataSource = genders;
            cbGender.Text = string.Empty;
        }

        private bool ValidateForm()
        {

            bool ValidationCheckResult = true;

            #region MessageBox Parameters
            string sMsCaption = "Dodawanie pracownika";
            StringBuilder sbMessage = new StringBuilder();

            DialogResult msAnswer = DialogResult.Yes;               // it's means everything is OK , you can start save
            MessageBoxButtons msButtons = MessageBoxButtons.YesNo;  // default
            MessageBoxIcon msIcon = MessageBoxIcon.Information;     // default
            #endregion

            #region MessageBox Errora Cheking
            // string - jest immutowalny (niezmienny) przy "zmianie" tworzymy tak naprawde nowy obiekt na stercie pamieci
            // StringBuilder- reprezentuje modyfikowalny ciag znakow
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = epLastName.GetError(txtLastName);

            if (!string.IsNullOrEmpty(lastNameErrorMessage))
                sbErrorMessage.Append(Environment.NewLine + lastNameErrorMessage);

            string firsNameErrorMessage = epFirstName.GetError(txtFirstName);
            if (!string.IsNullOrEmpty(firsNameErrorMessage))
                sbErrorMessage.Append(Environment.NewLine + firsNameErrorMessage);

            if (sbErrorMessage.Length > 0)
            {
                sbErrorMessage.Insert(0, "Uzupelnij Dane:");
                sbMessage.Insert(0, sbErrorMessage.ToString());

                msButtons = MessageBoxButtons.OK;
                msIcon = MessageBoxIcon.Error;
                ValidationCheckResult = false;
            }
            #endregion

            #region MessageBox Warning To show
            string strWarningMessage = epPESEL.GetError(txtPesel);

            if (!string.IsNullOrEmpty(strWarningMessage))
            {
                sbMessage.Append(Environment.NewLine + strWarningMessage);
                if (sbErrorMessage.Length == 0)
                {
                    sbMessage.Append(Environment.NewLine + "Czy mimo to chcesz dodac pracownika?");
                    msButtons = MessageBoxButtons.YesNo;
                    msIcon = MessageBoxIcon.Warning;
                }
            }
            #endregion

            #region Build complet Message
            //if (!string.IsNullOrEmpty(sbMessage.ToString()))
            if (sbMessage.Length > 0)
            {
                msAnswer =
                MessageBox.Show(sbMessage.ToString()
                               , sMsCaption
                               , msButtons
                               , msIcon
                               );
                if (msAnswer == DialogResult.Yes)
                    ValidationCheckResult = true;
                else
                    ValidationCheckResult = false;

            }
            #endregion

            return ValidationCheckResult;
        }

        private EmployeeModel CreateEmployee(EmployeeModel employee)
        {
            //TO DO - save to DataBase
            employee.Id = 4;
            employee.Code = 4;

            return employee;
        }
        #endregion

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPesel_Validated(object sender, EventArgs e)
        {
            string pesel = txtPesel.Text;
            if (!string.IsNullOrWhiteSpace(pesel) && !ValidatorsHelper.IsValidPESEL(pesel))
                epPESEL.SetError(txtPesel, "Cyfra kontrola numeru PESEL jest nieprwidłowa.");
            else
                epPESEL.Clear();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChanged();
        }

        #endregion

        #region Override
        protected override void Save()
        {
            base.Save(); // w klasie bazowej jest pusto, wiec mozna to usunac

            if (ValidateForm())
            {

                employee.LastName = txtLastName.Text;
                employee.Firstname = txtFirstName.Text;
                employee.Gender = new GenderModel(cbGender.Text);
                employee.DateBirth = dtpDateBirth.Value;
                employee.PESEL = txtPesel.Text;
                employee.PhoneNumber = txtPhoneNumber.Text;
                employee.EmailAddress = txtEmailAddress.Text;
                employee.IdentityCardNumber = txtIdentityCardNumber.Text;
                employee.IssueDateIdentityCard = dtpIssueDateIdentityCard.Value;
                employee.ExpirationDateIdentityCard = dtpExpirationDateIdenitityCard.Value;
                employee.PassportNumber = txtPassportNumber.Text;
                employee.IssueDatePassport = dtpIssueDatePassport.Value;
                employee.ExpirationDatePassport = dtpExpirationDatePassport.Value;
                employee.Status = new StatusModel("Wprowadzony");


                /*TO DO
                 * Modyfikacja w bazie danych
                 */

                ReloadEmployees?.Invoke(btnSave, new EmployeeEventArgs(employee));

                Close();
            }

        }
        protected override void Cancel()
        {
            base.Cancel(); // w klasie bazowej mozna dodac dodatkowe dzialanie dla wszystkich klas pochodnych
                           // w zaleznosci od potrzeby moze ona nastapic przed lub po wywolaniu dodatkwych funkcjonalnosci
            Close();
        }
        #endregion
    }
}
