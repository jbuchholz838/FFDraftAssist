using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace FFDraftAssist
{

    public class DraftPick : INotifyPropertyChanged
    {

        private Player _PlayerPicked;
        public Player PlayerPicked
        {
            get
            {
                return _PlayerPicked;
            }
            set
            {
                _PlayerPicked = value;
                NotifyPropertyChanged("PlayerPicked");
                NotifyPropertyChanged("PlayerPickedPlayerName");
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
                NotifyPropertyChanged("PickedByTeamName");
            }
        }

        private int _RoundNum;
        public int RoundNum
        {
            get
            {
                return _RoundNum;
            }
            set
            {
                _RoundNum = value;
                NotifyPropertyChanged("RoundNum");
            }
        }

        private int _RoundPickNum;
        public int RoundPickNum
        {
            get
            {
                return _RoundPickNum;
            }
            set
            {
                _RoundPickNum = value;
                NotifyPropertyChanged("RoundPickNum");
            }
        }

        public string RoundPick
        {
            get
            {
                return (RoundNum + "." + RoundPickNum);
            }
        }

        private int _DraftPickNum;
        public int DraftPickNum
        {
            get
            {
                return _DraftPickNum;
            }
            set
            {
                _DraftPickNum = value;
                NotifyPropertyChanged("DraftPickNum");
            }
        }

        public DraftPick()
        {

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
