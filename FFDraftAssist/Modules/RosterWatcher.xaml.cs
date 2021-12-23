
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter;
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

namespace FFDraftAssist
{
    /// <summary>
    /// Interaction logic for RosterWatcher.xaml
    /// </summary>
    public partial class RosterWatcher : UserControl, INotifyPropertyChanged
    {
        public RosterWatcher()
        {
            InitializeComponent();
            //RosterSpotFieldSettings.SortComparer = new MyCustomSort();

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private void cboSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //rosterGrid.FieldLayouts[0].RecordFilters.Clear();

            //RecordFilter filter = new RecordFilter();
            //filter.FieldName = "PickedByTeamName";

            //ComparisonCondition cond = new ComparisonCondition();
            //cond.Operator = ComparisonOperator.Equals;
            //cond.Value = cboSearch.SelectedValue;

            //filter.Conditions.Add(cond);
            //rosterGrid.FieldLayouts[0].RecordFilters.Add(filter);
        }

        private void XamDataGrid_InitializeRecord(object sender, Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs e)
        {
            // Initializing a record causes it to be placed at the bottom. This re-sorts this record appropriately
            e.Record.RefreshSortPosition();
        }
    }

    public class MyCustomSort : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            double x1, y1;

            if (x == null || y == null)
            {
                return 99;
            }

            x1 = ConvertVal(x.ToString());
            y1 = ConvertVal(y.ToString());

            return x1.CompareTo(y1);
        }

        private double ConvertVal(string val)
        {
            double convertedVal = 99.0;

            if (val.StartsWith("QB "))
            {
                convertedVal = 1.0;
            }
            else if (val.StartsWith("RB "))
            {
                convertedVal = 2.0;
            }
            else if (val.StartsWith("WR "))
            {
                convertedVal = 3.0;
            }
            else if (val.StartsWith("TE "))
            {
                convertedVal = 4.0;
            }
            else if (val.Contains("/"))
            {
                convertedVal = 5.0;
            }
            else if (val.StartsWith("DEF"))
            {
                convertedVal = 6.0;
            }
            else if (val.StartsWith("K"))
            {
                convertedVal = 7.0;
            }
            else if (val.StartsWith("BENCH"))
            {
                convertedVal = 8.0;
            }

            if (val.Contains("1"))
            {
                convertedVal += 0.1;
            }
            else if (val.Contains("2"))
            {
                convertedVal += 0.2;
            }
            else if (val.Contains("3"))
            {
                convertedVal += 0.3;
            }
            else if (val.Contains("4"))
            {
                convertedVal += 0.4;
            }
            else if (val.Contains("5"))
            {
                convertedVal += 0.5;
            }
            else if (val.Contains("6"))
            {
                convertedVal += 0.6;
            }
            else if (val.Contains("7"))
            {
                convertedVal += 0.7;
            }

            return convertedVal;
        }
    }
}
