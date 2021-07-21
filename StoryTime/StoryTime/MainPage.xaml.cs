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
            if (Validate())
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

        private bool Validate()
        {
            var stringErrorList = "";
            // perform test for each field on page
            if (string.IsNullOrEmpty(UserNameEntry.Text)|| string.IsNullOrEmpty(mainNoun.Text)
                || string.IsNullOrEmpty(sibName.Text)|| string.IsNullOrEmpty(sibType.Text)
                || string.IsNullOrEmpty(petName.Text)|| string.IsNullOrEmpty(petType.Text))
            {
                DisplayAlert("Error", "Please enter a value for all the fields", "OK");
                return false;
            }

            if (mainNoun.Text == "he" || mainNoun.Text == "she")
            {

            }
            else
            {
                stringErrorList = stringErrorList + "Please enter a proper pronoun for Main character\n";
            }

            if (sibType.Text == "brother" || sibType.Text == "sister")
            {
               
            }
            else
            {
                stringErrorList = stringErrorList + "Please enter a proper relationship for sibling character\n";
            }

            if(stringErrorList == "")
            {
                return true;
            }
            else
            {
                DisplayAlert("Error", stringErrorList, "OK");
                return false;
            }
            // repeat for next field - some fields may have different, 
            // or multiple validations, depending on your business rules

            // if all validations pass, then return true
           
        }
    }
}
