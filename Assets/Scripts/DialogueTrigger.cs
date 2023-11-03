using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    Dialogue neededscript;
    public GameObject DialougeBox;

    void Start()
    {
        neededscript = GameObject.FindGameObjectWithTag("DialogueTag").GetComponent<Dialogue>();

    }

    

    void OnTriggerEnter(Collider player)
    {
        if(DialougeBox.activeInHierarchy == false)
        {
            DialougeBox.SetActive(true);
        }

        if (player.gameObject.tag == ("Player"))
        {
            
            neededscript.StartDialogue3();

        }
    }
}
