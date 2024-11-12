using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(SpeedMultiplication), menuName = menuPath + nameof(SpeedMultiplication))]
public class SpeedMultiplication : AreaEventData
{
    [SerializeField] private float value = 1f;



    public override void OnEnter(Character character)
    {
        if (character.TryGetComponent(out CharacterSpeed characterSpeed))
        {
            characterSpeed.Speed *= value;
        }
    }
    public override void OnExit(Character character)
    {
        if (character.TryGetComponent(out CharacterSpeed characterSpeed))
        {
            characterSpeed.Speed /= value;
        }
    }
}