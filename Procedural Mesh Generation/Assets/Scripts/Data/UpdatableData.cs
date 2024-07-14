using System;
using UnityEngine;

public class UpdatableData : ScriptableObject
{
    public event Action OnValuesUpdated;
    public bool autoUpdate;

    protected virtual void OnValidate()
    {
        if(autoUpdate)
        {
            NotifyWhenValuesAreUpdated();
        }
    }

    public void NotifyWhenValuesAreUpdated()
    {
        if(OnValuesUpdated != null)
        {
            OnValuesUpdated();
        }
    }
}
