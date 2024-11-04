using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(DefaultEvent), menuName = menuPath + nameof(DefaultEvent))]
public class DefaultEvent : AreaEventData
{
    public override void OnEnter(Character character)
    {
        Debug.Log(nameof(OnEnter));
    }
    public override void OnExit(Character character)
    {
        Debug.Log(nameof(OnExit));
    }
}
