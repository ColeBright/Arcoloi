using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMusic : MonoBehaviour
{
    public AK.Wwise.State OnTriggerEnterState;
    public Inventory playerInventory;
    public item requiredItem;
    //[SerializeField]
    //private AK.Wwise.Switch mySwitch;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.CompareTag("Player") && playerInventory.items.Contains(requiredItem))
        {
            Debug.Log("InTrigger");
            OnTriggerEnterState.SetValue();
            //mySwitch.SetValue(this.gameObject);
            //AkSoundEngine.SetSwitch("ThemesGroup", "NPCCleared", gameObject);
        }
    }
}
