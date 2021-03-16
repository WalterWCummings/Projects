using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Restart : Form
    {
        public Restart()
        {
            InitializeComponent();
        }

        private void Restart_Load(object sender, EventArgs e)
        {
            this.StartNewGame();
        }
        private void GameForm_FormCloses(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Continue?", "Continue?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Console.ReadKey();
                this.StartNewGame();
            }            
        }
        private void StartNewGame()
        {
            var gameForm = new Restart();
            gameForm.FormClosed += GameForm_FormCloses;
            gameForm.Show();

        }
    }
}
