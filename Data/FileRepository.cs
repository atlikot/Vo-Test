using IT_Test.Loca;

namespace IT_Test.Data
{
    public class FileRepository
    {
        private const string FILE_NAME = "db.vot";

        public List<Question> Questions { get; private set; }

        public FileRepository()
        {
            Questions = new List<Question>();
        }

        public void Load()
        {
            if (File.Exists(FILE_NAME))
            {
                var text = File.ReadAllText(FILE_NAME);
                Questions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Question>>(text) ?? new List<Question>();
                return;
            }

            Questions = new List<Question>
            {
                new Question($"{MyStrings.Question} 1", $"{MyStrings.QuestionText} 1", false)
                {
                    Answers = new List<Answer>
                    {
                        new Answer($"{MyStrings.Answer} 1", true),
                        new Answer($"{MyStrings.Answer} 2"),
                        new Answer($"{MyStrings.Answer} 3"),
                        new Answer($"{MyStrings.Answer} 4"),
                    },
                } 
            };

            Save();
        }

        public void Save()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Questions);
            File.WriteAllText(FILE_NAME, json);
        }
    }
}
