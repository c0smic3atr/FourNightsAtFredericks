using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableManager : MonoBehaviour
{
    public TextMeshProUGUI collectableDisplay;
    public int numberOfPizzas;

    public GameObject pizzaPrefab;
    public float spawnRange;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCount();
        
        for(int i = 0; i < 10; i++)
        {
            Instantiate(pizzaPrefab, RandomSpawnPos(), pizzaPrefab.transform.rotation);

        }
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    private Vector3 RandomSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    public void UpdateCount()
    {
        StartCoroutine(DelayedUpdateCount());
    }

    public IEnumerator DelayedUpdateCount()
    {
        Debug.Log("Updating!");
        yield return new WaitForEndOfFrame();

        foreach (GameObject pizza in GameObject.FindGameObjectsWithTag("Pizza"))
        {
            Debug.Log("I found a pizza named " + pizza.name);
        }

        numberOfPizzas = GameObject.FindGameObjectsWithTag("Pizza").Length;
        collectableDisplay.text = $"Pizzas Left: {numberOfPizzas}";
        if (numberOfPizzas <= 0)
        {
            AllDone();
        }
    }

    public void AllDone()
    {
        Debug.Log("All Done!!!!!!! ^_^");
    }
}
