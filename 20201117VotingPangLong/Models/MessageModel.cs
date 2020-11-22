using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20201117VotingPangLong.Models
{
    public class MessageModel
    {
        public MessageModel()
        {
            RespCode = "";
            RespDesp = "";
            RespType = "";
        }
        public MessageModel(String l_RespCode,String l_RespDesp,String l_RespType)
        {
            RespCode = l_RespCode;
            RespDesp = l_RespDesp;
            RespType = l_RespType;
        }
        public string RespCode { get; set; }
        public string RespDesp { get; set; }
        public string RespType { get; set; }
    }
    
}