namespace Sketches.Entities
{
    /**
     * 一种将场景转换为（可存储的）数据的方式
     */
    public interface ISketch
    {
        string ResourcePath { get; init; }
    }

    public abstract class Sketch : ISketch
    {
        public string ResourcePath { get; init; }
    }
}