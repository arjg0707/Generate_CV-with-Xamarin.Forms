using Project_002;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Project_002
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public List<string> Level { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Aptitudes { get; set; }
        public List<string> Skills { get; set; }




        private async void OnButtonClicked(System.Object sender, System.EventArgs e)
        {
            var name = name_.Text;
            var dateofBirth = date_.Date;
            var occupation = occupation_.Text;
            var phone = phone_.Text;
            var email = email_.Text;
            var nationality = string.Empty;
            nationality = nationality_.Items[nationality_.SelectedIndex];
            var _level = "";
            if (RadioBtnBasico.IsChecked) { _level = RadioBtnBasico.Value.ToString(); }
            if (RadioBtnIntermedio.IsChecked) { _level = RadioBtnIntermedio.Value.ToString(); }
            if (RadioBtnAvanzado.IsChecked) { _level = RadioBtnAvanzado.Value.ToString(); }
            if (RadioBtnFluido.IsChecked) { _level = RadioBtnFluido.Value.ToString(); }
            Level.Add(_level);
            if (Cpp.IsChecked) { Languages.Add("C++"); }
            if (Csharp.IsChecked) { Languages.Add("C#"); }
            if (Java.IsChecked) { Languages.Add("Java"); }
            if (Python.IsChecked) { Languages.Add("Python"); }
            var aptitudes = string.Empty;
            aptitudes = aptitudes_.Items[aptitudes_.SelectedIndex];
            Aptitudes.Add(aptitudes);
            if (skill_1.IsChecked) { Skills.Add("Acondicionamiento fisico"); }
            if (skill_2.IsChecked) { Skills.Add("Creacion de videos deportivos"); }
            if (skill_3.IsChecked) { Skills.Add("Pack office"); }
            if (skill_4.IsChecked) { Skills.Add("Tenis"); }
            var profile = profile_.Text;

            List<string> RadioBtns = new List<string>();
            var RadioBtns_ = levels_.Children.ToList();
            foreach(var i in RadioBtns_)
            {
                var myEntry = i as Entry;
                RadioBtns.Add(myEntry.Text);
            }
       

            await Application.Current.MainPage.Navigation.PushModalAsync(new toShowCV(name, dateofBirth, occupation, phone, email, nationality, Level, Languages, Aptitudes, Skills, profile),true);
        }



        void AddBtnEnglish(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter new languages" };
            levels_.Children.Add(entry);
        }
        void AddBtnLanguages(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter new languages programming" };
            entry = (Entry)languageslst.Children.Last();
            Languages.Add(entry.Text);
        }
        void AddBtnAptitudes(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter new aptitudes" };
            Aptitudes.Add(entry.Text);
        }
        void AddBtnSkills(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter new skills" };
            entry = (Entry)skillslst.Children.Last();
            Skills.Add(entry.Text);
        }



    }
}
