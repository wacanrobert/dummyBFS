using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8PuzzleBFS
{
    internal class PerformSearch
    {
        public PerformSearch()
        {

        }

        public async Task<List<Node>> Search(int[] p)
        {
            Node root = new Node(p);
            UninformedSearch ui = new UninformedSearch();
            //List<Node> solution = await ui.BreadthFirstSearch(root);
            List<Node> solution = null;
            return await Task.FromResult(solution);
        }
    }
}
