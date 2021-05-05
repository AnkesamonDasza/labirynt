using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelName : MonoBehaviour
{

    public Text levelName;
    // Start is called before the first frame update
    void Start()
    {
        levelName.text = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        levelName.text = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    }
}
