using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    class GarageSystem
    {
        public GarageSystem()
        {
            ShowWelcomeScreen();
            ShowMenueScreen();
        }

        private void ShowWelcomeScreen()
        {
            GarageSystemView.ShowWelcomeScreen();
        }

        private void ShowMenueScreen()
        {
            GarageSystemView.ShowMenueScreen();
        }
        
    }
}
