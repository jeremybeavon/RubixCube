using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RubixCube.Model
{
    internal sealed class RubixCubeFaceValidationResult
    {
        private readonly ICollection<ValidationException> validationErrors;

        public RubixCubeFaceValidationResult()
        {
            validationErrors = new List<ValidationException>();
        }

        public string Description { get; set; }

        public void ValidateAdjacentCubes(
            NamedCube<CubeWith3Faces> namedCubeWith3Faces,
            NamedCube<CubeWith2Faces> namedCubeWith2Faces)
        {
            ValidateAdjacentCubes(namedCubeWith3Faces.Cube.CubesWith2Faces, namedCubeWith2Faces, namedCubeWith3Faces);
            ValidateAdjacentCubes(namedCubeWith2Faces.Cube.CubesWith3Faces, namedCubeWith3Faces, namedCubeWith2Faces);
        }

        public void ValidateAdjacentCubes(
            NamedCube<CubeWith2Faces> namedCubeWith2Faces,
            NamedCube<CubeWith1Face> namedCubeWith1Face)
        {
            ValidateAdjacentCubes(namedCubeWith2Faces.Cube.CubesWith1Face, namedCubeWith1Face, namedCubeWith2Faces);
            ValidateAdjacentCubes(namedCubeWith1Face.Cube.CubesWith2Faces, namedCubeWith2Faces, namedCubeWith1Face);
        }

        public void ValidateIdenticalCubes<T>(NamedCube<T> cube1, NamedCube<T> cube2)
        {
            if (!Equals(cube1.Cube, cube2.Cube))
            {
                string errorMessage = string.Format("{0} and {1} are not identical.", cube1.Name, cube2.Name);
                validationErrors.Add(new ValidationException(errorMessage));
            }
        }

        public void FinishValidation()
        {
            if (validationErrors.Count != 0)
            {
                throw new AggregateException(validationErrors);
            }
        }

        private void ValidateAdjacentCubes<T, TParent>(
            IEnumerable<T> cubes,
            NamedCube<T> expectedNamedCube,
            NamedCube<TParent> namedCube)
        {
            if (!cubes.Contains(expectedNamedCube.Cube))
            {
                string errorMessage = string.Format("{0} is not adjacent to {1}.", namedCube.Name, expectedNamedCube.Name);
                validationErrors.Add(new ValidationException(errorMessage));
            }
        }
    }
}
