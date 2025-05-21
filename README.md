# Unity Scene Viewer

A simple Unity Editor extension that helps you quickly browse, locate, and open scenes in your project.  
This tool is especially useful for projects with many scenes, making scene management more efficient.

## Features

- **Scene List Viewer:** Lists all scenes under the `Assets/` folder, excluding package scenes.
- **Quick Open:** Click a scene name to open it (after prompting to save current changes).
- **Additive Open:** Use the "Add" button to load a scene additively.
- **Locate Scene:** Automatically highlights the scene asset in the Project window when you interact with it.
- **Refresh:** One-click refresh to update the scene list.

## Installation

1. Copy the `Editor/SceneViewer/SceneViewer.cs` file (and folder) into your Unity project's `Assets/Editor/` directory.
2. Open Unity. The tool will be available in the menu:  
   `Tools > BY Utils > Scene Viewer`

## Usage

1. Open the Scene Viewer window from the menu:  
   `Tools > BY Utils > Scene Viewer`
2. The window will display all scenes found in your project.
3. Click a scene name to open it (single mode), or click "Add" to open it additively.
4. Use the "Refresh Scene List" button if you add or remove scenes while the window is open.

## Project Structure

- `Editor/SceneViewer/SceneViewer.cs` — Main editor window script.

## License

This project is licensed under the MIT License.  
See the [LICENSE](Editor/SceneViewer/LICENSE) file for details.
