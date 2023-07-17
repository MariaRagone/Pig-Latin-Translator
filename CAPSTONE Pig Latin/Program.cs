

Console.WriteLine("Welcome to the English to Pig Latin Translator!");

//translate the phrase when the user wants to proceed
bool translate = true;
while (translate)
{
    Console.Write("Enter a phrase you want to translate: ");
    string english = Console.ReadLine().Trim();
    
   
    foreach (string word in english.Split(" "))//this splits each word between the spaces (what is inside the "" is a space)
    {
        //look through the letters for vowels
        for (int i = 0; i < word.Length; i++)
        {
            //STARTS WITH VOWEL
            //if the word starts with a vowel then add "way" to the end of the word
            if (StartsWithVowel(english))
            {
                if (!HasPunctuation(english))
                {

                string vowelWord = word + "way";
                Console.WriteLine(vowelWord);
                }

                else   
                {
                    string vowelWord = word + "way";
                    string punct = english.Substring(english.Length - 1, 1);
                    string justWord = vowelWord.Replace(punct, "");
                    Console.WriteLine(justWord + punct);
                }
                break;
            }

            //STARTS WITH CONSTINANT
            //get all the letters until there is a vowel of the input english
            //if the word starts with a constinant move the constinants to the end and add "ay"
            else if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u'
                    || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')

            {
                string firstLetters = word.Substring(0, i);//0 is the position of the letter you want to get so 0 is the first letter,
                                                           // the second number is how many letters you want to get
                                                           // this returns only the first letter of the input word//replace the first letter of the word with nothing ("")
                string beginning = word.Replace(firstLetters, "");
                //add the firstLetter and "ay" to the end of the word
                string end = word.Replace(word, firstLetters + "ay");
                Console.WriteLine(beginning + end);

                if (english.EndsWith("!") || english.EndsWith(".") || english.EndsWith("?")
                    || english.EndsWith(",") || english.EndsWith("¿") || english.EndsWith(":")
                    || english.EndsWith("¡"))
                
                {
                    string punct = english.Substring(english.Length - 1, 1);
                    //Console.WriteLine(beginning + end + punct);
                    Console.WriteLine("Punctuation found!");
                    break;
                }
                break;
            }

        }
    }


    //ask to continue
    bool answ = true;
    while (answ)
    {
        Console.WriteLine($"Do you want to translate again? y/n");
        string answer = Console.ReadLine().ToLower().Trim();
        if (answer == "n")
        {
            Console.WriteLine($"Bye!");
            translate = false;
            answ = false;
            break;
        }
        else if (answer == "y")
        {
            break;
        }
        else
        {
            Console.WriteLine("Please type 'y' or 'n'");
        }
    }
}


//METHODS
//-------------------------------------------------------------------------------------------------------
static bool StartsWithVowel(string english)
{
    foreach (string word in english.Split(" "))//this splits each word between the spaces (what is inside the "" is a space)
        for (int i = 0; i < word.Length; i++)
    {
        if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u'
            || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U')
    {
            return true;

    }
        else
            return false;
    }
    return false;
}

//static bool HasPunctuation(string english)
//{
//    foreach (string word in english.Split(" "))//this splits each word between the spaces (what is inside the "" is a space)
//    {
//        for (int i = 0; i < word.Length; i++)
//        {


//            if (english[i] == '!' || english[i] == '.' || english[i] == '?'
//                || english[i] == ',' || english[i] == '¿' || english[i] == ':'
//                || english[i] == '¡')
//            {
//                string last = word.Substring(english.Length + 1, 1);//0 is the position of the letter you want to get so 0 is the first letter,
//                                                           // the second number is how many letters you want to get
//                                                           // this returns only the first letter of the input word//replace the first letter of the
//                                                           //string punct = english.Substring(english.Length - 1, 1);
//                                                           //string justWord = english.Replace(punct, "");
//                                                           //Console.WriteLine($"This is the punctuation: {punct} and this is the word: {justWord}");
//                                                           //string vowelWordPunct = justWord + "way" + punct;
//                                                           //Console.WriteLine($"translation for constinant word {vowelWordPunct}");
//                string first = word.Substring(0, i);
//                Console.WriteLine("Punctuation found.");
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//    return false;





    static bool HasPunctuation(string english)
    {
        if (english.EndsWith("!") || english.EndsWith(".") || english.EndsWith("?")
           || english.EndsWith(",") || english.EndsWith("¿") || english.EndsWith(":")
           || english.EndsWith("¡"))
        {

            //string punct = english.Substring(english.Length - 1, 1);
            //string justWord = english.Replace(punct, "");
            //Console.WriteLine($"This is the punctuation: {punct} and this is the word: {justWord}");
            //string vowelWordPunct = justWord + "way" + punct;
            //Console.WriteLine($"translation for constinant word {vowelWordPunct}");
            return true;
        }
            else
        {
            return false;
        }
        
    }


