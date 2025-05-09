namespace LAB_21
{
    public interface IMessage
    {
        DateTime Timestamp { get; }
    }

    public class TextMessage : IMessage
    {
        public string Text { get; set; } = "";
        public DateTime Timestamp { get; } = DateTime.Now;
    }

    public class ImageMessage : IMessage
    {
        public string Url { get; set; } = "";
        public int SizeKb { get; set; }
        public DateTime Timestamp { get; } = DateTime.Now;
    }

    public class SystemMessage : IMessage
    {
        public string Code { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime Timestamp { get; } = DateTime.Now;
    }
}
