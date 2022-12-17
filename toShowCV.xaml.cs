using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_002
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class toShowCV : ContentPage
    {
        public toShowCV()
        {
            InitializeComponent();
        }

        private string nameContentProperty;
        private DateTime dateContentProperty;
        private string occupationContentProperty;
        private string phoneContentProperty;
        private string emailContentProperty;
        private string nationalityContentProperty;
        private string levelContentProperty;
        private ObservableCollection<string> languagesContentProperty = new ObservableCollection<string>();
        private string aptitudesContentProperty;
        private ObservableCollection<string> skillsContentProperty = new ObservableCollection<string>();
        private string profileContentProperty;

        public string NameContentProperty
        {
            get { return nameContentProperty; }
            set
            {
                nameContentProperty = value;
                OnPropertyChanged(nameof(NameContentProperty));
            }
        }
        public DateTime DateContentProperty
        {
            get { return dateContentProperty; }
            set
            {
                dateContentProperty = value;
                OnPropertyChanged(nameof(DateContentProperty));
            }
        }
        public string OccupationContentProperty
        {
            get { return occupationContentProperty; }
            set
            {
                occupationContentProperty = value;
                OnPropertyChanged(nameof(OccupationContentProperty));
            }
        }
        public string PhoneContentProperty
        {
            get { return phoneContentProperty; }
            set
            {
                phoneContentProperty = value;
                OnPropertyChanged(nameof(PhoneContentProperty));
            }
        }
        public string EmailContentProperty
        {
            get { return emailContentProperty; }
            set
            {
                emailContentProperty = value;
                OnPropertyChanged(nameof(EmailContentProperty));
            }
        }
        public string NationalityContentProperty
        {
            get { return nationalityContentProperty; }
            set
            {
                nationalityContentProperty = value;
                OnPropertyChanged(nameof(NationalityContentProperty));
            }
        }
        public string LevelContentProperty
        {
            get { return levelContentProperty; }
            set
            {
                levelContentProperty = value;
                OnPropertyChanged(nameof(LevelContentProperty));
            }
        }
        public ObservableCollection<string> LanguagesContentProperty
        {
            get { return languagesContentProperty; }
            set
            {
                if(value != null)
                {
                    languagesContentProperty = value;
                    OnPropertyChanged();
                }          
            }
        }
        public string AptitudesContentProperty
        {
            get { return aptitudesContentProperty; }
            set
            {
                aptitudesContentProperty = value;
                OnPropertyChanged(nameof(AptitudesContentProperty));
            }
        }
        public ObservableCollection<string> SkillsContentProperty
        {
            get { return skillsContentProperty; }
            set
            {
                if (value != null)
                {
                    skillsContentProperty = value;
                    OnPropertyChanged();
                }               
            }
        }
        public string ProfileContentProperty
        {
            get { return profileContentProperty; }
            set
            {
                profileContentProperty = value;
                OnPropertyChanged(nameof(ProfileContentProperty));
            }
        }

        public toShowCV(string nameContentProperty_, DateTime dateContentProperty_, string occupationContentProperty_, string phoneContentProperty_, string emailContentProperty_, string nationalityContentProperty_, string levelContentProperty_, ObservableCollection<string> languagesContentProperty_, string aptitudesContentProperty_,  ObservableCollection<string> skillsContentProperty_, string profileContentProperty_)
        {
            InitializeComponent();
            BindingContext = this;
            NameContentProperty = nameContentProperty_;
            DateContentProperty = dateContentProperty_;
            OccupationContentProperty = occupationContentProperty_;
            PhoneContentProperty = phoneContentProperty_;
            EmailContentProperty = emailContentProperty_;
            NationalityContentProperty = nationalityContentProperty_;
            LevelContentProperty = levelContentProperty_;
            LanguagesContentProperty = new ObservableCollection<string>(languagesContentProperty_);
            AptitudesContentProperty = aptitudesContentProperty_;
            SkillsContentProperty = new ObservableCollection<string>(skillsContentProperty_);
            ProfileContentProperty = profileContentProperty_;
        }
    }
}