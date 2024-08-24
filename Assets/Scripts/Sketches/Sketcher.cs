using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    public abstract class Sketcher : MonoBehaviour
    {
        public string path;

        public abstract ISketch ToSketch();
    }
}