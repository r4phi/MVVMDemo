using MVVM.Model;
using System.Windows.Input;

namespace VMMVDemo.ViewModel
{
    class DemoView
    {
        #region Properties
        public AddressModel Address { get; set; } = new AddressModel();
        #endregion

        #region methods
        public DemoView()
        {
            DeleteCommand = new RelayCommand(e =>
            {
                Address.Reset();
            }, c => true);

            AddressCommand = new RelayCommand(e =>
            {
                Address.BuildAddress();
            }, c => Address.Name != string.Empty);
        }
        #endregion

        #region commands
        public ICommand DeleteCommand { get; private set; }
        public ICommand AddressCommand { get; private set; }
        #endregion
    }
}
