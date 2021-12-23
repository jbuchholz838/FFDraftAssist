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

using Infragistics.Controls.Menus;
using Infragistics.Windows.DockManager;

namespace FFDraftAssist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        App appMain;

        public MainWindow()
        {
            InitializeComponent();

            appMain = (App)Application.Current;
            appMain.LoadViewModel();

            this.DataContext = appMain.viewModel;

        }

        private void menuClick(string itemText)
        {

            Control newControl = null;

            switch (itemText)
            {

                case "SpreadsheetSetup":

                    break;

                case "DraftWatcher":

                    DraftWatcher watcher = new DraftWatcher();
                    newControl = watcher;
                    break;

                case "DraftCenter":
                    DraftCenter center = new DraftCenter();
                    newControl = center;
                    break;

                case "PlayersList":

                    PlayerList players = new PlayerList();
                    //players.posFilters = "QB,WR";
                    players.load();
                    newControl = players;
                    break;

                case "DraftButton":
                    newControl = new DraftButton();
                    break;

                case "Browser":
                    newControl = new Browser();
                    break;

                case "DraftBoard":
                    DraftBoard board = new DraftBoard();
                    board.DataContext = this.DataContext;
                    board.Setup();
                    newControl = board;
                    break;
            }

            displayControl(newControl);

        }

        private void DraftMenuClick(string itemText)
        {

            Control newControl = null;

            switch (itemText)
            {

                case "NewDraft":
                    DraftSetup setup = new DraftSetup();
                    setup.ShowDialog();
                    break;

                case "Autodraft":
                    appMain.viewModel.CurrentDraft.AutoDraft();
                    break;

                case "Autodraft 2":
                    appMain.viewModel.CurrentDraft.AutoDraft(2);
                    break;

                case "Autodraft 4":
                    appMain.viewModel.CurrentDraft.AutoDraft(4);
                    break;

                case "Autodraft 6":
                    appMain.viewModel.CurrentDraft.AutoDraft(6);
                    break;

            }

            displayControl(newControl);

        }

        private void displayControl(Control ctrl)
        {

            if (ctrl != null)
            {

                ContentPane cp = new ContentPane();
                cp.Header = ctrl.GetType().Name;
                cp.CloseButtonVisibility = System.Windows.Visibility.Visible;
                cp.AllowClose = true;

                ScrollViewer scroll = new ScrollViewer();
                scroll.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
                scroll.Content = ctrl;

                cp.Content = scroll;

                grpTabPane.Items.Add(cp);

            }

        }

        private void DraftMenuItem_Click(object sender, EventArgs e)
        {

            XamMenuItem mItem = (XamMenuItem)sender;

            if (mItem.Tag != null)
            {
                DraftMenuClick(mItem.Tag.ToString());
            }

        }

        private void XamMenuItem_Click(object sender, EventArgs e)
        {

            XamMenuItem mItem = (XamMenuItem)sender;
            menuClick(mItem.Tag.ToString());

        }

        private void menUndo_Click(object sender, EventArgs e)
        {

            appMain.viewModel.CurrentDraft.UndoDraftPlayer();

        }

        private void menRestart_Click(object sender, EventArgs e)
        {

            appMain.viewModel.CurrentDraft.Restart();

        }

    }
}
