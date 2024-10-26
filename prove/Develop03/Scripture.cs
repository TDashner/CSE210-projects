using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureApp
{
    public class Scripture
    {
        public ScriptureReference Reference {get;}
        public List<ScriptureWord> Words {get; private set;}

        public Scripture(ScriptureReference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(word => new ScriptureWord(word)).ToList();
        }

        public string GetDisplayText()
        {
            return string.Join(" ", Words.Select(word => word.IsHidden ? "___" : word.Text));
        }

        public bool HideRandomWords(int count)
        {
            var visibleWords = Words.Where(w => !w.IsHidden).ToList();
            if (visibleWords.Count == 0) 
            return false;

            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                int index = rand.Next(visibleWords.Count);
                visibleWords[index].Hide();
            }

            return true;
        }
    }
}
