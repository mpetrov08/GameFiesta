using GameFiesta.Managers.Contracts;
using GameFiesta.StartScreen.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFiesta.Managers
{
    public class StartUpScreen
    {
        private User user;
        private IManager headerManager;
        private IManager setUpManager;
        
        public StartUpScreen(User user)
        {
            headerManager = new GameSetter(user);
            setUpManager = new SetUp(user);
        }

        public void Visualize()
        {
            setUpManager.Print();
            headerManager.Print();
        }
    }
}
