using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver_UI : MonoBehaviour
{
    float time = 0;
    [SerializeField]
    Text space_text;
    // Start is called before the first frame update
    void Start()
    {
        float time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 1.2f)
        {
            time = 0;
            space_text.enabled = true;
        }
        else if (time >= 1)
        {
            space_text.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            SceneManager.LoadScene("Game_Main");
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            SceneManager.LoadScene("Title");
        }

    }
}