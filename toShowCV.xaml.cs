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
        private List<string> levelContentProperty = new List<string>();
        private List<string> languagesContentProperty = new List<string>();
        private List<string> aptitudesContentProperty = new List<string>();
        private List<string> skillsContentProperty = new List<string>();
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
        public List<string> LevelContentProperty
        {
            get { return levelContentProperty; }
            set
            {
                levelContentProperty = value;
                OnPropertyChanged(nameof(LevelContentProperty));
            }
        }
        public List<string> LanguagesContentProperty
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
        public List<string> AptitudesContentProperty
        {
            get { return aptitudesContentProperty; }
            set
            {
                aptitudesContentProperty = value;
                OnPropertyChanged(nameof(AptitudesContentProperty));
            }
        }
        public List<string> SkillsContentProperty
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

        public toShowCV(string nameContentProperty, DateTime dateContentProperty, string occupationContentProperty, string phoneContentProperty, string emailContentProperty, string nationalityContentProperty, List<string> levelContentProperty, List<string> languagesContentProperty, List<string> aptitudesContentProperty, List<string> skillsContentProperty, string profileContentProperty)
        {
            InitializeComponent();
            BindingContext = this;
            NameContentProperty = nameContentProperty;
            DateContentProperty = dateContentProperty;
            OccupationContentProperty = occupationContentProperty;
            PhoneContentProperty = phoneContentProperty;
            EmailContentProperty = emailContentProperty;
            NationalityContentProperty = nationalityContentProperty;
            LevelContentProperty = new List<string>(levelContentProperty);
            LanguagesContentProperty = new List<string>(languagesContentProperty);
            AptitudesContentProperty = new List<string>(aptitudesContentProperty);
            SkillsContentProperty = new List<string>(skillsContentProperty);
            ProfileContentProperty = profileContentProperty;
        }
    }
}
