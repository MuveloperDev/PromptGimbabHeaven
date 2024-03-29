﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptGimbabHeaven
{
    internal class StartScene
    {
        public void Start()
        {

            Console.Title = "Prompt_PacMan";
            RunMainMenu();


        }

        private void RunMainMenu()
        {
            string prompt = @"




              _  __  _               _               _        _   _                                       
             | |/ / (_)  _ __ ___   | |__     __ _  | |__    | | | |   ___    __ _  __   __   ___   _ __  
             | ' /  | | | '_ ` _ \  | '_ \   / _` | | '_ \   | |_| |  / _ \  / _` | \ \ / /  / _ \ | '_ \ 
             | . \  | | | | | | | | | |_) | | (_| | | |_) |  |  _  | |  __/ | (_| |  \ V /  |  __/ | | | |
             |_|\_\ |_| |_| |_| |_| |_.__/   \__,_| |_.__/_  |_| |_|  \___|  \__,_|   \_/    \___| |_| |_|
                         / ___|  (_)  _ __ ___    _   _  | |   __ _  | |_    ___    _ __                              
                         \___ \  | | | '_ ` _ \  | | | | | |  / _` | | __|  / _ \  | '__|                             
                          ___) | | | | | | | | | | |_| | | | | (_| | | |_  | (_) | | |                                
                         |____/  |_| |_| |_| |_|  \__,_| |_|  \__,_|  \__|  \___/  |_|      



                                                                                              

";            // 프롬프트 값
            string[] options = { "Play", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    GameStart();
                    break;
                case 1:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {
            Console.WriteLine("\nPressed any Key to exit....");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        private void GameStart()
        {
            Console.Clear();
            return;
        }
    }
}
