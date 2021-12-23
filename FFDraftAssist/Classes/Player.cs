using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.ComponentModel;

namespace FFDraftAssist
{

    public class Player : INotifyPropertyChanged
    {

        private string _PlayerName = "";
        public string PlayerName
        {
            get
            {
                return _PlayerName;
            }
            set
            {
                _PlayerName = value;
                NotifyPropertyChanged("PlayerName");
            }
        }

        private string _Position = "";
        public string Position
        {
            get
            {
                return _Position;
            }
            set
            {
                _Position = value;
                NotifyPropertyChanged("Position");
            }
        }

        private string _PositionLong = "";
        public string PositionLong
        {
            get
            {
                return _PositionLong;
            }
            set
            {
                _PositionLong = value;
                NotifyPropertyChanged("PositionLong");
            }
        }

        private string _Team = "";
        public string Team
        {
            get
            {
                return _Team;
            }
            set
            {
                _Team = value;
                NotifyPropertyChanged("Team");
            }
        }

        private int _Bye;
        public int Bye
        {
            get
            {
                return _Bye;
            }
            set
            {
                _Bye = value;
                NotifyPropertyChanged("Bye");
            }
        }

        private bool _SharesBye;
        public bool SharesBye
        {
            get
            {
                return _SharesBye;
            }
            set
            {
                _SharesBye = value;
                NotifyPropertyChanged("SharesBye");
            }
        }

        private int _StringNum;
        public int StringNum
        {
            get
            {
                return _StringNum;
            }
            set
            {
                _StringNum = value;
                NotifyPropertyChanged("StringNum");
            }
        }

        private double _Rank;
        public double Rank
        {
            get
            {
                return _Rank;
            }
            set
            {
                _Rank = value;
                NotifyPropertyChanged("Rank");
            }
        }

        private string _Performance;
        public string Performance
        {
            get
            {
                return _Performance;
            }
            set
            {
                _Performance = value;
                NotifyPropertyChanged("Performance");
            }
        }

        private double _Value;
        public double Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = Math.Round(value, 2);
                NotifyPropertyChanged("Value");
            }
        }

        private double _ScarcityPerc;
        public double ScarcityPerc
        {
            get
            {
                return _ScarcityPerc;
            }
            set
            {
                _ScarcityPerc = Math.Round(value, 2);
                NotifyPropertyChanged("ScarcityPerc");
            }
        }

        private int _Tier;
        public int Tier
        {
            get
            {
                return _Tier;
            }
            set
            {
                _Tier = value;
                NotifyPropertyChanged("Tier");
            }
        }

        private string _PositionString;
        public string PositionString
        {
            get
            {
                return _PositionString;
            }
            set
            {
                _PositionString = value;
                NotifyPropertyChanged("PositionString");
            }
        }

        private string _PerformanceKey;
        public string PerformanceKey
        {
            get
            {
                return _PerformanceKey;
            }
            set
            {
                _PerformanceKey = value;
                NotifyPropertyChanged("PerformanceKey");
            }
        }

        private PlayerDraftStrategy _DraftStrategy;
        public PlayerDraftStrategy DraftStrategy
        {
            get
            {
                return _DraftStrategy;
            }
            set
            {
                _DraftStrategy = value;
                NotifyPropertyChanged("DraftStrategy");
            }
        }

        private bool _TopAvailable;
        public bool TopAvailable
        {
            get
            {
                return _TopAvailable;
            }
            set
            {
                _TopAvailable = value;
                NotifyPropertyChanged("TopAvailable");
            }
        }

        private string _DraftStatus;
        public string DraftStatus
        {
            get
            {
                return _DraftStatus;
            }
            set
            {
                _DraftStatus = value;
                NotifyPropertyChanged("DraftStatus");
            }
        }

        private Team _PickedBy;
        public Team PickedBy
        {
            get
            {
                return _PickedBy;
            }
            set
            {
                _PickedBy = value;
                NotifyPropertyChanged("PickedBy");
            }
        }

        private Draft _Draft;
        public Draft Draft
        {
            get
            {
                return _Draft;
            }
            set
            {
                _Draft = value;
                NotifyPropertyChanged("Draft");
            }
        }

        public Player()
        {

            PlayerName = "";
            Position = "";
            Team = "";
            Bye = 0;
            Rank = 0;
            Performance = "";
            Value = 0;
            ScarcityPerc = 0;
            Tier = 0;
            StringNum = 0;
            TopAvailable = false;

            DraftStatus = "Available";

        }

        public void SplitTeamBye()
        {

            string[] teamBye = Team.Split('/');

            Team = teamBye[0];
            if (teamBye.Length == 2)
            {
                int tmp = 0;
                int.TryParse(teamBye[1], out tmp);
                Bye = tmp;

            }

        }

        public void SplitStringNum()
        {

            string[] tmp = PlayerName.Split('(');

            PlayerName = tmp[0];
            if (tmp.Length == 2)
            {
                int num = 0;
                int.TryParse(tmp[1].Replace(")", ""), out num);
                StringNum = num;

            }
            else
            {
                StringNum = 1;
            }

        }

        public void BuildPositionString()
        {

            PositionString = "#" + StringNum + " " + ConvertPosition() + " - " + Team;

        }

        public string ConvertPosition()
        {

            string converted = "";

            switch (Position)
            {

                case "QB":
                    converted = "Quarterback";
                    break;

                case "WR":
                    converted = "Wide Receiver";
                    break;

                case "RB":
                    converted = "Running Back";
                    break;

                case "TE":
                    converted = "Tight End";
                    break;

                case "K":
                    converted = "Kicker";
                    break;

                case "DEF":
                    converted = "Defense";
                    break;

                case "D":
                    converted = "Defense";
                    break;

            }

            PositionLong = converted;
            return converted;

        }

        public void GetPeformanceKey()
        {

            string key = "";

            switch (Position)
            {

                case "QB":
                    key = "0.5 / 1 / P";
                    break;

                case "WR":
                    key = "1 / 2 / P";
                    break;

                case "RB":
                    key = " 1 / 2 / P";
                    break;

                case "TE":
                    key = " 0.5 / 1 / P";
                    break;

                case "K":
                    key = "Performance";
                    break;

                case "DEF":
                    key = "Performance";
                    break;

                case "D":
                    key = "Performance";
                    break;

            }

            Performance = Performance.Replace("/", " / ");
            PerformanceKey = key;

        }

        public string toString()
        {

            string output = "";

            output += "Name: " + PlayerName + "\n";
            output += "Position: " + Position + "\n";
            output += "Team: " + Team + "\n";
            output += "Bye: " + Bye + "\n";
            output += "Rank: " + Rank + "\n";
            output += "Performance: " + Performance + "\n";
            output += "Value: " + Value + "\n";
            output += "Scarcity: " + ScarcityPerc + "\n";
            output += "Tier: " + Tier;

            return output;

        }

        public string toShortString()
        {

            string output = "";
            string div = " - ";

            output = PlayerName + div + Position + div + Team + div + Bye + div + Performance + div + Value + div + ScarcityPerc + div + Tier;

            return output;

        }

        public string BelichickChooseRB()
        {
            string[] rbs = { "Damien Harris", "Rhamondre Stevenson", "James White", "Brandon Bolden", "J.J. Taylor" };

            Random bigBrainStrategy = new Random();
            int chosenOne = bigBrainStrategy.Next(0, rbs.Length);

            return rbs[chosenOne];
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

    }
}
