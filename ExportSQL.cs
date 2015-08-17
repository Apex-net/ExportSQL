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
        public enum SourceType
        {
            Inde,
            Other
        }

        // Order of these elements (0, 1, 2, ...) must match with the ones in designer!
        public enum SaveMode
        {
            SingleFilePerType,
            SingleFilePerObject,
            SingleFile
        }
        #endregion

        private string _inputText;

        private List<DBObject> _views = new List<DBObject>();
        private List<DBObject> _procedures = new List<DBObject>();
        private List<DBObject> _functions = new List<DBObject>();
        private List<DBObject> _triggers = new List<DBObject>();
        private string _filename;

        public void ReadIndeBuild(string filename)
        {
            _filename = filename;
            _inputText = System.IO.File.ReadAllText(filename, System.Text.Encoding.GetEncoding(1252));
            _dbType = GetIndeDataBaseType(_inputText);
        }

        public void readOtherText(string text)
        {
            _inputText = text;
        }

        /// <summary>
        /// Export an object to file
        /// </summary>
        /// <param name="sw">Previously created TextWriter object</param>
        /// <param name="obj">A DBObject</param>
        /// <param name="desc">A string that will be used as heading comment before object definition</param>
        private static void Export(TextWriter sw, DBObject obj, string desc)
        {
            Export(sw, new DBObject[] { obj }, desc);
        }

        /// <summary>
        /// Export a list of objects to file
        /// </summary>
        /// <param name="sw">Previously created TextWriter object</param>
        /// <param name="objects">A list of DBObjects</param>
        /// <param name="description">A string that will be used as heading comment before objects definitions</param>
        private static void Export(TextWriter sw, DBObject[] objects, string description)
        {
            sw.WriteLine("".PadRight(80, '-'));
            sw.WriteLine(String.Format("-- {0}", description));
            sw.WriteLine("".PadRight(80, '-'));
            sw.WriteLine();

            Array.ForEach(objects, o =>
            {
                o.WriteToStream(sw);
                sw.WriteLine();
            });
        }

        /// <summary>
        /// This will optionally add EOF at the end of the file
        /// </summary>
        /// <param name="sw">Previously created TextWriter object</param>
        private static void AppendEndOfFile(TextWriter sw)
        {
            if (Settings.General.Default.AppendEndOfFile)
            {
                sw.WriteLine(String.Format("-- {0}", Settings.Output.Default.TextEndOfFile));
            }
        }

        public void Export(SaveMode mode, string path)
        {
            switch ((SaveMode)mode)
            {
                #region SingleFile

                case SaveMode.SingleFile:
                    string originalFilename = Path.GetFileNameWithoutExtension(_filename);
                    using (TextWriter sw = new StreamWriter(
                        String.Format(@"{0}\{1}", path, originalFilename + Settings.Output.Default.FileName_SingleFile), true, System.Text.Encoding.GetEncoding(1252)))
                    {
                        if (_views.Count > 0)
                        {
                            Export(sw, _views.ToArray(), Settings.Output.Default.TitleViews);
                        }

                        if (_procedures.Count > 0)
                        {
                            Export(sw, _procedures.ToArray(), Settings.Output.Default.TitleProcedures);
                        }

                        if (_functions.Count > 0)
                        {
                            Export(sw, _functions.ToArray(), Settings.Output.Default.TitleFunctions);
                        }

                        if (_triggers.Count > 0)
                        {
                            Export(sw, _triggers.ToArray(), Settings.Output.Default.TitleTriggers);
                        }

                        AppendEndOfFile(sw);
                        sw.Close();
                    }

                    break;
                #endregion

                #region SingleFilePerObject

                case SaveMode.SingleFilePerObject:

                    #region Views

                    if (_views.Count > 0)
                    {
                        string dir = String.Format(@"{0}\{1}", path, Settings.Output.Default.DirectoryName_Views);
                        if (Directory.Exists(dir))
                        {
                            Directory.Delete(dir, true);
                        }
                        Directory.CreateDirectory(dir);

                        _views.ForEach(v =>
                        {
                            using (TextWriter sw = new StreamWriter(String.Format(@"{0}\{1}.vw", dir, v.Name)))
                            {
                                Export(sw, v, v.Name);
                                AppendEndOfFile(sw);
                                sw.Close();
                            }
                        });
                    }

                    #endregion

                    #region Procedures

                    if (_procedures.Count > 0)
                    {
                        string dir = String.Format(@"{0}\{1}", path, Settings.Output.Default.DirectoryName_Procedures);
                        if (Directory.Exists(dir))
                        {
                            Directory.Delete(dir, true);
                        }
                        Directory.CreateDirectory(dir);

                        _procedures.ForEach(p =>
                        {
                            using (TextWriter sw = new StreamWriter(String.Format(@"{0}\{1}.prc", dir, p.Name)))
                            {
                                Export(sw, p, p.Name);
                                AppendEndOfFile(sw);
                                sw.Close();
                            }
                        });
                    }

                    #endregion

                    #region Functions

                    if (_functions.Count > 0)
                    {
                        string dir = String.Format(@"{0}\{1}", path, Settings.Output.Default.DirectoryName_Functions);
                        if (Directory.Exists(dir))
                        {
                            Directory.Delete(dir, true);
                        }
                        Directory.CreateDirectory(dir);

                        _functions.ForEach(f =>
                        {
                            using (TextWriter sw = new StreamWriter(String.Format(@"{0}\{1}.fnc", dir, f.Name)))
                            {
                                Export(sw, f, f.Name);
                                AppendEndOfFile(sw);
                                sw.Close();
                            }
                        });
                    }

                    #endregion

                    #region Triggers

                    if (_triggers.Count > 0)
                    {
                        string dir = String.Format(@"{0}\{1}", path, Settings.Output.Default.DirectoryName_Triggers);
                        if (Directory.Exists(dir))
                        {
                            Directory.Delete(dir, true);
                        }
                        Directory.CreateDirectory(dir);

                        _triggers.ForEach(t =>
                        {
                            using (TextWriter sw = new StreamWriter(String.Format(@"{0}\{1}.trg", dir, t.Name)))
                            {
                                Export(sw, t, t.Name);
                                AppendEndOfFile(sw);
                                sw.Close();
                            }
                        });
                    }

                    #endregion

                    break;
                #endregion

                #region SingleFilePerType

                case SaveMode.SingleFilePerType:

                    #region Views

                    if (_views.Count > 0)
                    {
                        using (TextWriter sw = new StreamWriter(
                            String.Format(@"{0}\{1}", path, Settings.Output.Default.FileName_ViewsType)))
                        {
                            Export(sw, _views.ToArray(), Settings.Output.Default.TitleViews);
                            AppendEndOfFile(sw);
                            sw.Close();
                        }
                    }

                    #endregion

                    #region Procedures

                    if (_procedures.Count > 0)
                    {
                        using (TextWriter sw = new StreamWriter(
                        String.Format(@"{0}\{1}", path, Settings.Output.Default.FileName_ProceduresType)))
                        {
                            Export(sw, _procedures.ToArray(), Settings.Output.Default.TitleProcedures);
                            AppendEndOfFile(sw);
                            sw.Close();
                        }
                    }

                    #endregion

                    #region Functions

                    if (_functions.Count > 0)
                    {
                        using (TextWriter sw = new StreamWriter(
                        String.Format(@"{0}\{1}", path, Settings.Output.Default.FileName_FunctionsType)))
                        {
                            Export(sw, _functions.ToArray(), Settings.Output.Default.TitleFunctions);
                            AppendEndOfFile(sw);
                            sw.Close();
                        }
                    }

                    #endregion

                    #region Triggers

                    if (_triggers.Count > 0)
                    {
                        using (TextWriter sw = new StreamWriter(
                        String.Format(@"{0}\{1}", path, Settings.Output.Default.FileName_TriggersType)))
                        {
                            Export(sw, _triggers.ToArray(), Settings.Output.Default.TitleTriggers);
                        }
                    }

                    #endregion

                    break;
                #endregion

                default:
                    throw new NotSupportedException(
                        String.Format("{0} is not a valid save mode!",
                        (SaveMode)mode));
            }
        }
    }
}
