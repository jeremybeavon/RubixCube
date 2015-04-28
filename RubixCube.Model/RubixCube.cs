using System.Collections.Generic;

namespace RubixCube.Model
{
    public sealed class RubixCube
    {
        public const int NumberOfCubesWith1Face = 6;
        public const int NumberOfCubesWith2Faces = 12;
        public const int NumebrOfCubesWith3Faces = 8;

        private readonly ISet<CubeWith1Face> cubesWith1Face;
        private readonly ISet<CubeWith2Faces> cubesWith2Faces;
        private readonly ISet<CubeWith3Faces> cubesWith3Faces;

        public RubixCube()
        {
            InitialRubixCubeBuilder builder = new InitialRubixCubeBuilder();
            cubesWith1Face = builder.CubesWith1Face;
            cubesWith2Faces = builder.CubesWith2Faces;
            cubesWith3Faces = builder.CubesWith3Faces;
            FrontFace = builder.FrontFace;
            TopFace = builder.TopFace;
            LeftFace = builder.LeftFace;
            RightFace = builder.RightFace;
            BottomFace = builder.BottomFace;
            BackFace = builder.BackFace;
            Validate();
        }

        public IEnumerable<CubeWith1Face> CubesWith1Face
        {
            get { return cubesWith1Face; }
        }

        public IEnumerable<CubeWith2Faces> CubesWith2Faces
        {
            get { return cubesWith2Faces; }
        }

        public IEnumerable<CubeWith3Faces> CubesWith3Faces
        {
            get { return cubesWith3Faces; }
        }

        public RubixCubeFrontFace FrontFace { get; private set; }

        public RubixCubeTopFace TopFace { get; private set; }

        public RubixCubeLeftFace LeftFace { get; private set; }

        public RubixCubeRightFace RightFace { get; private set; }

        public RubixCubeBottomFace BottomFace { get; private set; }

        public RubixCubeBackFace BackFace { get; private set; }

        public void RotateTopFaceToFrontFace()
        {
            RubixCubeFrontFace newFrontFace = TopFace.MoveToFront();
            RubixCubeTopFace newTopFace = BackFace.MoveToTop();
            RubixCubeLeftFace newLeftFace = LeftFace.RotateAnticlockwise();
            RubixCubeRightFace newRightFace = RightFace.RotateAnticlockwise();
            RubixCubeBottomFace newBottomFace = FrontFace.MoveToBottom();
            RubixCubeBackFace newBackFace = BottomFace.MoveToBack();
            FrontFace = newFrontFace;
            TopFace = newTopFace;
            LeftFace = newLeftFace;
            RightFace = newRightFace;
            BottomFace = newBottomFace;
            BackFace = newBackFace;
            Validate();
        }

        public void RotateBottomFaceToFrontFace()
        {
            RubixCubeFrontFace newFrontFace = BottomFace.MoveToFront();
            RubixCubeTopFace newTopFace = FrontFace.MoveToTop();
            RubixCubeLeftFace newLeftFace = LeftFace.RotateClockwise();
            RubixCubeRightFace newRightFace = RightFace.RotateClockwise();
            RubixCubeBottomFace newBottomFace = BackFace.MoveToBottom();
            RubixCubeBackFace newBackFace = TopFace.MoveToBack();
            FrontFace = newFrontFace;
            TopFace = newTopFace;
            LeftFace = newLeftFace;
            RightFace = newRightFace;
            BottomFace = newBottomFace;
            BackFace = newBackFace;
            Validate();
        }

        public void RotateLeftFaceToFrontFace()
        {
            RubixCubeFrontFace newFrontFace = LeftFace.MoveToFront();
            RubixCubeTopFace newTopFace = TopFace.RotateAnticlockwise();
            RubixCubeLeftFace newLeftFace = BackFace.MoveToLeft();
            RubixCubeRightFace newRightFace = FrontFace.MoveToRight();
            RubixCubeBottomFace newBottomFace = BottomFace.RotateAnticlockwise();
            RubixCubeBackFace newBackFace = RightFace.MoveToBack();
            FrontFace = newFrontFace;
            TopFace = newTopFace;
            LeftFace = newLeftFace;
            RightFace = newRightFace;
            BottomFace = newBottomFace;
            BackFace = newBackFace;
            Validate();
        }

        public void RotateRightFaceToFrontFace()
        {
            RubixCubeFrontFace newFrontFace = RightFace.MoveToFront();
            RubixCubeTopFace newTopFace = TopFace.RotateClockwise();
            RubixCubeLeftFace newLeftFace = FrontFace.MoveToLeft();
            RubixCubeRightFace newRightFace = BackFace.MoveToRight();
            RubixCubeBottomFace newBottomFace = BottomFace.RotateClockwise();
            RubixCubeBackFace newBackFace = LeftFace.MoveToBack();
            FrontFace = newFrontFace;
            TopFace = newTopFace;
            LeftFace = newLeftFace;
            RightFace = newRightFace;
            BottomFace = newBottomFace;
            BackFace = newBackFace;
            Validate();
        }

        public void RotateLeftFaceToTopFace()
        {
            RubixCubeFrontFace newFrontFace = FrontFace.RotateClockwise();
            RubixCubeTopFace newTopFace = LeftFace.MoveToTop();
            RubixCubeLeftFace newLeftFace = BottomFace.MoveToLeft();
            RubixCubeRightFace newRightFace = TopFace.MoveToRight();
            RubixCubeBottomFace newBottomFace = RightFace.MoveToBottom();
            RubixCubeBackFace newBackFace = BackFace.RotateClockwise();
            FrontFace = newFrontFace;
            TopFace = newTopFace;
            LeftFace = newLeftFace;
            RightFace = newRightFace;
            BottomFace = newBottomFace;
            BackFace = newBackFace;
            Validate();
        }

        public void RotateRightFaceToTopFace()
        {
            RubixCubeFrontFace newFrontFace = FrontFace.RotateAnticlockwise();
            RubixCubeTopFace newTopFace = RightFace.MoveToTop();
            RubixCubeLeftFace newLeftFace = TopFace.MoveToLeft();
            RubixCubeRightFace newRightFace = BottomFace.MoveToRight();
            RubixCubeBottomFace newBottomFace = LeftFace.MoveToBottom();
            RubixCubeBackFace newBackFace = BackFace.RotateAnticlockwise();
            FrontFace = newFrontFace;
            TopFace = newTopFace;
            LeftFace = newLeftFace;
            RightFace = newRightFace;
            BottomFace = newBottomFace;
            BackFace = newBackFace;
            Validate();
        }

        public void RotateFrontFaceClockwise()
        {
            RotateFrontFace(FrontFace.RotateClockwise());
        }

        public void RotateFrontFaceAnticlockwise()
        {
            RotateFrontFace(FrontFace.RotateAnticlockwise());
        }

        public void RotateTopFaceClockwise()
        {
            RotateTopFace(TopFace.RotateClockwise());
        }

        public void RotateTopFaceAnticlockwise()
        {
            RotateTopFace(TopFace.RotateAnticlockwise());
        }

        public void RotateLeftFaceClockwise()
        {
            RotateLeftFace(LeftFace.RotateClockwise());
        }

        public void RotateLeftFaceAnticlockwise()
        {
            RotateLeftFace(LeftFace.RotateAnticlockwise());
        }

        public void RotateRightFaceClockwise()
        {
            RotateRightFace(RightFace.RotateClockwise());
        }

        public void RotateRightFaceAnticlockwise()
        {
            RotateRightFace(RightFace.RotateAnticlockwise());
        }

        public void RotateBottomFaceClockwise()
        {
            RotateBottomFace(BottomFace.RotateClockwise());
        }

        public void RotateBottomFaceAnticlockwise()
        {
            RotateBottomFace(BottomFace.RotateAnticlockwise());
        }

        private void RotateFrontFace(RubixCubeFrontFace newFrontFace)
        {
            RubixCubeFrontFaceRotation rotation = new RubixCubeFrontFaceRotation(this, newFrontFace);
            FrontFace = newFrontFace;
            TopFace = rotation.NewTopFace;
            LeftFace = rotation.NewLeftFace;
            RightFace = rotation.NewRightFace;
            BottomFace = rotation.NewBottomFace;
            Validate();
        }

        private void RotateTopFace(RubixCubeTopFace newTopFace)
        {
            RubixCubeTopFaceRotation rotation = new RubixCubeTopFaceRotation(this, newTopFace);
            FrontFace = rotation.NewFrontFace;
            LeftFace = rotation.NewLeftFace;
            RightFace = rotation.NewRightFace;
            TopFace = newTopFace;
            BackFace = rotation.NewBackFace;
            Validate();
        }

        private void RotateLeftFace(RubixCubeLeftFace newLeftFace)
        {
            RubixCubeLeftFaceRotation rotation = new RubixCubeLeftFaceRotation(this, newLeftFace);
            FrontFace = rotation.NewFrontFace;
            TopFace = rotation.NewTopFace;
            LeftFace = newLeftFace;
            BottomFace = rotation.NewBottomFace;
            BackFace = rotation.NewBackFace;
            Validate();
        }

        private void RotateRightFace(RubixCubeRightFace newRightFace)
        {
            RubixCubeRightFaceRotation rotation = new RubixCubeRightFaceRotation(this, newRightFace);
            FrontFace = rotation.NewFrontFace;
            TopFace = rotation.NewTopFace;
            RightFace = newRightFace;
            BottomFace = rotation.NewBottomFace;
            BackFace = rotation.NewBackFace;
            Validate();
        }

        private void RotateBottomFace(RubixCubeBottomFace newBottomFace)
        {
            RubixCubeBottomFaceRotation rotation = new RubixCubeBottomFaceRotation(this, newBottomFace);
            FrontFace = rotation.NewFrontFace;
            LeftFace = rotation.NewLeftFace;
            RightFace = rotation.NewRightFace;
            BottomFace = newBottomFace;
            BackFace = rotation.NewBackFace;
            Validate();
        }

        private void Validate()
        {
            RubixCubeFaceValidationResult validation = new RubixCubeFaceValidationResult();
            FrontFace.Validate(validation);
            TopFace.Validate(validation);
            LeftFace.Validate(validation);
            RightFace.Validate(validation);
            BottomFace.Validate(validation);
            BackFace.Validate(validation);
            ValidateIdenticalCubes(validation);
            validation.FinishValidation();
        }

        private void ValidateIdenticalCubes(RubixCubeFaceValidationResult validation)
        {
            validation.ValidateIdenticalCubes(FrontFace.NamedTopLeftCube, TopFace.NamedFrontLeftCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedTopLeftCube, LeftFace.NamedFrontTopCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedTopCube, TopFace.NamedFrontCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedTopRightCube, TopFace.NamedFrontRightCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedTopRightCube, RightFace.NamedFrontTopCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedLeftCube, LeftFace.NamedFrontCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedRightCube, RightFace.NamedFrontCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedBottomLeftCube, BottomFace.NamedFrontLeftCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedBottomLeftCube, LeftFace.NamedFrontBottomCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedBottomCube, BottomFace.NamedFrontCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedBottomRightCube, BottomFace.NamedFrontRightCube);
            validation.ValidateIdenticalCubes(FrontFace.NamedBottomRightCube, RightFace.NamedFrontBottomCube);
            validation.ValidateIdenticalCubes(LeftFace.NamedTopCube, TopFace.NamedLeftCube);
            validation.ValidateIdenticalCubes(LeftFace.NamedBottomCube, BottomFace.NamedLeftCube);
            validation.ValidateIdenticalCubes(RightFace.NamedTopCube, TopFace.NamedRightCube);
            validation.ValidateIdenticalCubes(RightFace.NamedBottomCube, BottomFace.NamedRightCube);
            validation.ValidateIdenticalCubes(BackFace.NamedTopLeftCube, TopFace.NamedBackLeftCube);
            validation.ValidateIdenticalCubes(BackFace.NamedTopLeftCube, LeftFace.NamedBackTopCube);
            validation.ValidateIdenticalCubes(BackFace.NamedTopCube, TopFace.NamedBackCube);
            validation.ValidateIdenticalCubes(BackFace.NamedTopRightCube, TopFace.NamedBackRightCube);
            validation.ValidateIdenticalCubes(BackFace.NamedTopRightCube, RightFace.NamedBackTopCube);
            validation.ValidateIdenticalCubes(BackFace.NamedLeftCube, LeftFace.NamedBackCube);
            validation.ValidateIdenticalCubes(BackFace.NamedRightCube, RightFace.NamedBackCube);
            validation.ValidateIdenticalCubes(BackFace.NamedBottomLeftCube, BottomFace.NamedBackLeftCube);
            validation.ValidateIdenticalCubes(BackFace.NamedBottomLeftCube, LeftFace.NamedBackBottomCube);
            validation.ValidateIdenticalCubes(BackFace.NamedBottomCube, BottomFace.NamedBackCube);
            validation.ValidateIdenticalCubes(BackFace.NamedBottomRightCube, BottomFace.NamedBackRightCube);
            validation.ValidateIdenticalCubes(BackFace.NamedBottomRightCube, RightFace.NamedBackBottomCube);
        }
    }
}
