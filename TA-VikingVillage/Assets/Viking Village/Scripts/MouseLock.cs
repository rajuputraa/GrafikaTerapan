using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MouseLock : MonoBehaviour {


	public GameObject Video;
	public GameObject Canvas;

	void OnApplicationFocus(bool status)
	{
		if (status)
		{
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
		}
	}
    private void Update()
    {
        bool spasiInput()
		{
			return Input.GetButtonDown("Jump");
		}

		if(spasiInput())
		{
			Video.SetActive(true);
			Canvas.SetActive(false);
		}
    }
}
