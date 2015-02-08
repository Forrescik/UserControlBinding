using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BindingTestViewModel
{
	public class MainViewModel : ViewModelBase
	{

		private string _controlText;
		private RelayCommand _viewModelCommand;
		private int _counter;

		public RelayCommand ViewModelCommand
		{
			get
			{
				return _viewModelCommand ??
				  (_viewModelCommand = new RelayCommand(e =>
				    {
					    ControlText = (_counter++).ToString();
				    }));
			}
		}

		public string ControlText
		{
			get { return _controlText; }
			set
			{
				if (_controlText == value)
					return;
				_controlText = value;
				OnPropertyChanged("ControlText");
			}
		}

		public MainViewModel()
		{
			_counter = 1;
		}
	}
}
