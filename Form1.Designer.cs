namespace A3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstPlayerNames = new ListBox();
            pnlCard = new Panel();
            label1 = new Label();
            picPlayerCard = new PictureBox();
            lblPointsPerGame = new Label();
            lblPlayerAssists = new Label();
            lblPlayerRating = new Label();
            lblPlayerPosition = new Label();
            lblPlayerName = new Label();
            lblPlayerTeam = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayerCard).BeginInit();
            SuspendLayout();
            // 
            // lstPlayerNames
            // 
            lstPlayerNames.FormattingEnabled = true;
            lstPlayerNames.ItemHeight = 15;
            lstPlayerNames.Location = new Point(45, 38);
            lstPlayerNames.Name = "lstPlayerNames";
            lstPlayerNames.Size = new Size(197, 229);
            lstPlayerNames.TabIndex = 0;
            lstPlayerNames.SelectedIndexChanged += lstPlayerNames_SelectedIndexChanged;
            // 
            // pnlCard
            // 
            pnlCard.Controls.Add(label1);
            pnlCard.Controls.Add(picPlayerCard);
            pnlCard.Controls.Add(lblPointsPerGame);
            pnlCard.Controls.Add(lblPlayerAssists);
            pnlCard.Controls.Add(lblPlayerRating);
            pnlCard.Controls.Add(lblPlayerPosition);
            pnlCard.Controls.Add(lblPlayerName);
            pnlCard.Controls.Add(lblPlayerTeam);
            pnlCard.Location = new Point(300, 38);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(448, 502);
            pnlCard.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 6);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 9;
            label1.Text = "Player Card";
            // 
            // picPlayerCard
            // 
            picPlayerCard.Location = new Point(81, 167);
            picPlayerCard.Name = "picPlayerCard";
            picPlayerCard.Size = new Size(288, 321);
            picPlayerCard.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayerCard.TabIndex = 4;
            picPlayerCard.TabStop = false;
            // 
            // lblPointsPerGame
            // 
            lblPointsPerGame.AutoSize = true;
            lblPointsPerGame.Location = new Point(277, 119);
            lblPointsPerGame.Name = "lblPointsPerGame";
            lblPointsPerGame.Size = new Size(0, 15);
            lblPointsPerGame.TabIndex = 8;
            // 
            // lblPlayerAssists
            // 
            lblPlayerAssists.AutoSize = true;
            lblPlayerAssists.Location = new Point(277, 89);
            lblPlayerAssists.Name = "lblPlayerAssists";
            lblPlayerAssists.Size = new Size(0, 15);
            lblPlayerAssists.TabIndex = 7;
            // 
            // lblPlayerRating
            // 
            lblPlayerRating.AutoSize = true;
            lblPlayerRating.Location = new Point(277, 59);
            lblPlayerRating.Name = "lblPlayerRating";
            lblPlayerRating.Size = new Size(0, 15);
            lblPlayerRating.TabIndex = 6;
            // 
            // lblPlayerPosition
            // 
            lblPlayerPosition.AutoSize = true;
            lblPlayerPosition.Location = new Point(57, 119);
            lblPlayerPosition.Name = "lblPlayerPosition";
            lblPlayerPosition.Size = new Size(0, 15);
            lblPlayerPosition.TabIndex = 5;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(57, 59);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(0, 15);
            lblPlayerName.TabIndex = 2;
            // 
            // lblPlayerTeam
            // 
            lblPlayerTeam.AutoSize = true;
            lblPlayerTeam.Location = new Point(57, 89);
            lblPlayerTeam.Name = "lblPlayerTeam";
            lblPlayerTeam.Size = new Size(0, 15);
            lblPlayerTeam.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(93, 312);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 48);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 391);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 48);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(93, 466);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 48);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 596);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lstPlayerNames);
            Controls.Add(pnlCard);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayerCard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPlayerNames;
        private Panel pnlCard;
        private Label lblPlayerName;
        private Label lblPlayerTeam;
        private PictureBox picPlayerCard;
        private Label lblPointsPerGame;
        private Label lblPlayerAssists;
        private Label lblPlayerRating;
        private Label lblPlayerPosition;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
    }
}
