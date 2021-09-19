using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models.Dictionaries;

namespace SystemHR.DataAccessLayer.Models
{
    public class EmployeeModel : EntityModel
    {
        public string LastName { get; set; }
        public string Firstname { get; set; }
        public int Code { get; set; }
        public GenderModel Gender { get; set; }
        public DateTime? DateBirth { get; set; }
        public string PESEL { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string IdentityCardNumber { get; set; }
        public DateTime? IssueDateIdentityCard { get; set; }
        public DateTime? ExpirationDateIdentityCard { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? IssueDatePassport { get; set; }
        public DateTime? ExpirationDatePassport { get; set; }
        public StatusModel Status { get; set; }
        
    }
}
