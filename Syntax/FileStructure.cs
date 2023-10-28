using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxSyntaxDotNet.Syntax
{
    public class FileStructure
    {
        public class File
        {
            public readonly string Name;

            public object[] Content;

            public File(string fileName)
            { Name = fileName; }
        }

        public class Common
        {

        }

        public class Events
        {

        }

        public class History
        {

        }

        public class Interface
        {

        }

        public class Localisation
        {

        }
    }
}
