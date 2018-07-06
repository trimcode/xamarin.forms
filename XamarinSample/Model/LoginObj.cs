using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace XamarinSample.Model
{
    public class LoginObj : ValidationBase
    {
        public LoginObj()
        {

        }

        private string _name;
        private string _password;

        [Required(ErrorMessage = "Name cannot be empty!")]
        public string Name
        {
            get { return _name; }
            set
            {
                ValidateProperty(value);
                SetProperty(ref _name, value);
            }
        }

        [Required(ErrorMessage = "Password cannot be empty!")]
        [RegularExpression(@"\w{5,}", ErrorMessage = "Password: more than 5 letters/numbers required")]
        public string Password
        {
            get { return _password; }
            set
            {
                ValidateProperty(value);
                SetProperty(ref _password, value);
            }
        }

        protected override void ValidateProperty(object value, [CallerMemberName] string propertyName = null)
        {
            base.ValidateProperty(value, propertyName);

            OnPropertyChanged("IsSubmitEnabled");
        }


    }
}
