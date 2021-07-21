using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryTime
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoryPage : ContentPage
    {
        public StoryPage(StoryModel data)
        {
            InitializeComponent();
            StringBuilder storyplot = new StringBuilder();
            var maincharpronoun = data.MainCharacter1Noun.ToLower() == "she" ? "her" : "his";
            var sinlingpronoun = data.SiblingType.ToLower() == "brother" ? "his" : "her";
            storyplot.Append(txtStory.Text = "" + data.MainCharacter1 + " opened " + maincharpronoun + " eyes." +
                " " + data.MainCharacter1Noun + " had fallen asleep reading the book 'How to charm a fairy'. " +
                "" + data.MainCharacter1Noun + " slipped off the bed and walked towards the window.It was nightime. "
                + data.MainCharacter1 + " turned and surveyed the room. " +
                "It had the usual paraphernalia of open textbooks, games, breakfast cups and saucers." +
                " " + data.MainCharacter1Noun + " took " + maincharpronoun + " half eaten plate of grapes and tossed it to the dustbin." +
                " " + data.MainCharacter1Noun + " heard a scuffle near the door and opened it to find " + maincharpronoun + " pet " + data.PetName + "," +
                " the " + data.PetType + ", looking at " + maincharpronoun + " pitifully from the floor." + data.MainCharacter1Noun + " sighed. " +
                "" + data.MainCharacter1Noun + " had forgotten to feed it. Just how much time did I sleep? " +
                "" + data.MainCharacter1Noun + " wondered as " + data.MainCharacter1Noun + " came downstairs to " + maincharpronoun + " kitchen." +
                " " + data.MainCharacter1Noun + " could see that " + maincharpronoun + " " + data.SiblingType.ToLower() + " " + data.SiblingName + " had been through the pack of cereals mom had carefully hidden away from " + sinlingpronoun + " clumsy hands. " +
                "" + data.MainCharacter1Noun + " opened a drawer and found something unexpected in it: a ancient looking key. " +
                "" + data.MainCharacter1Noun + " took it out and studied it carefully." +
                " " + data.MainCharacter1Noun + " had never seen anything like it in " + maincharpronoun + " house and " + data.MainCharacter1Noun + " was pretty sure no one in " + maincharpronoun + " family owned it." +
                " Did mom buy it recently? " + data.MainCharacter1Noun + " pondered, keeping it on the shelf and turning to get the cereal from the upper shelf." +
                " Suddenly " + data.MainCharacter1Noun + " heard a voice behind " + maincharpronoun + " say: 'Did you miss me?' " + data.MainCharacter1Noun + " turned around quickly and found a boy, about " + maincharpronoun + " age, smirking at " + maincharpronoun + ". " +
                "'Who are you?' " + data.MainCharacter1Noun + " asked quietly, shifting " + maincharpronoun + " arm to reach the knife behind " + maincharpronoun + "." +
                " He had popped up unexpectedly and " + data.MainCharacter1Noun + " was sure the doors were locked." +
                "He smiled and waved his hand. " + data.MainCharacter1 + " saw that he had the key " + data.MainCharacter1Noun + " had kept on the shelf in his hands." +
                " 'Im sure you have questions, but " + data.MainCharacter1 + ", don't you think you should recognize me? " +
                "I have been waiting for you for such a long time and now you are here!' he laughed out loud and in that moment," +
                " " + data.MainCharacter1 + " took a chance and rushed out of the kitchen. But " + data.MainCharacter1Noun + " tipped on the edge of carpet and fell down," +
                " knocking " + maincharpronoun + " head….");
               
            txtStory.Text = storyplot.ToString();
           
        }
    }
}