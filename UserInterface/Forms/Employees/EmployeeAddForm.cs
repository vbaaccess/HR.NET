using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Base;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeAddForm : BaseAddEditForm
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeDate();
            ValidateControls();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        protected override void Save()
        {
            base.Save(); // w klasie bazowej jest pusto, wiec mozna to usunac
            MessageBox.Show("Zapisano", "UNDER CONSTRUCTION");
            Close();
        }

        protected override void Cancel()
        {
            base.Cancel(); // w klasie bazowej mozna dodac dodatkowe dzialanie dla wszystkich klas pochodnych
                           // w zaleznosci od potrzeby moze ona nastapic przed lub po wywolaniu dodatkwych funkcjonalnosci
            MessageBox.Show("Anulowano", "UNDER CONSTRUCTION");
            Close();

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChanged();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
    }
}
