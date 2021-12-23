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
    /// Interaction logic for DraftButton.xaml
    /// </summary>
    public partial class DraftButton : UserControl
    {

        public DraftButton()
        {

            InitializeComponent();

        }

        private void btnDraftPlayer_Click(object sender, RoutedEventArgs e)
        {

            FFViewModel viewModel = (FFViewModel)this.DataContext;
            Player draftedPlayer = viewModel.CurrentPlayer;
            viewModel.CurrentDraft.DraftPlayer(draftedPlayer);

            //MessageBox.Show("Drafted: " + draftedPlayer.PlayerName);
            //viewModel.CurrentDraft.AutoDraft(21);

        }



    }
}
