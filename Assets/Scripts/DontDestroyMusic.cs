using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyMusic : MonoBehaviour
{
    public Inventory playerInventory;
    public item requiredItem;
    public GameObject defaultMusicPlayer;
    public GameObject finalMusicPlayer;

    //Scene currentScene = SceneManager.GetActiveScene();
    //public AkEvent stop;

    //private void Awake()
    //{

    //    GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Game Music");
    //    if( musicObj.Length > 1)
    //    {
    //        Destroy(this.gameObject);
    //    }
    //    DontDestroyOnLoad(this.gameObject);
    //}

    private void Start()
    {
        if (playerInventory.items.Contains(requiredItem))
        {
            defaultMusicPlayer.SetActive(false);
            finalMusicPlayer.SetActive(true);
        }
        else
        {
            defaultMusicPlayer.SetActive(true);
            finalMusicPlayer.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        Debug.Log("In Destroy");
        AkSoundEngine.PostEvent("StopAll", this.gameObject);
    }
    //check if area is resolved

    //private bool isAreaResolved(item itemAttained)
    //{
    //    //check based on inventory, and pan it?
    //    if (playerInventory.items.Contains(itemAttained))
    //    {
    //        return true;
    //    }
    //    return false;
    //}

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
