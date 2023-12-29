using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : Sign
{
    public Inventory playerInventory;
    public item mask;
    public item crescentMoon;
    public SignalSender raiseItem;
    public string finalDialog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {

        if (Input.GetButtonDown("attack") && playerInRange && playerInventory.items.Contains(mask) && !playerInventory.items.Contains(crescentMoon))
        {
            dialog = finalDialog;

            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
            //base.Update();
            playerInventory.AddItem(crescentMoon);
            playerInventory.currentItem = crescentMoon;
            //raiseItem.Raise();
        }
        else if (Input.GetButtonDown("attack") && playerInRange)
            {
                if (dialogBox.activeInHierarchy)
                {
                    dialogBox.SetActive(false);
                }
                else
                {
                    dialogBox.SetActive(true);
                    dialogText.text = dialog;
                }
            }
        else {
            base.Update();
        }
    }
}
