using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewspaperClipping : MonoBehaviour
{
    [SerializeField] private NewspaperClippingSO _scriptableObject = null;

    private TextMeshProUGUI _headline;
    private TextMeshProUGUI _bodyText;
    private SpriteRenderer _picture;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().worldCamera = Camera.main;
        Transform paper = transform.Find("Paper");
        _headline = paper.Find("Headline").GetComponent<TextMeshProUGUI>();
        _headline.text = _scriptableObject.Headline;
        _bodyText = paper.Find("Body Text").GetComponent<TextMeshProUGUI>();
        _bodyText.text = _scriptableObject.BodyText;
        _picture = paper.Find("Picture").GetComponent<SpriteRenderer>();

        if (_scriptableObject.Picture != null)
        {
            _picture.sprite = _scriptableObject.Picture;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
