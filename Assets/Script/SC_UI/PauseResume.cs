using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour
{
    public void onPause()
    {
        Time.timeScale = 0f;
    }

    public void OnResume()
    {
        Time.timeScale = 1f;
        this.gameObject.SetActive(false);
    }
}
