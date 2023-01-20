using System;

class Scripture
{
    private string ScriptureText;
    private Reference scriptureReference;

    public Scripture (Reference _scriptureReference, string _scriptureText)
    {
        scriptureReference = _scriptureReference;
        ScriptureText = _scriptureText;
    }

    public string toString()
    {
        return string.Format("{0}")
    }
}