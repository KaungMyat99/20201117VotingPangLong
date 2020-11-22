using _20201117VotingPangLong.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20201117VotingPangLong.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [ActionName("Listing")]
        public ActionResult StudentListing()
        {
            List<StudentEntity> l_lstStudent = new List<StudentEntity>();

            for (int i = 1; i < 11; i++)
            {
                StudentEntity StudentEntity = new StudentEntity();
                StudentEntity.StudentId = i+"";
                StudentEntity.StudentName = "Kaung Myat Moe "+i;
                StudentEntity.StudentYears = ""+(i / 5);
                StudentEntity.StudentFatherName = "U Mg Mg "+i;
                StudentEntity.StudentImage = i+"";
                l_lstStudent.Add(StudentEntity);
            }
            //StudentModel StudentModel = new StudentModel();
            //StudentModel.lstStudent = l_lstStudent;

            List<KingQueenEntity> l_lstKingQueen = new List<KingQueenEntity>();
            l_lstKingQueen.Add(new KingQueenEntity { KingQueenId = "1", KingQueenType="The Whole" });
            l_lstKingQueen.Add(new KingQueenEntity { KingQueenId = "1", KingQueenType="Popular" });
            l_lstKingQueen.Add(new KingQueenEntity { KingQueenId = "1", KingQueenType="Smart" });
            l_lstKingQueen.Add(new KingQueenEntity { KingQueenId = "1", KingQueenType="Miss" });

            //KingQueenModel KingQueenModel = new KingQueenModel();
            //KingQueenModel.lstKingQueen = l_lstKingQueen;

            dynamic model = new ExpandoObject();
            model.StudentModel = l_lstStudent;
            model.KingQueenModel = l_lstKingQueen;
            return View("StudentListing",model);
        }
    }
}