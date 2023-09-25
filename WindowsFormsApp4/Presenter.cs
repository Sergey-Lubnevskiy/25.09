public class Presenter
{
    private readonly IView _view;
    private readonly Model _model;
    public Presenter(IView view)
    {
        _view = view;
        _model = new Model();
    }
    public void AskQuestion(string question)
    {
        var answer = _model.GetAnswer(question);
        _view.DisplayAnswer(answer);
    }
}