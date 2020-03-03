using NUnit.Framework;

namespace Algorithms.Graph
{
    public class TestSymbolGraph
    {
        private SymbolGraph initSymbolGraph()
        {
            string str = "jfk,mco\nord,den\nord,hou\ndfw,phx\njfk,atl\nord,dfw\nord,phx\natl,hou\nden,phx\nphx,lax\njfk,ord\nden,las\ndfw,hou\nord,atl\nlas,lax\natl,mco\nhou,mco\nlas,phx";
            //print(str);
            var sg = new SymbolGraph(str, ',');
            return sg;
        }
        [Test]
        public void SymbolGraph_GetATLAdj_OrdJfkMcoHou()
        {
            SymbolGraph sg = initSymbolGraph();
            Graph g = sg.getG();
            var a = sg.index("atl");
            var res = sg.name(a);
            Assert.AreEqual("atl", res);
        }       
    }
}

