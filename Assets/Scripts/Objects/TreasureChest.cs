using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TreasureChest : Interactable
{
    public item contents;
    public Inventory playerInventory;
    public bool isOpen;
    public SignalSender raiseItem;
    public GameObject dialogBox;
    public Text dialogText;
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if (!isOpen)
            {
                OpenChest();
            }
            else
            {
                AlreadyOpen();
            }
        }
    }
    public async void OpenChest()
    {
        anim.SetBool("isOpen", true);
        await WaitTwoSecondAsync();
        dialogBox.SetActive(true);
        dialogText.text = contents.itemDescription;
        playerInventory.AddItem(contents);
        playerInventory.currentItem = contents;
        raiseItem.Raise();
        context.Raise();
        isOpen = true;
        //anim.SetBool("isOpen", true);

    }


    public void AlreadyOpen()
    {
            dialogBox.SetActive(false);
            raiseItem.Raise();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen)
        {
            context.Raise();
            playerInRange = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen)
        {
            context.Raise();
            playerInRange = false;
        }
    }
    private async Task WaitTwoSecondAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
    }
}
