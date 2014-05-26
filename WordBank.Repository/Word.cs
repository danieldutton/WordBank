namespace WordBank.Repository
{
    public sealed class Word
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Answer { get; set; }


        public override string ToString()
        {
            return string.Format("[{0}] Id:{1} Text:{2} Answer:{3}",
                GetType().Name, Id, Text, Answer);
        }
    }
}
