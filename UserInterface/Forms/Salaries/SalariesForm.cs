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

namespace SystemHR.UserInterface.Forms.Salaries
{
    public partial class SalariesForm : BaseForm
    {
        private static SalariesForm _instance = null;

        public static SalariesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SalariesForm();
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

        public SalariesForm()
        {
            InitializeComponent();
        }

        private void Event_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
