using Godot;

public partial class Dagger : Node2D
{
  [Export] public double Damage = .3;
  [Export] public int Velocity = 25;

  public override void _Ready()
  {
  }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(double delta)
  {

  }

  public bool IsThrown()
  {
    return Input.IsActionJustPressed("ability_trigger");
  }

  // if dagger has been thrown spawn in entity w/ velocity and if it collides with something emit damage
  public int DaggerThrow()
  {
    Velocity.
  }
}