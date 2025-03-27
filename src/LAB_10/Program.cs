using System.Diagnostics.CodeAnalysis;

namespace LAB_10
{
    internal class Program
    {

        public class Test
        {
            public int Value;

            public Test(int i)
            {
                Value = i;
            }
        }

        private static void Main(string[] args)
        {
            var que = new Queue<string>();
            que.Enqueue()
            var str = string.Join(",", que.ToArray());

            var queue = new Queue<int>();
            
            var el = queue.Dequeue();
            var a = queue.Peek();

            var stack = new Stack<int>();
            stack.Push(2);
            stack.Push(1);
            var elem = stack.Pop();
            stack.Push(-2);
            stack.Push(100);
            var elem2 = stack.Pop();
            stack.Push(50);




            var dict = new Dictionary<int, List<string>>();
            dict.Add(0, new List<string> { "a", "b", "c" });
            var list = dict[0];
            list.Add("d");
            
            //var dict = new Dictionary<string, int>();
            //var masWords = "aaple asfjkaso aaple skdlsa kdlas d asldk l;sa".Split(' ');
            //foreach(var word in masWords)
            //{
            //    if (dict.ContainsKey(word))
            //    {
            //        dict[word]++;
            //    }
            //    else
            //    {
            //        dict[word] = 1;
            //    }
            //}
        }

        private class TestComparer : IEqualityComparer<Test>
        {
            public bool Equals(Test? x, Test? y)
            {
                return x.Value == y.Value;
            }

            public int GetHashCode([DisallowNull] Test obj)
            {
                return obj.Value.GetHashCode();
            }
        }
    }
}