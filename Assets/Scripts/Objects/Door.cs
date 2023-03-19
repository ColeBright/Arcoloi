using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DoorType
{
    key,
    enemy,
    button
}

public class Door : Interactable
{
    [Header("door variables")]
    public DoorType thisDoorType;
    public bool open = false;
    public Inventory playerInventory;
    public SpriteRenderer doorSprite;
    public  BoxCollider2D physicsCollider;
    // Start is called before the first frame update


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerInRange && thisDoorType == DoorType.key)
            {
                if(playerInventory.numberOfKeys > 0)
                {
                    playerInventory.numberOfKeys--;
                    Open();
                }
                //does the player have a key
                //if so call open
            }
        }
    }
    public void Open()
    {
        //turn off the door's sprite renderer
        doorSprite.enabled = false;
        //set open to true
        open = true;
        //turn off the door's box collider
        physicsCollider.enabled = false;
    }

    public void Close()
    {

    }
}
