using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static _20201117VotingPangLong.Common.IsDBNullClass;
namespace _20201117VotingPangLong.Models
{
    public class VoteTypeModel
    {
        public List<VoteTypeEntity> lstVoteType { get; set; }
        public MessageModel Msg { get; set; }
        public int VoteTypeId { get; set; }
        public string VoteTypeCode { get; set; }
        public string VoteTypeName { get; set; }
    }
    public class VoteTypeEntity
    {
        public VoteTypeEntity(DataRow dr)
        {
            VoteTypeId = IsDBNullReturnInt("VoteTypeId",dr);
            VoteTypeCode = IsDBNull("VoteTypeCode", dr);
            VoteTypeName = IsDBNull("VoteTypeName", dr);
        }
        public int VoteTypeId { get; set; }
        public string VoteTypeCode { get; set; }
        public string VoteTypeName { get; set; }
    }

}