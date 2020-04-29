using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionHandler : MonoBehaviour
{
    private float _time = 0;
    private static float _doubleClickTime = 0.2f;
    [SerializeField] private GameObject _missionPopupPrefab = null;
    [SerializeField] private MissionPopupSO _mission=null; //TODO make it so you can instantiate several missions from one of these bois

    public void OnMouseDown()
    {
        float currentTime = Time.realtimeSinceStartup;

        //if less than doubleClickTime has passed
        if (Mathf.Abs(_time - currentTime) < _doubleClickTime)
        {
            //Instantiate a mission popup
            GameObject popup = Instantiate(_missionPopupPrefab, transform.position, Quaternion.identity);
            popup.GetComponent<MissionPopup>().Initialize(_mission);
        } else
        {
            //register new click
        _time = Time.realtimeSinceStartup;
        }
    }


}
