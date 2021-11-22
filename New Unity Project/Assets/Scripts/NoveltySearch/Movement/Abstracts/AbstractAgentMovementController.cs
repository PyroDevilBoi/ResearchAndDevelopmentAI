using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AgentScripts.Agent.Abstract
{
    public abstract class AbstractAgentMovementController : MonoBehaviour
    {
        public abstract void Move(Vector3 vector);

        public abstract void Rotate(Vector3 vector);
    }
}
