using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public void Todo(float range)
    {
        StartCoroutine(_Todo(range));
    }

    IEnumerator _Todo(float range)
    {
        for (int i = 0; i < 2; i++)
        {
            yield return _Shake(0.1f, range);
            yield return _Shake(0.1f, -range);
        }
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    IEnumerator _Shake(float duration, float range)
    {
        float elapsed = 0;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;

            transform.Rotate(0, 0, range * Time.deltaTime);
            yield return null;
        }
    }
}
