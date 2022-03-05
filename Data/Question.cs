using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Test.Data
{
    public class Question: INotifyPropertyChanged
    {
        private string _name;
        public string Name {
            get => _name;
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public bool IsMultiple { get; set; }
        public string Text { get; set; }

        public List<Answer> Answers { get; set; }

        public Question(string name, string text, bool isMultiple)
        {
            Text = text;
            Name = name;
            IsMultiple = isMultiple;
            Answers = new List<Answer>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void AddAnswer(string text, bool isCorrect = false)
        {
            Answers.Add(new Answer(text, isCorrect));
        }

        public void ValidateAnswers()
        {
            if (Answers == null || Answers.Count == 0)
            {
                return;
            }

            var hasCorrect = IsMultiple? Answers.Count(x => x.IsCorrect) >= 1 : Answers.Count(x => x.IsCorrect) == 1;

            if (hasCorrect)
            {
                return;
            }

            Answers[0].IsCorrect = true;

            for (int i = 1; i < Answers.Count; i++)
            {
                Answers[i].IsCorrect = false;
            }
        }
    }
}
