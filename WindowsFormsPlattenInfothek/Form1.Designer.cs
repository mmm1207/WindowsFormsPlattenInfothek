﻿namespace WindowsFormsPlattenInfothek
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlControl = new System.Windows.Forms.Panel();
            this.gridInterpreten = new System.Windows.Forms.DataGridView();
            this.gridPlatten = new System.Windows.Forms.DataGridView();
            this.pnlSeperation = new System.Windows.Forms.Panel();
            this.lblGridInterpreten = new System.Windows.Forms.Label();
            this.lblGridPlatten = new System.Windows.Forms.Label();
            this.txtPlattenID = new System.Windows.Forms.TextBox();
            this.txtInterpretenID = new System.Windows.Forms.TextBox();
            this.txtPlattenInterpret = new System.Windows.Forms.TextBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.txtGerne = new System.Windows.Forms.TextBox();
            this.txtErscheinungsdatum = new System.Windows.Forms.TextBox();
            this.txtAnzahlSongs = new System.Windows.Forms.TextBox();
            this.txtHerkunft = new System.Windows.Forms.TextBox();
            this.txtInterpret = new System.Windows.Forms.TextBox();
            this.btnInterpretHinzufügen = new System.Windows.Forms.Button();
            this.btnInterpretÄndern = new System.Windows.Forms.Button();
            this.btnPlatteHinzufügen = new System.Windows.Forms.Button();
            this.btnPlatteÄndern = new System.Windows.Forms.Button();
            this.lblInterpretenID = new System.Windows.Forms.Label();
            this.lblInterpret = new System.Windows.Forms.Label();
            this.lblHerkunft = new System.Windows.Forms.Label();
            this.lblPlattenID = new System.Windows.Forms.Label();
            this.lblPlattenInterpret = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblGerne = new System.Windows.Forms.Label();
            this.lblErscheinungsdatum = new System.Windows.Forms.Label();
            this.lblAnzahlSongs = new System.Windows.Forms.Label();
            this.btnAllePlatten = new System.Windows.Forms.Button();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInterpreten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlatten)).BeginInit();
            this.pnlSeperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnAllePlatten);
            this.pnlControl.Controls.Add(this.lblAnzahlSongs);
            this.pnlControl.Controls.Add(this.lblErscheinungsdatum);
            this.pnlControl.Controls.Add(this.lblGerne);
            this.pnlControl.Controls.Add(this.lblTitel);
            this.pnlControl.Controls.Add(this.lblPlattenInterpret);
            this.pnlControl.Controls.Add(this.lblPlattenID);
            this.pnlControl.Controls.Add(this.lblHerkunft);
            this.pnlControl.Controls.Add(this.lblInterpret);
            this.pnlControl.Controls.Add(this.lblInterpretenID);
            this.pnlControl.Controls.Add(this.btnPlatteÄndern);
            this.pnlControl.Controls.Add(this.btnPlatteHinzufügen);
            this.pnlControl.Controls.Add(this.btnInterpretÄndern);
            this.pnlControl.Controls.Add(this.btnInterpretHinzufügen);
            this.pnlControl.Controls.Add(this.txtInterpret);
            this.pnlControl.Controls.Add(this.txtHerkunft);
            this.pnlControl.Controls.Add(this.txtAnzahlSongs);
            this.pnlControl.Controls.Add(this.txtErscheinungsdatum);
            this.pnlControl.Controls.Add(this.txtGerne);
            this.pnlControl.Controls.Add(this.txtTitel);
            this.pnlControl.Controls.Add(this.txtPlattenInterpret);
            this.pnlControl.Controls.Add(this.txtInterpretenID);
            this.pnlControl.Controls.Add(this.txtPlattenID);
            this.pnlControl.Controls.Add(this.lblGridInterpreten);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(946, 163);
            this.pnlControl.TabIndex = 4;
            // 
            // gridInterpreten
            // 
            this.gridInterpreten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridInterpreten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInterpreten.Location = new System.Drawing.Point(0, 169);
            this.gridInterpreten.Name = "gridInterpreten";
            this.gridInterpreten.Size = new System.Drawing.Size(946, 185);
            this.gridInterpreten.TabIndex = 6;
            // 
            // gridPlatten
            // 
            this.gridPlatten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPlatten.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPlatten.Location = new System.Drawing.Point(0, 410);
            this.gridPlatten.Name = "gridPlatten";
            this.gridPlatten.Size = new System.Drawing.Size(946, 185);
            this.gridPlatten.TabIndex = 7;
            // 
            // pnlSeperation
            // 
            this.pnlSeperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeperation.Controls.Add(this.lblGridPlatten);
            this.pnlSeperation.Location = new System.Drawing.Point(0, 360);
            this.pnlSeperation.Name = "pnlSeperation";
            this.pnlSeperation.Size = new System.Drawing.Size(946, 44);
            this.pnlSeperation.TabIndex = 8;
            // 
            // lblGridInterpreten
            // 
            this.lblGridInterpreten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGridInterpreten.AutoSize = true;
            this.lblGridInterpreten.Location = new System.Drawing.Point(876, 150);
            this.lblGridInterpreten.Name = "lblGridInterpreten";
            this.lblGridInterpreten.Size = new System.Drawing.Size(58, 13);
            this.lblGridInterpreten.TabIndex = 4;
            this.lblGridInterpreten.Text = "Interpreten";
            // 
            // lblGridPlatten
            // 
            this.lblGridPlatten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGridPlatten.AutoSize = true;
            this.lblGridPlatten.Location = new System.Drawing.Point(894, 31);
            this.lblGridPlatten.Name = "lblGridPlatten";
            this.lblGridPlatten.Size = new System.Drawing.Size(40, 13);
            this.lblGridPlatten.TabIndex = 0;
            this.lblGridPlatten.Text = "Platten";
            // 
            // txtPlattenID
            // 
            this.txtPlattenID.Location = new System.Drawing.Point(12, 107);
            this.txtPlattenID.Name = "txtPlattenID";
            this.txtPlattenID.Size = new System.Drawing.Size(36, 20);
            this.txtPlattenID.TabIndex = 5;
            // 
            // txtInterpretenID
            // 
            this.txtInterpretenID.Location = new System.Drawing.Point(405, 44);
            this.txtInterpretenID.Name = "txtInterpretenID";
            this.txtInterpretenID.Size = new System.Drawing.Size(36, 20);
            this.txtInterpretenID.TabIndex = 6;
            // 
            // txtPlattenInterpret
            // 
            this.txtPlattenInterpret.Location = new System.Drawing.Point(54, 107);
            this.txtPlattenInterpret.Name = "txtPlattenInterpret";
            this.txtPlattenInterpret.Size = new System.Drawing.Size(125, 20);
            this.txtPlattenInterpret.TabIndex = 7;
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(185, 107);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(125, 20);
            this.txtTitel.TabIndex = 8;
            // 
            // txtGerne
            // 
            this.txtGerne.Location = new System.Drawing.Point(316, 107);
            this.txtGerne.Name = "txtGerne";
            this.txtGerne.Size = new System.Drawing.Size(125, 20);
            this.txtGerne.TabIndex = 9;
            // 
            // txtErscheinungsdatum
            // 
            this.txtErscheinungsdatum.Location = new System.Drawing.Point(447, 107);
            this.txtErscheinungsdatum.Name = "txtErscheinungsdatum";
            this.txtErscheinungsdatum.Size = new System.Drawing.Size(125, 20);
            this.txtErscheinungsdatum.TabIndex = 10;
            // 
            // txtAnzahlSongs
            // 
            this.txtAnzahlSongs.Location = new System.Drawing.Point(578, 107);
            this.txtAnzahlSongs.Name = "txtAnzahlSongs";
            this.txtAnzahlSongs.Size = new System.Drawing.Size(125, 20);
            this.txtAnzahlSongs.TabIndex = 11;
            // 
            // txtHerkunft
            // 
            this.txtHerkunft.Location = new System.Drawing.Point(578, 44);
            this.txtHerkunft.Name = "txtHerkunft";
            this.txtHerkunft.Size = new System.Drawing.Size(125, 20);
            this.txtHerkunft.TabIndex = 12;
            // 
            // txtInterpret
            // 
            this.txtInterpret.Location = new System.Drawing.Point(447, 44);
            this.txtInterpret.Name = "txtInterpret";
            this.txtInterpret.Size = new System.Drawing.Size(125, 20);
            this.txtInterpret.TabIndex = 13;
            // 
            // btnInterpretHinzufügen
            // 
            this.btnInterpretHinzufügen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInterpretHinzufügen.Location = new System.Drawing.Point(714, 12);
            this.btnInterpretHinzufügen.Name = "btnInterpretHinzufügen";
            this.btnInterpretHinzufügen.Size = new System.Drawing.Size(220, 23);
            this.btnInterpretHinzufügen.TabIndex = 14;
            this.btnInterpretHinzufügen.Text = "Interpret hinzufügen";
            this.btnInterpretHinzufügen.UseVisualStyleBackColor = true;
            // 
            // btnInterpretÄndern
            // 
            this.btnInterpretÄndern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInterpretÄndern.Location = new System.Drawing.Point(714, 43);
            this.btnInterpretÄndern.Name = "btnInterpretÄndern";
            this.btnInterpretÄndern.Size = new System.Drawing.Size(220, 23);
            this.btnInterpretÄndern.TabIndex = 15;
            this.btnInterpretÄndern.Text = "Interpret ändern";
            this.btnInterpretÄndern.UseVisualStyleBackColor = true;
            // 
            // btnPlatteHinzufügen
            // 
            this.btnPlatteHinzufügen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlatteHinzufügen.Location = new System.Drawing.Point(714, 74);
            this.btnPlatteHinzufügen.Name = "btnPlatteHinzufügen";
            this.btnPlatteHinzufügen.Size = new System.Drawing.Size(220, 23);
            this.btnPlatteHinzufügen.TabIndex = 16;
            this.btnPlatteHinzufügen.Text = "Platte hinzufügen";
            this.btnPlatteHinzufügen.UseVisualStyleBackColor = true;
            // 
            // btnPlatteÄndern
            // 
            this.btnPlatteÄndern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlatteÄndern.Location = new System.Drawing.Point(714, 106);
            this.btnPlatteÄndern.Name = "btnPlatteÄndern";
            this.btnPlatteÄndern.Size = new System.Drawing.Size(220, 23);
            this.btnPlatteÄndern.TabIndex = 17;
            this.btnPlatteÄndern.Text = "Platte ändern";
            this.btnPlatteÄndern.UseVisualStyleBackColor = true;
            // 
            // lblInterpretenID
            // 
            this.lblInterpretenID.AutoSize = true;
            this.lblInterpretenID.Location = new System.Drawing.Point(402, 28);
            this.lblInterpretenID.Name = "lblInterpretenID";
            this.lblInterpretenID.Size = new System.Drawing.Size(18, 13);
            this.lblInterpretenID.TabIndex = 18;
            this.lblInterpretenID.Text = "ID";
            // 
            // lblInterpret
            // 
            this.lblInterpret.AutoSize = true;
            this.lblInterpret.Location = new System.Drawing.Point(444, 28);
            this.lblInterpret.Name = "lblInterpret";
            this.lblInterpret.Size = new System.Drawing.Size(46, 13);
            this.lblInterpret.TabIndex = 19;
            this.lblInterpret.Text = "Interpret";
            // 
            // lblHerkunft
            // 
            this.lblHerkunft.AutoSize = true;
            this.lblHerkunft.Location = new System.Drawing.Point(575, 28);
            this.lblHerkunft.Name = "lblHerkunft";
            this.lblHerkunft.Size = new System.Drawing.Size(48, 13);
            this.lblHerkunft.TabIndex = 20;
            this.lblHerkunft.Text = "Herkunft";
            // 
            // lblPlattenID
            // 
            this.lblPlattenID.AutoSize = true;
            this.lblPlattenID.Location = new System.Drawing.Point(9, 91);
            this.lblPlattenID.Name = "lblPlattenID";
            this.lblPlattenID.Size = new System.Drawing.Size(18, 13);
            this.lblPlattenID.TabIndex = 21;
            this.lblPlattenID.Text = "ID";
            // 
            // lblPlattenInterpret
            // 
            this.lblPlattenInterpret.AutoSize = true;
            this.lblPlattenInterpret.Location = new System.Drawing.Point(51, 91);
            this.lblPlattenInterpret.Name = "lblPlattenInterpret";
            this.lblPlattenInterpret.Size = new System.Drawing.Size(46, 13);
            this.lblPlattenInterpret.TabIndex = 22;
            this.lblPlattenInterpret.Text = "Interpret";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(182, 91);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(27, 13);
            this.lblTitel.TabIndex = 23;
            this.lblTitel.Text = "Titel";
            // 
            // lblGerne
            // 
            this.lblGerne.AutoSize = true;
            this.lblGerne.Location = new System.Drawing.Point(313, 91);
            this.lblGerne.Name = "lblGerne";
            this.lblGerne.Size = new System.Drawing.Size(36, 13);
            this.lblGerne.TabIndex = 24;
            this.lblGerne.Text = "Gerne";
            // 
            // lblErscheinungsdatum
            // 
            this.lblErscheinungsdatum.AutoSize = true;
            this.lblErscheinungsdatum.Location = new System.Drawing.Point(444, 91);
            this.lblErscheinungsdatum.Name = "lblErscheinungsdatum";
            this.lblErscheinungsdatum.Size = new System.Drawing.Size(100, 13);
            this.lblErscheinungsdatum.TabIndex = 25;
            this.lblErscheinungsdatum.Text = "Erscheinungsdatum";
            // 
            // lblAnzahlSongs
            // 
            this.lblAnzahlSongs.AutoSize = true;
            this.lblAnzahlSongs.Location = new System.Drawing.Point(575, 91);
            this.lblAnzahlSongs.Name = "lblAnzahlSongs";
            this.lblAnzahlSongs.Size = new System.Drawing.Size(72, 13);
            this.lblAnzahlSongs.TabIndex = 26;
            this.lblAnzahlSongs.Text = "Anzahl Songs";
            // 
            // btnAllePlatten
            // 
            this.btnAllePlatten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllePlatten.Location = new System.Drawing.Point(12, 12);
            this.btnAllePlatten.Name = "btnAllePlatten";
            this.btnAllePlatten.Size = new System.Drawing.Size(85, 44);
            this.btnAllePlatten.TabIndex = 27;
            this.btnAllePlatten.Text = "Alle Platten anzeigen";
            this.btnAllePlatten.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 595);
            this.Controls.Add(this.pnlSeperation);
            this.Controls.Add(this.gridPlatten);
            this.Controls.Add(this.gridInterpreten);
            this.Controls.Add(this.pnlControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInterpreten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlatten)).EndInit();
            this.pnlSeperation.ResumeLayout(false);
            this.pnlSeperation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblGridInterpreten;
        private System.Windows.Forms.DataGridView gridInterpreten;
        private System.Windows.Forms.DataGridView gridPlatten;
        private System.Windows.Forms.Panel pnlSeperation;
        private System.Windows.Forms.Label lblGridPlatten;
        private System.Windows.Forms.Label lblAnzahlSongs;
        private System.Windows.Forms.Label lblErscheinungsdatum;
        private System.Windows.Forms.Label lblGerne;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblPlattenInterpret;
        private System.Windows.Forms.Label lblPlattenID;
        private System.Windows.Forms.Label lblHerkunft;
        private System.Windows.Forms.Label lblInterpret;
        private System.Windows.Forms.Label lblInterpretenID;
        private System.Windows.Forms.Button btnPlatteÄndern;
        private System.Windows.Forms.Button btnPlatteHinzufügen;
        private System.Windows.Forms.Button btnInterpretÄndern;
        private System.Windows.Forms.Button btnInterpretHinzufügen;
        private System.Windows.Forms.TextBox txtInterpret;
        private System.Windows.Forms.TextBox txtHerkunft;
        private System.Windows.Forms.TextBox txtAnzahlSongs;
        private System.Windows.Forms.TextBox txtErscheinungsdatum;
        private System.Windows.Forms.TextBox txtGerne;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.TextBox txtPlattenInterpret;
        private System.Windows.Forms.TextBox txtInterpretenID;
        private System.Windows.Forms.TextBox txtPlattenID;
        private System.Windows.Forms.Button btnAllePlatten;
    }
}

