using System;
using System.Collections.Generic;
using System.Text;

namespace BigGreenButton.Dependencies
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
