using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    public abstract class Sketcher : MonoBehaviour
    {
        public abstract ISketch ToSketch();
    }
}