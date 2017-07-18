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

        
    }
      
    
}
