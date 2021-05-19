using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPoco;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsPlattenInfothek
{
    public class Interpret
    {
        public int InterpretenID { get; set; }
        public string Kuenstlername { get; set; }
        public string Herkunft { get; set; }

        public Interpret() { }

        public override string ToString()
        {
            return $"[{InterpretenID}] - {Kuenstlername}";
        }
    }
}
