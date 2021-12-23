using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Collections.ObjectModel;

namespace FFDraftAssist
{

    public class FFViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Draft> _Drafts;
        public ObservableCollection<Draft> Drafts
        {
            get
            {
                return _Drafts;
            }
            set
            {
                _Drafts = value;
                NotifyPropertyChanged("Drafts");
            }
        }

        private Draft _CurrentDraft;
        public Draft CurrentDraft
        {
            get
            {
                return _CurrentDraft;
            }
            set
            {
                _CurrentDraft = value;
                NotifyPropertyChanged("CurrentDraft");
            }
        }

        private Player _CurrentPlayer;
        public Player CurrentPlayer
        {
            get
            {
                return _CurrentPlayer;
            }
            set
            {
                _CurrentPlayer = value;
                NotifyPropertyChanged("CurrentPlayer");
            }
        }

        private ObservableCollection<PlayerRankings> _Rankings;
        public ObservableCollection<PlayerRankings> Rankings
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

        private PlayerRankings _CurrentRankings;
        public PlayerRankings CurrentRankings
        {
            get
            {
                return _CurrentRankings;
            }
            set
            {
                _CurrentRankings = value;
                NotifyPropertyChanged("CurrentRankings");
            }
        }

        private int _TestNum;
        public int TestNum
        {
            get
            {
                return _TestNum;
            }
            set
            {
                _TestNum = value;
                NotifyPropertyChanged("TestNum");
            }
        }

        public FFViewModel()
        {

            Drafts = new ObservableCollection<Draft>();
            Rankings = new ObservableCollection<PlayerRankings>();
            TestNum = 8;

        }

        public void LoadPlayerRankings(Spreadsheet sheet)
        {

            Rankings.Add(sheet);

            CurrentRankings = sheet;

        }

        public void StartNewDraft(Draft newDraft, Spreadsheet spreadsheet = null)
        {

            if (spreadsheet == null)
            {
                spreadsheet = new Spreadsheet();
            }

            LoadPlayerRankings(spreadsheet);

            newDraft.Rankings = CurrentRankings;

            newDraft.Start();
            Drafts.Add(newDraft);
            CurrentDraft = newDraft;

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
