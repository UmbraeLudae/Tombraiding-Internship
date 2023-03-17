
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PuzzleNote))]
public class PuzzleNoteEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var pageNumProperty = serializedObject.FindProperty(nameof(PuzzleNote.pageNuber));
        EditorGUILayout.PropertyField(pageNumProperty);
        var textProperty = serializedObject.FindProperty(nameof(PuzzleNote.tmpNoteText));
        textProperty.stringValue = EditorGUILayout.TextArea(textProperty.stringValue);
        serializedObject.ApplyModifiedProperties();
    }
}
