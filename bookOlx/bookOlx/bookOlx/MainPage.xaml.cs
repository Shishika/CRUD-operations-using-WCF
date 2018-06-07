using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bookOlx
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var books = GetMockBooks();
            bookListView.ItemsSource = books;
        }
        private List<BookModel> GetMockBooks()
        {
            var books = new List<BookModel>()
            {   new BookModel { Image="one.jpg", BookName = "Alchem", AuthorName = "Paulo", Price = 25.25, Description="hellloooo"},
                new BookModel { Image="two.jpg", BookName = "mist", AuthorName = "leo", Price = 125.25, Description="hieeeee" },
                new BookModel { Image="three.jpg", BookName = "harry", AuthorName = "kit", Price = 225.25, Description="byeee"}
            };
            return books;
        }
        private async void bookListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedBook = e.SelectedItem as BookModel;
            await Navigation.PushAsync(new BookDetailsPage(selectedBook));
        }
    }
}

