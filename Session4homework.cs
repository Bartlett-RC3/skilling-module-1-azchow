using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4homework : MonoBehaviour
{
    //Variables
    public GameObject columnPrefab;
    IEnumerator createPrefabsCoroutine;


    // Start is called before the first frame update
    void Start()
    {
        createPrefabsCoroutine = DropPrefabs();
       

    }

    // Update is called once per frame
    void Update()
    {
        //Calling (using) a coroutine
        StartCoroutine(createPrefabsCoroutine);
        Debug.Log(Time.time);
        if(Time.time>10)
        {
            //stop a specific coroutine
            StopCoroutine(createPrefabsCoroutine);
            //stop all coroutines
            StopAllCoroutines();
        }
    }

    //Coroutines
    IEnumerator DropPrefabs()
    {
        while(true)
        {
            //Action the coroutine(create and drop column)
            Vector3 dropPosition = new Vector3(Random.RandomRange(-5.0f, 12.0f), Random.RandomRange(3.0f, 14.0f), Random.RandomRange(-7.0f, 6.0f));
            Quaternion dropRotaion = new Quaternion(Random.RandomRange(0, 90), Random.RandomRange(0, 90), Random.RandomRange(0, 90), 1);
            Instantiate(columnPrefab, dropPosition, dropRotaion);
            yield return new WaitForSeconds(5);
        } 

    }

}
