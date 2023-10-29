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
            public string Name { get; }

            public string Extension { get; set; }

            public object[] Content;

            public File(string fileName)
            { Name = fileName; FuncName = Name; }

            public readonly string FuncName;
        }

        public class Common
        {
            public object[] SubFolders;

            public class Decisions
            {
                public class Categories
                { public File[] Files; public readonly string FuncName = "categories"; }

                public Categories SubFolderCats;

                public File[] Files;

                public readonly string FuncName = "decisions";
            }

            public class OnActions
            { public File[] Files; public readonly string FuncName = "on_actions"; }

            public readonly string FuncName = "common";
        }

        public class Events
        { public File[] Files; public readonly string FuncName = "events"; }

        public class History
        {
            public class Countries
            { public File[] Files; public readonly string FuncName = "countries"; }

            public class General
            { public File[] Files; public readonly string FuncName = "general"; }

            public class States
            { public File[] Files; public readonly string FuncName = "states"; }

            public class Units
            { public File[] Files; public readonly string FuncName = "units"; }

            public Countries CountriesSubFolder;

            public General GeneralSubFolder;

            public States StatesSubFolder;

            public Units UnitsSubFolder;

            public File[] Files;

            public readonly string FuncName = "history";
        }

        public class Interface
        {
            public class SubFolder
            {
                public string Name;

                public File[] Files;

                public SubFolder(string name)
                { Name = name; FuncName = Name; }

                public readonly string FuncName = "";
            }

            public SubFolder[] SubFolders;

            public File[] Files;

            public readonly string FuncName = "";
        }

        public class Localisation
        {
            public class LocFolder
            {
                public string Name;

                public File[] Files;

                public LocFolder(string folderName)
                { Name = folderName; FuncName = Name; }

                public readonly string FuncName;
            }

            public LocFolder[] LocFolders;

            public File[] Files;

            public readonly string FuncName = "localisation";
        }
    }
}
