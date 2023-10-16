using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public bool dialogue1bool;
    public bool startDialogue2;
    
    

    public int dialoguenum;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue1();
        dialogue1bool = true;
        
    }

    void Update()
    { 
        if(Input.GetMouseButtonDown(0) && dialogue1bool)
        {
            if (textComponent.text == lines[dialoguenum])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[dialoguenum];
            }
        }

    }
    

    void StartDialogue1()
    {
        dialoguenum = 0;
        StartCoroutine(TypeLine1());
    }
    void StartDialogue2()
    {
        dialoguenum = 5;
        StartCoroutine(TypeLine1());
    }

    IEnumerator TypeLine1()
    {
        foreach (char c in lines[dialoguenum].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (dialoguenum <= 2)
        {
            dialoguenum++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine1());
        }
        else if (dialoguenum == 3)
        {
            dialoguenum++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine1());
        }
        
        
        if (dialoguenum == 4)
        {
            dialogue1bool = false;
            gameObject.SetActive(false);
        }

    }

}
