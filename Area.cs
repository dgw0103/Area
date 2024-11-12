using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    [SerializeField] private AreaEventData[] areaEventDatas;



    private void OnTriggerEnter(Collider other)
    {
        if (areaEventDatas.Length == 0)
        {
            return;
        }
    
        if (other.TryGetComponent(out Character character))
        {
            character.OnEnterArea(this, areaEventDatas);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (areaEventDatas.Length == 0)
        {
            return;
        }
    
        if (other.TryGetComponent(out Character character))
        {
            character.OnExitArea(this, areaEventDatas);
        }
    }
}
