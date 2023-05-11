using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingsReader : MonoBehaviour
{
    public int timeNotification = 15*60;

    [SerializeField] TMP_InputField inputFieldTimeNotification;
    [SerializeField] private TimerNotificationEyeCharging timerNotificationEyeCharging;

    void Start()
    {
        updateSettingsText();
    }
    public void clickSaveSattings()
    {
        if (!string.IsNullOrEmpty(inputFieldTimeNotification.text))
        {
            timeNotification = int.Parse(inputFieldTimeNotification.text);
            inputFieldTimeNotification.text = "";
            updateSettingsText();
            timerNotificationEyeCharging.updateNotificationTimer();
        }
    }
    void updateSettingsText() 
    {
        inputFieldTimeNotification.placeholder.GetComponent<TMP_Text>().text = "Время напоминания: " + timeNotification.ToString() + "c";
    }
}
