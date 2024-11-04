using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class AreaEventData : ScriptableObject
{
    [SerializeField] private bool isAffectedOnlyOnce;
#if UNITY_EDITOR
    protected const string menuPath = "AreaEventData/";
#endif



    public bool IsAffectedOnlyOnce { get => isAffectedOnlyOnce; }
    public abstract void OnEnter(Character character);
    public abstract void OnExit(Character character);
}
