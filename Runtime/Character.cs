using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class Character : MonoBehaviour
{
    private HashSet<AreaAreaEventDataPair> areaEventDatas = new HashSet<AreaAreaEventDataPair>();



    public void OnEnterArea(Area area, AreaEventData[] currentAreaEventDatas)
    {
        foreach (var item in currentAreaEventDatas)
        {
            areaEventDatas.Add(CreateAreaAreaEventDataPair(area, item));

            if ((item.IsAffectedOnlyOnce && areaEventDatas.Count((x) => x.areaEventData == item) < 2) || item.IsAffectedOnlyOnce == false)
            {
                item.OnEnter(this);
            }
        }
    }
    public void OnExitArea(Area area, AreaEventData[] currentAreaEventDatas)
    {
        IEnumerable<AreaEventData> reversed = currentAreaEventDatas.Reverse();

        foreach (var item in reversed)
        {
            areaEventDatas.Remove(CreateAreaAreaEventDataPair(area, item));

            if ((item.IsAffectedOnlyOnce && areaEventDatas.Any((x) => x.areaEventData == item) == false) || item.IsAffectedOnlyOnce == false)
            {
                item.OnExit(this);
            }
        }
    }
    private AreaAreaEventDataPair CreateAreaAreaEventDataPair(Area area, AreaEventData areaEventData)
    {
        AreaAreaEventDataPair areaAreaEventDataPair = new AreaAreaEventDataPair()
        {
            area = area,
            areaEventData = areaEventData
        };

        return areaAreaEventDataPair;
    }





    private struct AreaAreaEventDataPair
    {
        public Area area;
        public AreaEventData areaEventData;
    }
}