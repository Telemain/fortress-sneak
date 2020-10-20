using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroFade : MonoBehaviour
{
    //public Text Intro;
    //public RawImage black;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fadeText());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator fadeText()
    {
        yield return new WaitForSeconds(2);

        for( float i = 0.01f; i < 2; i += Time.deltaTime ){

            this.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(1.0f, 0.0f, i/2);
            yield return null;
        }
        gameObject.SetActive(false);
    }
}
