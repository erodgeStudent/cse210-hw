using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
public class Word{

   
   // //---------ATTRIBUTES
   private string _word;
   private bool _hidden = false;



   // //---------CONSTRUCTORS
   public Word(string text) {
      _word = text;
   }

   //---------METHODS

     public void Hide() {
        _hidden = true;
     }

     public Boolean IsHidden() {
        return _hidden;
     }

     public string DisplayWord() {
        if(_hidden) {
            StringBuilder replaced = new StringBuilder();
            for(int i = 0; i < _word.Length; i++){
                replaced.Append('_');
            }
            return replaced.ToString();
        }
        return _word;
     }

    

}