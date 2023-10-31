using Godot;
using System;

public partial class Protagonist : Node2D
{
	[Export]
	public string ThisIsMyFavoriteString = "Hello World!";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		MoveRight();
	}

	public string MoveRight()
	{
		return "Move Right!";
	}
}
