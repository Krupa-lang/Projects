using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ParentChild> list = new List<ParentChild>()
            {
            new ParentChild{Parent = "parent1", Child = "child1"},
            new ParentChild{Parent = "parent1", Child = "child2"},
            new ParentChild{Parent = "parent1", Child = "child3"},
            new ParentChild{Parent = "parent2", Child = "child1"},
            new ParentChild{Parent = "parent2", Child = "child2"},
            new ParentChild{Parent = "parent3", Child = "child2"},
            };
            var listGroup = list.GroupBy(p => p.Parent)
                        .Select(x => new
                        {
                            Parent = x.Key,
                            Child = x.Select(y => y)
                        });

            string s = string.Empty;

            foreach (var group in listGroup)
            {
                s +=  group.Parent + ": ";
                foreach (var child in group.Child)
                {
                    s += child.Child + ", ";
                }
                s += "\n";
            }
            Console.Write(s);
            Console.ReadKey();
        }
    }
    public class ParentChild
    {
        public string Parent { get; set; }
        public string Child { get; set; }
    }
    
   

}
