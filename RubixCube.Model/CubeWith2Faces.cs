using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubixCube.Model
{
    public sealed class CubeWith2Faces
    {
        public const int NumberOfCubesWith1Face = 2;
        public const int NumberOfCubesWith3Faces = 2;

        private readonly ISet<CubeWith1Face> cubesWith1Face;
        private readonly ISet<CubeWith3Faces> cubesWith3Faces;

        public CubeWith2Faces()
        {
            cubesWith1Face = new FixedLengthSet<CubeWith1Face>(NumberOfCubesWith1Face);
            cubesWith3Faces = new FixedLengthSet<CubeWith3Faces>(NumberOfCubesWith3Faces);
        }

        public IEnumerable<CubeWith1Face> CubesWith1Face
        {
            get { return cubesWith1Face; }
        }

        public IEnumerable<CubeWith3Faces> CubesWith3Faces
        {
            get { return cubesWith3Faces; }
        }

        internal void AddCubeWith1Face(CubeWith1Face cube)
        {
            cubesWith1Face.Add(cube);
        }

        internal void AddCubeWith3Faces(CubeWith3Faces cube)
        {
            cubesWith3Faces.Add(cube);
        }

        internal void RemoveCubeWith1Face(CubeWith1Face cube)
        {
            if (!cubesWith1Face.Remove(cube))
            {
                throw new InvalidOperationException("cube was not found in set");
            }
        }

        internal void RemoveCubeWith3Faces(CubeWith3Faces cube)
        {
            if (!cubesWith3Faces.Remove(cube))
            {
                throw new InvalidOperationException("cube was not found in set");
            }
        }
    }
}
