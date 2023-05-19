using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Invoke("ChangeScene", 1f);
    }
    private void ChangeScene()
    {
        SceneManager.LoadScene("End");
    }
}
