namespace LAB_21
{
    public class UserProfile
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class AppSettings
    {
        public string Theme { get; set; }
        public string Language { get; set; }
    }

    public class Cache<T> where T : IMessage
    {
        private readonly Dictionary<string, T> _storage = new();

        public void Set(string key, T item)
        {

            _storage[key] = item;
        }

        public T? Get(string key)
        {
            if (_storage.TryGetValue(key, out var item))
            {
                return item;
            }

            return default(T);
        }
    }
}