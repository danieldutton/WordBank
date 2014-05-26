namespace WordBank.Repository
{
    public class Word
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Answer { get; set; }

        public bool IsCorrect
        {
            get { return Text == Answer; }
        }
    }
}
