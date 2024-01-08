using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testC : ScriptableObject
{
    public float A;
    public float B;

#if UNITY_EDITOR
    [UnityEditor.MenuItem("Assets/Create/testC")]
    public static void Create()
    {
        testC testC = CreateInstance<testC>();
        string path = UnityEditor.AssetDatabase.GetAssetPath(UnityEditor.Selection.activeObject);
        string assetPathAndName = UnityEditor.AssetDatabase.GenerateUniqueAssetPath(path + "/New testC.asset");
        UnityEditor.AssetDatabase.CreateAsset(testC, assetPathAndName);
        UnityEditor.AssetDatabase.SaveAssets();
        UnityEditor.AssetDatabase.Refresh();
        UnityEditor.Selection.activeObject = testC;
    }
#endif
}
