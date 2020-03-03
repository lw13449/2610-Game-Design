<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent, TriggerExitEvent;
    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        TriggerExitEvent.Invoke();
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent, TriggerExitEvent;
    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        TriggerExitEvent.Invoke();
    }
}
>>>>>>> master
