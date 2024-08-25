#if NEWTONSOFT_JSON
using System;
using Koyou.Commons;
using Newtonsoft.Json;
using Sketches.Entities;
using UnityEngine;

namespace Utils
{
    namespace Sketches.Entities
    {
        public class MapSketchConverter : JsonConverter
        {
            [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
            public static void Init()
            {
                Log.N($"Init MapSketchConverter");
                JsonUtil.AddConverter(new MapSketchConverter());
            }

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(IMapSketch);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                return serializer.Deserialize<MapSketch>(reader);
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }

        public class TerrainsSketchConverter : JsonConverter
        {
            [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
            public static void Init()
            {
                Log.N($"Init TerrainsSketchConverter");
                JsonUtil.AddConverter(new TerrainsSketchConverter());
            }

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(ITerrainsSketch);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                return serializer.Deserialize<TerrainsSketch>(reader);
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }
        
        public class ShapeSketchConverter : JsonConverter
        {
            [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
            public static void Init()
            {
                Log.N($"Init ShapeSketchConverter");
                JsonUtil.AddConverter(new ShapeSketchConverter());
            }

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(IShapeSketch);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                return serializer.Deserialize<ShapeSketch>(reader);
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }
    }
}
#endif