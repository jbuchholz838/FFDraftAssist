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

namespace FFDraftAssist
{
    /// <summary>
    /// Interaction logic for PlayerList.xaml
    /// </summary>
    public partial class PlayerList : UserControl
    {

        private string _PositionFilter;
        public string PositionFilter
        {
            get
            {
                return _PositionFilter;
            }
            set
            {
                _PositionFilter = value;
                load();
            }
        }

        private string _TeamFilter;
        public string TeamFilter
        {
            get
            {
                return _TeamFilter;
            }
            set
            {
                _TeamFilter = value;
                load();
            }
        }

        private bool _HideDrafted;
        public bool HideDrafted
        {
            get
            {
                return _HideDrafted;
            }
            set
            {
                _HideDrafted = value;
                ApplyHideDraftedFilter();
            }
        }

        public MouseButtonEventHandler RecordDoubleClick { get; set; }

        public PlayerList()
        {

            setup();

        }

        private void setup()
        {

            InitializeComponent();

            if (string.IsNullOrEmpty(PositionFilter))
                PositionFilter = "";

            //load();

        }

        public void load()
        {

            ApplyPositionFilter();
            ApplyTeamFilter();
            HideColumns();
        }

        private void ApplyPositionFilter()
        {

            RecordFilter filter = new RecordFilter();
            filter.Conditions.LogicalOperator = LogicalOperator.Or;
            filter.FieldName = "Position";

            if (!string.IsNullOrEmpty(PositionFilter))
            {
                foreach (string pos in PositionFilter.Split(','))
                {
                    filter.Conditions.Add(new ComparisonCondition(ComparisonOperator.In, PositionFilter));
                }
            }

            grdFieldLayout.RecordFilters.Add(filter);

        }

        private void ApplyTeamFilter()
        {

            RecordFilter filter = new RecordFilter();
            filter.FieldName = "TeamName";

            if (!string.IsNullOrEmpty(TeamFilter))
            {

                filter.Conditions.Add(new ComparisonCondition(ComparisonOperator.In, TeamFilter));

                grdData.Resources.Add(typeof(DataRecordCellArea), new Style()
                {
                    TargetType = typeof(DataRecordCellArea)
                });

            }


            grdFieldLayout.RecordFilters.Add(filter);

        }

        private void ApplyHideDraftedFilter()
        {
            RecordFilter filter = new RecordFilter();
            filter.FieldName = "DraftStatus";

            if (HideDrafted)
            {
                filter.Conditions.Add(new ComparisonCondition(ComparisonOperator.Equals, "Available"));
            }

            grdFieldLayout.RecordFilters.Add(filter);
        }

        private void HideColumns()
        {

            if (!string.IsNullOrEmpty(PositionFilter) && grdFieldLayout != null)
            {

                foreach (Field fld in grdFieldLayout.FieldItems)
                {

                    if (fld.Name == "Position")
                        fld.Visibility = System.Windows.Visibility.Collapsed;

                    if ((PositionFilter.Contains("DEF") || PositionFilter == "D" || PositionFilter.Contains("K")) && fld.Tag != null && fld.Tag.ToString() == "Hide")
                    {

                        fld.Visibility = System.Windows.Visibility.Collapsed;

                    }
                }
            }
        }

        private void grdData_SelectedItemsChanged(object sender, Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs e)
        {

            Player selected = (Player)grdData.ActiveDataItem;
            (this.DataContext as FFViewModel).CurrentPlayer = selected;

        }

        private void grdData_RecordActivated(object sender, Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs e)
        {

            if (grdData.SelectedDataItem != grdData.ActiveDataItem)
                grdData.SelectedDataItem = grdData.ActiveDataItem;

        }

        private void DataRecordPresenter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (RecordDoubleClick != null)
            {
                RecordDoubleClick(sender, e);
            }
        }
    }
}
