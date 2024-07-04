using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EffectsManager : MonoBehaviour
{
    public static EffectsManager instance;
    [SerializeField] public List<GameObject> listEffects; 



    private void Awake()
    {
        EffectsManager.instance = this;
        this.LoadEffect();
    }

    protected virtual void LoadEffect()
    {
        listEffects = new List<GameObject>();
        foreach (Transform child in transform)
        {
            this.listEffects.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
    }

    public virtual void SpawnVFX(string effectName,Vector3 position,Quaternion rot)
    {
        Debug.Log("dung2");
        GameObject effect = this.GetEffect(effectName);
        GameObject newEffect = Instantiate(effect,position,rot);
        newEffect.gameObject.SetActive(true);
        //Destroy(newEffect);
    }
    public virtual GameObject GetEffect(string effectName) 
    {
        Debug.Log(effectName);
        foreach(GameObject child in this.listEffects)
        {
            if(child.name == effectName)
            {
                return child;
            }
             
        }
        return null;
    }
}
