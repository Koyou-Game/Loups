﻿using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    /**
     * 用于将场景/json数据转换成Sketch
     *
     * 1、将场景内容转换成Sketch
     * 2、将json数据转换成Sketch
     */
    public abstract class Sketcher : MonoBehaviour
    {
        public string resourcePath;

        public abstract ISketch SceneToSketch();
    }
}