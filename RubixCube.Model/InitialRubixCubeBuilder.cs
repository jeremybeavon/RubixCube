using System.Collections.Generic;

namespace RubixCube.Model
{
    internal sealed class InitialRubixCubeBuilder
    {
        private readonly ISet<CubeWith1Face> cubesWith1Face;
        private readonly ISet<CubeWith2Faces> cubesWith2Faces;
        private readonly ISet<CubeWith3Faces> cubesWith3Faces;
        private readonly CubeWith1Face frontCube;
        private readonly CubeWith1Face topCube;
        private readonly CubeWith1Face bottomCube;
        private readonly CubeWith1Face leftCube;
        private readonly CubeWith1Face rightCube;
        private readonly CubeWith1Face backCube;
        private readonly CubeWith2Faces frontTopCube;
        private readonly CubeWith2Faces frontLeftCube;
        private readonly CubeWith2Faces frontRightCube;
        private readonly CubeWith2Faces frontBottomCube;
        private readonly CubeWith2Faces leftTopCube;
        private readonly CubeWith2Faces leftBottomCube;
        private readonly CubeWith2Faces rightTopCube;
        private readonly CubeWith2Faces rightBottomCube;
        private readonly CubeWith2Faces backTopCube;
        private readonly CubeWith2Faces backLeftCube;
        private readonly CubeWith2Faces backRightCube;
        private readonly CubeWith2Faces backBottomCube;
        private readonly CubeWith3Faces frontTopLeftCube;
        private readonly CubeWith3Faces frontTopRightCube;
        private readonly CubeWith3Faces frontBottomLeftCube;
        private readonly CubeWith3Faces frontBottomRightCube;
        private readonly CubeWith3Faces backTopLeftCube;
        private readonly CubeWith3Faces backTopRightCube;
        private readonly CubeWith3Faces backBottomLeftCube;
        private readonly CubeWith3Faces backBottomRightCube;

        public InitialRubixCubeBuilder()
        {
            cubesWith1Face = new FixedLengthSet<CubeWith1Face>(RubixCube.NumberOfCubesWith1Face);
            cubesWith2Faces = new FixedLengthSet<CubeWith2Faces>(RubixCube.NumberOfCubesWith2Faces);
            cubesWith3Faces = new FixedLengthSet<CubeWith3Faces>(RubixCube.NumebrOfCubesWith3Faces);
            frontCube = new CubeWith1Face();
            topCube = new CubeWith1Face();
            bottomCube = new CubeWith1Face();
            leftCube = new CubeWith1Face();
            rightCube = new CubeWith1Face();
            backCube = new CubeWith1Face();
            frontTopCube = new CubeWith2Faces();
            frontLeftCube = new CubeWith2Faces();
            frontRightCube = new CubeWith2Faces();
            frontBottomCube = new CubeWith2Faces();
            leftTopCube = new CubeWith2Faces();
            leftBottomCube = new CubeWith2Faces();
            rightTopCube = new CubeWith2Faces();
            rightBottomCube = new CubeWith2Faces();
            backTopCube = new CubeWith2Faces();
            backLeftCube = new CubeWith2Faces();
            backRightCube = new CubeWith2Faces();
            backBottomCube = new CubeWith2Faces();
            frontTopLeftCube = new CubeWith3Faces();
            frontTopRightCube = new CubeWith3Faces();
            frontBottomLeftCube = new CubeWith3Faces();
            frontBottomRightCube = new CubeWith3Faces();
            backTopLeftCube = new CubeWith3Faces();
            backTopRightCube = new CubeWith3Faces();
            backBottomLeftCube = new CubeWith3Faces();
            backBottomRightCube = new CubeWith3Faces();
            InitializeRubixCube();
        }

        public ISet<CubeWith1Face> CubesWith1Face
        {
            get { return cubesWith1Face; }
        }

        public ISet<CubeWith2Faces> CubesWith2Faces
        {
            get { return cubesWith2Faces; }
        }

        public ISet<CubeWith3Faces> CubesWith3Faces
        {
            get { return cubesWith3Faces; }
        }

        public RubixCubeFrontFace FrontFace { get; private set; }

        public RubixCubeTopFace TopFace { get; private set; }

        public RubixCubeLeftFace LeftFace { get; private set; }

        public RubixCubeRightFace RightFace { get; private set; }

        public RubixCubeBottomFace BottomFace { get; private set; }

        public RubixCubeBackFace BackFace { get; private set; }

        private void InitializeRubixCube()
        {
            AddCubesToSet();
            InitializeCubesWith1Face();
            InitializeCubesWith3Faces();
            InitializeFrontFace();
            InitializeTopFace();
            InitializeLeftFace();
            InitializeRightFace();
            InitializeBottomFace();
            InitializeBackFace();
        }

        private void AddCubesToSet()
        {
            cubesWith1Face.Add(frontCube);
            cubesWith1Face.Add(topCube);
            cubesWith1Face.Add(bottomCube);
            cubesWith1Face.Add(leftCube);
            cubesWith1Face.Add(rightCube);
            cubesWith1Face.Add(backCube);
            cubesWith2Faces.Add(frontTopCube);
            cubesWith2Faces.Add(frontLeftCube);
            cubesWith2Faces.Add(frontRightCube);
            cubesWith2Faces.Add(frontBottomCube);
            cubesWith2Faces.Add(leftTopCube);
            cubesWith2Faces.Add(leftBottomCube);
            cubesWith2Faces.Add(rightTopCube);
            cubesWith2Faces.Add(rightBottomCube);
            cubesWith2Faces.Add(backTopCube);
            cubesWith2Faces.Add(backLeftCube);
            cubesWith2Faces.Add(backRightCube);
            cubesWith2Faces.Add(backBottomCube);
            cubesWith3Faces.Add(frontTopLeftCube);
            cubesWith3Faces.Add(frontTopRightCube);
            cubesWith3Faces.Add(frontBottomLeftCube);
            cubesWith3Faces.Add(frontBottomRightCube);
            cubesWith3Faces.Add(backTopLeftCube);
            cubesWith3Faces.Add(backTopRightCube);
            cubesWith3Faces.Add(backBottomLeftCube);
            cubesWith3Faces.Add(backBottomRightCube);
        }

        private void InitializeCubesWith1Face()
        {
            frontCube.AddCubeWith2Faces(frontTopCube);
            frontCube.AddCubeWith2Faces(frontLeftCube);
            frontCube.AddCubeWith2Faces(frontRightCube);
            frontCube.AddCubeWith2Faces(frontBottomCube);
            topCube.AddCubeWith2Faces(frontTopCube);
            topCube.AddCubeWith2Faces(backTopCube);
            topCube.AddCubeWith2Faces(leftTopCube);
            topCube.AddCubeWith2Faces(rightTopCube);
            leftCube.AddCubeWith2Faces(leftTopCube);
            leftCube.AddCubeWith2Faces(frontLeftCube);
            leftCube.AddCubeWith2Faces(backLeftCube);
            leftCube.AddCubeWith2Faces(leftBottomCube);
            rightCube.AddCubeWith2Faces(rightTopCube);
            rightCube.AddCubeWith2Faces(frontRightCube);
            rightCube.AddCubeWith2Faces(backRightCube);
            rightCube.AddCubeWith2Faces(rightBottomCube);
            bottomCube.AddCubeWith2Faces(frontBottomCube);
            bottomCube.AddCubeWith2Faces(leftBottomCube);
            bottomCube.AddCubeWith2Faces(rightBottomCube);
            bottomCube.AddCubeWith2Faces(backBottomCube);
            backCube.AddCubeWith2Faces(backTopCube);
            backCube.AddCubeWith2Faces(backLeftCube);
            backCube.AddCubeWith2Faces(backRightCube);
            backCube.AddCubeWith2Faces(backBottomCube);
        }

        private void InitializeCubesWith3Faces()
        {
            frontTopLeftCube.AddCubeWith2Faces(frontTopCube);
            frontTopLeftCube.AddCubeWith2Faces(frontLeftCube);
            frontTopLeftCube.AddCubeWith2Faces(leftTopCube);
            frontTopRightCube.AddCubeWith2Faces(frontTopCube);
            frontTopRightCube.AddCubeWith2Faces(frontRightCube);
            frontTopRightCube.AddCubeWith2Faces(rightTopCube);
            frontBottomLeftCube.AddCubeWith2Faces(frontBottomCube);
            frontBottomLeftCube.AddCubeWith2Faces(frontLeftCube);
            frontBottomLeftCube.AddCubeWith2Faces(leftBottomCube);
            frontBottomRightCube.AddCubeWith2Faces(frontBottomCube);
            frontBottomRightCube.AddCubeWith2Faces(frontRightCube);
            frontBottomRightCube.AddCubeWith2Faces(rightBottomCube);
            backTopLeftCube.AddCubeWith2Faces(backTopCube);
            backTopLeftCube.AddCubeWith2Faces(backLeftCube);
            backTopLeftCube.AddCubeWith2Faces(leftTopCube);
            backTopRightCube.AddCubeWith2Faces(backTopCube);
            backTopRightCube.AddCubeWith2Faces(backRightCube);
            backTopRightCube.AddCubeWith2Faces(rightTopCube);
            backBottomLeftCube.AddCubeWith2Faces(backBottomCube);
            backBottomLeftCube.AddCubeWith2Faces(backLeftCube);
            backBottomLeftCube.AddCubeWith2Faces(leftBottomCube);
            backBottomRightCube.AddCubeWith2Faces(backBottomCube);
            backBottomRightCube.AddCubeWith2Faces(backRightCube);
            backBottomRightCube.AddCubeWith2Faces(rightBottomCube);
        }

        private void InitializeFrontFace()
        {
            FrontFace = new RubixCubeFrontFace()
            {
                TopLeftCube = frontTopLeftCube,
                TopCube = frontTopCube,
                TopRightCube = frontTopRightCube,
                LeftCube = frontLeftCube,
                CenterCube = frontCube,
                RightCube = frontRightCube,
                BottomLeftCube = frontBottomLeftCube,
                BottomCube = frontBottomCube,
                BottomRightCube = frontBottomRightCube
            };
        }

        private void InitializeTopFace()
        {
            TopFace = new RubixCubeTopFace()
            {
                FrontLeftCube = frontTopLeftCube,
                FrontCube = frontTopCube,
                FrontRightCube = frontTopRightCube,
                LeftCube = leftTopCube,
                CenterCube = topCube,
                RightCube = rightTopCube,
                BackLeftCube = backTopLeftCube,
                BackCube = backTopCube,
                BackRightCube = backTopRightCube
            };
        }

        private void InitializeLeftFace()
        {
            LeftFace = new RubixCubeLeftFace()
            {
                FrontTopCube = frontTopLeftCube,
                TopCube = leftTopCube,
                BackTopCube = backTopLeftCube,
                FrontCube = frontLeftCube,
                CenterCube = leftCube,
                BackCube = backLeftCube,
                FrontBottomCube = frontBottomLeftCube,
                BottomCube = leftBottomCube,
                BackBottomCube = backBottomLeftCube
            };
        }

        private void InitializeRightFace()
        {
            RightFace = new RubixCubeRightFace()
            {
                FrontTopCube = frontTopRightCube,
                TopCube = rightTopCube,
                BackTopCube = backTopRightCube,
                FrontCube = frontRightCube,
                CenterCube = rightCube,
                BackCube = backRightCube,
                FrontBottomCube = frontBottomRightCube,
                BottomCube = rightBottomCube,
                BackBottomCube = backBottomRightCube
            };
        }

        private void InitializeBottomFace()
        {
            BottomFace = new RubixCubeBottomFace()
            {
                FrontLeftCube = frontBottomLeftCube,
                FrontCube = frontBottomCube,
                FrontRightCube = frontBottomRightCube,
                LeftCube = leftBottomCube,
                CenterCube = bottomCube,
                RightCube = rightBottomCube,
                BackLeftCube = backBottomLeftCube,
                BackCube = backBottomCube,
                BackRightCube = backBottomRightCube
            };
        }

        private void InitializeBackFace()
        {
            BackFace = new RubixCubeBackFace()
            {
                TopLeftCube = backTopLeftCube,
                TopCube = backTopCube,
                TopRightCube = backTopRightCube,
                LeftCube = backLeftCube,
                CenterCube = backCube,
                RightCube = backRightCube,
                BottomLeftCube = backBottomLeftCube,
                BottomCube = backBottomCube,
                BottomRightCube = backBottomRightCube
            };
        }
    }
}
