using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testA : MonoBehaviour
{
    [ScriptableObjectField(typeof(testB))]
    public testB testB;

    [ScriptableObjectField(typeof(testC))]
    public testC testC;

    [ScriptableObjectField(typeof(testB))]
    public List<testB> testBList;
}
