using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using StoryOverview;
using TextToSpeech;



namespace DnD_WaterDeep_DragonHeist
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            await TextToSpeech.TextToSpeech.SynthesisToSpeakerAsync();
        }
    }
}
