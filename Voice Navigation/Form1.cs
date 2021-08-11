using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;



namespace Voice_Navigation
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine spEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer sssizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnenable_Click(object sender, EventArgs e)
        {
            spEngine.RecognizeAsync(RecognizeMode.Multiple);
            btndisable.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "say hello", "print my name" , "Speak selected text"});
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(commands);
            Grammar grr = new Grammar(gb);

            spEngine.LoadGrammarAsync(grr);
            spEngine.SetInputToDefaultAudioDevice();
            spEngine.SpeechRecognized += spEngine_SpeechRecognized;
        }
         
        void spEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "say hello":
                    PromptBuilder bb = new PromptBuilder();
                    bb.StartSentence();
                    bb.AppendText("Hello New User.");
                    bb.EndSentence();

                    bb.AppendBreak(new  TimeSpan());

                    bb.StartSentence();
                    bb.AppendText("How are you?", PromptEmphasis.Strong);
                    bb.EndSentence();

                    sssizer.SpeakAsync(bb);
                    break;
                case "print my name":
                    rtb11.Text += "\nAshley";
                    break;
                case "speak selected text":
                    sssizer.SpeakAsync(rtb11.SelectedText);
                    break;
            }
        }

        private void btndisable_Click(object sender, EventArgs e)
        {
            spEngine.RecognizeAsyncStop();
            btndisable.Enabled = false;
        }

        private void rtb11_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
