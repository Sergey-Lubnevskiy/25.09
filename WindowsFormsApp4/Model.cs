using System;
public class Model
{
    private static readonly Random _random = new Random();
    private static readonly string[] _answers =
    {
        "Без сомнений", "Да", "Нет", "Возможно", "Спросите позже"
    };
    public string GetAnswer(string question)
    {
        return _answers[_random.Next(_answers.Length)];
    }
}