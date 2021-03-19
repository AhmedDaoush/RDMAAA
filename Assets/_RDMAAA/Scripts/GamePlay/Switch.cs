using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    GameObject player1;
    [SerializeField]
    GameObject player2;
    [SerializeField]
    GameObject camPlayer1;
    [SerializeField]
    GameObject camPlayer2;

    public void SwitchPlayers()
    {
        if (null != player1.gameObject && null != player2.gameObject)
        {
            if (player1.gameObject.activeInHierarchy == true)
            {
                player2.SetActive(true);
                camPlayer2.SetActive(true);
                StartCoroutine("swap1");
            }
            else
            {
                player1.SetActive(true);
                camPlayer1.SetActive(true);
                StartCoroutine("swap2");
            }
        }
    }
    IEnumerator swap1()
    {
        yield return new WaitForSeconds(1);
        player1.SetActive(false);
        camPlayer1.SetActive(false);

    }
    IEnumerator swap2()
    {
        yield return new WaitForSeconds(1);
        camPlayer2.SetActive(false);
        player2.SetActive(false);

    }
}
