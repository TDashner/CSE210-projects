using System;


namespace ScriptureApp
{
    public class ScriptureWord
    {
        public string Text {get;}
        public bool IsHidden {get; private set;}

        public ScriptureWord(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }
    }
}
