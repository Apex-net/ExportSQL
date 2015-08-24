using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExportSQL
{
    partial class ExportSQL
    {
        #region Useful Enumerations
        // Order of these elements (0, 1, 2, ...) must match with the ones in designer!
        public enum DataBaseType
        {
            Unknown,
            Oracle,
            SQLServer
        }
        #endregion

        private DataBaseType _dbType = DataBaseType.Unknown;

        public DataBaseType DbType
        {
            get
            {
                return _dbType;
            }
            set
            {
                _dbType = value;
            }
        }

        private static DataBaseType GetIndeDataBaseType(string inputText)
        {
            Regex re = new Regex(@"Database Type:\s+(?<DatabaseType>.*)", RegexOptions.Multiline | RegexOptions.Compiled);

            MatchCollection matches = re.Matches(inputText);
            if (matches.Count == 1)
            {
                string dbType = matches[0].Groups["DatabaseType"].ToString();
                if (dbType.StartsWith("Oracle"))
                {
                    return DataBaseType.Oracle;
                }
                else if (dbType.StartsWith("SQL Server"))
                {
                    return DataBaseType.SQLServer;
                }
                else
                {
                    throw new Exception(string.Format("\"{0}\" DataBase Type is not supported yet!", dbType));
                }
            }
            else
            {
                return DataBaseType.Unknown;
            }
        }

        private ExtractObjectsArgs GetViewExtractObjectsArgs(DataBaseType dbType)
        {
            switch (dbType)
            {
                case DataBaseType.Oracle:
                    return new ExtractObjectsArgs(
                        Settings.Oracle.View.Default.Regex,
                        _inputText,
                        Settings.Oracle.View.Default.DropEnding,
                        Settings.Oracle.View.Default.DropReplace,
                        Settings.Oracle.View.Default.CreateEnding,
                        Settings.Oracle.View.Default.CreateSearch,
                        Settings.Oracle.View.Default.CreateReplace,
                        _views);

                case DataBaseType.SQLServer:
                    return new ExtractObjectsArgs(
                        Settings.SQLServer.View.Default.Regex,
                        _inputText,
                        Settings.SQLServer.View.Default.DropEnding,
                        Settings.SQLServer.View.Default.DropReplace,
                        Settings.SQLServer.View.Default.CreateEnding,
                        Settings.SQLServer.View.Default.CreateSearch,
                        Settings.SQLServer.View.Default.CreateReplace,
                        _views);

                default:
                    throw new NotSupportedException(
                        String.Format("{0} is not a valid DataBase Type!",
                        (DataBaseType)dbType));
            }
        }

        private ExtractObjectsArgs GetProcedureExtractObjectsArgs(DataBaseType dbType)
        {
            switch (dbType)
            {
                case DataBaseType.Oracle:
                    return new ExtractObjectsArgs(
                        Settings.Oracle.Procedure.Default.Regex,
                        _inputText,
                        Settings.Oracle.Procedure.Default.DropEnding,
                        Settings.Oracle.Procedure.Default.DropReplace,
                        Settings.Oracle.Procedure.Default.CreateEnding,
                        Settings.Oracle.Procedure.Default.CreateSearch,
                        Settings.Oracle.Procedure.Default.CreateReplace,
                        _procedures);

                case DataBaseType.SQLServer:
                    return new ExtractObjectsArgs(
                        Settings.SQLServer.Procedure.Default.Regex,
                        _inputText,
                        Settings.SQLServer.Procedure.Default.DropEnding,
                        Settings.SQLServer.Procedure.Default.DropReplace,
                        Settings.SQLServer.Procedure.Default.CreateEnding,
                        Settings.SQLServer.Procedure.Default.CreateSearch,
                        Settings.SQLServer.Procedure.Default.CreateReplace,
                        _procedures);

                default:
                    throw new NotSupportedException(
                        String.Format("{0} is not a valid DataBase Type!",
                        (DataBaseType)dbType));
            }
        }

        private ExtractObjectsArgs GetFunctionExtractObjectsArgs(DataBaseType dbType)
        {
            switch (dbType)
            {
                case DataBaseType.Oracle:
                    return new ExtractObjectsArgs(
                        Settings.Oracle.Function.Default.Regex,
                        _inputText,
                        Settings.Oracle.Function.Default.DropEnding,
                        Settings.Oracle.Function.Default.DropReplace,
                        Settings.Oracle.Function.Default.CreateEnding,
                        Settings.Oracle.Function.Default.CreateSearch,
                        Settings.Oracle.Function.Default.CreateReplace,
                        _functions,
                        delegate(string str) { return str.Equals("\r\nBEGIN\r\nRETURN NULL;\r\n"); });

                case DataBaseType.SQLServer:
                    return new ExtractObjectsArgs(
                        Settings.SQLServer.Function.Default.Regex,
                        _inputText,
                        Settings.SQLServer.Function.Default.DropEnding,
                        Settings.SQLServer.Function.Default.DropReplace,
                        Settings.SQLServer.Function.Default.CreateEnding,
                        Settings.SQLServer.Function.Default.CreateSearch,
                        Settings.SQLServer.Function.Default.CreateReplace,
                        _functions,
                        delegate(string str) { return str.Equals(" begin\r\nreturn NULL\r\n"); });

                default:
                    throw new NotSupportedException(
                        String.Format("{0} is not a valid DataBase Type!",
                        (DataBaseType)dbType));
            }
        }

        private ExtractObjectsArgs GetTriggerExtractObjectsArgs(DataBaseType dbType)
        {
            switch (dbType)
            {
                case DataBaseType.Oracle:
                    return new ExtractObjectsArgs(
                        Settings.Oracle.Trigger.Default.Regex,
                        _inputText,
                        Settings.Oracle.Trigger.Default.DropEnding,
                        Settings.Oracle.Trigger.Default.DropReplace,
                        Settings.Oracle.Trigger.Default.CreateEnding,
                        Settings.Oracle.Trigger.Default.CreateSearch,
                        Settings.Oracle.Trigger.Default.CreateReplace,
                        _triggers);

                case DataBaseType.SQLServer:
                    return new ExtractObjectsArgs(
                        Settings.SQLServer.Trigger.Default.Regex,
                        _inputText,
                        Settings.SQLServer.Trigger.Default.DropEnding,
                        Settings.SQLServer.Trigger.Default.DropReplace,
                        Settings.SQLServer.Trigger.Default.CreateEnding,
                        Settings.SQLServer.Trigger.Default.CreateSearch,
                        Settings.SQLServer.Trigger.Default.CreateReplace,
                        _triggers);

                default:
                    throw new NotSupportedException(
                        String.Format("{0} is not a valid DataBase Type!",
                        (DataBaseType)dbType));
            }
        }
    }
}
