
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class TriggerEditorUtil
{
    public static void DrawTriggerList(GameObject target, List<Trigger> triggerList, Action<Trigger> OnTriggerClicked)
    {
        var handleColor = Handles.color;
        var availableTriggers = target.scene.GetRootGameObjects().SelectMany(go => go.GetComponentsInChildren<Trigger>()).ToList();
        foreach (var trigger in availableTriggers)
        {
            var inList = triggerList.Contains(trigger);
            var position = trigger.gameObject.transform.position + Vector3.up * .5f;
            var camera = SceneView.currentDrawingSceneView.camera;
            var delta = position - camera.transform.position;
            var rotation = Quaternion.LookRotation(delta);
            var size = Mathf.Clamp(delta.magnitude * .03f, 0.3f, .6f) * 2f;

            Handles.color = inList ? (trigger.IsOn ? Color.green : Color.red) : Color.gray;
            Handles.DrawAAPolyLine(target.transform.position, position);
            if (Handles.Button(position, rotation, size, size, Handles.ConeHandleCap))
                OnTriggerClicked?.Invoke(trigger);
        }
        Handles.color = handleColor;
    }
}
