using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AgentScripts.Agent.Abstract
{

    [RequireComponent(typeof(MovementController))]
    public abstract class AbstractAgentController : MonoBehaviour
    {
        [SerializeField] protected ScriptableObjects.Containers.FloatReference _movingSpeed;
        [SerializeField] protected ScriptableObjects.Containers.FloatReference _rotationSpeed;

        public void Tick()
        {
            DoAction();
        }

        protected abstract void DoAction();

        public abstract void Reset(Vector3 defaultPos);
    }
}
