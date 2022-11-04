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
        }


    }
}
