using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMusic : MonoBehaviour
{
    [SerializeField]
    public AK.Wwise.State OnTriggerEnterState;

    private void Awake()
    {
        OnTriggerEnterState.SetValue();
    }
    private void OnDestroy()
    {
        Debug.Log("In Destroy");
        AkSoundEngine.PostEvent("StopAll", this.gameObject);
    }
}
