using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Threading;

namespace FFDraftAssist
{

    public class Draft : INotifyPropertyChanged
    {

        private string _DraftName;
        public string DraftName
        {
            get
            {
                return _DraftName;
            }
            set
            {
                _DraftName = value;
                NotifyPropertyChanged("DraftName");
            }
        }

        private DateTime _StartTime;
        public DateTime StartTime
        {
            get
            {
                return _StartTime;
            }
            set
            {
                _StartTime = value;
                NotifyPropertyChanged("StartTime");
            }
        }

        private DateTime _EndTime;
        public DateTime EndTime
        {
            get
            {
                return _EndTime;
            }
            set
            {
                _EndTime = value;
                NotifyPropertyChanged("EndTime");
            }
        }

        private string _DraftType = "Snake";
        public string DraftType
        {
            get
            {
                return _DraftType;
            }
            set
            {
                _DraftType = value;
                NotifyPropertyChanged("DraftType");
            }
        }

        private int _DraftRounds = 15;
        public int DraftRounds
        {
            get
            {
                return _DraftRounds;
            }
            set
            {
                _DraftRounds = value;
                NotifyPropertyChanged("DraftRounds");
            }
        }

        private PlayerRankings _Rankings;
        public PlayerRankings Rankings
        {
            get
            {
                return _Rankings;
            }
            set
            {
                _Rankings = value;
                NotifyPropertyChanged("Rankings");
            }
        }

        private List<Player> _Players;
        public List<Player> Players
        {

            get
            {
                return _Players;
            }
            set
            {
                _Players = value;
                NotifyPropertyChanged("Players");
                NotifyPropertyChanged("UndraftedPlayers");
            }

        }

        public List<Player> UndraftedPlayers
        {

            get
            {
                return Players.Where(p => p.DraftStatus == "Available").ToList();
            }
        }

        private List<Team> _Teams;
        public List<Team> Teams
        {

            get
            {
                return _Teams;
            }
            set
            {
                _Teams = value;
                NotifyPropertyChanged("Teams");
            }

        }

        public Team MyTeam
        {
            get
            {
                return Teams.Where(t => t.UserName == "Me").FirstOrDefault();
            }
        }

        private Dictionary<int, Team> _TeamPicks;
        public Dictionary<int, Team> TeamPicks
        {

            get
            {
                return _TeamPicks;
            }
            set
            {
                _TeamPicks = value;
                NotifyPropertyChanged("TeamPicks");
            }

        }

        private Team _CurrentTeam;
        public Team CurrentTeam
        {
            get
            {
                return _CurrentTeam;
            }
            set
            {
                _CurrentTeam = value;
                NotifyPropertyChanged("CurrentTeam");
            }
        }

        private ObservableDictionary<int, DraftPick> _DraftPicks;
        public ObservableDictionary<int, DraftPick> DraftPicks
        {

            get
            {
                return _DraftPicks;
            }
            set
            {
                _DraftPicks = value;
                NotifyPropertyChanged("DraftPicks");
                NotifyPropertyChanged("DraftPicksList");
            }

        }

        public List<DraftPick> DraftPicksList
        {
            get
            {
                return DraftPicks.Values.ToList<DraftPick>();
            }
            set
            {
            }
        }

        private int _CurrentRoundNum;
        public int CurrentRoundNum
        {
            get
            {
                return _CurrentRoundNum;
            }
            set
            {
                _CurrentRoundNum = value;
                NotifyPropertyChanged("CurrentRoundNum");
            }
        }

        private int _CurrentRoundPickNum;
        public int CurrentRoundPickNum
        {
            get
            {
                return _CurrentRoundPickNum;
            }
            set
            {
                _CurrentRoundPickNum = value;
                NotifyPropertyChanged("CurrentRoundPickNum");
            }
        }

        private int _CurrentDraftPickNum;
        public int CurrentDraftPickNum
        {
            get
            {
                return _CurrentDraftPickNum;
            }
            set
            {
                _CurrentDraftPickNum = value;
                NotifyPropertyChanged("CurrentDraftPickNum");
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

        private Player _TopQB;
        public Player TopQB
        {
            get
            {
                return _TopQB;
            }
            set
            {
                _TopQB = value;
                NotifyPropertyChanged("TopQB");
            }
        }

        private Player _TopRB;
        public Player TopRB
        {
            get
            {
                return _TopRB;
            }
            set
            {
                _TopRB = value;
                NotifyPropertyChanged("TopRB");
            }
        }

        private Player _TopWR;
        public Player TopWR
        {
            get
            {
                return _TopWR;
            }
            set
            {
                _TopWR = value;
                NotifyPropertyChanged("TopWR");
            }
        }

        private Player _TopTE;
        public Player TopTE
        {
            get
            {
                return _TopTE;
            }
            set
            {
                _TopTE = value;
                NotifyPropertyChanged("TopTE");
            }
        }

        private Player _TopDEF;
        public Player TopDEF
        {
            get
            {
                return _TopDEF;
            }
            set
            {
                _TopDEF = value;
                NotifyPropertyChanged("TopDEF");
            }
        }

        private Player _TopK;
        public Player TopK
        {
            get
            {
                return _TopK;
            }
            set
            {
                _TopK = value;
                NotifyPropertyChanged("TopK");
            }
        }

        private double _QBScarcity;
        public double QBScarcity
        {
            get
            {
                return _QBScarcity;
            }
            set
            {
                _QBScarcity = value;
                NotifyPropertyChanged("QBScarcity");
            }
        }

        private double _RBScarcity;
        public double RBScarcity
        {
            get
            {
                return _RBScarcity;
            }
            set
            {
                _RBScarcity = value;
                NotifyPropertyChanged("RBScarcity");
            }
        }

        private double _WRScarcity;
        public double WRScarcity
        {
            get
            {
                return _WRScarcity;
            }
            set
            {
                _WRScarcity = value;
                NotifyPropertyChanged("WRScarcity");
            }
        }

        private double _TEScarcity;
        public double TEScarcity
        {
            get
            {
                return _TEScarcity;
            }
            set
            {
                _TEScarcity = value;
                NotifyPropertyChanged("TEScarcity");
            }
        }

        private ObservableDictionary<string, int> _RosterSummary;
        public ObservableDictionary<string, int> RosterSummary
        {

            get
            {
                return _RosterSummary;
            }
            set
            {
                _RosterSummary = value;
                NotifyPropertyChanged("RosterSummary");
            }

        }

        private List<PlayerDraftStrategy> _PlayerDraftStrategies;
        public List<PlayerDraftStrategy> PlayerDraftStrategies
        {

            get
            {
                return _PlayerDraftStrategies;
            }
            set
            {
                _PlayerDraftStrategies = value;
                NotifyPropertyChanged("PlayerDraftStrategies");
            }

        }

        DispatcherTimer timAutoDraft = new DispatcherTimer();

        public Draft()
        {
            Players = new List<Player>();
            Teams = new List<Team>();
            DraftPicks = new ObservableDictionary<int, DraftPick>();
            TeamPicks = new Dictionary<int, Team>();
            PlayerDraftStrategies = new List<PlayerDraftStrategy>();
            DraftType = "Snake";

            SetPlayerStrategies();
        }

        private void SetPlayerStrategies()
        {
            PlayerDraftStrategies.Clear();

            // Targets
            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Denver",
                Action = "Target",
                Note = "Opens against the Giants, Jaguars and Jets"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Corey Davis",
                Action = "Target",
                Note = "Will be the #1 receiver for the Jets and should get a bunch of targets"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "James Robinson",
                Action = "Target",
                Note = "Will get the majority of carries which may lead to the extra 2 bonus points"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Darnell Mooney",
                Action = "Target",
                Note = "Deeper sleeper who had a lot of deep potential last year and could compliment Justin Fields well"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Jerry Jeudy",
                Action = "Target",
                Note = "Explosive and could be the #1 receiver in Denver and benefits from Bridgewater as the QB"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Jonnu Smith",
                Action = "Target",
                Note = "I'm incredibly intrigued by him being on the Patriots and he is incredibly cheap"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Tyler Higbee",
                Action = "Target",
                Note = "Decent value and could be a big focal point in an upgraded Rams offense"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Michael Pittman",
                Action = "Target",
                Note = "Should be the #1 WR for Indy and showed a lot of potential last year. Good value pick"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Tyler Bass",
                Action = "Target",
                Note = ""
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Jason Sanders",
                Action = "Target",
                Note = ""
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Nick Folk",
                Action = "Target",
                Note = ""
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Greg Zuerlein",
                Action = "Target",
                Note = ""
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Mason Crosby",
                Action = "Target",
                Note = ""
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "LA Rams",
                Action = "Target",
                Note = ""
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Tampa Bay",
                Action = "Target",
                Note = ""
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "New England",
                Action = "Target",
                Note = ""
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Jaylen Waddle",
                Action = "Target",
                Note = "He's a rookie, but has been a go-to target and is really fast and athletic"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Marquez Callaway",
                Action = "Target",
                Note = "Could be the default WR1 in New Orleans and is a great value pick"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Gus Edwards",
                Action = "Target",
                Note = "Dobbins suffered a likely bad knee injury"
            });

            // Ignores
            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Brandin Cooks",
                Action = "Ignore",
                Note = "He's rarely performed where expected and he's playing for Houston"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "Kenny Golladay",
                Action = "Ignore",
                Note = "Injury issues and the Giants could be really bad"
            });

            PlayerDraftStrategies.Add(new PlayerDraftStrategy()
            {
                PlayerName = "JK Dobbins",
                Action = "Ignore",
                Note = "Likely bad knee injury"
            });
        }

        public void GenerateRosterSummary(Dictionary<string, DraftPick> roster)
        {
            RosterSummary = new ObservableDictionary<string, int>();
            
            foreach(string key in roster.Keys)
            {
                if (!key.Contains("BENCH"))
                {
                    RosterSummary.Add(key, 0);
                }
            }

            NotifyPropertyChanged("RosterSummary");
        }

        public void Start()
        {

            if (Rankings != null)
            {

                Players = Rankings.GetPlayers(this);
                GenerateTeamPicks();

                DraftPicks.Clear();
                CurrentRoundNum = 0;
                CurrentRoundPickNum = 0;
                CurrentDraftPickNum = 0;
                DraftStatus = "In Progress";

                NextPick();

            }
        }

        public void Restart()
        {

            Start();

        }

        private void GenerateTeamPicks()
        {

            int evenAdjust = 0;
            TeamPicks.Clear();

            if (DraftType == "Snake")
            {

                evenAdjust = Teams.Count - 1;

            }

            for (int roundNum = 1; roundNum <= DraftRounds; roundNum++)
            {

                foreach (Team team in Teams)
                {

                    int draftPickNum = -1;

                    if (DraftType == "Snake" && roundNum % 2 == 0)
                    {

                        draftPickNum = roundNum * Teams.Count - team.PickOrder + 1;

                    }
                    else
                    {

                        draftPickNum = (roundNum - 1) * Teams.Count + team.PickOrder;

                    }

                    TeamPicks.Add(draftPickNum, team);

                }
            }
        }

        public void DraftPlayer(Player player)
        {

            DraftPlayer(player, CurrentDraftPickNum);

        }

        public void DraftPlayer(Player player, int pickNum)
        {

            Team pickedBy = TeamPicks[pickNum];

            DraftPick pick = new DraftPick();
            pick.DraftPickNum = CurrentDraftPickNum;
            pick.RoundNum = CurrentRoundNum;
            pick.RoundPickNum = CurrentRoundPickNum;
            pick.PlayerPicked = player;
            pick.PickedBy = pickedBy;

            if (DraftPicks.ContainsKey(pickNum))
            {
                DraftPicks[pickNum] = pick;
            }
            else
            {
                DraftPicks.Add(pickNum, pick);
            }

            pickedBy.DraftPlayer(pick, pickNum, this);

            if (pickedBy.UserName == "Me")
            {
                player.DraftStatus = "I Drafted";
            }
            else
            {
                player.DraftStatus = "Drafted";
            }

            player.PickedBy = pickedBy;
            player.TopAvailable = false;

            CheckHandcuff(player);

            NextPick();

            NotifyPropertyChanged("DraftPicks");
            NotifyPropertyChanged("DraftPicksList");
            NotifyPropertyChanged("Teams");
            NotifyPropertyChanged("UndraftedPlayers");
            NotifyPropertyChanged("Players");
        }

        private void CheckHandcuff(Player player)
        {
            if (player.PickedBy.UserName == "Me")
            {
                string handcuffPlayerName = "";
                switch (player.PlayerName)
                {
                    case "Christian McCaffrey":
                        handcuffPlayerName = "Chuba Hubbard";
                        break;

                    case "Melvin Gordon":
                        handcuffPlayerName = "Javonte Williams";
                        break;

                    case "Javonte Williams":
                        handcuffPlayerName = "Melvin Gordon";
                        break;

                    case "Aaron Jones":
                        handcuffPlayerName = "AJ Dillon";
                        break;

                    case "Jonathan Taylor":
                        handcuffPlayerName = "Nyheim Hines";
                        break;

                    case "Alvin Kamara":
                        handcuffPlayerName = "Tony Jones";
                        break;

                    case "Nick Chubb":
                        handcuffPlayerName = "Kareem Hunt";
                        break;

                    case "Chase Edmonds":
                        handcuffPlayerName = "James Conner";
                        break;

                    case "James Conner":
                        handcuffPlayerName = "Chase Edmonds";
                        break;

                    case "JK Dobbins":
                        handcuffPlayerName = "Gus Edwards";
                        break;

                    case "Zack Moss":
                        handcuffPlayerName = "Devin Singletary";
                        break;

                    case "Devin Singletary":
                        handcuffPlayerName = "Zack Moss";
                        break;

                    case "Josh Jacobs":
                        handcuffPlayerName = "Kenyan Drake";
                        break;

                    case "Darrel Henderson":
                        handcuffPlayerName = "Sony Michel";
                        break;

                    case "Sony Michel":
                        handcuffPlayerName = "Darrel Henderson";
                        break;

                    case "Raheem Mostert":
                        handcuffPlayerName = "Trey Sermon";
                        break;

                    case "Trey Sermon":
                        handcuffPlayerName = "Raheem Mostert";
                        break;

                    case "Chris Carson":
                        handcuffPlayerName = "Rashaad Penny";
                        break;

                    case "Ronald Jones":
                        handcuffPlayerName = "Leonard Fournette";
                        break;

                    case "Leonard Fournette":
                        handcuffPlayerName = "Ronald Jones";
                        break;

                    case "Dalvin Cook":
                        handcuffPlayerName = "Alexander Mattison";
                        break;

                    case "Ezekiel Elliot":
                        handcuffPlayerName = "Tony Pollard";
                        break;
                }

                if (!String.IsNullOrEmpty(handcuffPlayerName))
                {
                    PlayerDraftStrategy strategy = new PlayerDraftStrategy()
                    {
                        PlayerName = handcuffPlayerName,
                        Action = "Target",
                        Note = $"Handcuff for {player.PlayerName}"
                    };

                    Player handcuffPlayer = Players.Where(p => p.PlayerName == handcuffPlayerName).FirstOrDefault();

                    if (handcuffPlayer != null)
                    {
                        handcuffPlayer.DraftStrategy = strategy;
                    }
                }
            }
        }

        public void InsertPlayer(Team team, Player player, int pickNum)
        {

            // Shift PickNum and After
            // Add Pick

        }

        private void NextPick()
        {

            // Update Pick Numbers
            CurrentDraftPickNum++;

            if (CurrentRoundPickNum == Teams.Count || CurrentRoundNum == 0)
            {

                CurrentRoundNum++;
                CurrentRoundPickNum = 1;

            }
            else
            {

                CurrentRoundPickNum++;

            }

            if (CurrentRoundNum > DraftRounds || CurrentDraftPickNum > TeamPicks.Count())
            {

                DraftStatus = "Complete";

            }
            else
            {

                // Update Current Team
                CurrentTeam = TeamPicks[CurrentDraftPickNum];

                UpdateTopPlayers();
                UpdateSharesByeWeek();
                UpdatePlayerScarcity();
            }
        }

        public void UndoDraftPlayer()
        {

            int key = DraftPicks.Last().Key;
            DraftPick pick = DraftPicks.Last().Value;

            string rosterKey = pick.PlayerPicked.PickedBy.Roster.Where(kvp => kvp.Value == pick).FirstOrDefault().Key;

            if (!string.IsNullOrEmpty(rosterKey))
            {
                pick.PlayerPicked.PickedBy.Roster[rosterKey] = null;

                if (RosterSummary.ContainsKey(rosterKey))
                {
                    RosterSummary[rosterKey] -= 1;
                }
            }

            pick.PlayerPicked.DraftStatus = "Available";
            pick.PlayerPicked.PickedBy = null;

            DraftPicks.Remove(key);

            // Revert to Previous Pick
            if (DraftPicks.Count > 0)
            {
                DraftPick last = DraftPicks.Last().Value;
                CurrentDraftPickNum = last.DraftPickNum;
                CurrentRoundNum = last.RoundNum;
                CurrentRoundPickNum = last.RoundPickNum;
                CurrentTeam = last.PickedBy;
            }
            else
            {
                CurrentDraftPickNum = 0;
                CurrentRoundNum = 0;
                CurrentRoundPickNum = 0;
                CurrentTeam = null;
            }

            // Process NextPick Again
            NextPick();

            NotifyPropertyChanged("DraftPicks");
            NotifyPropertyChanged("DraftPicksList");
            NotifyPropertyChanged("Teams");
            NotifyPropertyChanged("UndraftedPlayers");
            NotifyPropertyChanged("Players");
        }

        private void UpdateTopPlayers()
        {

            // Reset Top Players - Mostly important for undos, inserts and replacements
            List<Player> topPlayers =
                (from player in Players
                 where player.TopAvailable == true
                 select player).ToList<Player>();

            foreach (Player player in topPlayers)
            {

                player.TopAvailable = false;

            }

            // Identify Top Players
            //Player topQB =
            TopQB =
                (from player in Players
                 where player.Position == "QB" && player.DraftStatus == "Available"
                 orderby player.Value descending
                 select player).FirstOrDefault();

            if (TopQB != null)
                TopQB.TopAvailable = true;

            TopWR =
                (from player in Players
                 where player.Position == "WR" && player.DraftStatus == "Available"
                 orderby player.Value descending
                 select player).FirstOrDefault();

            if (TopWR != null)
                TopWR.TopAvailable = true;

            TopRB =
                (from player in Players
                 where player.Position == "RB" && player.DraftStatus == "Available"
                 orderby player.Value descending
                 select player).FirstOrDefault();

            if (TopRB != null)
                TopRB.TopAvailable = true;

            TopTE =
                (from player in Players
                 where player.Position == "TE" && player.DraftStatus == "Available"
                 orderby player.Value descending
                 select player).FirstOrDefault();

            if (TopTE != null)
                TopTE.TopAvailable = true;

            TopDEF =
                (from player in Players
                 where player.Position == "DEF" && player.DraftStatus == "Available"
                 orderby player.Value descending
                 select player).FirstOrDefault();

            if (TopDEF != null)
                TopDEF.TopAvailable = true;

            TopK =
                (from player in Players
                 where player.Position == "K" && player.DraftStatus == "Available"
                 orderby player.Value descending
                 select player).FirstOrDefault();

            if (TopK != null)
                TopK.TopAvailable = true;

        }

        private void UpdatePlayerScarcity()
        {
            // QB
            double qbTotalValue = Players.Where(p => p.Position == "QB" && p.Value > 0).Select(p => p.Value).Sum();
            double qbAvailableValue = Players.Where(p => p.Position == "QB" && p.Value > 0 && p.DraftStatus == "Available").Select(p => p.Value).Sum();
            QBScarcity = (qbAvailableValue / qbTotalValue) * 100;

            // RB
            double rbTotalValue = Players.Where(p => p.Position == "RB" && p.Value > 0).Select(p => p.Value).Sum();
            double rbAvailableValue = Players.Where(p => p.Position == "RB" && p.Value > 0 && p.DraftStatus == "Available").Select(p => p.Value).Sum();
            RBScarcity = (rbAvailableValue / rbTotalValue) * 100;

            // WR
            double wrTotalValue = Players.Where(p => p.Position == "WR" && p.Value > 0).Select(p => p.Value).Sum();
            double wrAvailableValue = Players.Where(p => p.Position == "WR" && p.Value > 0 && p.DraftStatus == "Available").Select(p => p.Value).Sum();
            WRScarcity = (wrAvailableValue / wrTotalValue) * 100;

            // TE
            double teTotalValue = Players.Where(p => p.Position == "TE" && p.Value > 0).Select(p => p.Value).Sum();
            double teAvailableValue = Players.Where(p => p.Position == "TE" && p.Value > 0 && p.DraftStatus == "Available").Select(p => p.Value).Sum();
            TEScarcity = (teAvailableValue / teTotalValue) * 100;
        }

        private void UpdateSharesByeWeek()
        {
            string[] myByeWeeks = Players.Where(p => p.PickedBy != null && p.PickedBy.UserName == "Me").Select(p => p.Position + "-" + p.Bye).ToArray();
            foreach (Player player in Players.Where(p => myByeWeeks.Contains(p.Position + "-" + p.Bye)))
            {
                player.SharesBye = true;
            }
        }

        public void AutoDraft(int rounds = 0)
        {

            if (rounds == 0)
            {
                timAutoDraft.Tick += timAutoDraft_Tick;
                timAutoDraft.Interval = new TimeSpan(0, 0, 0, 0, 100);
                timAutoDraft.Start();
            }
            else
            {
                for (int i = 0; i < rounds * Teams.Count; i++)
                {
                    AutoDraftTick();
                }
            }

        }

        void timAutoDraft_Tick(object sender, EventArgs e)
        {

            if (DraftStatus != "In Progress")
            {

                timAutoDraft.Stop();
                return;
            }

            AutoDraftTick();
        }

        private void AutoDraftTick()
        {
            Player topPlayer =
                (from player in Players
                 where player.DraftStatus == "Available"
                 orderby player.Value descending
                 select player).First();

            DraftPlayer(topPlayer);
        }

        public bool IsValid()
        {

            bool valid = true;

            if (Teams.Count < 2)
                valid = false;

            if (string.IsNullOrEmpty(DraftName))
                valid = false;

            if (string.IsNullOrEmpty(DraftType))
                valid = false;

            if (DraftRounds < 1)
                valid = false;

            return valid;

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
