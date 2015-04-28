using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubixCube.Model
{
    public sealed class CubeWith1Face
    {
        public const int NumberOfCubesWith2Faces = 4;

        private readonly ISet<CubeWith2Faces> cubesWith2Faces;

        public CubeWith1Face()
        {
            cubesWith2Faces = new FixedLengthSet<CubeWith2Faces>(NumberOfCubesWith2Faces);
        }

        public IEnumerable<CubeWith2Faces> CubesWith2Faces
        {
            get { return cubesWith2Faces; }
        }

        internal void AddCubeWith2Faces(CubeWith2Faces cube)
        {
            cubesWith2Faces.Add(cube);
            cube.AddCubeWith1Face(this);
        }

        internal void RemoveCubeWith2Faces(CubeWith2Faces cube)
        {
            if (!cubesWith2Faces.Remove(cube))
            {
                throw new InvalidOperationException("cube was not found in set");
            }

            cube.RemoveCubeWith1Face(this);
        }
    }
}
