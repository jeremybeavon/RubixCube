using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RubixCube.Model.Tests
{
    [TestClass]
    public class RubixCubeTests
    {
        [TestMethod]
        public void Test_Constructor_GenerateCorrectNumberOfCubesWith1Face()
        {
            // Act
            RubixCube target = new RubixCube();

            // Assert
            target.CubesWith1Face.Count().Should().Be(RubixCube.NumberOfCubesWith1Face);
        }

        [TestMethod]
        public void Test_Constructor_GenerateCorrectNumberOfCubesWith2Faces()
        {
            // Act
            RubixCube target = new RubixCube();

            // Assert
            target.CubesWith2Faces.Count().Should().Be(RubixCube.NumberOfCubesWith2Faces);
        }

        [TestMethod]
        public void Test_Constructor_GenerateCorrectNumberOfCubesWith3Faces()
        {
            // Act
            RubixCube target = new RubixCube();

            // Assert
            target.CubesWith3Faces.Count().Should().Be(RubixCube.NumebrOfCubesWith3Faces);
        }

        [TestMethod]
        public void Test_Constructor_GeneratesCorrectNumberOfCubesWith2FacesForEachCubeWith1Face()
        {
            // Act
            RubixCube target = new RubixCube();

            // Assert
            target.CubesWith1Face.All(cube => cube.CubesWith2Faces.Count() == CubeWith1Face.NumberOfCubesWith2Faces);
        }

        [TestMethod]
        public void Test_Constructor_GeneratesCorrectNumberOfCubesWith1FaceForEachCubeWith2Faces()
        {
            // Act
            RubixCube target = new RubixCube();

            // Assert
            target.CubesWith2Faces.All(cube => cube.CubesWith1Face.Count() == CubeWith2Faces.NumberOfCubesWith1Face);
        }

        [TestMethod]
        public void Test_Constructor_GeneratesCorrectNumberOfCubesWith3FacesForEachCubeWith2Faces()
        {
            // Act
            RubixCube target = new RubixCube();

            // Assert
            target.CubesWith2Faces.All(cube => cube.CubesWith3Faces.Count() == CubeWith2Faces.NumberOfCubesWith3Faces);
        }

        [TestMethod]
        public void Test_Constructor_GeneratesCorrectNumberOfCubesWith2FacesForEachCubeWith3Faces()
        {
            // Act
            RubixCube target = new RubixCube();

            // Assert
            target.CubesWith3Faces.All(cube => cube.CubesWith2Faces.Count() == CubeWith3Faces.NumberOfCubesWith2Faces);
        }

        [TestMethod]
        public void Test_RotateTopFaceToFrontFace_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateTopFaceToFrontFace();
        }

        [TestMethod]
        public void Test_RotateBottomFaceToFrontFace_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateBottomFaceToFrontFace();
        }

        [TestMethod]
        public void Test_RotateLeftFaceToFrontFace_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateLeftFaceToFrontFace();
        }

        [TestMethod]
        public void Test_RotateRightFaceToFrontFace_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateRightFaceToFrontFace();
        }

        [TestMethod]
        public void Test_RotateLeftFaceToTopFace_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateLeftFaceToTopFace();
        }

        [TestMethod]
        public void Test_RotateRightFaceToTopFace_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateRightFaceToTopFace();
        }

        [TestMethod]
        public void Test_RotateFrontFaceClockwise_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateFrontFaceClockwise();
        }

        [TestMethod]
        public void Test_RotateFrontFaceAnticlockwise_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateFrontFaceAnticlockwise();
        }

        [TestMethod]
        public void Test_RotateTopFaceClockwise_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateTopFaceClockwise();
        }

        [TestMethod]
        public void Test_RotateTopFaceAnticlockwise_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateTopFaceAnticlockwise();
        }

        [TestMethod]
        public void Test_RotateLeftFaceClockwise_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateLeftFaceClockwise();
        }

        [TestMethod]
        public void Test_RotateLeftFaceAnticlockwise_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateLeftFaceAnticlockwise();
        }

        [TestMethod]
        public void Test_RotateRightFaceClockwise_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateRightFaceClockwise();
        }

        [TestMethod]
        public void Test_RotateRightFaceAnticlockwise_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateRightFaceAnticlockwise();
        }

        [TestMethod]
        public void Test_RotateBottomFaceClockwise_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateBottomFaceClockwise();
        }

        [TestMethod]
        public void Test_RotateBottomFaceAnticlockwise_DoesNotThrowAnException()
        {
            // Act
            RubixCube target = new RubixCube();
            target.RotateBottomFaceAnticlockwise();
        }
    }
}
