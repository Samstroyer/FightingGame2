using Raylib_cs;

//Game made by me: Samuel Palmér
//This is a test of my sanity + some programming stuff, 
//but everything is possible in programming if you are willing to spend some time...
//That amount of time can sometimes get a lot... so well, lets see if I will make it!

//Based on the assignment 'slagsmålspelet V2' in PrrPrr02, NTI Odenplan

//Fun side note: 
//The first problem that occured was Raylib not being able to run multiple windows... 
//That sucks, but I will just have to cluster in 1 window instead (pls fix)

Setup();

Engine e = new();

Start();

void Setup()
{
    //400x400 is super small, but it should work
    Raylib.InitWindow(400, 400, "Sammes Fighter 2");
}

void Start()
{
    e.Run();
}