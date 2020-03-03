<<<<<<< HEAD
﻿using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
=======
﻿using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
>>>>>>> master
}