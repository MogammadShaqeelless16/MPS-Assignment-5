namespace Hangman
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AnimalCategoryTile = new MetroFramework.Controls.MetroTile();
            this.FoodCategoryTile = new MetroFramework.Controls.MetroTile();
            this.SportsCategoryTile = new MetroFramework.Controls.MetroTile();
            this.PoliticsCategoryTile = new MetroFramework.Controls.MetroTile();
            this.CountriesCategoryTile = new MetroFramework.Controls.MetroTile();
            this.TechnologyCategoryTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // AnimalCategoryTile
            // 
            this.AnimalCategoryTile.Location = new System.Drawing.Point(23, 63);
            this.AnimalCategoryTile.Name = "AnimalCategoryTile";
            this.AnimalCategoryTile.Size = new System.Drawing.Size(144, 69);
            this.AnimalCategoryTile.TabIndex = 0;
            this.AnimalCategoryTile.Text = "ANIMALS";
            this.AnimalCategoryTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AnimalCategoryTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AnimalCategoryTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AnimalCategoryTile.Click += new System.EventHandler(this.AnimalCategoryTile_Click);
            // 
            // FoodCategoryTile
            // 
            this.FoodCategoryTile.Location = new System.Drawing.Point(23, 138);
            this.FoodCategoryTile.Name = "FoodCategoryTile";
            this.FoodCategoryTile.Size = new System.Drawing.Size(144, 69);
            this.FoodCategoryTile.TabIndex = 1;
            this.FoodCategoryTile.Text = "FOOD";
            this.FoodCategoryTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FoodCategoryTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FoodCategoryTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.FoodCategoryTile.Click += new System.EventHandler(this.FoodCategoryTile_Click);
            // 
            // SportsCategoryTile
            // 
            this.SportsCategoryTile.Location = new System.Drawing.Point(23, 213);
            this.SportsCategoryTile.Name = "SportsCategoryTile";
            this.SportsCategoryTile.Size = new System.Drawing.Size(144, 69);
            this.SportsCategoryTile.TabIndex = 2;
            this.SportsCategoryTile.Text = "SPORTS";
            this.SportsCategoryTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SportsCategoryTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SportsCategoryTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SportsCategoryTile.Click += new System.EventHandler(this.SportsCategoryTile_Click);
            // 
            // PoliticsCategoryTile
            // 
            this.PoliticsCategoryTile.Location = new System.Drawing.Point(173, 63);
            this.PoliticsCategoryTile.Name = "PoliticsCategoryTile";
            this.PoliticsCategoryTile.Size = new System.Drawing.Size(144, 69);
            this.PoliticsCategoryTile.TabIndex = 3;
            this.PoliticsCategoryTile.Text = "POLITICS";
            this.PoliticsCategoryTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PoliticsCategoryTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PoliticsCategoryTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.PoliticsCategoryTile.Click += new System.EventHandler(this.PoliticsCategoryTile_Click);
            // 
            // CountriesCategoryTile
            // 
            this.CountriesCategoryTile.Location = new System.Drawing.Point(173, 138);
            this.CountriesCategoryTile.Name = "CountriesCategoryTile";
            this.CountriesCategoryTile.Size = new System.Drawing.Size(144, 69);
            this.CountriesCategoryTile.TabIndex = 4;
            this.CountriesCategoryTile.Text = "COUNTRIES";
            this.CountriesCategoryTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountriesCategoryTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CountriesCategoryTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CountriesCategoryTile.Click += new System.EventHandler(this.CountriesCategoryTile_Click);
            // 
            // TechnologyCategoryTile
            // 
            this.TechnologyCategoryTile.Location = new System.Drawing.Point(173, 213);
            this.TechnologyCategoryTile.Name = "TechnologyCategoryTile";
            this.TechnologyCategoryTile.Size = new System.Drawing.Size(144, 69);
            this.TechnologyCategoryTile.TabIndex = 5;
            this.TechnologyCategoryTile.Text = "TECHNOLOGY";
            this.TechnologyCategoryTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TechnologyCategoryTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TechnologyCategoryTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TechnologyCategoryTile.Click += new System.EventHandler(this.TechnologyCategoryTile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 322);
            this.Controls.Add(this.TechnologyCategoryTile);
            this.Controls.Add(this.CountriesCategoryTile);
            this.Controls.Add(this.PoliticsCategoryTile);
            this.Controls.Add(this.SportsCategoryTile);
            this.Controls.Add(this.FoodCategoryTile);
            this.Controls.Add(this.AnimalCategoryTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile AnimalCategoryTile;
        private MetroFramework.Controls.MetroTile FoodCategoryTile;
        private MetroFramework.Controls.MetroTile SportsCategoryTile;
        private MetroFramework.Controls.MetroTile PoliticsCategoryTile;
        private MetroFramework.Controls.MetroTile CountriesCategoryTile;
        private MetroFramework.Controls.MetroTile TechnologyCategoryTile;
    }
}