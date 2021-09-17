﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        private static EmployeesForm _instance = null;

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
        }

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
