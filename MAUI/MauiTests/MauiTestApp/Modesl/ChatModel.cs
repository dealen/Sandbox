namespace MauiTestApp.Models
{
    public class ChatModel
    {
        public ChatModel(string input)
        {
            Id = Guid.NewGuid();
            Message = input;
            SendDate= DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}