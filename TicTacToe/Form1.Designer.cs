
namespace TicTacToe
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Pwin = new System.Windows.Forms.Label();
            this.Cwin = new System.Windows.Forms.Label();
            this.NorthWest = new System.Windows.Forms.Button();
            this.North = new System.Windows.Forms.Button();
            this.NorthEast = new System.Windows.Forms.Button();
            this.West = new System.Windows.Forms.Button();
            this.Center = new System.Windows.Forms.Button();
            this.East = new System.Windows.Forms.Button();
            this.SouthWest = new System.Windows.Forms.Button();
            this.South = new System.Windows.Forms.Button();
            this.SouthEast = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.CPUmoves = new System.Windows.Forms.Timer(this.components);
            this.Dwin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pwin
            // 
            this.Pwin.AutoSize = true;
            this.Pwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pwin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Pwin.Location = new System.Drawing.Point(60, 44);
            this.Pwin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Pwin.Name = "Pwin";
            this.Pwin.Size = new System.Drawing.Size(176, 25);
            this.Pwin.TabIndex = 0;
            this.Pwin.Text = "Player Win(s) - 0";
            this.Pwin.Click += new System.EventHandler(this.Pwin_Click);
            // 
            // Cwin
            // 
            this.Cwin.AutoSize = true;
            this.Cwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cwin.ForeColor = System.Drawing.Color.Red;
            this.Cwin.Location = new System.Drawing.Point(448, 44);
            this.Cwin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Cwin.Name = "Cwin";
            this.Cwin.Size = new System.Drawing.Size(160, 25);
            this.Cwin.TabIndex = 2;
            this.Cwin.Text = "CPU Win(s) - 0";
            // 
            // NorthWest
            // 
            this.NorthWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthWest.Location = new System.Drawing.Point(65, 89);
            this.NorthWest.Name = "NorthWest";
            this.NorthWest.Size = new System.Drawing.Size(177, 160);
            this.NorthWest.TabIndex = 3;
            this.NorthWest.Tag = "play";
            this.NorthWest.Text = "-";
            this.NorthWest.UseVisualStyleBackColor = true;
            this.NorthWest.Click += new System.EventHandler(this.PClick);
            // 
            // North
            // 
            this.North.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.North.Location = new System.Drawing.Point(248, 89);
            this.North.Name = "North";
            this.North.Size = new System.Drawing.Size(177, 160);
            this.North.TabIndex = 4;
            this.North.Tag = "play";
            this.North.Text = "-";
            this.North.UseVisualStyleBackColor = true;
            this.North.Click += new System.EventHandler(this.PClick);
            // 
            // NorthEast
            // 
            this.NorthEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NorthEast.Location = new System.Drawing.Point(431, 89);
            this.NorthEast.Name = "NorthEast";
            this.NorthEast.Size = new System.Drawing.Size(177, 160);
            this.NorthEast.TabIndex = 5;
            this.NorthEast.Tag = "play";
            this.NorthEast.Text = "-";
            this.NorthEast.UseVisualStyleBackColor = true;
            this.NorthEast.Click += new System.EventHandler(this.PClick);
            // 
            // West
            // 
            this.West.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.West.Location = new System.Drawing.Point(65, 255);
            this.West.Name = "West";
            this.West.Size = new System.Drawing.Size(177, 160);
            this.West.TabIndex = 6;
            this.West.Tag = "play";
            this.West.Text = "-";
            this.West.UseVisualStyleBackColor = true;
            this.West.Click += new System.EventHandler(this.PClick);
            // 
            // Center
            // 
            this.Center.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Center.Location = new System.Drawing.Point(248, 255);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(177, 160);
            this.Center.TabIndex = 7;
            this.Center.Tag = "play";
            this.Center.Text = "-";
            this.Center.UseVisualStyleBackColor = true;
            this.Center.Click += new System.EventHandler(this.PClick);
            // 
            // East
            // 
            this.East.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.East.Location = new System.Drawing.Point(431, 255);
            this.East.Name = "East";
            this.East.Size = new System.Drawing.Size(177, 160);
            this.East.TabIndex = 8;
            this.East.Tag = "play";
            this.East.Text = "-";
            this.East.UseVisualStyleBackColor = true;
            this.East.Click += new System.EventHandler(this.PClick);
            // 
            // SouthWest
            // 
            this.SouthWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthWest.Location = new System.Drawing.Point(65, 421);
            this.SouthWest.Name = "SouthWest";
            this.SouthWest.Size = new System.Drawing.Size(177, 160);
            this.SouthWest.TabIndex = 9;
            this.SouthWest.Tag = "play";
            this.SouthWest.Text = "-";
            this.SouthWest.UseVisualStyleBackColor = true;
            this.SouthWest.Click += new System.EventHandler(this.PClick);
            // 
            // South
            // 
            this.South.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.South.Location = new System.Drawing.Point(248, 421);
            this.South.Name = "South";
            this.South.Size = new System.Drawing.Size(177, 160);
            this.South.TabIndex = 10;
            this.South.Tag = "play";
            this.South.Text = "-";
            this.South.UseVisualStyleBackColor = true;
            this.South.Click += new System.EventHandler(this.PClick);
            // 
            // SouthEast
            // 
            this.SouthEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SouthEast.Location = new System.Drawing.Point(431, 421);
            this.SouthEast.Name = "SouthEast";
            this.SouthEast.Size = new System.Drawing.Size(177, 160);
            this.SouthEast.TabIndex = 11;
            this.SouthEast.Tag = "play";
            this.SouthEast.Text = "-";
            this.SouthEast.UseVisualStyleBackColor = true;
            this.SouthEast.Click += new System.EventHandler(this.PClick);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Reset.Location = new System.Drawing.Point(12, 635);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(106, 34);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.RestartGame);
            // 
            // CPUmoves
            // 
            this.CPUmoves.Tick += new System.EventHandler(this.CPUmove);
            // 
            // Dwin
            // 
            this.Dwin.AutoSize = true;
            this.Dwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dwin.ForeColor = System.Drawing.Color.Yellow;
            this.Dwin.Location = new System.Drawing.Point(276, 44);
            this.Dwin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Dwin.Name = "Dwin";
            this.Dwin.Size = new System.Drawing.Size(120, 25);
            this.Dwin.TabIndex = 13;
            this.Dwin.Text = "Draw(s) - 0";
            this.Dwin.Click += new System.EventHandler(this.Dwin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(674, 681);
            this.Controls.Add(this.Dwin);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.SouthEast);
            this.Controls.Add(this.South);
            this.Controls.Add(this.SouthWest);
            this.Controls.Add(this.East);
            this.Controls.Add(this.Center);
            this.Controls.Add(this.West);
            this.Controls.Add(this.NorthEast);
            this.Controls.Add(this.North);
            this.Controls.Add(this.NorthWest);
            this.Controls.Add(this.Cwin);
            this.Controls.Add(this.Pwin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pwin;
        private System.Windows.Forms.Label Cwin;
        private System.Windows.Forms.Button NorthWest;
        private System.Windows.Forms.Button North;
        private System.Windows.Forms.Button NorthEast;
        private System.Windows.Forms.Button West;
        private System.Windows.Forms.Button Center;
        private System.Windows.Forms.Button East;
        private System.Windows.Forms.Button SouthWest;
        private System.Windows.Forms.Button South;
        private System.Windows.Forms.Button SouthEast;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer CPUmoves;
        private System.Windows.Forms.Label Dwin;
    }
}

