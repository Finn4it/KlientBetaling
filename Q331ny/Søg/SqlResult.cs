using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q331ny.Søg
{
    public class SqlResult
    {
        public List<Kolloner> Col{ get; set; }
        public SqlResult()
        {
            Col = new List<Kolloner>();
        }
        public void Addkol(string values)
        {
            Kolloner tt = new Kolloner();
            tt.Felt = values;
            Col.Add(tt);
        }
    }


}
