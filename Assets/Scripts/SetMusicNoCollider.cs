using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMusicNoCollider : MonoBehaviour
{
    public AK.Wwise.State LetterObtained;
    public AK.Wwise.State LetterNotObtained;
    public Inventory playerInventory;
    public item requiredItem;

    private void Awake()
    {
        if (playerInventory.items.Contains(requiredItem))
        {
            LetterObtained.SetValue();
        }
        else
        {
            LetterNotObtained.SetValue();
        }
    }
}
