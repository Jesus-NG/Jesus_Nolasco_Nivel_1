using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{

    public GameObject PanelReiniciar;

    void Start()
    {
        PanelReiniciar.SetActive(false);
        Time.timeScale = 1;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.name == "Meta")
        {
            this.enabled = false;
            return;
        }

        PanelReiniciar.SetActive(true);
        Time.timeScale = 0;

    }

    public void ReiniciarNivel()
    {
        SceneManager.LoadScene(0);
    }

}
