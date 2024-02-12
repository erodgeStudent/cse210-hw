using System.Text;

public class Scripture
{
    //--------ATTRIBUTES
    private string _reference;
    private static List<Word> _txt;
    private bool _completelyHidden = false;


    
    //--------CONSTRUCTOR
    public Scripture(string reference, string txt)
    {
        _reference = reference;
        _txt = WordsToList(txt);
    }



    //---------GETTERS AND SETTERS

    public bool GetCompletelyHidden() {
        return _completelyHidden;
    }

    //---------METHODS

    public List<Word> WordsToList(string text)
    //change the scripture text string to word objects
    //then add to a list of Word objects
    {
        List<Word> _wordList = new List<Word>();
        List<String> _words = text.Split(' ').ToList();
        foreach(string word in _words){
            _wordList.Add(new Word(word));
        }
        return _wordList;
    }
    public void HideNext(int num)
    {  
        Random r = new Random();
        Stack<Word> myStack = new Stack<Word>();
        foreach(Word w in _txt.OrderBy(x => r.Next()))
        {
            myStack.Push(w);
        }
        // Console.Write(myStack.Count);
        int count = 0;
        while(count < num && !(myStack.Count == 0)) {
            Word word = myStack.Pop();
            if(!word.IsHidden()) {
                word.Hide();
                count++;
            }
        }
        if(myStack.Count == 0) {
            _completelyHidden = true;
        }
    }

    public string Display()
    //Take word object and make it to string. Add the scripture text string
    //to the scripture reference string and display it. 
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