using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using student.Data;
namespace student.Models
{
    public class regModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public string Savereg(regModel model)
        {
            string msg = "";
            studentEntities Db = new studentEntities();
            {
                var studentData = new tblreg()
                {
                    Name = model.Name,
                    Address = model.Address,
                    Mobile = model.Mobile,
                    Email = model.Email,
                };
                Db.tblregs.Add(studentData);
                Db.SaveChanges();
                return msg;
            }
        }
    }
}