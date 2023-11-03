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
    public bool goodjobbool;
    public bool dialogueC;
    public bool wallrunbool;



    public int dialoguenum;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue1();
        dialogue1bool = true;
        goodjobbool = true;
        dialogueC = false;
        wallrunbool = false;
    }

    void Update()
    {
        

        if (Input.GetMouseButtonDown(0) && wallrunbool == true)
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

        if (Input.GetMouseButtonDown(0) && dialogue1bool == true)
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

        if (Input.GetMouseButtonDown(0) && goodjobbool == false)
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
    IEnumerator dialogueDelay()
    {
        yield return new WaitForSeconds(2);


        gameObject.SetActive(false);
    }



    void StartDialogue1()
    {
        dialoguenum = 0;
        StartCoroutine(TypeLine1());
    }
    public void StartDialogue2()
    {
        if (goodjobbool == true)
        {
            StopAllCoroutines();
            textComponent.text = string.Empty;
            gameObject.SetActive(true);
            dialoguenum = 13;
            StartCoroutine(TypeLine1());
            goodjobbool = false;
            dialogue1bool = false;
            goodjobbool = false;
            dialogueC = false;
            wallrunbool = false;
        }
        
    }

    public void StartDialogue3()
    {
        if (dialogueC == false)
        {
            StopAllCoroutines();
            dialogueC = true;
            textComponent.text = string.Empty;
            gameObject.SetActive(true);
            dialoguenum = 7;
            StartCoroutine(TypeLine1());
        }

    }

    public void StartDialogue4()
    {
        if (wallrunbool == false)
        {
            wallrunbool = true;
            StopAllCoroutines();
            textComponent.text = string.Empty;
            dialoguenum = 10;
            StartCoroutine(TypeLine1());
        }

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
        if (dialoguenum < 3)
        {
            dialoguenum++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine1());
        }

        if (dialoguenum == 3)
        {
            dialoguenum++;
            StartCoroutine(TypeLine1());
            dialogue1bool = false;
        }

        if (dialoguenum == 4)
        {
            StartCoroutine(TypeLine1());
            dialogueDelay();
        }

        if (dialoguenum < 11 && dialoguenum > 9)
        {
            dialoguenum++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine1());

        }

        

        if (dialoguenum >= 13 && dialoguenum < 16)
        {
            
            dialoguenum++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine1());

        }
        

    }
}
