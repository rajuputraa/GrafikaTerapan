using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Dipanggil ketika tombol ditekan
    public void OnButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}


