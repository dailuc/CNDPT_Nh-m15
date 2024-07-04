using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public virtual void Destroy()
    {
        Destroy(gameObject);
    }
}
