using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Visualizer : MonoBehaviour
{
    public float speed = 0.0f;
    private int counter = 0;
    private float value1 = 0.0f;
    private float value2 = 0.0f;
    private float value3 = 0.0f;
    private float value4 = 0.0f;
    private float value5 = 0.0f;
    private float value6 = 0.0f;
    private float value7 = 0.0f;
    private float value8 = 0.0f;
    private float value9 = 0.0f;
    private float value10 = 0.0f;
    private float value11 = 0.0f;
    private float value12 = 0.0f;
    private float value13 = 0.0f;
    public Image S1;
    public Image S2;
    public Image S3;
    public Image S4;
    public Image S5;
    public Image S6;
    public Image S7;
    public Image S8;
    public Image S9;
    public Image S10;
    public Image S11;
    public Image S12;
    public Image S13;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 5)
        {
            value1 = Random.Range(0.0f, 1.0f);
            value2 = Random.Range(0.0f, 1.0f);
            value3 = Random.Range(0.0f, 1.0f);
            value4 = Random.Range(0.0f, 1.0f);
            value5 = Random.Range(0.0f, 1.0f);
            value6 = Random.Range(0.0f, 1.0f);
            value7 = Random.Range(0.0f, 1.0f);
            value8 = Random.Range(0.0f, 1.0f);
            value9 = Random.Range(0.0f, 1.0f);
            value10 = Random.Range(0.0f, 1.0f);
            value11 = Random.Range(0.0f, 1.0f);
            value12 = Random.Range(0.0f, 1.0f);
            value13 = Random.Range(0.0f, 1.0f);
            counter = 0;
        }
        counter++;
        Vector3 newScale = new Vector3(1, value1, 1);
        S1.rectTransform.localScale = Vector3.Lerp(S1.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value2, 1);
        S2.rectTransform.localScale = Vector3.Lerp(S2.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value3, 1);
        S3.rectTransform.localScale = Vector3.Lerp(S3.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value4, 1);
        S4.rectTransform.localScale = Vector3.Lerp(S4.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value5, 1);
        S5.rectTransform.localScale = Vector3.Lerp(S5.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value6, 1);
        S6.rectTransform.localScale = Vector3.Lerp(S6.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value7, 1);
        S7.rectTransform.localScale = Vector3.Lerp(S7.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value8, 1);
        S8.rectTransform.localScale = Vector3.Lerp(S8.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value9, 1);
        S9.rectTransform.localScale = Vector3.Lerp(S9.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value10, 1);
        S10.rectTransform.localScale = Vector3.Lerp(S10.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value11, 1);
        S11.rectTransform.localScale = Vector3.Lerp(S11.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value12, 1);
        S12.rectTransform.localScale = Vector3.Lerp(S12.rectTransform.localScale, newScale, speed * Time.deltaTime);
        newScale = new Vector3(1, value13, 1);
        S13.rectTransform.localScale = Vector3.Lerp(S13.rectTransform.localScale, newScale, speed * Time.deltaTime);
    }
}
