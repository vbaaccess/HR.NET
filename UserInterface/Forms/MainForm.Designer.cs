namespace SystemHR.UserInterface.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMaing = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.btnPositions = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnOrganizationalStructure = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnContracts = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tcMaing.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMaing
            // 
            this.tcMaing.Controls.Add(this.tpGeneral);
            this.tcMaing.Controls.Add(this.tpConfiguration);
            this.tcMaing.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMaing.Location = new System.Drawing.Point(0, 0);
            this.tcMaing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcMaing.Name = "tcMaing";
            this.tcMaing.SelectedIndex = 0;
            this.tcMaing.Size = new System.Drawing.Size(770, 70);
            this.tcMaing.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnPositions);
            this.tpGeneral.Controls.Add(this.splitter5);
            this.tpGeneral.Controls.Add(this.btnDepartment);
            this.tpGeneral.Controls.Add(this.splitter4);
            this.tpGeneral.Controls.Add(this.btnSalaries);
            this.tpGeneral.Controls.Add(this.splitter3);
            this.tpGeneral.Controls.Add(this.btnOrganizationalStructure);
            this.tpGeneral.Controls.Add(this.splitter2);
            this.tpGeneral.Controls.Add(this.btnContracts);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnEmployees);
            this.tpGeneral.Location = new System.Drawing.Point(4, 25);
            this.tpGeneral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpGeneral.Size = new System.Drawing.Size(762, 41);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // btnPositions
            // 
            this.btnPositions.BackColor = System.Drawing.Color.White;
            this.btnPositions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPositions.Image = ((System.Drawing.Image)(resources.GetObject("btnPositions.Image")));
            this.btnPositions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPositions.Location = new System.Drawing.Point(644, 4);
            this.btnPositions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(112, 33);
            this.btnPositions.TabIndex = 11;
            this.btnPositions.Text = "Stanowiska";
            this.btnPositions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPositions.UseVisualStyleBackColor = false;
            this.btnPositions.Click += new System.EventHandler(this.btnPositions_Click);
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(639, 4);
            this.splitter5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(5, 33);
            this.splitter5.TabIndex = 10;
            this.splitter5.TabStop = false;
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.White;
            this.btnDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartment.Image")));
            this.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.Location = new System.Drawing.Point(552, 4);
            this.btnDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(87, 33);
            this.btnDepartment.TabIndex = 9;
            this.btnDepartment.Text = "Działy";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(547, 4);
            this.splitter4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 33);
            this.splitter4.TabIndex = 8;
            this.splitter4.TabStop = false;
            // 
            // btnSalaries
            // 
            this.btnSalaries.BackColor = System.Drawing.Color.White;
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalaries.Image = ((System.Drawing.Image)(resources.GetObject("btnSalaries.Image")));
            this.btnSalaries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaries.Location = new System.Drawing.Point(408, 4);
            this.btnSalaries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(139, 33);
            this.btnSalaries.TabIndex = 7;
            this.btnSalaries.Text = "Wynagrodzenia";
            this.btnSalaries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalaries.UseVisualStyleBackColor = false;
            this.btnSalaries.Click += new System.EventHandler(this.btnSalaries_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(403, 4);
            this.splitter3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 33);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // btnOrganizationalStructure
            // 
            this.btnOrganizationalStructure.BackColor = System.Drawing.Color.White;
            this.btnOrganizationalStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrganizationalStructure.Image = ((System.Drawing.Image)(resources.GetObject("btnOrganizationalStructure.Image")));
            this.btnOrganizationalStructure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizationalStructure.Location = new System.Drawing.Point(220, 4);
            this.btnOrganizationalStructure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrganizationalStructure.Name = "btnOrganizationalStructure";
            this.btnOrganizationalStructure.Size = new System.Drawing.Size(183, 33);
            this.btnOrganizationalStructure.TabIndex = 5;
            this.btnOrganizationalStructure.Text = "Struktura organizacyjna";
            this.btnOrganizationalStructure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrganizationalStructure.UseVisualStyleBackColor = false;
            this.btnOrganizationalStructure.Click += new System.EventHandler(this.btnOrganizationalStructure_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(215, 4);
            this.splitter2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 33);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // btnContracts
            // 
            this.btnContracts.BackColor = System.Drawing.Color.White;
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContracts.Image = ((System.Drawing.Image)(resources.GetObject("btnContracts.Image")));
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(128, 4);
            this.btnContracts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(87, 33);
            this.btnContracts.TabIndex = 3;
            this.btnContracts.Text = "Umowy";
            this.btnContracts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContracts.UseVisualStyleBackColor = false;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(123, 4);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 33);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.White;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(3, 4);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 33);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Pracownicy";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Location = new System.Drawing.Point(4, 25);
            this.tpConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpConfiguration.Size = new System.Drawing.Size(762, 41);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDatabase,
            this.tssUser});
            this.ssMain.Location = new System.Drawing.Point(0, 670);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ssMain.Size = new System.Drawing.Size(770, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(72, 17);
            this.tsslVersion.Text = "Wersja: 1.0.0";
            // 
            // tsslDatabase
            // 
            this.tsslDatabase.Image = ((System.Drawing.Image)(resources.GetObject("tsslDatabase.Image")));
            this.tsslDatabase.Name = "tsslDatabase";
            this.tsslDatabase.Size = new System.Drawing.Size(141, 17);
            this.tsslDatabase.Text = "Baza: HumanResource";
            // 
            // tssUser
            // 
            this.tssUser.Image = ((System.Drawing.Image)(resources.GetObject("tssUser.Image")));
            this.tssUser.Name = "tssUser";
            this.tssUser.Size = new System.Drawing.Size(152, 17);
            this.tssUser.Text = "Użytkownik: Paweł Duda";
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.tcTabs);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 70);
            this.pMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(770, 600);
            this.pMain.TabIndex = 2;
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(770, 600);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcTabs_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcTabs_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 692);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMaing);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR.NET - System zarządzania pracownikami";
            this.tcMaing.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMaing;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnOrganizationalStructure;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tssUser;
        private System.Windows.Forms.TabControl tcTabs;
    }
}