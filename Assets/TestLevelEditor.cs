using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TestLevel))]
public class TestLevelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        TestLevel testLevel = (TestLevel)target;

        if (GUILayout.Button("Load Level"))
        {
            if (GameManager.instance == null)
            {
                Debug.LogError("GameManager instance is null");
                return;
            }

            GameManager.instance.LoadLevel(testLevel.levelIndex);
        }
    }
}