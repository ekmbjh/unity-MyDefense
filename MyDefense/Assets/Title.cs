using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject anykey;

    public string loadToScene = "MainMenu";

    private bool isShow = false;
    private float showTimer = 3f;
    private float countdown = 0f;
    private float delayTimer = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ShowAnykey", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        countdown += Time.deltaTime;

        if (countdown >= delayTimer)
        {
            GotoMenu();
            return;
        }

        if (Input.anyKeyDown && isShow)
        {
            GotoMenu();
        }
    }

    private void ShowAnykey()
    {
        isShow = true;
        anykey.SetActive(true);
    }

    private void GotoMenu()
    {
        SceneManager.LoadScene(loadToScene);
    }
}
