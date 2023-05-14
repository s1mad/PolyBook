using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingsReader : MonoBehaviour
{
    public int timeNotification = 15*60;
    private int timeNotificationMinutes = 15;

    [SerializeField] TMP_Text textTimeNotificationHeading, textTimeNotificationEditor;
    [SerializeField] private TimerNotificationEyeCharging timerNotificationEyeCharging;

    void Start()
    {
        updateSettingsText();
    }
    public void clickTimeNotificationEditorPlus()
    {
        if (timeNotificationMinutes< 600000)
        {
            timeNotificationMinutes++;
            textTimeNotificationEditor.text = timeNotificationMinutes.ToString() + " мин";
        }
    }
    public void clickTimeNotificationEditorMinus()
    {
        if (timeNotificationMinutes > 1)
        {
            timeNotificationMinutes--;
            textTimeNotificationEditor.text = timeNotificationMinutes.ToString() + " мин";
        }
    }
    public void clickSaveSattings()
    {
        timeNotification = timeNotificationMinutes * 60;
        updateSettingsText();
        timerNotificationEyeCharging.updateNotificationTimer();
    }
    void updateSettingsText() 
    {
        textTimeNotificationHeading.text = "Время напоминания: " + timeNotificationMinutes.ToString() + " м";
    }
}
