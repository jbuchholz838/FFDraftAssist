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

using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Controls;
using Infragistics.Controls.Layouts;

namespace FFDraftAssist
{
    /// <summary>
    /// Interaction logic for TeamRoster.xaml
    /// </summary>
    public partial class DraftBoard : UserControl
    {

        string teamNameFilter = "";

        public DraftBoard()
        {



        }

        public DraftBoard(string teamName)
        {

            teamNameFilter = teamName;

        }

        public void Setup()
        {

            InitializeComponent();

            FFViewModel viewModel = (FFViewModel)this.DataContext;

            TileSettings.MaxColumns = viewModel.CurrentDraft.Teams.Count();
            double num = manTiles.Width;
            for (int i = 0; i < TileSettings.MaxColumns; i++)
            {

                ColumnDefinition def = new ColumnDefinition();
                def.Width = new GridLength(155);
                //def.Width = new GridLength(1, GridUnitType.Star);
                grdTeamNames.ColumnDefinitions.Add(def);

                TextBlock name = new TextBlock();
                name.Text = viewModel.CurrentDraft.Teams[i].TeamName;
                name.Style = Resources["TeamNameStyle"] as Style;
                name.VerticalAlignment = VerticalAlignment.Center;
                name.HorizontalAlignment = HorizontalAlignment.Center;
                name.TextAlignment = TextAlignment.Center;

                //name.SetValue(Grid.ColumnProperty, i);
                //name.SetValue(Grid.RowProperty, 0);

                Border bord = new Border();
                bord.Child = name;
                bord.SetValue(Grid.ColumnProperty, i);
                bord.SetValue(Grid.RowProperty, 0);

                grdTeamNames.Children.Add(bord);


            }

            for (int i = 0; i < viewModel.CurrentDraft.DraftRounds; i++)
            {

                //<RowDefinition Height="30" />
                RowDefinition row = new RowDefinition();
                row.Height = new GridLength(61);
                grdRounds.RowDefinitions.Add(row);

                TextBlock round = new TextBlock();
                round.Text = (i + 1).ToString();
                round.Style = Resources["TeamNameStyle"] as Style;
                round.VerticalAlignment = System.Windows.VerticalAlignment.Center;

                round.SetValue(Grid.ColumnProperty, 0);
                round.SetValue(Grid.RowProperty, i);
                grdRounds.Children.Add(round);

            }

        }

    }
}
