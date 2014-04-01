using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NProgressTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.ProgressBar1.SetPercentage(this.ProgressBar1.Percentage +20);
			
		}

		private void Button1_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.ProgressBar1.SetPercentage(this.ProgressBar1.Percentage - 10);
		}

		private void Finish_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.ProgressBar1.Complete();
		}
	}
}