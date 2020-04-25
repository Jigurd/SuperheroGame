using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Newspaper Clipping", menuName = "Map Items")]
public class NewspaperClippingSO : ScriptableObject
{
    public string Headline;
    public string BodyText;
    public Sprite Picture;

    //Need some logic for dialogue options and whatnot at some point
}
