using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    public abstract class Sketcher : MonoBehaviour
    {
        public string resourcePath;

        public abstract ISketch ToSketch();
    }
}