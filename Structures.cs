using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportSQL
{
    partial class ExportSQL
    {
        private struct ExtractObjectsArgs
        {
            private string _Regex;
            private string _InputText;
            private string _DropEnding;
            private string _DropReplace;
            private string _CreateEnding;
            private string _CreateSearch;
            private string _CreateReplace;
            private List<DBObject> _ObjList;
            private BodyCheckDelegate _BodyCheck;
            public ExtractObjectsArgs(string regex, string inputText, string dropEnding, string dropReplace, string createEnding, string createSearch, string createReplace, List<DBObject> objList)
                : this(regex, inputText, dropEnding, dropReplace, createEnding, createSearch, createReplace, objList, null)
            {
            }
            public ExtractObjectsArgs(
                string regex,
                string inputText,
                string dropEnding,
                string dropReplace,
                string createEnding,
                string createSearch,
                string createReplace,
                List<DBObject> objList,
                BodyCheckDelegate bodyCheck)
            {
                _Regex = regex;
                _InputText = inputText;
                _DropEnding = dropEnding;
                _DropReplace = dropReplace;
                _CreateEnding = createEnding;
                _CreateSearch = createSearch;
                _CreateReplace = createReplace;
                _ObjList = objList;
                _BodyCheck = bodyCheck;
            }
            public BodyCheckDelegate BodyCheck
            {
                get
                {
                    return _BodyCheck;
                }
            }
            public string CreateEnding
            {
                get
                {
                    return _CreateEnding;
                }
            }
            public string CreateReplace
            {
                get
                {
                    return _CreateReplace;
                }
            }
            public string CreateSearch
            {
                get
                {
                    return _CreateSearch;
                }
            }
            public string DropEnding
            {
                get
                {
                    return _DropEnding;
                }
            }
            public string DropReplace
            {
                get
                {
                    return _DropReplace;
                }
            }
            public string InputText
            {
                get
                {
                    return _InputText;
                }
            }
            public List<DBObject> ObjList
            {
                get
                {
                    return _ObjList;
                }
            }
            public string Regex
            {
                get
                {
                    return _Regex;
                }
            }
        }
    }
}
