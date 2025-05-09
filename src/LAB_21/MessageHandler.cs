namespace LAB_21
{
    public class MessageHandler<T> where T : IMessage
    {

        public void Handle(T message)
        {
            Console.WriteLine($"Обробка повідомлення типу: {typeof(T).Name}");
            Console.WriteLine($"Час: {message.Timestamp}");

            switch (message)
            {
                case TextMessage txt:
                    Console.WriteLine($"Текст: {txt.Text}");
                    break;

                case ImageMessage img:
                    Console.WriteLine($"Зображення: {img.Url} ({img.SizeKb} KB)");
                    break;

                case SystemMessage sys:
                    Console.WriteLine($"Код: {sys.Code}, Опис: {sys.Description}");
                    break;

                default:
                    Console.WriteLine("Невідомий тип повідомлення");
                    break;
            }
        }
    }
}
