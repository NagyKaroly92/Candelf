using Caliburn.Micro;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Windows.Input;


namespace Candelf.UserControls.ViewModel
{
    public class AlapadatokViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private List<string> _items;
        public List<string> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                //NotifyOfPropertyChange(() => Items);
                OnPropertyChanged(nameof(Items));
                
            }
        }

        private ObservableCollection<DTO> _alapanyagList;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<DTO> AlapanyagList
        {
            get { return _alapanyagList; }
            set
            {
                Set(ref _alapanyagList, value);
            }
        }

        public ICommand AddItemCommand { get; private set; }

        
        public string TBAlapanyagText { get; set; }

        public AlapadatokViewModel()
        {
            AlapanyagList = new ObservableCollection<DTO>();
            _items = new List<string>();
            TBAlapanyagText = "Teszt";

            AddItemCommand = new RelayCommand(AddAlapanyag);
        }

        public void AddAlapanyag()
        {
            AlapanyagList.Add(new DTO { ID = 2, IsCheckBox = true, Name = "teszt" });
            Items.Add(TBAlapanyagText);
            OnPropertyChanged();
            OnPropertyChanged("AlapanyagList");
            OnPropertyChanged("AlapadatokViewModel");
            OnPropertyChanged("viewModel");
            OnPropertyChanged("_items");
            OnPropertyChanged("Items");

            RaisePropertyChanged("Items");
            
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }

    public class DTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private bool isCheckBox;

        public bool IsCheckBox
        {
            get { return isCheckBox; }
            set
            {
                isCheckBox = value;
                OnPropertyChange(nameof(IsCheckBox));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly System.Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(System.Action execute)
            : this(execute, null)
        {
        }

        public RelayCommand(System.Action execute, Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
