using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Numerics;

namespace A3
{
    public partial class Form1 : Form
    {
        private Players playerList;
        private Player selectedPlayer;
        private Color selectedTeamColor = Color.LightGray; // Default color for new teams

        public Form1()
        {
            InitializeComponent();
            playerList = new Players(); // Initialize the player list
            UpdatePlayerList();
            ApplyStyling();

            // Default Panel styling
            pnlCard.BackColor = Color.LightGray;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
        }

        // Method to update the player list in the ListBox
        private void UpdatePlayerList()
        {
            lstPlayerNames.Items.Clear();

            foreach (var player in playerList.player)
            {
                lstPlayerNames.Items.Add(player.Name);
            }
        }

        // Event handler for Adding new player
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPlayer addPlayerForm = new AddPlayer(playerList);  // Pass playerList to AddPlayer Form
            addPlayerForm.ShowDialog();
            UpdatePlayerList();

        }

        // Event handler for Updating a player details
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPlayer == null)
            {
                MessageBox.Show("Please select a player to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddPlayer addPlayerForm = new AddPlayer(playerList, selectedPlayer);  // Pass playerList and selectedPlayer to the AddPlayer Form
            addPlayerForm.ShowDialog();
            UpdatePlayerList();
        }

        // Event handler for Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPlayer == null)
            {
                MessageBox.Show("Please select a player to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this player?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                playerList.player.Remove(selectedPlayer);
                UpdatePlayerList();
                ClearCardView();
            }
        }

        // Event handler for selecting a player from the list
        private void lstPlayerNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayerNames.SelectedIndex >= 0)
            {
                selectedPlayer = playerList.player[lstPlayerNames.SelectedIndex];
                UpdatePlayerCard();
            }
        }

        private Dictionary<string, Color> teamColors = new Dictionary<string, Color>
        {
            { "Paris Saint-Germain", Color.LightCoral },
            { "Manchester United", Color.LightBlue },
            { "Liverpool", Color.LightGreen },
            { "Manchester City", Color.LightCyan },
            { "Real Madrid", Color.White },
            { "Bayern Munich", Color.LightSalmon }
        };


        // Method to update the player card
        public void UpdatePlayerCard()
        {
            if (selectedPlayer == null) return;

            // Add titles with player data to the labels
            lblPlayerName.Text = "Name: " + selectedPlayer.Name;
            lblPlayerTeam.Text = "Team: " + selectedPlayer.Team;
            lblPlayerPosition.Text = "Position: " + selectedPlayer.Position;
            lblPlayerRating.Text = "Rating: " + selectedPlayer.Rating.ToString();
            lblPlayerAssists.Text = "Assists: " + selectedPlayer.Assists.ToString();
            lblPointsPerGame.Text = "Points per Game: " + selectedPlayer.PointsPerGame.ToString();

            // Check if the image path is correct
            if (string.IsNullOrEmpty(selectedPlayer.Photo) || !System.IO.File.Exists(selectedPlayer.Photo))
            {
                MessageBox.Show("Player photo is missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                picPlayerCard.ImageLocation = selectedPlayer.Photo;
            }

            // Apply the selected team color
            pnlCard.BackColor = selectedPlayer.TeamColor != default ? selectedPlayer.TeamColor : Color.LightGray;
            pnlCard.ForeColor = Color.Black;
        }

        // Helper method to style the application
        private void ApplyStyling()
        {
            lstPlayerNames.BackColor = Color.WhiteSmoke;
            lstPlayerNames.Font = new Font("Arial", 10);
            lstPlayerNames.ForeColor = Color.Black;

            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Arial", 10, FontStyle.Regular);

            btnUpdate.BackColor = Color.MediumOrchid;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Font = new Font("Arial", 10, FontStyle.Regular);

            btnDelete.BackColor = Color.IndianRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Arial", 10, FontStyle.Regular);

            // Style Labels
            lblPlayerName.Font = new Font("Arial", 12, FontStyle.Regular);
            lblPlayerTeam.Font = new Font("Arial", 12);
            lblPlayerPosition.Font = new Font("Arial", 12);
            lblPlayerRating.Font = new Font("Arial", 12);
            lblPlayerAssists.Font = new Font("Arial", 12);
            lblPointsPerGame.Font = new Font("Arial", 12);

        }

        private void ClearCardView()
        {
            lblPlayerName.Text = "";
            lblPlayerTeam.Text = "";
            lblPlayerPosition.Text = "";
            lblPlayerRating.Text = "";
            lblPlayerAssists.Text = "";
            lblPointsPerGame.Text = "";
            picPlayerCard.Image = null;
            pnlCard.BackColor = Color.LightGray; // Default color
        }
    }
}
