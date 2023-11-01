using Godot;
using System;
using System.Collections.Generic;

public partial class Protagonist : Node2D
{
	[Export] public float Speed;
	//procs initially on Class creation
	public override void _Ready()
	{

	}

	// procs every frame
	public override void _Process(double delta)
	{
		Vector2 movement = GetMovementInput() * (float)(Speed * delta);
		Position += movement;

	}

	public Vector2 GetMovementInput()
	{
		Vector2 movement = Vector2.Zero;

		if (Input.IsActionPressed("move_left"))
			movement.X -= 1;
		if (Input.IsActionPressed("move_right"))
			movement.X += 1;
		if (Input.IsActionPressed("move_up"))
			movement.Y -= 1;
		if (Input.IsActionPressed("move_down"))
			movement.Y += 1;

		return movement;
	}
}