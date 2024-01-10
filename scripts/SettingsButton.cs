using Godot;
using System;

public partial class SettingsButton : Button {

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

		Pressed += buttonPressed;
	}

	
	private void buttonPressed() {

		// Add a dialog that prompts the user to input an url
		
	}
}
