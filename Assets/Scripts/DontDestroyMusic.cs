using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyMusic : MonoBehaviour
{
    public Inventory playerInventory;

    //Scene currentScene = SceneManager.GetActiveScene();

    private void Awake()
    {

        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Game Music");
        if( musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    //check if area is resolved

    private bool isAreaResolved(item itemAttained)
    {
        //check based on inventory, and pan it?
        if (playerInventory.items.Contains(itemAttained))
        {
            return true;
        }
        return false;
    }

    //if it is check which scene
    //private void checkScene(Scene scene)
    //{
    //    if(scene.name == "SatieScene")
    //    {
    //        //specific region in scene
    //        //set signal based on room transition script

    //        switch()
    //    }
    //}

    // if its overworld, switch statement for for skatepark, statue park, or graveyard

    //if not, maybe switch statement for house, mosque, church, or dungeon


    //if area is not resolved switch statement for overworld, dungeon, or house/church/mosque


}
