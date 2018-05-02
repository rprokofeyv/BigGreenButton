using BigGreenButton.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BigGreenButton.ViewModels
{
    class GreenButtonViewModel : BaseViewModel
    {
        private List<string> _phrases = new List<string> { "Ой! {0}-то как стало!", "Вот теперь - {0}! Вот сейчас нравится!", "Ну вот! Это же {0}!" };
        private List<string> _texts = new List<string> { "Хорошо", "Круто", "Красиво", "Замечательно", "Отлично", "Файно" };
        private string _phrase => _phrases[new Random().Next(_phrases.Count)];

        public string ButtonText => _texts[new Random().Next(_texts.Count)];
        public int ButtonWidth { get; set; } = 160;
        public Command<string> ButtonClick { get; set; }

        public GreenButtonViewModel()
        {
            ButtonClick = new Command<string>((text)=>{
                DependencyService.Get<ITextToSpeech>().Speak(string.Format(_phrase, text));
                OnPropertyChanged(nameof(ButtonText));
            });
        }
    }
}
