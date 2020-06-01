using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using StoryOverview;

namespace TextToSpeech
{
    public class TextToSpeech
    {
        public static async Task SynthesisToSpeakerAsync()
        { 
            var config = SpeechConfig.FromSubscription("8afdd1b2184d4cb794b264fafba98868", "eastus");
            using (var synthesizer = new SpeechSynthesizer(config))
            {
                string text = (Story_Overview.StoryOverview());
                using (var result = await synthesizer.SpeakTextAsync(text))
                {
                    if (result.Reason == ResultReason.SynthesizingAudioCompleted)
                    {
                       Console.WriteLine($"Speech synthesized to speaker for text [{text}]");
                    }
                    
                    else if (result.Reason == ResultReason.Canceled)
                    {
                        var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
                        Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");
                        
                        if (cancellation.Reason == CancellationReason.Error)
                        {
                            Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                            Console.WriteLine($"CANCELED: ErrorDetails=[{cancellation.ErrorDetails}]");
                            Console.WriteLine($"CANCELED: Did you update the subscription info?");
                        }
                    }
                }
            }
            
 
        }   
    }
}
