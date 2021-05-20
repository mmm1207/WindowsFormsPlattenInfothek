using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using NPoco;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsPlattenInfothek
{
    public partial class Form1 : Form
    {
        #region Setup
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["mariadb"].ConnectionString;
        }

        private void InitializeGrid()
        {
            gridInterpreten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridInterpreten.ReadOnly = true;
            gridInterpreten.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridInterpreten.MultiSelect = false;
            gridInterpreten.RowHeadersVisible = false;


            gridPlatten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPlatten.ReadOnly = true;
            gridPlatten.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPlatten.MultiSelect = false;
            gridPlatten.RowHeadersVisible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InterpretenLaden();
        }
        #endregion

        #region LadenFunktionen
        private void InterpretenLaden()
        {
            List<Interpret> lstInterpret = new List<Interpret>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                using (IDatabase db = new Database(connection))
                {
                    db.Connection.Open();
                    lstInterpret = db.Fetch<Interpret>("order by kuenstlername");
                    gridInterpreten.DataSource = null;
                    gridInterpreten.DataSource = lstInterpret;
                    gridInterpreten.Columns["InterpretenID"].Width = 80;

                    gridInterpreten_CellClick(this, new DataGridViewCellEventArgs(0, 0));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void PlatteLadenFür(int interpretenID)
        {
            List<Platte> lstPlatte = new List<Platte>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                using (IDatabase db = new Database(connection))
                {
                    db.Connection.Open();
                    lstPlatte.Clear();
                    lstPlatte = db.Fetch<Platte>("Select * from platte where interpretenID = @0 order by erscheinungsdatum", interpretenID);

                    gridPlatten.DataSource = null;
                    gridPlatten.DataSource = lstPlatte;
                    gridPlatten.Columns["PlattenID"].Width = 80;
                    gridPlatten.Columns["InterpretenID"].Width = 80;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void btnAllePlatten_Click(object sender, EventArgs e)
        {
            AllePlattenLaden();
        }
        private void AllePlattenLaden()
        {
            List<Platte> lstPlatte = new List<Platte>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                using (IDatabase db = new Database(connection))
                {
                    db.Connection.Open();
                    lstPlatte = db.Fetch<Platte>("order by platteninterpret, erscheinungsdatum");
                    gridPlatten.DataSource = null;
                    gridPlatten.DataSource = lstPlatte;
                    gridPlatten.Columns["PlattenID"].Width = 80;
                    gridPlatten.Columns["InterpretenID"].Width = 80;

                    gridPlatten_CellClick(this, new DataGridViewCellEventArgs(0, 0));
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        #endregion

        #region CellClickFunktionen
        private void gridInterpreten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridInterpreten.SelectedRows.Count > 0)
            {
                Interpret interpret = gridInterpreten.SelectedRows[0].DataBoundItem as Interpret;
                if (interpret != null)
                {
                    txtInterpretenID.Text = interpret.InterpretenID.ToString();
                    txtInterpret.Text = interpret.Kuenstlername;
                    txtHerkunft.Text = interpret.Herkunft;

                    PlatteLadenFür(interpret.InterpretenID);

                    gridPlatten_CellClick(sender, e);
                }
            }
        }


        private void gridPlatten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridPlatten.SelectedRows.Count > 0)
            {
                Platte platte = gridPlatten.SelectedRows[0].DataBoundItem as Platte;
                if (platte != null)
                {
                    txtPlattenID.Text = platte.PlattenID.ToString();
                    txtPlattenInterpret.Text = platte.PlattenInterpret;
                    txtTitel.Text = platte.Titel;
                    txtGerne.Text = platte.Gerne;
                    txtErscheinungsdatum.Text = platte.Erscheinungsdatum.ToShortDateString();
                    txtAnzahlSongs.Text = platte.AnzahlSongs.ToString();
                }
            }
        }
        #endregion

        #region InterpretHinzufügen

        private void btnInterpretHinzufügen_Click(object sender, EventArgs e)
        {
            InterpretHinzufügen();
        }
        private void InterpretHinzufügen()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                using (IDatabase db = new Database(connection))
                {
                    db.Connection.Open();
                    Interpret interpret = new Interpret();
                    interpret.InterpretenID = 0;
                    interpret.Kuenstlername = txtInterpret.Text;
                    interpret.Herkunft = txtHerkunft.Text;

                    object o = db.Insert(interpret);
                    InterpretenLaden();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        #endregion

        #region InterpretÄndern
        private void btnInterpretÄndern_Click(object sender, EventArgs e)
        {
            InterpretÄndern();
        }
        private void InterpretÄndern()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                using (IDatabase db = new Database(connection))
                {
                    db.Connection.Open();
                    Interpret interpret = new Interpret();
                    interpret.InterpretenID = Convert.ToInt32(txtInterpretenID.Text);
                    interpret.Kuenstlername = txtInterpret.Text;
                    interpret.Herkunft = txtHerkunft.Text;

                    int n = db.Update(interpret);

                    InterpretenLaden();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        #endregion

        #region PlatteHinzufügen
        private void PlatteHinzufügen()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                using (IDatabase db = new Database(connection))
                {
                    db.Connection.Open();
                    Platte platte = new Platte();
                    platte.PlattenID = 0;
                    Interpret interpret = gridInterpreten.CurrentCell.OwningRow.DataBoundItem as Interpret;
                    if (interpret != null)
                    {
                        platte.InterpretenID = interpret.InterpretenID;
                    }
                    else
                    {
                        platte.InterpretenID = 0;

                    }
                    platte.PlattenInterpret = txtPlattenInterpret.Text;
                    platte.Titel = txtTitel.Text;
                    platte.Gerne = txtGerne.Text;
                    platte.Erscheinungsdatum = Convert.ToDateTime(txtErscheinungsdatum.Text).Date;
                    platte.AnzahlSongs = Convert.ToInt32(txtAnzahlSongs.Text);

                    object o = db.Insert(platte);

                    PlatteLadenFür(interpret.InterpretenID);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void btnPlatteHinzufügen_Click(object sender, EventArgs e)
        {
            PlatteHinzufügen();
        }
        #endregion

        #region PlatteÄndern
        private void PlatteÄndern()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(GetConnectionString()))
                using (IDatabase db = new Database(connection))
                {
                    db.Connection.Open();
                    Platte platte = new Platte();
                    platte.PlattenID = Convert.ToInt32(txtPlattenID.Text);
                    Interpret interpret = gridInterpreten.CurrentCell.OwningRow.DataBoundItem as Interpret;
                    if (interpret != null)
                    {
                        platte.InterpretenID = interpret.InterpretenID;
                    }
                    else
                    {
                        platte.InterpretenID = 0;
                    }
                    platte.PlattenInterpret = txtPlattenInterpret.Text;
                    platte.Titel = txtTitel.Text;
                    platte.Gerne = txtGerne.Text;
                    platte.Erscheinungsdatum = Convert.ToDateTime(txtErscheinungsdatum.Text).Date;
                    platte.AnzahlSongs = Convert.ToInt32(txtAnzahlSongs.Text);

                    int n = db.Update(platte);

                    PlatteLadenFür(interpret.InterpretenID);

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void btnPlatteÄndern_Click(object sender, EventArgs e)
        {
            PlatteÄndern();
        }
        #endregion

        #region TextBoxenLeeren
        private void btnLeerenInterpret_Click(object sender, EventArgs e)
        {
            txtInterpretenID.Text = "";
            txtInterpret.Text = "";
            txtHerkunft.Text = "";
        }

        private void btnLeerenPlatte_Click(object sender, EventArgs e)
        {
            txtPlattenID.Text = "";
            txtPlattenInterpret.Text = "";
            txtTitel.Text = "";
            txtGerne.Text = "";
            txtErscheinungsdatum.Text = "";
            txtAnzahlSongs.Text = "";
        } 
        #endregion
    }
}
