using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombolistEditor
{
    class MenuItemAction
    {
        public MenuItemAction()
        {
            GetCharacter = "x";
        }

        public string FileDirectoryAndName()
        {
            return (FileDirectory + "/" + FileName);
        }

        public string GetCharacter
        {
            get;
            set;
        }

        public string FileDirectory
        {
            get;
            set;
        }

        public string FileName
        {
            get;
            set;
        }

    }

    class ComboList
    {
        public string TextFileLines
        {
            get;
            set;
        }

        public void AppendLine(string givenLine)
        {
            TextFileLines = TextFileLines + givenLine + Environment.NewLine;
        }
    }
}
