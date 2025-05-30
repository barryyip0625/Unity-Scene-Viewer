# Unity Scene Viewer

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) [![Readme_ZH](https://img.shields.io/badge/UnitySceneViewer-%E4%B8%AD%E6%96%87%E6%96%87%E6%AA%94-red)](https://github.com/barryyip0625/Unity-Scene-Viewer/blob/main/README_ZH.md)

A simple Unity Editor extension that helps you quickly browse, locate, and open scenes in your project.  
This tool is especially useful for projects with many scenes, making scene management more efficient.

![Screenshot 2025-05-21 154055](https://github.com/user-attachments/assets/2a20adef-8cfc-47fd-b6ea-99c509c973df)


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

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

## Contributing

Issues and pull requests are welcome. Your contributions will help make this tool better!
