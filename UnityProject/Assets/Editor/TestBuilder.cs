using UnityEditor;
using UnityEngine;

public class TestBuilder
{
    [MenuItem("Build/Test Build")]
    public static void BuildGame()
    {
        try
        {
            string pathToDeploy = "./Builds/MyGame";
            BuildPipeline.BuildPlayer(GetScenePaths(), pathToDeploy, BuildOptions.None);
            Debug.Log("Build completed successfully!");
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Error during build: " + ex.Message);
        }
    }

    private static string[] GetScenePaths()
    {
        // Get path to all scenes in build settings
        return new string[] { "Assets/Scenes/Scene1.unity", "Assets/Scenes/Scene2.unity" };
    }
}