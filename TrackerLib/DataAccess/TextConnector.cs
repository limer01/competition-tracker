using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackerLib.Models;
using TrackerLib.DataAccess.TextHelpers;

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

            //Find ID
            int currentId = 1;

            if(prizes.Count > 0)
            {
                currentId = currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            //Add new record with the new ID
            prizes.Add(model);

            //convert prozes to list<String>
            //save the list>string> to the text file 
            prizes.SaveToPrizeFile(PrizesFile);

            return model;

      
        }
    }
}
