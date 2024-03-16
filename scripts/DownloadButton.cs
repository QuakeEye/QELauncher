using Godot;
using System;

public partial class DownloadButton : Button {

	// Called when the node enters the scene tree for the first time
	public override void _Ready() { 
		
		Pressed += buttonPressed;
	}


    private void buttonPressed() {

        // Pop up a message box that shows confirmation text
        var dialog = new AcceptDialog {
            DialogText = "You pressed the download button!"
        };
        AddChild(dialog);
		dialog.PopupCentered();
    }
}