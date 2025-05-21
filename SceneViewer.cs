using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using UnityEditor.SceneManagement;

namespace BYUtils.EditorTools
{
    public class SceneViewer : EditorWindow
    {
        private Vector2 scrollPosition;
        private List<string> scenePathList = new List<string>();
        private GUIStyle headerStyle;
        private GUIStyle buttonStyle;

        [MenuItem("Tools/BY Utils/Scene Viewer")]
        public static void ShowWindow()
        {
            SceneViewer window = GetWindow<SceneViewer>("Scene Viewer");
            window.minSize = new Vector2(300, 200);
            window.Show();
        }

        private void OnEnable()
        {
            RefreshSceneList();
        }

        private void CreateStyles()
        {
            if (headerStyle == null)
            {
                headerStyle = new GUIStyle(GUI.skin.label)
                {
                    fontSize = 14,
                    fontStyle = FontStyle.Bold,
                    alignment = TextAnchor.MiddleCenter,
                    padding = new RectOffset(0, 0, 5, 10)
                };
            }

            if (buttonStyle == null)
            {
                buttonStyle = new GUIStyle(GUI.skin.button)
                {
                    padding = new RectOffset(10, 10, 6, 6),
                    margin = new RectOffset(10, 10, 4, 4)
                };
            }
        }

        private void RefreshSceneList()
        {
            scenePathList.Clear();

            // Find all scene files
            string[] sceneGuids = AssetDatabase.FindAssets("t:Scene");
            foreach (string guid in sceneGuids)
            {
                string path = AssetDatabase.GUIDToAssetPath(guid);
                // Only add scenes from the Assets folder, exclude Package scenes
                if (!string.IsNullOrEmpty(path) && path.StartsWith("Assets/"))
                {
                    scenePathList.Add(path);
                }
            }

            // Sort scenes by name
            scenePathList.Sort((a, b) => Path.GetFileNameWithoutExtension(a).CompareTo(Path.GetFileNameWithoutExtension(b)));
        }

        private void OnGUI()
        {
            CreateStyles();

            EditorGUILayout.BeginVertical();
            
            if (GUILayout.Button("Refresh Scene List", GUILayout.Height(30)))
            {
                RefreshSceneList();
            }

            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Click on a scene below to open it:", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);

            if (scenePathList.Count == 0)
            {
                EditorGUILayout.HelpBox("No scenes found in the project.", MessageType.Info);
            }
            else
            {
                foreach (string scenePath in scenePathList)
                {
                    EditorGUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));

                    string sceneName = Path.GetFileNameWithoutExtension(scenePath);
                    
                    // Main scene button, using ExpandWidth to ensure it takes up most of the space
                    if (GUILayout.Button(sceneName, buttonStyle, GUILayout.Height(30), GUILayout.ExpandWidth(true)))
                    {
                        // Locate and highlight the scene file in Project window
                        UnityEngine.Object sceneAsset = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(scenePath);
                        EditorGUIUtility.PingObject(sceneAsset);

                        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                        {
                            EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Single);
                        }
                    }

                    // Add button with fixed width
                    if (GUILayout.Button("Add", GUILayout.Width(50), GUILayout.Height(30)))
                    {
                        // Locate and highlight the scene file in Project window
                        UnityEngine.Object sceneAsset = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(scenePath);
                        EditorGUIUtility.PingObject(sceneAsset);

                        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                        {
                            EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Additive);
                        }
                    }

                    EditorGUILayout.EndHorizontal();
                    EditorGUILayout.Space(2); // Add a small vertical spacing
                }
            }

            EditorGUILayout.EndScrollView();
            EditorGUILayout.EndVertical();
        }
    }
}
