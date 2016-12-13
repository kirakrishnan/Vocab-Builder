using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordsHelper;

//(class library)
namespace WordsHelper
{
    /*************************************************************************************
     * Class     : Searchwords 
     * 
     * Methods   : 
     *             1) Search : Compares the user entered word to the wordList and returns
     *                         found word or null if not found
     *             
     * Arguments : 1) (List<Word>) wordlist
     *             2) (String) tobesearched
     *************************************************************************************/
  
    
    public class SearchWords
    {
        /***********************************************************
        *  FUNCTION   :  Search()                                       
        *  ARGUMENTS  :  List<Word> wordlist, string tobesearched      
        *  RETURNS    :  Word from the list and null if not found                           
        *  NOTES      :  searches for the word received from the second   
                         argument in the list received from first argument
                         and returns the word if exists.                  
        ***********************************************************/
       
        public static Word Search(List<Word> wordlist, string toBeSearched)
        {
            //Loops through the wordList
            foreach (var word in wordlist)
            {
                //Checks if user entered 'toBeSearched' matches any word in wordList
                word.Equals(toBeSearched);

                //Trims the user entered word to remove spaces
                if (word.Spelling.Trim().ToLower() == toBeSearched.Trim().ToLower())
                {
                    //returns the found word and its info from the wordList
                    return word;
                }
            }

            //returns null if word is not found
            return null;
        }
    
    }//ends class Search


 }// End namespace WordsHelper
 

//Search smart option:
// return wordlist.FirstOrDefault(x => x.Spelling.Trim().ToLower() == tobesearched.Trim().ToLower());
