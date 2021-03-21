using Catel.IoC;
using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace CatelActiveViewModelsBug.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<IViewModel> ActiveViewModels { get; set; } = new();

        private DispatcherTimer RefreshActiveViewModelsTime;
        public MainWindowViewModel()
        {
            Title = "MainWindowViewModel";

            RefreshActiveViewModelsTime = new DispatcherTimer();
            RefreshActiveViewModelsTime.Tick += RefreshActiveViewModelsTime_Tick;
            RefreshActiveViewModelsTime.Interval = new TimeSpan(2000);
            RefreshActiveViewModelsTime.Start();
        }

        private void RefreshActiveViewModelsTime_Tick(object sender, EventArgs e)
        {
            for (int i = ActiveViewModels.Count - 1; i >= 0; i--)
            {
                if (!ViewModelManager.ActiveViewModels.Contains(ActiveViewModels[i]))
                {
                    ActiveViewModels.RemoveAt(i);
                }
            }

            foreach (var viewModel in ViewModelManager.ActiveViewModels)
            {
                if (!ActiveViewModels.Contains(viewModel))
                {
                    ActiveViewModels.Add(viewModel);
                }
            }
        }
    }
}