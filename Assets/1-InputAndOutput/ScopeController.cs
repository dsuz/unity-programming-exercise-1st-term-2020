using UnityEngine;

public class ScopeController : MonoBehaviour
{
    public int m_counter;

    void Start()
    {
        string[] a = { "apple", "orange", "banana", "kiwi" };
        for (int i = 0; i < a.Length; i++)
        {
            Debug.Log(a[i]);
        }
    }

    void Update()
    {
        int n = 0;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_counter += 1;
            n += 1;
            Debug.LogFormat("m_counter は {0}, n は {1}", m_counter, n);
        }
    }
}
