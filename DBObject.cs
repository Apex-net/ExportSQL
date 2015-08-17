using System;
using System.IO;

namespace ExportSQL
{
    class DBObject
    {
        public const string NAME = "Name";
        public const string DROP_STAT = "DropStatement";
        public const string CREATE_STAT = "CreateStatement";

        public string Name { get; set; }
        public string Drop { get; set; }
        public string Create { get; set; }

        public DBObject(string name, string drop, string create)
        {
            Name = name;
            Drop = drop;
            Create = create;
        }

        public void WriteToStream(TextWriter sw)
        {
            if (Settings.General.Default.ExportDrops)
            {
                sw.WriteLine(Drop);
            }

            sw.WriteLine(Create);
        }
    }
}
