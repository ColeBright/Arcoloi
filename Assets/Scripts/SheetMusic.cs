using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetMusic : MonoBehaviour
{
    public GameObject sheetMusicObj;
    public Inventory playerInventory;
    public item requiredItem;

    // Start is called before the first frame update
    void Start()
    {
        if (!playerInventory.items.Contains(requiredItem))
        {
            sheetMusicObj.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
