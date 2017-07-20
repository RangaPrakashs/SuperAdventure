using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace GameTest
{
    public partial class Form1 : Form
    {
        private Player _player;
        public Form1()
        {
            InitializeComponent();
            _player = new Player(10, 10, 20, 0, 1);
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;

            lblHp.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExp.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        public void MoveTo(Location newLocation)
        {
            //Does this Have any Required Items?

        if(newLocation.itemRequiredToEnter!=null)
            {
                //See if the Player Has the Required Item in their Inventory
                bool playerHasRequiredItem = false;

                foreach(InventoryItem ii in _player.Inventory)
                {
                    if(ii.Details.ID==newLocation.itemRequiredToEnter.ID)
                    {
                        // We Found the Required Item
                        playerHasRequiredItem = true;
                        break;
                    }
                }
                if(!playerHasRequiredItem)
                {
                    //We Didn't find the Required Item in their Inventory, So display the Message and Stop Moving!

                    rtbMessages.Text += "You must have a " + newLocation.itemRequiredToEnter.Name + " to enter this location." + Environment.NewLine;
                }
            }

            // Update the Player's Current Location.
            _player.CurrentLocation = newLocation;

            //Show//Hide available Movements Buttons

            btnNorth.Visible = (newLocation.LocationToNorth != null);
            btnEast.Visible = (newLocation.LocationToEast != null);
            btnWest.Visible = (newLocation.LocationToWest != null);
            btnSouth.Visible = (newLocation.LocationToSouth != null);

            //Display the Current Location

            rtbLocation.Text = newLocation.Name + Environment.NewLine;
            rtbMessages.Text += newLocation.Description + Environment.NewLine;

            //Completely heal the Player!
            _player.CurrentHitPoints = _player.MaximumHitPoints;

            //Update Hit Points in the UI
            lblHp.Text = _player.CurrentHitPoints.ToString();

            //Does the Location have a Quest?

            if(newLocation.QuestAvailableHere!= null)
            {
                //See if the player aread has the quest, and if they've completed it!

                bool PlayerAlreadyHasTheQuest = false;
                bool PlayerAlreadyCompletedQuest = false;

                foreach (PlayerQuest playerQuest in _player.Quests)
                {
                    if(playerQuest.Details.ID ==newLocation.QuestAvailableHere.ID)
                    {
                        PlayerAlreadyHasTheQuest = true;
                        if(playerQuest.IsCompleted)
                        {
                            PlayerAlreadyCompletedQuest = true;
                        }
                    }
                }

                //See if the Player already has the Quest
                
            }

        }

    }
      
    
}
