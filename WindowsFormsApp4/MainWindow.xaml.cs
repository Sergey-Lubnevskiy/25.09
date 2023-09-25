using System.Windows;

namespace Magic8Ball
{
    public partial class MainWindow : Window, IView
    {
        private Presenter _presenter;
        public MainWindow()
        {
            InitializeComponent();
            _presenter = new Presenter(this);
            AskButton.Click += (sender, args) => _presenter.AskQuestion(QuestionBox.Text);
        }
        public void DisplayAnswer(string answer)
        {
            AnswerBox.Text = answer;
        }
    }
}