using System.IO;
using Koyou.Commons;
using Sketches.Entities;
using UnityEngine;

namespace Storages
{
    public static class LevelRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sketch"></param>
        /// <param name="story"></param>
        /// <param name="level"></param>
        /// <returns>saved path</returns>
        public static string Save(ILevelSketch sketch, string story, string level)
        {
            // 构建文件路径
            var directoryPath = Path.Combine(Application.persistentDataPath, story);
            var levelPath = Path.Combine(directoryPath, $"{level}.json");
            Log.N($"directoryPath:\t{directoryPath}");
            Log.N($"levelPath:\t{levelPath}");

            // 如果文件夹不存在，则创建文件夹
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            var json = JsonUtil.SerializeObject(sketch);
            File.WriteAllText(levelPath, json);

            return levelPath;
        }
    }
}