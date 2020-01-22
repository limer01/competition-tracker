using System;
using System.Collections.Generic;
using System.Text;
using TrackerLib.Models;
using TrackerLib.DataAccess.TextHelpers

namespace TrackerLib.DataAccess
{
    public class TextConnector : IDataConnection   
    {
        private const string PrizesFile = "PrizeModels.csv";
        //TODO  Make the create prize method actually save to the textfiles
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load Text File
            //convert to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            int currentId = prizes.

            //Find ID
            //Add new record with the new ID
            //convert prozes to list<String>
            //save the list>string> to the text file 

      
        }
    }
}
