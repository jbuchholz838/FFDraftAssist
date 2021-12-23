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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FFDraftAssist
{
    /// <summary>
    /// Interaction logic for TopPlayersList.xaml
    /// </summary>
    public partial class TopPlayersList : UserControl
    {

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
            }

        }

        public TopPlayersList()
        {

            InitializeComponent();

        }


    }
}
