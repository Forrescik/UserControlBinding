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

namespace BindingTestControls
{
	/// <summary>
	/// Interaction logic for MyUserControl.xaml
	/// </summary>
	public partial class MyUserControl : UserControl
	{
		public static readonly DependencyProperty UserControlCommandProperty =
			DependencyProperty.Register("UserControlCommand", typeof(ICommand), typeof(MyUserControl), 
			new PropertyMetadata(null));

		public static readonly DependencyProperty UserControlTextProperty =
			DependencyProperty.Register("UserControlText", typeof (string), typeof (MyUserControl), 
			new PropertyMetadata(""));

		public ICommand UserControlCommand
		{
			get
			{
				return (ICommand)GetValue(UserControlCommandProperty);
			}
			set
			{
				SetValue(UserControlCommandProperty, value);
			}
		}

		public string UserControlText
		{
			get { return (string) GetValue(UserControlTextProperty); }
			set { SetValue(UserControlTextProperty, value); }
		}
		public MyUserControl()
		{
			InitializeComponent();
		}
	}
}
