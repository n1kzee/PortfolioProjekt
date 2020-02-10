using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESETRESOLUTION : MonoBehaviour
{
    [SerializeField]
    Vector2 m_Resolution;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForScreenChange(true, m_Resolution));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WaitForScreenChange(bool fullscreen, Vector2 _resolution)
    {
        int width = (int)_resolution.x;
        int height = (int)_resolution.y;

        Screen.fullScreen = fullscreen;

        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();

        Screen.SetResolution(width, height, Screen.fullScreen);
    }

   
}
