using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform transPlayer;
    public float speed = 27f;
    public float limitFollow = 6f;
    public float randPos = 0f;

    void Start()
    {
        transPlayer = PlayerCtrl.instance.transform;
        this.randPos = Random.Range(-6, 6);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.followPlayer();
    }
    public void followPlayer()
    {
        Vector3 currentPosition = this.transform.position;
        Vector3 pos = transPlayer.position;
        pos.x = randPos;

        Vector3 vectorFollow = pos - currentPosition;
        if(vectorFollow.magnitude>=limitFollow)
        {
            Vector3 target = currentPosition +(vectorFollow - vectorFollow.normalized * limitFollow);
            this.transform.position = Vector3.MoveTowards(currentPosition, target, speed * Time.deltaTime);
        }
    }
}
