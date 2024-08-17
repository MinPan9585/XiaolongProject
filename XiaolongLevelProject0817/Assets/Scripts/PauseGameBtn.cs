using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGameBtn : MonoBehaviour
{
    public GameObject startGameBtn;
    public void PauseGame()
    {
        Time.timeScale = 0;
        startGameBtn.SetActive(true);
        this.gameObject.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
            PauseGame();
    }
}
