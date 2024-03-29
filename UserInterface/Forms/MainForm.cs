﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Employees;
using SystemHR.UserInterface.Forms.Contracts;
using SystemHR.UserInterface.Helpers;
using SystemHR.UserInterface.Forms.OrganizationalStructure;
using SystemHR.UserInterface.Forms.Salaries;
using SystemHR.UserInterface.Forms.Departments;
using SystemHR.UserInterface.Forms.Positions;

namespace SystemHR.UserInterface.Forms
{
    public partial class MainForm : Form
    {
        #region Fields
        private TabPage _tpEmployees;
        private TabPage _tpContracts;
        private TabPage _tpOrganizationalStructure;
        private TabPage _tpSalaries;
        private TabPage _tpDepartments;
        private TabPage _tpPositions;
        #endregion

        #region Constructior
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (EmployeesForm.IsNull)
            {
                _tpEmployees = new TabPage();
                SetPropertyInTabPage(_tpEmployees, EmployeesForm.Instance);
            }
            else
                tcTabs.SelectedTab = _tpEmployees;
            //ShowFormInTabpage(_tpEmployees, EmployeesForm.Instance);
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            if (ContractsForm.IsNull)
            {
                _tpContracts = new TabPage();
                SetPropertyInTabPage(_tpContracts, ContractsForm.Instance);
            }
            else
                tcTabs.SelectedTab = _tpContracts;
            //ShowFormInTabpage(_tpContracts, ContractsForm.Instance);
        }


        private void btnOrganizationalStructure_Click(object sender, EventArgs e)
        {
            if (OrganizationalStructureForm.IsNull)
            {
                _tpOrganizationalStructure = new TabPage();
                SetPropertyInTabPage(_tpOrganizationalStructure, OrganizationalStructureForm.Instance);
            }
            else
                tcTabs.SelectedTab = _tpOrganizationalStructure;
        }

        private void btnSalaries_Click(object sender, EventArgs e)
        {
            if (SalariesForm.IsNull)
            {
                _tpSalaries = new TabPage();
                SetPropertyInTabPage(_tpSalaries, SalariesForm.Instance);
            }
            else
                tcTabs.SelectedTab = _tpSalaries;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            if (DepartmentsForm.IsNull)
            {
                _tpDepartments = new TabPage();
                SetPropertyInTabPage(_tpDepartments, DepartmentsForm.Instance);
            }
            else
                tcTabs.SelectedTab = _tpDepartments;
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            if (PositionsForm.IsNull)
            {
                _tpPositions = new TabPage();
                SetPropertyInTabPage(_tpPositions, PositionsForm.Instance);
            }
            else
                tcTabs.SelectedTab = _tpPositions;
        }

        private void tcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*
             https://social.technet.microsoft.com/wiki/contents/articles/50957.c-winform-tabcontrol-with-add-and-close-button.aspx
             */
            try
            {
                var tabPage = this.tcTabs.TabPages[e.Index];
                var tabRect = this.tcTabs.GetTabRect(e.Index);

                    var closeImage = new Bitmap(closeButtonFullPath());
                    e.Graphics.DrawImage(closeImage,
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                    TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                        tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < this.tcTabs.TabPages.Count; i++)
            {
                var tabRect = this.tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap(closeButtonFullPath());
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    //EmployeesForm.Instance.Close();
                    var frm = tcTabs.TabPages[i].Controls[0] as Form;
                    frm.Close();

                    this.tcTabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
        #endregion

        #region Private Methods
        private string closeButtonFullPath()
        {
            return $@"{ResourcesHelper.ResourcesFilePath}\{ResourcesHelper.CloseButtonName}";
        }

        private void ShowFormInTabpage(TabPage tpTab, Form frm)
        {
            SetPropertyInTabPage(tpTab, frm);
        }
        
        private void SetPropertyInTabPage(TabPage tpTab, Form frm)
        {
            tcTabs.Controls.Add(tpTab);

            tpTab.Text = frm.Text;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tcTabs.TabPages[0].Controls.Add(frm);
            tcTabs.SelectedTab = tpTab;
        }

        #endregion

        #region Public Methods
        #endregion


    }
}
