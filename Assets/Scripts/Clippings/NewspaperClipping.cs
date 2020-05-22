using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NewspaperClipping : MonoBehaviour
{
    [SerializeField]
    public NewspaperClippingSO ScriptableObject  = null;

    private TextMeshProUGUI _headline;
    private TextMeshProUGUI _bodyText;
    private Image _picture;

    void Start()
    {
        GetComponent<Canvas>().worldCamera = Camera.main;
        Transform paper = transform.Find("Paper");
        _headline = paper.Find("Headline").GetComponent<TextMeshProUGUI>();
        _headline.text = ScriptableObject.Headline;
        name = ScriptableObject.name;
        _bodyText = paper.Find("Body Text").GetComponent<TextMeshProUGUI>();
        _bodyText.text = ScriptableObject.BodyText;
        _picture = paper.Find("Picture").GetComponent<Image>();

        if (ScriptableObject.Picture != null)
        {
            _picture.sprite = ScriptableObject.Picture;
        }
    }

    void Update()
    {

    }
}
