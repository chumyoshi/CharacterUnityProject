using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{

    
        public void PlayGame ()
        {
            SceneManager.LoadScene("GameLevel1");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    
}
