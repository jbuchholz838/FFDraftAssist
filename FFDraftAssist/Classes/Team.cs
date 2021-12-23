using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace FFDraftAssist
{

    public class Team : INotifyPropertyChanged
    {

        private string _TeamName;
        public string TeamName
        {
            get
            {
                return _TeamName;
            }
            set
            {
                _TeamName = value;
                NotifyPropertyChanged("TeamName");
            }
        }

        private string _UserName;
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
                NotifyPropertyChanged("UserName");
            }
        }

        private int _PickOrder;
        public int PickOrder
        {
            get
            {
                return _PickOrder;
            }
            set
            {
                _PickOrder = value;
                NotifyPropertyChanged("PickOrder");
            }
        }

        private Dictionary<int, DraftPick> _DraftPicks;
        public Dictionary<int, DraftPick> DraftPicks
        {
            get
            {
                return _DraftPicks;
            }
            set
            {
                _DraftPicks = value;
                NotifyPropertyChanged("DraftPicks");
            }
        }

        private ObservableDictionary<string, DraftPick> _Roster;
        public ObservableDictionary<string, DraftPick> Roster
        {
            get
            {
                return _Roster;
            }
            set
            {
                _Roster = value;
                NotifyPropertyChanged("Roster");
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

        public Team()
        {

            DraftPicks = new Dictionary<int, DraftPick>();

        }

        public void DraftPlayer(DraftPick pick, int pickNum, Draft draft)
        {

            // Add player to roster
            string key = "";
            if (Roster.OrderBy(r => r.Key).Where(r => r.Key.StartsWith(pick.PlayerPicked.Position + " ") && r.Value == null).Count() > 0)
            {
                key = Roster.OrderBy(r => r.Key).Where(r => r.Key.StartsWith(pick.PlayerPicked.Position + " ") && r.Value == null).FirstOrDefault().Key;
            }
            else if (Roster.OrderBy(r => r.Key).Where(r => r.Key.Contains(pick.PlayerPicked.Position) && r.Value == null).Count() > 0)
            {
                key = Roster.OrderBy(r => r.Key).Where(r => r.Key.Contains(pick.PlayerPicked.Position) && r.Value == null).FirstOrDefault().Key;
            }
            else if (Roster.OrderBy(r => r.Key).Where(r => r.Key.StartsWith("BENCH") && r.Value == null).Count() > 0)
            {
                key = Roster.OrderBy(r => r.Key).Where(r => r.Key.StartsWith("BENCH") && r.Value == null).FirstOrDefault().Key;
                
            }

            if (!string.IsNullOrEmpty(key) && draft.RosterSummary != null)
            {
                Roster[key] = pick;

                if (draft.RosterSummary.ContainsKey(key))
                {
                    draft.RosterSummary[key] += 1;
                }
            }

            if (DraftPicks.ContainsKey(pickNum))
            {
                DraftPicks[pickNum] = pick;
            }
            else
            {
                DraftPicks.Add(pickNum, pick);
            }

            NotifyPropertyChanged("DraftPicks");
            NotifyPropertyChanged("Roster");

        }

        public void UndoDraftPlayer()
        {

            DraftPicks.Remove(DraftPicks.Last().Key);

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
