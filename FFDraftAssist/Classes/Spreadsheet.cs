using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.ComponentModel;

namespace FFDraftAssist
{

    public class Spreadsheet : PlayerRankings
    {

        public string filePath = "";
        public string fileName = "";
        public SpreadsheetSettings settings;
        private SpreadsheetDocument document;

        public Spreadsheet()
        {

            defaultSettings();

        }

        public void test()
        {
            Console.WriteLine(DateTime.Now);

            using (document = SpreadsheetDocument.Open(filePath, false))
            {

                foreach (Player play in GetPlayers())
                {

                    Console.WriteLine(play.toShortString());

                }
            }

            Console.WriteLine(DateTime.Now);
        }

        private void defaultSettings()
        {

            settings = new SpreadsheetSettings();

            filePath = "Beersheets.xlsx";

            PositionSettings posQB = new PositionSettings();
            posQB.position = "QB";
            posQB.colName = "B";        // Player Name
            posQB.colTeam = "C";        // Team Name
            posQB.colRank = "D";        // Player Rank
                                        //posQB.colPerf = "H";		// Last Season Performance
            posQB.colVal = "G";         // Player Value
            posQB.colScarcity = "I";    // Scarcity
            posQB.colTier = "J";        // Tier
            posQB.rowStart = 6;         // First Player Row Number
            posQB.rowEnd = 41;          // Last Player Row Number

            PositionSettings posRB = new PositionSettings();
            posRB.position = "RB";
            posRB.colName = "L";
            posRB.colTeam = "M";
            posRB.colRank = "N";
            //posRB.colPerf = "S";
            posRB.colVal = "Q";
            posRB.colScarcity = "S";
            posRB.colTier = "T";
            posRB.rowStart = 6;
            posRB.rowEnd = 65;

            PositionSettings posWR = new PositionSettings();
            posWR.position = "WR";
            posWR.colName = "V";
            posWR.colTeam = "W";
            posWR.colRank = "X";
            //posWR.colPerf = "AD";
            posWR.colVal = "AA";
            posWR.colScarcity = "AC";
            posWR.colTier = "AD";
            posWR.rowStart = 6;
            posWR.rowEnd = 65;

            PositionSettings posTE = new PositionSettings();
            posTE.position = "TE";
            posTE.colName = posQB.colName;      // Player Name
            posTE.colTeam = posQB.colTeam;      // Team Name
            posTE.colRank = posQB.colRank;      // Player Rank
            posTE.colPerf = posQB.colPerf;      // Last Season Performance
            posTE.colVal = posQB.colVal;            // Player Value
            posTE.colScarcity = posQB.colScarcity;  // Scarcity
            posTE.colTier = posQB.colTier;      // Tier
            posTE.rowStart = 45;
            posTE.rowEnd = 65;

            PositionSettings posKick = new PositionSettings();
            posKick.position = "K";
            posKick.colName = "B";
            posKick.rowStart = 69;
            posKick.rowEnd = 83;
            posKick.colTier = "B";

            PositionSettings posDef = new PositionSettings();
            posDef.position = "DEF";
            posDef.colName = "C";
            posDef.colBye = "H";
            posDef.colTier = "C";
            posDef.rowStart = 69;
            posDef.rowEnd = 83;

            settings.posSettings.Add(posQB);
            settings.posSettings.Add(posRB);
            settings.posSettings.Add(posWR);
            settings.posSettings.Add(posTE);
            settings.posSettings.Add(posKick);
            settings.posSettings.Add(posDef);

        }

        public override List<Player> GetPlayers(Draft draft = null)
        {

            List<Player> obsPlayers = new List<Player>();

            using (document = SpreadsheetDocument.Open(filePath, false))
            {

                foreach (PositionSettings posSettings in settings.posSettings)
                {

                    for (int i = posSettings.rowStart; i <= posSettings.rowEnd; i++)
                    {

                        Player play = new Player();
                        play.Position = posSettings.position;

                        play.PlayerName = getCellValue(posSettings.colName + i);
                        play.Team = getCellValue(posSettings.colTeam + i);
                        play.Rank = tryToDouble(getCellValue(posSettings.colRank + i).Replace("|", "."));
                        play.Performance = getCellValue(posSettings.colPerf + i);
                        play.Value = tryToDouble(getCellValue(posSettings.colVal + i));
                        play.ScarcityPerc = tryToDouble(getCellValue(posSettings.colScarcity + i).Replace("%", "")) * 100;
                        play.Tier = tryToInt(getCellValue(posSettings.colTier + i).Replace("+", "").Replace("-", ""));
                        play.Draft = draft;
                        play.SplitTeamBye();
                        play.SplitStringNum();
                        play.BuildPositionString();
                        play.GetPeformanceKey();

                        if (play.Tier == 0)
                            play.Tier = 1;

                        if (play.Position == "DEF" || play.Position == "K")
                            play.Value = -99;

                        if (draft != null)
                        {
                            play.DraftStrategy = draft.PlayerDraftStrategies.Where(ps => ps.PlayerName == play.PlayerName).FirstOrDefault();
                        }

                        if (!String.IsNullOrEmpty(play.PlayerName))
                        {
                            obsPlayers.Add(play);
                        }
                    }
                }

            }

            List<Player> additionalPlayers = GetAdditionalPlayers(draft);

            foreach(Player addPlayer in additionalPlayers)
            {
                if (obsPlayers.Where(p => p.PlayerName == addPlayer.PlayerName).Count() == 0)
                {
                    obsPlayers.Add(addPlayer);

                    if (draft != null)
                    {
                        addPlayer.DraftStrategy = draft.PlayerDraftStrategies.Where(ps => ps.PlayerName == addPlayer.PlayerName).FirstOrDefault();
                    }
                }
            }

            return obsPlayers;

        }

        private List<Player> GetAdditionalPlayers(Draft draft = null)
        {
            List<Player> additionalPlayers = new List<Player>();

            additionalPlayers.Add(new Player()
            {
                PlayerName = "Marquez Callaway",
                Team = "NO",
                Value  = -99,
                Draft = draft,
                Bye = 6,
                Position = "WR"
            });

            additionalPlayers.Add(new Player()
            {
                PlayerName = "Tony Jones",
                Team = "NO",
                Value = -99,
                Draft = draft,
                Bye = 6,
                Position = "RB"
            });

            additionalPlayers.Add(new Player()
            {
                PlayerName = "Chuba Hubbard",
                Team = "CAR",
                Value = -99,
                Draft = draft,
                Bye = 13,
                Position = "RB"
            });

            return additionalPlayers;
        }

        private double tryToDouble(string text)
        {

            double output = 0;

            double.TryParse(text, out output);

            return output;

        }

        private int tryToInt(string text)
        {

            int output = 0;

            int.TryParse(text, out output);

            return output;

        }

        public string getCellValue(string addressName)
        {

            if (!String.IsNullOrEmpty(addressName))
            {
                return getCellValue("", addressName);
            }
            else
            {
                return "";
            }
        }

        public string getCellValue(string sheetName, string addressName)
        {

            // addressName = 'A2', 'AA13', etc.

            string value = "";

            if (string.IsNullOrEmpty(addressName))
            {

                return "";

            }

            // Open the spreadsheet document for read-only access.
            //using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, false)) {

            // Retrieve a reference to the workbook part.
            WorkbookPart wbPart = document.WorkbookPart;

            // Find the sheet with the supplied name, and then use that 
            // Sheet object to retrieve a reference to the first worksheet.
            Sheet theSheet;
            if (string.IsNullOrEmpty(sheetName))
            {

                theSheet = wbPart.Workbook.Descendants<Sheet>().FirstOrDefault();

            }
            else
            {

                theSheet = wbPart.Workbook.Descendants<Sheet>().Where(s => s.Name == sheetName).FirstOrDefault();

            }


            // Throw an exception if there is no sheet.
            if (theSheet == null)
            {
                throw new ArgumentException("sheetName");
            }

            // Retrieve a reference to the worksheet part.
            WorksheetPart wsPart = (WorksheetPart)(wbPart.GetPartById(theSheet.Id));

            // Use its Worksheet property to get a reference to the cell 
            // whose address matches the address you supplied.
            Cell theCell = wsPart.Worksheet.Descendants<Cell>().
                Where(c => c.CellReference == addressName).FirstOrDefault();

            // If the cell does not exist, return an empty string.
            if (theCell != null)
            {
                value = theCell.InnerText;

                // If the cell represents an integer number, you are done. 
                // For dates, this code returns the serialized value that 
                // represents the date. The code handles strings and 
                // Booleans individually. For shared strings, the code 
                // looks up the corresponding value in the shared string 
                // table. For Booleans, the code converts the value into 
                // the words TRUE or FALSE.
                if (theCell.DataType != null)
                {
                    switch (theCell.DataType.Value)
                    {
                        case CellValues.SharedString:

                            // For shared strings, look up the value in the
                            // shared strings table.
                            var stringTable =
                                wbPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();

                            // If the shared string table is missing, something 
                            // is wrong. Return the index that is in
                            // the cell. Otherwise, look up the correct text in 
                            // the table.
                            if (stringTable != null)
                            {
                                value = stringTable.SharedStringTable.ElementAt(int.Parse(value)).InnerText;
                            }
                            break;

                        case CellValues.Boolean:
                            switch (value)
                            {
                                case "0":
                                    value = "FALSE";
                                    break;
                                default:
                                    value = "TRUE";
                                    break;
                            }
                            break;
                    }
                }
            }
            return value;
        }

        public PositionSettings GetPositionSettings(string position)
        {
            return settings.posSettings.Where(s => s.position == position).FirstOrDefault();
        }
    }

    public class SpreadsheetSettings
    {

        public List<PositionSettings> posSettings;

        public SpreadsheetSettings()
        {
            posSettings = new List<PositionSettings>();
        }


    }

    public class PositionSettings
    {

        public string position = "";
        public string colName = "";
        public string colTeam = "";
        public string colRank = "";
        public string colPerf = "";
        public string colVal = "";
        public string colScarcity = "";
        public string colTier = "";
        public string colBye = "";
        public int rowStart = 1;
        public int rowEnd = 1;

        public PositionSettings()
        {
        }

    }

}
