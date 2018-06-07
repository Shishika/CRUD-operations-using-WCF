using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bookOlx
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookDetailsPage : ContentPage
	{
        private BookModel selectedBook { get; set; }  
        public BookDetailsPage (BookModel selectedBookModel)
		{
			InitializeComponent ();
            selectedBook = selectedBookModel;
            imageLabel.Source = selectedBook.Image;
            bookNameLabel.Text = selectedBook.BookName;
            authorNameLabel.Text = selectedBook.AuthorName;
            priceLabel.Text = selectedBook.Price.ToString();
            descriptionLabel.Text = selectedBook.Description;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Not available", "OK");
        }
    }

}
