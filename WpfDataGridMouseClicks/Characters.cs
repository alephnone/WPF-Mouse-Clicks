using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace WpfDataGridMouseClicks
{
    public class Characters
    {
        public static ObservableCollection<Character> GetCharacters()
        {
            ObservableCollection<Character> characters = new ObservableCollection<Character>(){
                new Character()
                {
                    Surname = "Simpson",
                    Forename = "Homer",
                    VoicedBy = "Dan Castellaneta"
                },
                new Character()
                {
                    Surname = "Simpson",
                    Forename = "Marge",
                    VoicedBy = "Julie Kavner"
                },
                new Character()
                {
                    Surname = "Simpson",
                    Forename = "Bart",
                    VoicedBy = "Nancy Cartwright"
                },
                new Character()
                {
                    Surname = "Simpson",
                    Forename = "Lisa",
                    VoicedBy = "Yeardley Smith"
                },
                new Character()
                {
                    Surname = "Simpson",
                    Forename = "Maggie",
                    VoicedBy = "Elizabeth Taylor"
                },
                new Character()
                {
                    Surname = "Bouvier",
                    Forename = "Patty",
                    VoicedBy = "Julie Kavner"
                },
                new Character()
                {
                    Surname = "Bouvier",
                    Forename = "Selma",
                    VoicedBy = "Julie Kavner"
                },
                new Character()
                {
                    Surname = "Brockman",
                    Forename = "Kent",
                    VoicedBy = "Harry Shearer"
                },
                new Character()
                {
                    Surname = "Flanders",
                    Forename = "Ned",
                    VoicedBy = "Harry Shearer"
                },
                new Character()
                {
                    Surname = "Flanders",
                    Forename = "Rod",
                    VoicedBy = "Pamela Hayden"
                },
                new Character()
                {
                    Surname = "Flanders",
                    Forename = "Todd",
                    VoicedBy = "Nancy Cartwright"
                }
            };

            return characters;
        }
    }
    public class Character
    {
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string VoicedBy { get; set; }
    }
}
