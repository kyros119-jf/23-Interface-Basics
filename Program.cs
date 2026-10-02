IMovable[] movables = 
{
    new Player(),
    new Enemy()
};

foreach (IMovable movable in movables)
{
    movable.Move();
}