using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(FirstSceneControl))]
[CanEditMultipleObjects]
public class MyPlayerEditor : Editor
{
   
    SerializedProperty roundProp;

    void OnEnable()
    {
        roundProp = serializedObject.FindProperty("round");
    }

    public override void OnInspectorGUI()
    {
        
        serializedObject.Update();

        EditorGUILayout.IntSlider(roundProp, 1, 3, new GUIContent("Upper Limit of Difficulty"));

        if (!roundProp.hasMultipleDifferentValues)
            ProgressBar(roundProp.intValue / 3f, "Upper Limit of Difficulty");

       
        serializedObject.ApplyModifiedProperties();
    }

    
    void ProgressBar(float value, string label)
    {
        Rect rect = GUILayoutUtility.GetRect(18, 18, "TextField");
        EditorGUI.ProgressBar(rect, value, label);
        EditorGUILayout.Space();
    }
}