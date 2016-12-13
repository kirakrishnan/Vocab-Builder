using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WordsHelper
{

    /*****************************************************************************************
        * Class : DisplayRandomWords : IDisposable
        * 
        * Description : Gets the word information from .dll library
        * 
        * Methods     : 1) public DisplayRandomWords()  : Displays new word from .dll
        *             : 2) public void SendWord(object ob) : Displays a word by sending it
        *             : 3) public Dispose : Disposes the word
        *             : 4) public class WordEventArgs : System.EventArgs
        *                 - definition of a new type named WordEventArgs that has
                            System.EventArgs as its base class   
        *    
        *               
        ******************************************************************************************/
    public class DisplayRandomWords : IDisposable
    {
        //Delegate event 
        public event EventHandler<WordEventArgs> DisplayWord;

        //Timer instance
        Timer timer;

        //List of old words
        List<wordContainer.word> oldWordList = new List<wordContainer.word>();


        /*****************************************************************************************
         * Function : DisplayRandomWords() Method for the event "DisplayWord"
         * 
         * Description : get the words from .dll library to newWords variable
         *               loop through all the words and add it to the list
         *               timer allows 10 seconds delay between each words
         *               
         ******************************************************************************************/
        public DisplayRandomWords()
        {
            //get the words from .dll library to newWords variable
            var newWords = new wordContainer.words();

            //loop through all the words and add it to the list
            for (int a = 0; a < newWords.Count; a++)
            {
                oldWordList.Add(newWords[a]);
            }

            //timer allows 10 seconds delay between each words
           
            timer = new Timer(new TimerCallback(SendWord),this, 10000, 13000);
            
        }




        /*****************************************************************************************
         * Function : Dispose() 
         * 
         * Description : Disposes the timer
         *               makes timer empty
         *               
         ******************************************************************************************/
        public void Dispose()
        {
            //Disposes the timer
            timer.Dispose();
            timer = null;
        }


        /*****************************************************************************************
         * Function : SendWord() 
         * 
         * Description : Creates a random class instance
         *               Assings min value and max value from oldWordList to "word" instance
         *               Display the word
         *                
         *               
         ******************************************************************************************/
        public void SendWord(object ob)
        {
            //Creates a random class instance
            Random random = new Random();

            //assings min value and max value from oldWordList to "word" instance
            wordContainer.word word = oldWordList[random.Next(0, oldWordList.Count - 1)];

            //if there is some word
            if (this.DisplayWord != null)
            {
                //it will be displayed
                this.DisplayWord(this, new WordEventArgs(word));
            }
        }

        
    }


    /*****************************************************************************************
         * Function : WordEventArgs inherits from base class (System.EventArgs)
         * 
         * Description : Contains information about a word
         *                
         *               
         ******************************************************************************************/
    public class WordEventArgs : System.EventArgs
        {

            //Constructor
            public WordEventArgs(wordContainer.word word)
            {
                Word = word;
            }

            //Property
            public wordContainer.word Word { get; set; }
        }
}
