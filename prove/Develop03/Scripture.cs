using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(numberToHide, _words.Count(word=> !word.IsHidden()));

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
                _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n{_words.Select(word => word.GetDisplayText()).Aggregate((a, b) => $"{a} {b}")}";

    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
    
}