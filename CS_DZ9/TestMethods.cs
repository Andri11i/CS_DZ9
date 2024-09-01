using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ9
{
    public class SampleClass
    {
        [Documentation("John Doe", "1.0")]
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        [Documentation("Jane Smith", "1.1-BETA")]
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
        [Documentation("John Doe", "1.0-mueheehe", Desc = "this is third method by john dor")]
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
    }

}
