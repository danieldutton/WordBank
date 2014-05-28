namespace WordBank.Repository.Model
{
    public sealed class WordAnswer
    {
        public int Id { get; private set; }

        public string Text { get; private set; }

        public string Answer { get; set; }


        public WordAnswer(int id, string text, string answer)
        {
            Id = id;
            Text = text;
            Answer = answer;
        }

        public override string ToString()
        {
            return string.Format("[{0}] Id:{1} Text:{2} Answer:{3}",
                GetType().Name, Id, Text, Answer);
        }
    }
}
