using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Base;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeAddForm : BaseAddEditForm
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
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

    }
}
