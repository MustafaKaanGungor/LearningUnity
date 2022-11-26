using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class signReader : MonoBehaviour
{
    public GameObject dialogBoxGO;
    public Text dialogBoxTXT;
    public bool signActivator;
    public string dialogTXT;
    public GameObject PointerOfAction;
    public bool outliner;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PointerOfAction.SetActive(true);
            outliner = true;
            if(Input.GetKeyDown("e"))
            {
                dialogBoxGO.SetActive(true);
            }
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PointerOfAction.SetActive(false);
            outliner = false;
            dialogBoxGO.SetActive(false);
        }
    }
}
