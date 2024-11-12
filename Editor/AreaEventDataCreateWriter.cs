using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;

public class AreaEventDataCreateWriter : AssetPostprocessor
{
    private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        CreateAssetMenuGenerator.AddToImportedAssets(importedAssets, nameof(AreaEventData));
    }
}