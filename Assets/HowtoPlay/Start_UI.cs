using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_UI : MonoBehaviour
{
    float time = 0;
    [SerializeField]
    Text title_text;
    // Start is called before the first frame update
    void Start()
    {
        float time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 1.5f)
        {
            time = 0;
            title_text.enabled = true;
        }
        else if (time >= 1)
        {
            title_text.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            SceneManager.LoadScene("Game_Main");
        }

    }
}