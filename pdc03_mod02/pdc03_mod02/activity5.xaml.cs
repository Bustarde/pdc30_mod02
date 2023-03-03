using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace pdc03_mod02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class activity5 : ContentPage
	{
		ObservableCollection<employee> employees = new ObservableCollection<employee>();
		public ObservableCollection<employee> Employees { get { return employees; } }
		public activity5()
		{
			InitializeComponent();

			{
				lst.ItemsSource = employees;

				employees.Add(new employee { DisplayName = "Juan Dela Cruz", Position = "President", profileimage = "image1.png" });
				employees.Add(new employee { DisplayName = "Peter", Position = "Vice President",  profileimage = "image2.png" });
				employees.Add(new employee { DisplayName = "Mary", Position = "Secretary", profileimage = "https://cdn-icons-png.flaticon.com/512/5231/5231019.png" });

			}
		}
	}
}