using System;
using System.Windows.Forms;
using System.Drawing;

namespace A3
{
    public partial class AddPlayer : Form
    {
        public Player selectedPlayer;
        private Players playerList;
        private Color selectedTeamColor = Color.LightGray;  // Default color for new teams
        private Dictionary<string, Color> teamColors = new Dictionary<string, Color>
    {
        { "Paris Saint-Germain", Color.LightCoral },
        { "Manchester United", Color.LightBlue },
        { "Liverpool", Color.LightGreen },
        { "Manchester City", Color.LightCyan },
        { "Real Madrid", Color.White },
        { "Bayern Munich", Color.LightSalmon }
    };

        public AddPlayer(Players players, Player player = null)
        {
            InitializeComponent();
            playerList = players;
            selectedPlayer = player;
            ApplyStyling();

            if (selectedPlayer != null)
            {
                // Populate fields with selected player's data if available (for update)
                txtName.Text = selectedPlayer.Name;
                txtTeam.Text = selectedPlayer.Team;
                txtPosition.Text = selectedPlayer.Position;
                txtRating.Text = selectedPlayer.Rating.ToString();
                txtAssists.Text = selectedPlayer.Assists.ToString();
                txtPointsPerGame.Text = selectedPlayer.PointsPerGame.ToString();
                picPlayerImage.ImageLocation = selectedPlayer.Photo;
                btnSave.Text = "Update"; // Change button text for update

                // Set the team color
                selectedTeamColor = teamColors.ContainsKey(selectedPlayer.Team) ? teamColors[selectedPlayer.Team] : selectedTeamColor;
            }
        }

        // Event handler for the Image button to select the player's image
        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picPlayerImage.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        // Event handler for the Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the Add/Update button
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation: Check if all fields are filled
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtTeam.Text) ||
                string.IsNullOrEmpty(txtPosition.Text) ||
                string.IsNullOrEmpty(txtRating.Text) ||
                string.IsNullOrEmpty(txtAssists.Text) ||
                string.IsNullOrEmpty(txtPointsPerGame.Text) ||
                picPlayerImage.Image == null)
            {
                MessageBox.Show("Please fill all the fields and select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!double.TryParse(txtRating.Text, out double rating) ||
                !int.TryParse(txtAssists.Text, out int assists) ||
                !double.TryParse(txtPointsPerGame.Text, out double pointsPerGame))
            {
                MessageBox.Show("Please enter valid values for rating, assists, and points per game.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color teamColor;

            if (teamColors.ContainsKey(txtTeam.Text))
            {
                teamColor = teamColors[txtTeam.Text]; // Use the pre-existing color for the team
            }
            else
            {
                teamColor = selectedTeamColor;  // Use the color chosen by the user if it's a new team
            }

            // Create a new player object
            Player newPlayer = new Player
            {
                Name = txtName.Text,
                Team = txtTeam.Text,
                Position = txtPosition.Text,
                Rating = rating,
                Assists = assists,
                PointsPerGame = pointsPerGame,
                Photo = picPlayerImage.ImageLocation,
                TeamColor = teamColor  // Assign the team color to the player
            };

            if (selectedPlayer == null)
            {
                // Add the new player to the list
                playerList.player.Add(newPlayer);
                MessageBox.Show("Player added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Update the existing player
                selectedPlayer.Name = newPlayer.Name;
                selectedPlayer.Team = newPlayer.Team;
                selectedPlayer.Position = newPlayer.Position;
                selectedPlayer.Rating = newPlayer.Rating;
                selectedPlayer.Assists = newPlayer.Assists;
                selectedPlayer.PointsPerGame = newPlayer.PointsPerGame;
                selectedPlayer.Photo = newPlayer.Photo;
                selectedPlayer.TeamColor = newPlayer.TeamColor;  // Update the team color
                MessageBox.Show("Player updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            this.Close(); // Close the form after adding/updating the player
        }

        // Event handler for selecting a color
        public void btnSelectColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedTeamColor = colorDialog.Color;
                }
            }
        }

        private void ApplyStyling()
        {
            // Helper method for styling

            txtName.BackColor = Color.WhiteSmoke;
            txtName.Font = new Font("Arial", 10);
            txtTeam.BackColor = Color.WhiteSmoke;
            txtTeam.Font = new Font("Arial", 10);
            txtPosition.BackColor = Color.WhiteSmoke;
            txtPosition.Font = new Font("Arial", 10);
            txtRating.BackColor = Color.WhiteSmoke;
            txtRating.Font = new Font("Arial", 10);
            txtAssists.BackColor = Color.WhiteSmoke;
            txtAssists.Font = new Font("Arial", 10);
            txtPointsPerGame.BackColor = Color.WhiteSmoke;
            txtPointsPerGame.Font = new Font("Arial", 10);

            // Style Buttons
            btnSave.BackColor = Color.MediumSeaGreen;
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Arial", 10, FontStyle.Bold);

            btnCancel.BackColor = Color.IndianRed;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Arial", 10, FontStyle.Bold);

            // Style PictureBox
            picPlayerImage.BorderStyle = BorderStyle.FixedSingle;
        }
    }

}
