using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHR.UserInterface.Forms.Base
{
    public partial class BaseAddEditForm : BaseForm
    {
        public BaseAddEditForm()
        {
            InitializeComponent();
        }

        private void BaseAddEditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
            {
                Save();
            }

            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.A)
            {
                Cancel();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        /* Metody wirtualne: 
         * to metoda ktora mozna przedefiniowac w klasach pochodnych, ma implementacje w klasie bazowej
         * w tym przypadku pozostje pusta
         * uwayamy jej gdy podstawowa funkcjonalnosc metody jest takasama ale jest potrzebne rozszerzenie funkcjonalnosci w klasie pochodnej
         * tworzymy ja w klasie bazowej (virtual) 
         * metoda ta jest zastepowana w klasie pochodnej poprzez nadpisanie (overaid)
         * za pomoca slowa kluczowego protected dzieki czemu beda one widoczne tylko w klasach pochodnych
         */
        #region Virutaln Method
        protected virtual void Save() { }
        protected virtual void Cancel() { }
        #endregion
    }
}
