using System;
using System.Collections.Generic;
using System.Text;
using TrackerLib.Models;

namespace TrackerLib.DataAccess
{
    public class TextConnector : IDataConnection
    {
        //TODO  Make the create prize method actually save to the textfiles
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
