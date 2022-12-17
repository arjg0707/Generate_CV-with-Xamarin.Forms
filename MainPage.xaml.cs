using Project_002;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;
using static Xamarin.Forms.Internals.Profile;

namespace Project_002
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        async void OnButtonClicked(System.Object sender, System.EventArgs e)
        {
            var name = name_.Text;
            var dateofBirth = date_.Date;
            var occupation = occupation_.Text;
            var phone = phone_.Text;
            var email = email_.Text;
            var nationality = nationality_.Items[nationality_.SelectedIndex];
            var level = "";
            if (RadioBtnBasico.IsChecked) { level = RadioBtnBasico.Value.ToString(); }
            if (RadioBtnIntermedio.IsChecked) { level = RadioBtnIntermedio.Value.ToString(); }
            if (RadioBtnAvanzado.IsChecked) { level = RadioBtnAvanzado.Value.ToString(); }
            if (RadioBtnFluido.IsChecked) { level = RadioBtnFluido.Value.ToString(); }
            var languages = new ObservableCollection<string>();
            if (Cpp.IsChecked) { languages.Add("C++"); }
            if (Csharp.IsChecked) { languages.Add("C#"); }
            if (Java.IsChecked) { languages.Add("Java"); }
            if (Python.IsChecked) { languages.Add("Python"); }
            var aptitudes = aptitudes_.Items[aptitudes_.SelectedIndex];
            var skills = new ObservableCollection<string>();
            if (skill_1.IsChecked) { skills.Add("Acondicionamiento fisico"); }
            if (skill_2.IsChecked) { skills.Add("Creacion de videos deportivos"); }
            if (skill_3.IsChecked) { skills.Add("Pack office"); }
            if (skill_4.IsChecked) { skills.Add("Tenis"); }
            var profile = profile_.Text;

            await Application.Current.MainPage.Navigation.PushAsync(new toShowCV(name, dateofBirth, occupation, phone, email, nationality, level, languages, aptitudes, skills, profile));
        }

    }
}
