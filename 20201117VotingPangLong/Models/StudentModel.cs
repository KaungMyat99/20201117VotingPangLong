using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20201117VotingPangLong.Models
{
    public class StudentModel
    {
        public List<StudentEntity> lstStudent { get; set; }
       public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentFatherName { get; set; }
        public string StudentPhoneNo { get; set; }
        public string StudentYears { get; set; }
        public string StudentImage { get; set; }
    }
    public class StudentEntity
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentFatherName { get; set; }
        public string StudentPhoneNo { get; set; }
        public string StudentYears { get; set; }
        public string StudentImage { get; set; }
    }
}