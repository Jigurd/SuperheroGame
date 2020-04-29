using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Keeps track of global variables and state, such as money, energy, and time.
/// </summary>
public class GameState : MonoBehaviour
{
    public static GameState Instance { get; protected set; }
    public int Money { get; protected set; } = 200;
    public int Energy { get; protected set; } = 100;
    public float Time { get; protected set; } = 12;

    private TextMeshProUGUI _moneyText;
    private TextMeshProUGUI _energyText;
    private TextMeshProUGUI _timeText;

    void Awake()
    {
        Instance = this;
        _moneyText = transform.Find("Header").Find("MoneyIcon").Find("MoneyText").GetComponent<TextMeshProUGUI>();
        _energyText = transform.Find("Header").Find("EnergyIcon").Find("EnergyText").GetComponent<TextMeshProUGUI>();
        _timeText = transform.Find("Header").Find("TimeIcon").Find("TimeText").GetComponent<TextMeshProUGUI>();

        _moneyText.text = Money.ToString();
        _energyText.text = Energy.ToString();
        _timeText.text = Time.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Changes money by given amount and updates the text accordingly.
    /// </summary>
    /// <param name="amount"></param>
    public void ModifyMoney(int amount)
    {
        Money += amount;
        _moneyText.text = Money.ToString();
    }

    /// <summary>
    /// Changes energy by given amount and updates the text accordingly.
    /// </summary>
    /// <param name="amount"></param>
    public void ModifyEnergy(int amount)
    {
        Energy += amount;
        _energyText.text = Energy.ToString();
    }

    /// <summary>
    /// Advances time by a number of hours.
    /// </summary>
    /// <param name="amount">Float number of hours (2,5 would be 2 hrs 30 mins)</param>
    public void AdvanceTime(float amount)
    {
        //TODO fix this
        Time = (Time + amount) % 24;
        _timeText.text = Time.ToString();
    }
}
