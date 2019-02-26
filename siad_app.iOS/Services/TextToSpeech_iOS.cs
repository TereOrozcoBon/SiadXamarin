using System;
using AVFoundation;
using siad_app.iOS.Services;
using siad_app.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeech_iOS))]
namespace siad_app.iOS.Services
{
    public class TextToSpeech_iOS
    {
        public TextToSpeech_iOS()
        {
        }

        public class TextToSpeechImplementation : ITextToSpeech
        {
            public TextToSpeechImplementation() { }

            public void Speak(string text)
            {
                var speechSynthesizer = new AVSpeechSynthesizer();
                var speechUtterance = new AVSpeechUtterance(text)
                {
                    Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                    Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                    Volume = 0.5f,
                    PitchMultiplier = 1.0f
                };

                speechSynthesizer.SpeakUtterance(speechUtterance);
            }
        }
    }
}
