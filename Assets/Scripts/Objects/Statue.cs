using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : Sign
{
    public Inventory playerInventory;
    public item mask;
    public item crescentMoon;
    public SignalSender raiseItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        if (Input.GetButtonDown("attack") && playerInRange && playerInventory.items.Contains(mask) && !playerInventory.items.Contains(crescentMoon))
        {
            dialog = "The wind seems to be whispering something... 'There is a House of the East that is missing their celestial light. Bring this to them.'";
            base.Update();
            playerInventory.AddItem(crescentMoon);
            playerInventory.currentItem = crescentMoon;
            raiseItem.Raise();
        }
        else {
            base.Update();
        }
    }
}
