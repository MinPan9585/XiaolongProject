using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueGameBtn : MonoBehaviour
{
    public GameObject pauseGameBtn;
    public void ContinueGame()
    {
        Time.timeScale = 1;
        pauseGameBtn.SetActive(true);
        this.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            ContinueGame();
    }
}
