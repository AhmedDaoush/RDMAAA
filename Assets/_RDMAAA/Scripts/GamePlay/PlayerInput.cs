using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public IInputManager inputManager;
    public Vector3SO movement;
    [SerializeField]
    UIBarSO timeBar;
    [SerializeField]
    EnemySO timeSlowSO;
    [SerializeField]
    float timeScale = 7;
    [SerializeField]
    bool switchPlayers;
    [SerializeField]
    bool ability;
    [SerializeField]
    JetPackSO jetSO;
    [SerializeField]
    float timeUsage = 5;
    float initialEnemySpeed;

    void Start()
    {
        jetSO.canJump = false;
        jetSO.canJet = false;
        //getting abilities components
        if (null == inputManager)
        {
            inputManager = new InputHandler();
            // Debug.Log("nulll");
        }
        //getback button listener
        initialEnemySpeed = timeSlowSO.EnemySpeed;
    }

    void Update()
    {
        Vector3 moving = Vector3.zero;

        if (inputManager.GetForword())
        {
            moving.z++;
        }
        if (inputManager.GetBackword())
        {
            moving.z--;
        }
        if (inputManager.GetRight())
        {
            moving.x++;
        }
        if (inputManager.GetLeft())
        {
            moving.x--;
        }
        if (inputManager.Jump())
        {
            jetSO.canJump = true;
        }
        if (inputManager.UseJetPack())
        {
            // Debug.Log("can jet");
            jetSO.canJet = true;
        }
        if (inputManager.useTime() && timeBar.Value >= timeUsage * Time.deltaTime)
        {
            timeSlowSO.EnemySpeed = timeScale;
            timeBar.Value -= timeUsage * Time.deltaTime;
        }
        else
        {
            ResetEnemySO();
        }
        this.movement.vector = moving;
    }

    public void ResetEnemySO()
    {
        timeSlowSO.EnemySpeed = initialEnemySpeed;
    }

}
