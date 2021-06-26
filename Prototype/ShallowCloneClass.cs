using System;

/// <summary>
/// Интерфейс ICloneable
/// Поддерживает копирование, при котором создается новый экземпляр класса с тем же значением, что и у существующего экземпляра.
/// </summary>
namespace Prototype
{
    class ShallowCloneClass : CloneClass, ICloneable
    {
        public object Clone()
        {
            return (ShallowCloneClass)this.MemberwiseClone();
        }
    }
}
