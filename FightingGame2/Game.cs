using Raylib_cs;

enum GameState
{
    Start,
    Tutorial,
    Explorer,
    Inventory,
    Paused,
}

class Game
{
    public GameState state { get; private set; }
    public bool playing { get; private set; }
    public (int x, int y) mid { get; private set; }

    private Player p;
    private bool hasSaves;

    public Game()
    {
        playing = true;
        state = GameState.Start;
        hasSaves = CheckForSaves();

        mid = new(Raylib.GetScreenWidth() / 2, Raylib.GetScreenHeight() / 2);
    }

    public void Start()
    {
        while (playing)
        {
            FrameChecks();
            switch (state)
            {
                case GameState.Explorer:
                    //Explorer();
                    break;
                case GameState.Inventory:
                    //Explorer();
                    break;
                case GameState.Paused:
                    //Explorer();
                    break;
                case GameState.Tutorial:
                    //Explorer();
                    break;
                case GameState.Start:
                    StartMenu();
                    break;
                default:
                    Console.WriteLine("'state' have no set GameState, impossible?");
                    state = GameState.Explorer;
                    Console.WriteLine("'state' is set to $0", state.ToString());
                    break;

            }
        }
    }

    private void FrameChecks()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_Q))
        {
            playing = false;
        }
    }

    private void StartMenu()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        var mouseCords = Raylib.GetMousePosition();

        //New Game
        Rectangle newGameButton = new(mid.x - 150, mid.y - 100, 300, 50);
        if (Raylib.CheckCollisionPointRec(mouseCords, newGameButton))
        {
            Raylib.DrawRectangleRec(newGameButton, Color.DARKGRAY);
            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
            {
                p = new();
            }
        }
        else
        {
            Raylib.DrawRectangleRec(newGameButton, Color.GRAY);
        }
        int offset = Raylib.MeasureText("New Game", 30);
        Raylib.DrawText("New Game", mid.x - offset / 2, mid.y - 90, 30, Color.BLACK);

        //Load Game
        if (hasSaves)
        {
            Rectangle loadButton = new(mid.x - 150, mid.y, 300, 50);
            if (Raylib.CheckCollisionPointRec(mouseCords, loadButton))
            {
                Raylib.DrawRectangleRec(loadButton, Color.DARKGRAY);
            }
            else
            {
                Raylib.DrawRectangleRec(loadButton, Color.GRAY);
            }
            offset = Raylib.MeasureText("Load Game", 30);
            Raylib.DrawText("Load Game", mid.x - offset / 2, mid.y + 10, 30, Color.BLACK);
        }
        else
        {
            offset = Raylib.MeasureText("No saves detected!", 30);
            Raylib.DrawText("No saves detected!", 10, 375, 26, Color.RED);

            Rectangle checkButton = new(275, 375, 100, 20);
            if (Raylib.CheckCollisionPointRec(mouseCords, checkButton))
            {
                if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
                {
                    Console.WriteLine("Started checking for saves!");
                    CheckForSaves();
                }
                Raylib.DrawRectangleRec(checkButton, Color.DARKGRAY);
            }
            else
            {
                Raylib.DrawRectangleRec(checkButton, Color.GRAY);
            }

            offset = Raylib.MeasureText("Update", 18);
            Raylib.DrawText("Update", 270 + offset / 2, 377, 18, Color.BLACK);
        }





        Raylib.EndDrawing();
    }

    private dynamic CheckForSaves()
    {
        return false;
    }
}