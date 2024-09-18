using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instant;
    public static T Instant => _instant;
    Dictionary<T, List<T>> _poolObject = new Dictionary<T, List<T>>();
    private void Awake()
    {
        if (_instant != null && _instant.gameObject.GetInstanceID() != this.gameObject.GetInstanceID())
            Destroy(this.gameObject);
        _instant = this.GetComponent<T>();
    }
    public T getPoolObject(T key)
    {
        List<T> values = new List<T>();
        if (!_poolObject.ContainsKey(key))
        {
            _poolObject.Add(key, values);
        }
        else
        {
            values = _poolObject[key];
        }
        foreach (T g in values)
        {
            if (g is GameObject)
            {
                if (g.gameObject.activeSelf)
                    continue;
                return g;
            }
            continue;
        }
        T g2 = Instantiate(key, this.transform.position, this.transform.rotation);
        g2.gameObject.SetActive(false);
        values.Add(g2);
        return g2;
    }
}
