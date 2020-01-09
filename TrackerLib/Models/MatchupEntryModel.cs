using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLib.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Reprsents one team in teh matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }
    }
}
