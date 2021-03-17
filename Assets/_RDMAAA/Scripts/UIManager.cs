using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField]
    bool Jetpack = false;
    [Header("Refrences")]
    [SerializeField]
    EventSO SwitchEvent;
    [SerializeField]
    GameObject JetbackBar;
    [SerializeField]
    GameObject TimeSlowBar;
    private void Start()
    {
        Jetpack = !Jetpack;
        Switch();
    }
    public void Switch()
    {
        Jetpack = !Jetpack;
        JetbackBar.SetActive(Jetpack);
        TimeSlowBar.SetActive(!Jetpack);
    }
}
