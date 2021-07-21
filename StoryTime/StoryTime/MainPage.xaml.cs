using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StoryTime
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var data = new StoryModel
            {
                MainCharacter1 = UserNameEntry.Text,
                MainCharacter1Noun = mainNoun.Text,
                SiblingName = sibName.Text,
                SiblingType = sibType.Text,
                PetName = petName.Text,
                PetType = petType.Text
            };
            await Navigation.PushAsync(new StoryPage(data));
        }
    }
}
