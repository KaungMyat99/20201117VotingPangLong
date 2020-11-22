using _20201117VotingPangLong.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static _20201117VotingPangLong.Common.SqlProcedureString;
using static _20201117VotingPangLong.SqlConnector.SqlConnectcor;
namespace _20201117VotingPangLong.Controllers
{
    public class VoteTypeController : Controller
    {
        // GET: VoteType
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("Listing")]
        public ActionResult VoteTypeListing()
        {
            DataSet ds = ExecuteDataSet("select * from Tbl_VoteType", CommandType.Text);
            List<VoteTypeEntity> l_lstVoteType = ds.Tables[0].AsEnumerable().Select(row=>new VoteTypeEntity(row)).ToList();
            VoteTypeModel model = new VoteTypeModel();
            model.lstVoteType = l_lstVoteType;
            return View("VoteTypeListing",model);
        }

        [HttpPost]
        [ActionName("Insert")]
        public ActionResult VoteTypeInsert(VoteTypeModel reqModel)
        {
            Connect();
            //DataSet ds = ExecuteDataSet("insert into Tbl_VoteType(VoteTypeName) values " + reqModel.VoteTypeName + "'", CommandType.Text);
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = GetSqlParameter("VoteTypeCode", reqModel.VoteTypeCode);
            sqlParameters[1] = GetSqlParameter("VoteTypeName", reqModel.VoteTypeName);
             DataSet ds = ExecuteDataSet(SP_InsertVoteType, CommandType.StoredProcedure,sqlParameters);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            MessageModel l_Msg = new MessageModel(dr["RespCode"].ToString(), dr["RespDesp"].ToString(), dr["RespType"].ToString());
            VoteTypeModel model = new VoteTypeModel();
            model.Msg = l_Msg;
            return Json(model.Msg, JsonRequestBehavior.AllowGet);
        }
    }
}