using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExportSQL
{
    partial class ExportSQL
    {
        private delegate bool BodyCheckDelegate(string controlText);

        private static DBObject[] ExtractObjects(ExtractObjectsArgs args)
        {
            Regex re = new Regex(args.Regex, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.Compiled);

            foreach (Match m in re.Matches(args.InputText))
            {
                if (args.BodyCheck == null || !args.BodyCheck(m.Groups["Body"].ToString()))
                {
                    
                    string name = String.Format("{0}",
                        m.Groups[DBObject.NAME].ToString().Trim());
                    string dropStat = String.Format("{0}{1}{2}",
                        m.Groups[DBObject.DROP_STAT].ToString().Trim(), Environment.NewLine, args.DropEnding);
                    string createStat = String.Format("{0}{1}{2}",
                        m.Groups[DBObject.CREATE_STAT].ToString().Trim(), Environment.NewLine, args.CreateEnding);

                    if (!args.CreateReplace.Equals(string.Empty))
                    {
                        createStat = createStat.Replace(args.CreateSearch, args.CreateReplace);
                    }
                    if (!args.DropReplace.Equals(string.Empty))
                    {                        
                        dropStat = String.Format("{0}{1}{2}",
                           args.DropReplace.Replace("{OBJECT_NAME}", name), Environment.NewLine, dropStat);                        
                    }
                    
                    args.ObjList.Add(new DBObject(name, dropStat, createStat));
                }
            }

            return args.ObjList.ToArray();
        }

        public DBObject[] ExtractViews()
        {
            return ExtractObjects(GetViewExtractObjectsArgs(_dbType));            
        }

        public DBObject[] ExtractProcedures
            ()
        {
            return ExtractObjects(GetProcedureExtractObjectsArgs(_dbType));
        }

        public DBObject[] ExtractFunctions()
        {
            return ExtractObjects(GetFunctionExtractObjectsArgs(_dbType));
        }

        public DBObject[] ExtractTriggers()
        {
            return ExtractObjects(GetTriggerExtractObjectsArgs(_dbType));
        }
    }
}
