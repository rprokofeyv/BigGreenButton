using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using BigGreenButton.Droid.Dependencies;
using BigGreenButton.Dependencies;
using Java.Util;

using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace BigGreenButton.Droid.Dependencies
{
    public class TextToSpeechImplementation : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public void Speak(string text)
        {
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(Android.App.Application.Context, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                //speaker.SetLanguage(Locale.R);
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
    }
}
