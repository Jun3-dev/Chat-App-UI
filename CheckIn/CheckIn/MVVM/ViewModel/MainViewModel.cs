using CheckIn.Core;
using CheckIn.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }

        public ObservableCollection<ContactModel> Contacts { get; set; }

        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o => 
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });

                Message = "";
            });

            Messages.Add(new MessageModel
            {
                Username = "Archie",
                UsernameColor = "#409aff",
                ImageSource = "https://media.discordapp.net/attachments/756056938495868950/879158225272995880/unknown.png",
                Message = "test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 3; i++){
                Messages.Add(new MessageModel
                {
                    Username = "Archie",
                    UsernameColor = "#409AFF",
                    ImageSource = "https://media.discordapp.net/attachments/756056938495868950/879158225272995880/unknown.png",
                    Message = "Sup!",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });

            }

            for(int i = 0; i < 4; i++)
            { 
                Messages.Add(new MessageModel
                {
                    Username = "Jun",
                    UsernameColor = "#409AFF",
                    ImageSource = "https://media.discordapp.net/attachments/882033510762819624/883863009922011186/ANIMAE_ME.jpg",
                    Message = "Sup!",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }
                Messages.Add(new MessageModel
                {
                    Username = "Jun",
                    UsernameColor = "#409AFF",
                    ImageSource = "https://media.discordapp.net/attachments/882033510762819624/883863009922011186/ANIMAE_ME.jpg",
                    Message = "Last",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });

                for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Archie {i}",
                    ImageSource = "",
                    Messages = Messages

                });
            }

            
        }
    }
}
