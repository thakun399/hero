using UnityEngine;

public class BuildingHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    public int point;
    GameManager gameManager;

    void Start()
    {
        currentHealth = maxHealth; 
        GameObject go = GameObject.Find("GameManager");
        gameManager = go.GetComponent<GameManager>();
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Building HP: " + currentHealth);

        if (currentHealth <= 0)
        {
            gameManager.UpdateScore(point);

            DestroyBuilding(); 
        }
    }

    void DestroyBuilding()
    {
        Debug.Log("Building Destroyed!");
        Destroy(gameObject); 
    }
}