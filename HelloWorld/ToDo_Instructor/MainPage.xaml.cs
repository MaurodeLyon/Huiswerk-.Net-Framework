using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ToDo_Instructor.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ToDo_Instructor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private ObservableCollection<TodoItem> _items;//List<TodoItem> _items;
        public MainPage()
        {
            this.InitializeComponent();

            _items = new ObservableCollection<TodoItem>();// = new List<TodoItem>();
            DataContext = _items;

            _items.Add(new TodoItem
            {
                Description = "My TODO item"
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newTodoItem = new TodoItem
            {
                Description = itemDescription.Text
            };
            _items.Add(newTodoItem);
        }
    }
}
