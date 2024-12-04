namespace A3
{
    partial class AddPlayer
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
            btnSave = new Button();
            lblName = new Label();
            lblTeam = new Label();
            lblPosition = new Label();
            lblRating = new Label();
            lblAssists = new Label();
            lblPointsPerGame = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnImage = new Button();
            txtName = new TextBox();
            txtTeam = new TextBox();
            txtPosition = new TextBox();
            txtRating = new TextBox();
            txtAssists = new TextBox();
            txtPointsPerGame = new TextBox();
            picPlayerImage = new PictureBox();
            btnCancel = new Button();
            btnSelectColor = new Button();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)picPlayerImage).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(43, 373);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 60);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(56, 64);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(56, 106);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(35, 15);
            lblTeam.TabIndex = 2;
            lblTeam.Text = "Team";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(56, 145);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(50, 15);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(313, 68);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(41, 15);
            lblRating.TabIndex = 4;
            lblRating.Text = "Rating";
            // 
            // lblAssists
            // 
            lblAssists.AutoSize = true;
            lblAssists.Location = new Point(313, 106);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(42, 15);
            lblAssists.TabIndex = 5;
            lblAssists.Text = "Assists";
            // 
            // lblPointsPerGame
            // 
            lblPointsPerGame.AutoSize = true;
            lblPointsPerGame.Location = new Point(313, 145);
            lblPointsPerGame.Name = "lblPointsPerGame";
            lblPointsPerGame.Size = new Size(94, 15);
            lblPointsPerGame.TabIndex = 6;
            lblPointsPerGame.Text = "Points Per Game";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(89, 290);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(129, 60);
            btnImage.TabIndex = 8;
            btnImage.Text = "Select an Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 9;
            // 
            // txtTeam
            // 
            txtTeam.Location = new Point(135, 93);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(100, 23);
            txtTeam.TabIndex = 10;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(135, 145);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(100, 23);
            txtPosition.TabIndex = 11;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(449, 52);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(100, 23);
            txtRating.TabIndex = 12;
            // 
            // txtAssists
            // 
            txtAssists.Location = new Point(449, 93);
            txtAssists.Name = "txtAssists";
            txtAssists.Size = new Size(100, 23);
            txtAssists.TabIndex = 13;
            // 
            // txtPointsPerGame
            // 
            txtPointsPerGame.Location = new Point(449, 145);
            txtPointsPerGame.Name = "txtPointsPerGame";
            txtPointsPerGame.Size = new Size(100, 23);
            txtPointsPerGame.TabIndex = 14;
            // 
            // picPlayerImage
            // 
            picPlayerImage.Location = new Point(313, 204);
            picPlayerImage.Name = "picPlayerImage";
            picPlayerImage.Size = new Size(256, 267);
            picPlayerImage.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayerImage.TabIndex = 15;
            picPlayerImage.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(174, 373);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 60);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSelectColor
            // 
            btnSelectColor.Location = new Point(89, 204);
            btnSelectColor.Name = "btnSelectColor";
            btnSelectColor.Size = new Size(129, 60);
            btnSelectColor.TabIndex = 18;
            btnSelectColor.Text = "Select  a team color";
            btnSelectColor.UseVisualStyleBackColor = true;
            btnSelectColor.Click += btnSelectColor_Click;
            // 
            // AddPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 497);
            Controls.Add(btnSelectColor);
            Controls.Add(btnCancel);
            Controls.Add(picPlayerImage);
            Controls.Add(txtPointsPerGame);
            Controls.Add(txtAssists);
            Controls.Add(txtRating);
            Controls.Add(txtPosition);
            Controls.Add(txtTeam);
            Controls.Add(txtName);
            Controls.Add(btnImage);
            Controls.Add(lblPointsPerGame);
            Controls.Add(lblAssists);
            Controls.Add(lblRating);
            Controls.Add(lblPosition);
            Controls.Add(lblTeam);
            Controls.Add(lblName);
            Controls.Add(btnSave);
            Name = "AddPlayer";
            Text = "AddPlayer";
            ((System.ComponentModel.ISupportInitialize)picPlayerImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblName;
        private Label lblTeam;
        private Label lblPosition;
        private Label lblRating;
        private Label lblAssists;
        private Label lblPointsPerGame;
        private OpenFileDialog openFileDialog1;
        private Button btnImage;
        private TextBox txtName;
        private TextBox txtTeam;
        private TextBox txtPosition;
        private TextBox txtRating;
        private TextBox txtAssists;
        private TextBox txtPointsPerGame;
        private PictureBox picPlayerImage;
        private Button btnCancel;
        private Button btnSelectColor;
        private ColorDialog colorDialog1;
    }
}