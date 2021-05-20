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
    [PrimaryKey("PlattenID")]
    public class Platte
    {
        public int PlattenID { get; set; }
        public int InterpretenID { get; set; }
        public string PlattenInterpret { get; set; }
        public string Titel { get; set; }
        public string Gerne { get; set; }
        public DateTime Erscheinungsdatum { get; set; }
        public int AnzahlSongs { get; set; }

        public override string ToString()
        {
            return $"[{PlattenID}] - {Titel}";
        }
    }
}
