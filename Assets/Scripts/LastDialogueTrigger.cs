using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastDialogueTrigger : MonoBehaviour
{

    Dialogue neededscript;
    public GameObject DialougeBox;
    public GameObject WallSudden;

    void Start()
    {
        neededscript = GameObject.FindGameObjectWithTag("DialogueTag").GetComponent<Dialogue>();
        WallSudden.SetActive(false);

    }



    void OnTriggerEnter(Collider player)
    {
        WallSudden.SetActive(true);

        if (player.gameObject.tag == ("Player"))
        {
           
            neededscript.StartDialogue2();

        }
    }
}

