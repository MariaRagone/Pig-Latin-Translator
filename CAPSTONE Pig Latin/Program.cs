using System;

Console.WriteLine("Welcome to the English to Pig Latin Translator!");

bool translate = true;

//translate the phrase when the user wants to proceed
while (translate)
{
    DoTranslate();

    //ask if the user wants to translate another time
    Console.WriteLine("Do you want to translate again? y/n");
        string answer = Console.ReadLine().ToLower();

        if (answer == "n")
        {
            Console.WriteLine($"Bye!");
            translate = false;
            break;
        }
        else if (answer == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Please enter y or n!");

            continue;
        }
    }


//Methods
static void DoTranslate()
{
    Console.Write("Enter a phrase you want to translate: ");
    string english = Console.ReadLine().Trim();

    FindConstinant(english);
    Console.WriteLine($"This is the constinant {FindConstinant(english)}");
    FindVowel(english);
    Console.WriteLine($"This is the vowel {FindVowel(english)}");
    FindPunctuation(english);
    Console.WriteLine($"This is the punctuation {FindPunctuation(english)}");

    if (FindConstinant(english))
    {
        string punct = english.Substring(english.Length - 1, 1);
        foreach (string word in english.Split(" "))//this splits each word between the spaces (what is inside the "" is a space)
        {
            for (int i = 0; i < word.Length; i++)
            {//get all the letters until there is a vowel of the input english
                string justWord = english.Replace("!", "");

                if //do the following for words that start with vowels
                    (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u'
                    || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U')
                {
                    //add "ay" to the end of the word

                    string vowelWordPunct = justWord + "way" + punct;
                    Console.WriteLine($"translation for vowel word {vowelWordPunct}");
                    break;
                }
                else //do the following for words that start with constinants
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u'
                    || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
                    {
                        string firstLetter = word.Substring(0, i);//0 is the position of the letter you want to get so 0 is the first letter,
                                                                  // the second number is how many letters you want to get
                                                                  // this returns only the first letter of the input word//replace the first letter of the word with nothing ("")
                        string beginning = word.Replace(firstLetter, "");
                        //add the firstLetter and "ay" to the end of the word
                        string end = word.Replace(word, firstLetter + "ay");
                        Console.WriteLine($"translation for constinant {beginning}{end}{punct}");
                        break;
                    }
                }
            }
        }

    }
    else
    {
        foreach (string word in english.Split(" "))//this splits each word between the spaces (what is inside the "" is a space)
        {
            for (int i = 0; i < word.Length; i++)
            {//get all the letters until there is a vowel of the input english
                string justWord = english.Replace("!", "");

                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u'
                    || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U')
                //if the word starts with a vowel then do the code below
                {
                    //add "ay" to the end of the word
                    //string punct = english.Substring(english.Length + 1, 1);

                    string vowelWord = justWord + "way";
                    Console.WriteLine($"translation for vowel word without punctuation {vowelWord}");
                    break;
                }
                else
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u'
                    || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
                    //if the word has a vowel in it then do the code below
                    {
                        string firstLetter = word.Substring(0, i);//0 is the position of the letter you want to get so 0 is the first letter,
                                                                  // the second number is how many letters you want to get
                                                                  // this returns only the first letter of the input word//replace the first letter of the word with nothing ("")
                        string beginning = word.Replace(firstLetter, "");
                        //add the firstLetter and "ay" to the end of the word
                        string end = word.Replace(word, firstLetter + "ay");
                        Console.WriteLine($"translation for constinant {beginning}{end}");
                        break;
                    }
                }
            }
        }
    }
}

static string FindPunctuation(string english)
{
    if (english.EndsWith("!") || english.EndsWith(".") || english.EndsWith("?")
        || english.EndsWith(",") || english.EndsWith("¿") || english.EndsWith(":")
        || english.EndsWith("¡"))
    {
        string punct = english.Substring(english.Length - 1, 1);
        Console.WriteLine(punct);
        return punct;
    }
    else
    {
        return "there is no punctuation";
    }
}


static bool FindVowel(string english)
{
    foreach (string word in english.Split(" "))//this splits each word between the spaces (what is inside the "" is a space)
    {
        for (int i = 0; i < word.Length; i++)
        {//get all the letters until there is a vowel of the input english

            if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u'
                || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U')
            //if the word starts with a vowel then do the code below
            {
                string firstLetter = word.Substring(0, i);//0 is the position of the letter you want to get so 0 is the first letter,
                                                          // the second number is how many letters you want to get
                                                          // this returns only the first letter of the input word//replace the first letter of the word with nothing ("")
                string beginning = word.Replace(firstLetter, "");
                //add the firstLetter and "ay" to the end of the word
                string end = word.Replace(word, firstLetter + "ay");
                Console.WriteLine(beginning + end);
                return true;

            }
            else
            {
                return false;

            }
        }
    }
    return false;
}
static bool FindConstinant(string english)
{
    foreach (string word in english.Split(" "))//this splits each word between the spaces (what is inside the "" is a space)
    {
        for (int i = 0; i < word.Length; i++)
        {//get all the letters until there is a vowel of the input english

            if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u'
                || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
            //if the word starts with a constinant then do the code below
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
    return false;
}



