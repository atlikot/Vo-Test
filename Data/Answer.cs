namespace IT_Test.Data
{
    public class Answer
    {
        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public Answer(string text, bool isCorrect = false)
        {
            Text = text;
            IsCorrect = isCorrect;
        }
    }
}
