using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Mission Popup", menuName = "Map Items/Mission Popup", order = 1)]
public class MissionPopupSO : ScriptableObject
{
    public string Title;
    public string TextBody;
    public Image Picture;

    public int MoneyCost;
    public int EnergyCost;
    public float TimeCost;

    [Tooltip("The verb that goes in the 'do the thing' button")] public string Verb;
}
