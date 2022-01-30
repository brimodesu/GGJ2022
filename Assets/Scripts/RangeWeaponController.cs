using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeWeaponController : MonoBehaviour
{
    public List<GameObject> pooledBullets;

    public ScriptableBullet bullet;
    public int _bulletsAvailable = 20;
    public Transform spawnArea;
    
    void Start()
    {
        CreateBullets(_bulletsAvailable);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateBullets(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject obj = Instantiate(bullet.prefab);
            obj.GetComponent<Bullet>().speed = bullet.speed;
            obj.GetComponent<Bullet>().damage = bullet.damage;
            obj.SetActive(false);
            pooledBullets.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i <pooledBullets.Count ; i++)
        {
            if (!pooledBullets[i].activeInHierarchy)
            {
                return pooledBullets[i];
            }
        }

        return null;
    }

    public void Fire(Transform origin)
    {
        var pooledBullet = GetPooledObject();
        pooledBullet.transform.position = spawnArea.position;
        
        Vector3 newRotation = new Vector3(0, origin.eulerAngles.y,90f);
        pooledBullet.transform.rotation = Quaternion.Euler(newRotation);
        pooledBullet.SetActive(true);
        pooledBullet.GetComponent<Bullet>().direction = origin.TransformDirection(Vector3.forward);
    }
}
