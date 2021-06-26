using System;

/// <summary>
/// Интерфейс ICloneable
/// Поддерживает копирование, при котором создается новый экземпляр класса с тем же значением, что и у существующего экземпляра.
/// </summary>

namespace Prototype
{
    class DeepCloneClass : CloneClass, ICloneable
    {
        public object Clone()
        {
            DeepCloneClass result = new DeepCloneClass();

            result.X = this.X;
            result.Y = this.Y;
            result.ds = new DeepStructure();
            result.ds.A = this.ds.A;
            result.ds.B = this.ds.B;
            return result; ;
        }
    }
}
