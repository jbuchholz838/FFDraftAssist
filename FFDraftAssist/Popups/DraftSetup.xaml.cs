using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FFDraftAssist
{
    /// <summary>
    /// Interaction logic for DraftSetup.xaml
    /// </summary>
    public partial class DraftSetup : Window
    {

        App appMain;
        Draft newDraft;

        public DraftSetup()
        {

            InitializeComponent();

            appMain = (App)Application.Current;
            newDraft = new Draft();
            newDraft.Rankings = appMain.viewModel.CurrentRankings;

            this.DataContext = newDraft;

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {

            if (newDraft.IsValid())
            {

                // Valid Draft
                appMain.viewModel.StartNewDraft(newDraft);
                this.DialogResult = true;
                this.Close();

            }
            else
            {

                // Invalid Draft

            }

        }

        private void btnLUM_Click(object sender, RoutedEventArgs e)
        {

            newDraft.DraftName = "League of United Misfits";
            newDraft.Rankings = appMain.viewModel.CurrentRankings;
            newDraft.DraftType = "Snake";
            newDraft.DraftRounds = 15;

            // Create team roster configuration
            Dictionary<string, DraftPick> roster = new Dictionary<string, DraftPick>();
            roster.Add("QB 1", null);
            roster.Add("RB 1", null);
            roster.Add("RB 2", null);
            roster.Add("WR 1", null);
            roster.Add("WR 2", null);
            roster.Add("TE 1", null);
            roster.Add("RB/WR", null);
            roster.Add("DEF", null);
            roster.Add("K", null);
            roster.Add("BENCH 1", null);
            roster.Add("BENCH 2", null);
            roster.Add("BENCH 3", null);
            roster.Add("BENCH 4", null);
            roster.Add("BENCH 5", null);
            roster.Add("BENCH 6", null);

            newDraft.GenerateRosterSummary(roster);

            // Create teams
            List<Team> Teams = new List<Team>();

            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Baba Booey", PickOrder = 1, UserName = "Hollywood" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Mischievous Maniacs", PickOrder = 2, UserName = "Me" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Forever redzoned", PickOrder = 3, UserName = "PT" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "DJ Henry", PickOrder = 4, UserName = "Jay" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Ravyn's Flock", PickOrder = 5, UserName = "Ryan" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Jake's Ingeneous Team", PickOrder = 6, UserName = "Jake" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Black Market Beagles", PickOrder = 7, UserName = "Rob" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Zeke and Destroy", PickOrder = 8, UserName = "Josiah" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Nehal's Splendid Team", PickOrder = 9, UserName = "Nehal" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Alan's Team", PickOrder = 10, UserName = "Alan" });

            newDraft.Teams = Teams;

            // Customize spreadsheet settings
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.filePath = "LUM_Beersheet.xlsx";

            appMain.viewModel.StartNewDraft(newDraft, spreadsheet);
            this.DialogResult = true;
            this.Close();

        }

        private void btnVampire_Click(object sender, RoutedEventArgs e)
        {
            newDraft.DraftName = "Vampire League";
            newDraft.Rankings = appMain.viewModel.CurrentRankings;
            newDraft.DraftType = "Snake";
            newDraft.DraftRounds = 15;

            // Create team roster configuration
            Dictionary<string, DraftPick> roster = new Dictionary<string, DraftPick>();
            roster.Add("QB 1", null);
            roster.Add("QB 2", null);
            roster.Add("RB 1", null);
            roster.Add("RB 2", null);
            roster.Add("WR 1", null);
            roster.Add("WR 2", null);
            roster.Add("TE 1", null);
            roster.Add("TE 2", null);
            roster.Add("RB/WR/TE", null);
            roster.Add("DEF", null);
            roster.Add("K", null);
            roster.Add("BENCH 1", null);
            roster.Add("BENCH 2", null);
            roster.Add("BENCH 3", null);
            roster.Add("BENCH 4", null);

            newDraft.GenerateRosterSummary(roster);

            // Create teams
            List<Team> Teams = new List<Team>();

            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Candicefit", PickOrder = 1, UserName = "Candicefit" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Youth Group 4 Horny Teens", PickOrder = 2, UserName = "pholohan756" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "The Von Helsings", PickOrder = 3, UserName = "thackbart" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Carson Wentza Play", PickOrder = 4, UserName = "killer370" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Drewpy Peen", PickOrder = 5, UserName = "drucipher" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Mac n Jones", PickOrder = 6, UserName = "cschutte489" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Me", PickOrder = 7, UserName = "Me" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Washing Foreskins", PickOrder = 8, UserName = "coonar1" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "stlam", PickOrder = 9, UserName = "stlam" });
            Teams.Add(new Team() { Roster = new ObservableDictionary<string, DraftPick>(roster), TeamName = "Brownville Browntowns", PickOrder = 10, UserName = "rileu" });

            newDraft.Teams = Teams;

            // Customize spreadsheet settings
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.filePath = "Vampire_Beersheet.xlsx";

            //PositionSettings qbSettings = spreadsheet.GetPositionSettings("QB");
            //qbSettings.rowEnd = 41;

            //PositionSettings teSettings = spreadsheet.GetPositionSettings("TE");
            //teSettings.rowStart = 45;

            appMain.viewModel.StartNewDraft(newDraft, spreadsheet);
            this.DialogResult = true;
            this.Close();

        }

        private void btnSchutte_Click(object sender, RoutedEventArgs e)
        {
            newDraft.DraftName = "Schutte ESPN";
            newDraft.Rankings = appMain.viewModel.CurrentRankings;
            newDraft.DraftType = "Snake";
            newDraft.DraftRounds = 16;

            List<Team> Teams = new List<Team>();

            Teams.Add(new Team() { TeamName = "Take This Week Off", PickOrder = 1, UserName = "Paul Riemer" });
            Teams.Add(new Team() { TeamName = "Team Medlin", PickOrder = 2, UserName = "Jack Medlin" });
            Teams.Add(new Team() { TeamName = "Turn Your Head and Goff", PickOrder = 3, UserName = "Jake Leutzinger" });
            Teams.Add(new Team() { TeamName = "The Deflatiots", PickOrder = 4, UserName = "Chris Schutte" });
            Teams.Add(new Team() { TeamName = "Suck My Ass Long Dong", PickOrder = 5, UserName = "Matt Thomas" });
            Teams.Add(new Team() { TeamName = "Team Prucka", PickOrder = 6, UserName = "Chris Prucka" });
            Teams.Add(new Team() { TeamName = "Elastigirls Elastigirls", PickOrder = 7, UserName = "Dane Niemann" });
            Teams.Add(new Team() { TeamName = "The Denver Butt Chubbs", PickOrder = 8, UserName = "Taylor Hackbart" });
            Teams.Add(new Team() { TeamName = "Chillin With Mahomes", PickOrder = 9, UserName = "Jordan Schutte" });
            Teams.Add(new Team() { TeamName = "Papa Johnson's", PickOrder = 10, UserName = "Me" });
            Teams.Add(new Team() { TeamName = "Philly Philly Special's", PickOrder = 11, UserName = "Jeff Schutte" });
            Teams.Add(new Team() { TeamName = "Two Gurleys One Kupp", PickOrder = 12, UserName = "James Belling" });
            Teams.Add(new Team() { TeamName = "Omaha Voldemort", PickOrder = 13, UserName = "Connar Hackbart" });
            Teams.Add(new Team() { TeamName = "Show Me Your TDs", PickOrder = 14, UserName = "Payton Rockwell" });

            newDraft.Teams = Teams;

            appMain.viewModel.StartNewDraft(newDraft);
            this.DialogResult = true;
            this.Close();
        }

        private void btnSleeper_Click(object sender, RoutedEventArgs e)
        {
            newDraft.DraftName = "Sleeper Keeper";
            newDraft.Rankings = appMain.viewModel.CurrentRankings;
            newDraft.DraftType = "Snake";
            newDraft.DraftRounds = 13;

            List<Team> Teams = new List<Team>();

            Teams.Add(new Team() { TeamName = "SuperPenguinz", PickOrder = 1, UserName = "SuperPenguinz" });
            Teams.Add(new Team() { TeamName = "Kazan", PickOrder = 2, UserName = "Kazan" });
            Teams.Add(new Team() { TeamName = "diddy1031", PickOrder = 3, UserName = "diddy1031" });
            Teams.Add(new Team() { TeamName = "jaysekah", PickOrder = 4, UserName = "jaysekah" });
            Teams.Add(new Team() { TeamName = "BGarrett", PickOrder = 5, UserName = "jaysekah" });
            Teams.Add(new Team() { TeamName = "TPeas154", PickOrder = 6, UserName = "TPeas154" });
            Teams.Add(new Team() { TeamName = "Evangellic", PickOrder = 7, UserName = "Evangellic" });
            Teams.Add(new Team() { TeamName = "brangelham", PickOrder = 8, UserName = "brangelham" });
            Teams.Add(new Team() { TeamName = "claymate", PickOrder = 9, UserName = "claymate" });
            Teams.Add(new Team() { TeamName = "Discardo", PickOrder = 10, UserName = "Discardo" });
            Teams.Add(new Team() { TeamName = "Justin_B", PickOrder = 11, UserName = "Me" });
            Teams.Add(new Team() { TeamName = "Fantasygauntlet", PickOrder = 12, UserName = "Fantasygauntlet" });

            newDraft.Teams = Teams;

            appMain.viewModel.StartNewDraft(newDraft);
            this.DialogResult = true;
            this.Close();
        }



    }
}
