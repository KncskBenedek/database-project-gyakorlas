using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
namespace SampleRules
{
    internal class WaitForDelayVisitor : TSqlConcreteFragmentVisitor
    {
        public IList<WaitForStatement> WaitForDelayStatements { get; private set; }
        public override void ExplicitVisit(WaitForStatement node)
        {
            if (node.WaitForOption == WaitForOption.Delay)
                WaitForDelayStatements.Add(node);
        }
    }
}
