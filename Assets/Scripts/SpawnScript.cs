using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject SpawnPoint;
    
    public float minX, minY; // минимальный край координат с учетом координат точки спауна
    public float maxX, maxY; // максимальный край координат с учетом координат точки спауна
    public float speedSpawn = 2.5f; //скорость спауна
    public float stepSpeedSpawn = 0.1f; //скорость спауна
    public float minSpeedSpawnInCycle = 0.5f; //скорость спауна
    public float maxSpeedSpawnInCycle = 1.3f; //скорость спауна

    void Start()
    {
        StartCoroutine(salvo());
        //Прототип подстройки под разные экраны спаун области с помощью нормировки
        /*minX = Screen.width / -150;
        minY = Screen.height / -240;
        maxX = Screen.width / 150;
        maxY = Screen.height / 240;
        Debug.Log(minX);
        Debug.Log(minY);
        Debug.Log(maxX);
        Debug.Log(maxY);
        */
    }
    void CreateSpawnObject()
    {
        float x = Random.Range(minX, maxX) + SpawnPoint.transform.position.x; // позиция X
        float y = Random.Range(minY, maxY) + SpawnPoint.transform.position.y; // позиция Y
        Instantiate(spawnObject, new Vector3(x, y, 0f), transform.rotation);
        
    }
    IEnumerator salvo()
    {
        CreateSpawnObject();
        yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
        CreateSpawnObject();
        yield return new WaitForSeconds(Random.Range(0.9f, 1.7f));
        CreateSpawnObject();
        yield return new WaitForSeconds(Random.Range(0.5f, 1.3f));
        CreateSpawnObject();
        yield return new WaitForSeconds(Random.Range(0.5f, 1.3f));
        CreateSpawnObject();
        yield return new WaitForSeconds(Random.Range(0.5f, 1.3f));

       // speedSpawn = 2.5f;
        while (speedSpawn >= 0.1f)
        {
            CreateSpawnObject();
            yield return new WaitForSeconds(speedSpawn);
            speedSpawn -= stepSpeedSpawn;
            if (speedSpawn <= stepSpeedSpawn*2) speedSpawn += Random.Range(0.5f, 1.3f);
        }        
    }

    public void ChooseMode()
    {

    }
     
}
