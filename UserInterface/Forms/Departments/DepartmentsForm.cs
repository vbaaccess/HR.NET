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

namespace SystemHR.UserInterface.Forms.Departments
{
    public partial class DepartmentsForm : BaseForm
    {
        private static DepartmentsForm _instance = null;

        public static DepartmentsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DepartmentsForm();
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

        public DepartmentsForm()
        {
            InitializeComponent();
        }

        private void Event_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
