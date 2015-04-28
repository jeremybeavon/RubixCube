using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubixCube.Model
{
    internal sealed class NamedCube<T>
    {
        public NamedCube(T cube, string name)
        {
            Cube = cube;
            Name = name;
        }

        public T Cube { get; private set; }

        public string Name { get; private set; }
    }
}
