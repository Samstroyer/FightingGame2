using System;
using Raylib_cs;
using System.Numerics;
using System.Threading;

//W.I.P

public enum MenuScreens
{
    Start,
    Settings,
    Help,
    Game

}

public enum GameState
{
    Menu,
    Explorer,
    Fight,
    Inventory
}

public class Engine
{
    private MenuScreens currentMenu;
    private GameState currentState;
    private int midX, midY;
    private bool playing = false;

    public DateTime Started { get; private set; }

    public Engine()
    {
        Started = DateTime.Now;
        currentMenu = MenuScreens.Start;
        currentState = GameState.Menu;

        midX = (int)(Raylib.GetScreenWidth() / 2);
        midY = (int)(Raylib.GetScreenHeight() / 2);
    }

    public void Run()
    {
        while (!Raylib.WindowShouldClose())
        {
            if (playing)
            {

            }
            else
            {
                Menu();
            }
            // switch (currentState)
            // {
            //     case GameState.Menu:
            //         Menu();
            //         break;
            //     case GameState.Explorer:
            //         break;
            //     case GameState.Inventory:
            //         break;
            //     default:
            //         currentState = GameState.Menu;
            //         break;
            // }
        }
    }

    private void Menu()
    {
        Raylib.BeginDrawing();

        Vector2 mouseCord = Raylib.GetMousePosition();

        switch (currentMenu)
        {
            case MenuScreens.Start:
                Raylib.ClearBackground(Color.WHITE);

                Rectangle nextButton = new(midX - 150, midY - 150, 300, 50);
                Rectangle settingsButton = new(midX - 150, midY - 50, 300, 50);
                Rectangle helpButton = new(midX - 150, midY + 50, 300, 50);

                //NextButton
                if (Raylib.CheckCollisionPointRec(mouseCord, nextButton))
                {
                    Raylib.DrawRectangleRec(nextButton, Color.DARKGRAY);
                    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
                    {
                        // Something like this i guess
                        // currentState = GameState.Explorer;
                    }
                }
                else
                {
                    Raylib.DrawRectangleRec(nextButton, Color.GRAY);
                }
                int offset = Raylib.MeasureText("START", 30);
                Raylib.DrawText("START", midX - offset / 2, midY - 140, 30, Color.BLACK);

                //SettingsButton
                if (Raylib.CheckCollisionPointRec(mouseCord, settingsButton))
                {
                    Raylib.DrawRectangleRec(settingsButton, Color.DARKGRAY);

                    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
                    {
                        currentMenu = MenuScreens.Settings;
                    }
                }
                else
                {
                    Raylib.DrawRectangleRec(settingsButton, Color.GRAY);
                }
                offset = Raylib.MeasureText("SETTINGS", 30);
                Raylib.DrawText("SETTINGS", midX - offset / 2, midY - 40, 30, Color.BLACK);

                //HelpButton
                if (Raylib.CheckCollisionPointRec(mouseCord, helpButton))
                {
                    Raylib.DrawRectangleRec(helpButton, Color.DARKGRAY);

                    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
                    {
                        currentMenu = MenuScreens.Help;
                    }
                }
                else
                {
                    Raylib.DrawRectangleRec(helpButton, Color.GRAY);
                }
                offset = Raylib.MeasureText("HELP", 30);
                Raylib.DrawText("HELP", midX - offset / 2, midY + 60, 30, Color.BLACK);

                break;
            case MenuScreens.Settings:
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText("W.I.P", midX, midY, 50, Color.BLACK);


                // For now until W.I.P Done:
                currentMenu = MenuScreens.Start;
                break;

            case MenuScreens.Help:
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText("W.I.P", midX, midY, 50, Color.BLACK);


                // For now until W.I.P Done:
                currentMenu = MenuScreens.Start;
                break;

        }


        Raylib.EndDrawing();
    }
}
