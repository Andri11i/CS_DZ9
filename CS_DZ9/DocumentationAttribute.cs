using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ9
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class DocumentationAttribute : Attribute
    {
        public string Author { get; }
        public string Version { get; }
        public DocumentationAttribute(string author, string version)
        {
            Author = author;
            Version = version;
        }
        public string Desc { get; set; }
    }
}
