using System.Xml.Linq;

namespace Clone_Graph
{
    internal class Solution
    {

        Dictionary<Node, Node> reference = new Dictionary<Node, Node>();

        public bool CheckClone(Node node)
        {
            if (reference.ContainsKey(node))
                return true;

            reference.Add(node, new Node(node.val));
            return false;
        }

        public void DeepClone(Node node)
        {
            if (CheckClone(node))
                return;

            for (int i = 0; i < node.neighbors.Count; i++)
            {
                DeepClone(node.neighbors[i]);
                reference[node].neighbors.Add(reference[node.neighbors[i]]);
            }
        }

        public Node CloneGraph(Node node)
        {
            if (node == null)
                return null;

            DeepClone(node);

            return reference[node];
        }

        internal static void Main(string[] args)
        {

            var data = new List<Node>
            {
                new(1),
                new(2),
                new(3),
                new(4),
            };
            data[0].neighbors.Add(data[1]);
            data[0].neighbors.Add(data[3]);
            data[1].neighbors.Add(data[2]);
            data[2].neighbors.Add(data[3]);

            var s = new Solution();
            s.CloneGraph(data[0]);

            Console.WriteLine();
        }
    }
}
