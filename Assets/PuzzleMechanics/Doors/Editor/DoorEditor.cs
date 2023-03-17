using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Door))]
public class DoorEditor : Editor
{
    private Door Door => target as Door;

    void OnSceneGUI()
    {
        TriggerEditorUtil.DrawTriggerList(Door.gameObject, Door.triggers, OnTriggerClicked);
    }

    void OnTriggerClicked(Trigger trigger)
    {
        Undo.RecordObject(Door, "modify door triggers");
        if (Door.triggers.Contains(trigger)) Door.triggers.Remove(trigger);
        else Door.triggers.Add(trigger);
        EditorUtility.SetDirty(Door);
    }
}
