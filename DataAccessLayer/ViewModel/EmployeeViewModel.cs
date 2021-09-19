using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.ViewModel
{
    // tylko te wlasciwosci ktore maja byc na formularzu-liscie pracownikow
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        private string lastName { get; set; }
        public string LastName
        {
            get { return lastName.ToUpper(); }
            set { lastName = value;  }
        }

        private string firstname { get; set; }
        public string Firstname
        {
            get { return firstname.ToUpper(); }
            set { firstname = value; }
        }

        private string code;
        public string Code
        {
            get { return code.PadLeft(4, '0');  }
            set { code = value; }
        }

        public string Position { get; set; }
        public string Status { get; set; }

        //public PositionModel Position { get; set; }
        //public StatusModel Status { get; set; }        

    }
}
