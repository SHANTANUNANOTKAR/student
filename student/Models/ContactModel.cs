using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using student.Data;

namespace student.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public string SaveContact(ContactModel model)
        {
            string msg = "";
            studentEntities Db = new studentEntities();
            var studentData = new tblContact()
            {
                Name = model.Name,
                Address = model.Address,
                Contact = model.Contact,

            };
            Db.tblContacts.Add(studentData);
            Db.SaveChanges();
            return msg;

        }
    }
}


