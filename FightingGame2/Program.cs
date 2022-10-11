using Raylib_cs;

Setup();

Engine e = new();

Start();

void Setup()
{
    Raylib.InitWindow(400, 400, "Sammes Fighter 2");
}

void Start()
{
    e.Run();
}