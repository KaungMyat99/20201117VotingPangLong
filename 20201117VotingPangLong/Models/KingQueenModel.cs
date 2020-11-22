using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20201117VotingPangLong.Models
{
    public class KingQueenModel
    {
        public List<KingQueenEntity> lstKingQueen { get; set; }
        public string KingQueenId { get; set; }
        public string KingQueenType { get; set; }
    }
    public class KingQueenEntity
    {
        public string KingQueenId { get; set; }
        public string KingQueenType { get; set; }
    }
}