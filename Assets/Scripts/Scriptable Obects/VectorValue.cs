using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class VectorValue : ScriptableObject, ISerializationCallbackReceiver
{
    public Vector2 initialvalue;

    public Vector2 defaultValue;

    public void OnAfterDeserialize() { initialvalue = defaultValue; }

    public void OnBeforeSerialize() { }


}
