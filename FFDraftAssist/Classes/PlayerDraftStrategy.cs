using FFDraftAssist.Properties;
using FontAwesome.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FFDraftAssist
{
    public class PlayerDraftStrategy : INotifyPropertyChanged
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

        private string _Action;
        public string Action
        {
            get
            {
                return _Action;
            }
            set
            {
                _Action = value;
                NotifyPropertyChanged("Action");
                NotifyPropertyChanged("ActionImage");
            }
        }

        public byte[] ActionImage
        {
            get
            {
                byte[] img = null;
                switch (Action)
                {
                    case "Target":
                        //img = ImageAwesome.CreateImageSource(FontAwesomeIcon.Star, Brushes.Yellow);
                        ImageConverter converter = new ImageConverter();
                        img = (byte[])converter.ConvertTo(Properties.Resources.ImgStar, typeof(byte[]));
                        break;

                    case "Ignore":
                        //img = ImageAwesome.CreateImageSource(FontAwesomeIcon.Times, System.Windows.Media.Brushes.Red);
                        break;

                    default:
                        break;
                }

                return img;
            }
        }

        private string _Note;
        public string Note
        {
            get
            {
                return _Note;
            }
            set
            {
                _Note = value;
                NotifyPropertyChanged("Note");
            }
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
