using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class ContactData
    {
        private string firstname;
        private string middlename;
        //Если потребуется добавлять новые поля для заполнения
        //private string SomeNewField = "";

        public ContactData(string firstname, string middlename)
        {
            this.firstname = firstname;
            this.middlename = middlename;
        }

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }
        //Если потребуется добавлять новые поля для заполнения
        //public string SomeNewField
        //{
        //    get
        //    {
        //        return somenewfield;
        //    }
        //    set
        //    {
        //        somenewfield = value;
        //    }
        //}
    }
}
