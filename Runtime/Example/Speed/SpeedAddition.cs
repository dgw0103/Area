using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(SpeedAddition), menuName = menuPath + nameof(SpeedAddition))]
public class SpeedAddition : AreaEventData
{
    [SerializeField] private float value = 0;



    public override void OnEnter(Character character)
    {
        if (character.TryGetComponent(out CharacterSpeed characterSpeed))
        {
            characterSpeed.Speed += value;
        }
    }
    public override void OnExit(Character character)
    {
        if (character.TryGetComponent(out CharacterSpeed characterSpeed))
        {
            characterSpeed.Speed -= value;
        }
    }
}
