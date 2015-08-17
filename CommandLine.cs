using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportSQL
{
    static class CommandLine
    {
        #region Argument management

        public static class Argument
        {
            public const string NO_WINDOW = "--no-window";
            public const string USAGE = "--usage";

            public const string DB_TYPE = "--db-type";
            public const string ORACLE = "oracle";
            public const string SQL_SERVER = "sqlserver";

            public const string NO_VIEWS = "--no-views";
            public const string NO_PROCEDURES = "--no-procedures";
            public const string NO_FUNCTIONS = "--no-functions";
            public const string NO_TRIGGERS = "--no-triggers";

            public const string EXTRACT_MODE = "--extract-mode";
            public const string EXT_PER_TYPE = "type";
            public const string EXT_PER_OBJ = "object";
            public const string EXT_ALL = "all";
        }

        private static bool IsArgWithValue(string paramString, string name)
        {
            return paramString.StartsWith(String.Format("{0}=", name));
        }

        private static string GetArgValue(string paramString)
        {
            string[] temp = paramString.Split('=');
            return temp[temp.Length - 1];
        }

        #endregion

        public static void Parse(string[] args)
        {
            bool runWithoutWindow = false;
            ExportSQL.DataBaseType dbType = ExportSQL.DataBaseType.Unknown;
            ExportSQL.SaveMode saveMode = ExportSQL.SaveMode.SingleFilePerType;
            bool expViews = true; bool expProcedures = true; bool expFunctions = true; bool expTriggers = true;
            for (int i = 1; i < args.Length; i++)
            {
                string argument = args[i];

                if (argument.Equals(CommandLine.Argument.NO_WINDOW))
                {
                    runWithoutWindow = true;
                }
                else if (CommandLine.IsArgWithValue(argument, CommandLine.Argument.DB_TYPE))
                {
                    string value = CommandLine.GetArgValue(argument);
                    switch (value)
                    {
                        case CommandLine.Argument.ORACLE:
                            dbType = ExportSQL.DataBaseType.Oracle;
                            break;
                        case CommandLine.Argument.SQL_SERVER:
                            dbType = ExportSQL.DataBaseType.SQLServer;
                            break;
                        default:
                            Console.WriteLine(String.Format("{0} is not a valid database type!", value));
                            Environment.Exit(-1);
                            break;
                    }
                }
                else if (CommandLine.IsArgWithValue(argument, CommandLine.Argument.EXTRACT_MODE))
                {
                    string value = CommandLine.GetArgValue(argument);
                    switch (value)
                    {
                        case CommandLine.Argument.EXT_PER_TYPE:
                            saveMode = ExportSQL.SaveMode.SingleFilePerType;
                            break;
                        case CommandLine.Argument.EXT_PER_OBJ:
                            saveMode = ExportSQL.SaveMode.SingleFilePerObject;
                            break;
                        case CommandLine.Argument.EXT_ALL:
                            saveMode = ExportSQL.SaveMode.SingleFile;
                            break;
                        default:
                            Console.WriteLine(String.Format("{0} is not a valid save mode!", value));
                            Environment.Exit(-1);
                            break;
                    }
                }
                else if (argument.Equals(CommandLine.Argument.NO_VIEWS))
                {
                    expViews = false;
                }
                else if (argument.Equals(CommandLine.Argument.NO_PROCEDURES))
                {
                    expProcedures = false;
                }
                else if (argument.Equals(CommandLine.Argument.NO_FUNCTIONS))
                {
                    expFunctions = false;
                }
                else if (argument.Equals(CommandLine.Argument.NO_TRIGGERS))
                {
                    expTriggers = false;
                }
                else
                {
                    Console.WriteLine(String.Format("Parameter \"{0}\" is not supported!", argument));
                    Environment.Exit(-1);
                }
            }

            if (runWithoutWindow)
            {
                CommandLine.RunWithoutWindow(dbType, saveMode, expViews, expProcedures, expFunctions, expTriggers);
            }
            Environment.Exit(0);
        }

        public static void ShowUsage(string program)
        {
            Console.WriteLine(String.Format(
                "NAME\n" +
                "    ExportSQL rocks!\n" +
                "\n" +
                "SYNOPSIS\n" +
                "    {0} [ {1} [{2}=<DB_TYPE>] [{9}=<EXTRACT_MODE>] [{5}] [{6}] [{7}] [{8}] ]\n" +
                "\n" +
                "DESCRIPTION\n" +
                "    {1}        Run in windowless mode.\n" +
                "    {2}          Set input database type (default is auto detected)\n" +
                "    {9}     Set extract mode (default is 'Single file per type')\n" +
                "    {5}         Don't extract views (by default views will be extracted)\n" +
                "    {6}    Don't extract procedures (by default procedures will be extracted)\n" +
                "    {7}     Don't extract functions (by default functions will be extracted)\n" +
                "    {8}      Don't extract triggers (by default triggers will be extracted)\n" +
                "\n" +
                "    In windowless mode {0} will read from configuration files,\n" +
                "    run automagically and die silently.\n" +
                "\n" +
                "    DB_TYPE    Either '{3}' or '{4}' can be set as value.\n" +
                "               If {1} is not given, correct database type will be detected\n" +
                "               automagically from input In.De. build file.\n" +
                "\n" +
                "    EXTRACT_MODE    Either '{10}', '{11}' or '{12}' can be set as value.\n" +
                "                    In {10} mode a file per type will be generated, while\n" +
                "                    in {11} mode, a file is created for every single object\n" +
                "                    grouped in folders; {12} mode is used to generate a single\n" +
                "                    file for everything.\n" +
                "                    If {9} is not given, {10} mode will be used by default.\n" +
                "",
                program,
                Argument.NO_WINDOW,
                Argument.DB_TYPE, Argument.ORACLE, Argument.SQL_SERVER,
                Argument.NO_VIEWS, Argument.NO_PROCEDURES, Argument.NO_FUNCTIONS, Argument.NO_TRIGGERS,
                Argument.EXTRACT_MODE, Argument.EXT_PER_TYPE, Argument.EXT_PER_OBJ, Argument.EXT_ALL));
        }

        private static void RunWithoutWindow(
            ExportSQL.DataBaseType dbType,
            ExportSQL.SaveMode saveMode,
            bool expViews, bool expProcedures, bool expFunctions, bool expTriggers)
        {
            Console.WriteLine("Running in windowless mode...");
            Console.WriteLine("");
            ExportSQL exp = new ExportSQL();

            exp.ReadIndeBuild(Settings.General.Default.DefaultInputFile);
            if (dbType != ExportSQL.DataBaseType.Unknown)
            {
                exp.DbType = dbType;
            }
            Console.WriteLine("Input database type: " + exp.DbType);

            Console.WriteLine("          Save mode: " + saveMode);
            Console.WriteLine("       Export views: " + expViews);
            Console.WriteLine("  Export procedures: " + expProcedures);
            Console.WriteLine("   Export functions: " + expFunctions);
            Console.WriteLine("    Export triggers: " + expTriggers);

            Console.WriteLine("");
            Console.Write("Please wait while exporting...");

            if (expViews)
            {
                exp.ExtractViews();
            }
            if (expProcedures)
            {
                exp.ExtractProcedures();
            }
            if (expFunctions)
            {
                exp.ExtractFunctions();
            }
            if (expTriggers)
            {
                exp.ExtractTriggers();
            }
            exp.Export(saveMode, Settings.General.Default.DefaultOutputPath);
            
            Console.WriteLine(" done.");
        }
    }
}
