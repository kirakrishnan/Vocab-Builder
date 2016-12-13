using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*************************************************************************************
     * Namespace    :   wordsHelper (Class Library)
     * 
     * Class        :   Word
     *            
     * Desciption   :   Builds a class 'Word' which sets the properties
     *                      spelling, meaning and sentence
     *************************************************************************************/
namespace WordsHelper
{


    /*************************************************************************************
     * Class      :   Word 
     * 
     * Properties : 
     *             1) Spelling : Gets user input spelling from DetailsView
     *                           Sets the value to 'spelling'
     *             2) Meaning : Gets user input meaning from DetailsView
     *                           Sets the value to 'meaning'
     *             3) Sentence : Gets user input sentence from DetailsView
     *                           Sets the value to 'sentence'
     *************************************************************************************/

    public class Word
    {
        //Declaring strings for the DetailsView input fields
        public string spelling;
        public string meaning;
        public string sentence;


        /*****************************************************************************************
        * Function : Word() (Constructor)
        * 
        * Description : Takes user input strings from DetailsView spelling, meaning, sentence
         *              and pass to a constructor
        ******************************************************************************************/
        public Word(string spelling, string meaning, string sentence)
        {
            //user-input strings from detailsView
            this.spelling = spelling;
            this.meaning = meaning;
            this.sentence = sentence;
        }



        /**********************************************************
        * Property : Spelling
        * 
        * Description : Gets user input spelling from DetailsView
         *              Sets the value to 'spelling'
        ***********************************************************/
        public string Spelling
        {
            get
            {
                return spelling;
            }
            set
            {
                spelling = value;
            }
        }


        /**********************************************************
        * Property : Meaning
        * 
        * Description : Gets user input meaning from DetailsView
        *               Sets the value to 'meaning'
        ***********************************************************/
        public string Meaning
        {
            get
            {
                return meaning;
            }
            set
            {
                meaning = value;
            }
        }



        /**********************************************************
         * Property : Sentence
         *
         * Description : Gets user input sentence from DetailsView
         *               Sets the value to 'sentence'
         ***********************************************************/
        public string Sentence
        {
            get
            {
                return sentence;
            }
            set
            {
                sentence = value;
            }
        }
    }
}