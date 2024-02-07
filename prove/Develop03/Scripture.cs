using System;
using System.Text;

public class Scripture
{
    //--------ATTRIBUTES
    private string _reference;
    private static List<Word> _txt;

    // New class hider 
    //getThree(count) -> list(1,2,3)

    
    //--------CONSTRUCTOR
    public Scripture(string reference, string txt)
    {
        _reference = reference;
        _txt = WordsToList(txt);
    }

        public List<Word> WordsToList(string text)
    {
        List<Word> _wordList = new List<Word>();
        List<String> _words = text.Split(' ').ToList();
        foreach(string word in _words){
            _wordList.Add(new Word(word));
        }
        return _wordList;
    }

    //---------GETTERS AND SETTERS

    public string Display()
    {
        StringBuilder words = new StringBuilder();
        words.Append(_reference);
        words.Append(": ");
        for(int i = 0; i < _txt.Count; i++){
            words.Append($"{_txt[i].DisplayWord()} ");
        }
        return words.ToString();
    }

}