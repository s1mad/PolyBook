using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerNotificationEyeCharging : MonoBehaviour
{
    [SerializeField] private GameObject notificationPanel;
    [SerializeField] private SettingsReader settingsReader;
    private int timeNotification;
    private Coroutine notificationCoroutine;
    void Start()
    {
        updateNotificationTimer();
    }

    IEnumerator notificationTimer(int timeNotification)
    {
        yield return new WaitForSeconds(timeNotification);
        notificationPanel.SetActive(true);
    }
    public void updateNotificationTimer()
    {
        if (notificationCoroutine != null)
            StopCoroutine(notificationCoroutine);
        timeNotification = settingsReader.timeNotification;
        StartCoroutine(notificationTimer(timeNotification));
    }
}
