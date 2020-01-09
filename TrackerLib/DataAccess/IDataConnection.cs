using System;
using System.Collections.Generic;
using System.Text;
using TrackerLib.Models;

namespace TrackerLib.DataAccess
{
    public interface IDataConnection
    {
        Models.PrizeModel CreatePrize(PrizeModel model);
    }
}
