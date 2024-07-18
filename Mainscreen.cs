using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainscreen : MonoBehaviour
{
    Vector3 offset;
    public GameObject bird;

    // Start is called before the first frame update
    void Start()
    {
        offset = bird.transform.position - transform.position;
        print(offset.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.gameOver) return;

        this.transform.position = new Vector3(
            bird.transform.position.x - offset.x,
            transform.position.y,
            transform.position.z
            );

    }

}
