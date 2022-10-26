using System;
using Raylib_cs;
using System.Numerics;

public class World
{
    List<Tile> worldTiles;
    Vector2 size;
    (int x, int y) dim;

    public World()
    {
        size = new(40, 40);
        dim = new(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());
    }

    public void Run()
    {
        Render();
    }

    private void GenerateArea(int minSize, int maxSize)
    {

    }

    private void Render()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);





        Raylib.EndDrawing();
    }
}


enum Tile
{
    Stone,
    Grass,
    Monster,
    RESTRICTED
}