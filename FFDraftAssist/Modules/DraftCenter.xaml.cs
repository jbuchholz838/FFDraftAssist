using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Infragistics.Controls.Editors;
using Infragistics.Controls.Interactions;

namespace FFDraftAssist
{
    /// <summary>
    /// Interaction logic for DraftCenter.xaml
    /// </summary>
    public partial class DraftCenter : UserControl, INotifyPropertyChanged
    {

        private int _PlayerListFontSize = 14;
        public int PlayerListFontSize
        {
            get
            {
                return _PlayerListFontSize;
            }
            set
            {
                _PlayerListFontSize = value;
                NotifyPropertyChanged("PlayerListFontSize");
            }
        }

        public DraftCenter()
        {

            InitializeComponent();

        }

        private void DraftPlayer(Player draftedPlayer = null)
        {

            FFViewModel viewModel = (FFViewModel)this.DataContext;

            if (draftedPlayer == null)
            {
                draftedPlayer = viewModel.CurrentPlayer;
            }

            if (draftedPlayer.DraftStatus != "Available")
            {

                MessageBox.Show("Player has already been drafted!");
                return;

            }

            viewModel.CurrentDraft.DraftPlayer(draftedPlayer);

            cboSearch.Focus();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ManualDraft manual = new ManualDraft();
            manual.ShowDialog();

        }

        private void btnDraftPlayer_Click(object sender, RoutedEventArgs e)
        {

            DraftPlayer();
        }

        private void RecordDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DraftPlayer();
        }

        private void cboSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {

                XamComboEditor editor = sender as XamComboEditor;

                DraftPlayer((editor.SelectedItem as Player));
                e.Handled = true;
                editor.SelectedItem = null;
            }
            else if (e.Key == Key.Tab)
            {
                e.Handled = true;
            }

        }

        private void cboSearch_DropDownOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            XamComboEditor editor = sender as XamComboEditor;

            if (editor.SelectedValue != null)
            {
                e.Cancel = true;
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
