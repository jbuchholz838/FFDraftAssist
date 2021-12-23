using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using System.Collections.ObjectModel;

namespace FFDraftAssist
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public FFViewModel viewModel;
        public Spreadsheet currSpreadsheet;

        public void LoadViewModel()
        {

            viewModel = new FFViewModel();

            //viewModel.LoadPlayerRankings();

        }

    }
}
