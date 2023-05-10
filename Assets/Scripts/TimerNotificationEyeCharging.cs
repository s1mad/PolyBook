using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerNotificationEyeCharging : MonoBehaviour
{
    [SerializeField] private GameObject notificationPanel;
    public int timeNotification = 15*60;
    void Start()
    {
        StartCoroutine(notificationTimer(timeNotification));
    }

    IEnumerator notificationTimer(int timeNotification)
    {
        yield return new WaitForSeconds(timeNotification);
        notificationPanel.SetActive(true);
    }
}
