using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatValue : ScriptableObject, ISerializationCallbackReceiver
{
    // Start is called before the first frame update
    public float initialValue;
    [HideInInspector]
    public float runtimeValue;
    public void OnBeforeSerialize(){
        runtimeValue = initialValue;
    }

    public void OnAfterDeserialize()
    {

    }
}
