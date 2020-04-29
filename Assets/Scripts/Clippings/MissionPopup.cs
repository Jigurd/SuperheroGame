using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MissionPopup : MonoBehaviour
{
    private TextMeshProUGUI _title;
    private TextMeshProUGUI _textBody;
    private Image _picture;

    private int _moneyCost;
    private int _energyCost;
    private float _timeCost;

    private TextMeshProUGUI _moneyCostText;
    private TextMeshProUGUI _energyCostText;
    private TextMeshProUGUI _timeCostText;
    private Button _verbButton;
    private Button _closeButton;


    void Awake()
    {
        _title = transform.Find("Title").GetComponent<TextMeshProUGUI>();
        _textBody = transform.Find("Text Body").GetComponent<TextMeshProUGUI>();
        _picture = transform.Find("Picture").GetComponent<Image>();

        _moneyCostText = transform.Find("MoneyCostIcon").Find("MoneyCost").GetComponent<TextMeshProUGUI>();
        _energyCostText = transform.Find("EnergyCostIcon").Find("EnergyCost").GetComponent<TextMeshProUGUI>();
        _timeCostText = transform.Find("TimeCostIcon").Find("TimeCost").GetComponent<TextMeshProUGUI>();

        _verbButton = transform.Find("VerbButton").GetComponent<Button>();
        _closeButton = transform.Find("CloseButton").GetComponent<Button>();

        _verbButton.onClick.AddListener(OnVerbButton);
        _closeButton.onClick.AddListener(OnCloseButton);
    }

    void Update()
    {
        
    }

    //Initializes mission text
    public void Initialize(MissionPopupSO mission)
    {
        _title.text = mission.Title;
        _textBody.text = mission.TextBody;
        if (mission.Picture != null)
        {
            _picture = mission.Picture;
        }
        _moneyCost = mission.MoneyCost;
        _energyCost = mission.EnergyCost;
        _timeCost = mission.TimeCost;

        _moneyCostText.text = _moneyCost.ToString();
        _energyCostText.text = _energyCost.ToString();
        _timeCostText.text = _timeCost.ToString();
    }


    private void OnVerbButton()
    {
        GameState.Instance.ModifyMoney(-_moneyCost);
        GameState.Instance.ModifyEnergy(-_energyCost);
        GameState.Instance.AdvanceTime(_timeCost);
        Destroy(gameObject);
    }

    //Closes the window
    private void OnCloseButton()
    {
        Destroy(gameObject);
    }
}
