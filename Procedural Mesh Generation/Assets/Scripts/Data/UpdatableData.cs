using System;
using UnityEditor;
using UnityEngine;

public class UpdatableData : ScriptableObject
{
    public event Action OnValuesUpdated;
    public bool autoUpdate;

    #if UNITY_EDITOR
    protected virtual void OnValidate()
    {
        if(autoUpdate)
        {
            EditorApplication.update += NotifyWhenValuesAreUpdated;
        }
    }

    public void NotifyWhenValuesAreUpdated()
    {   
        EditorApplication.update -= NotifyWhenValuesAreUpdated;
        if(OnValuesUpdated != null)
        {
            OnValuesUpdated();
        }
    }

    #endif
}
