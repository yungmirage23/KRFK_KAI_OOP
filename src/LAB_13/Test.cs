namespace LAB_13
{
    public class Test
    {
        public int A = 5;
        public event EventHandler<ConsoleKeyInfo> OnKeyClicked;
        public event EventHandler<int> OnEventHappened;

        public void RaiseEvent()
        {
            OnEventHappened?.Invoke(this, A);
        }
        
        
        public void ReadKeys()
        {
            while (true)
            {
                Console.Write("Press KEY: ");
                var key = Console.ReadKey();
                Console.Write('\n');
                OnKeyClicked?.Invoke(this, key);
            }
        }


        public static int FindFirst(int[] mas, Predicate<int> predicate)
        {
            foreach (var i in mas)
            {
                if (predicate(i))
                    return i;
            }

            return -1;
        }
    }
}
